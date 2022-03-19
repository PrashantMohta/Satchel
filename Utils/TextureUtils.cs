using System.IO;
using System.Security.Cryptography;

namespace Satchel
{
    public static class TextureUtils{
        public static Texture2D createTextureOfColor(int width, int height, Color color){
            Texture2D tex = new Texture2D(width,height);
            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    tex.SetPixel(i, j, color);
                }
            }
            tex.Apply();
            return tex;
        }


        public static Texture2D LoadTextureFromFile(string path){
            Texture2D tex = new Texture2D(2, 2);
            byte[] texBytes = File.ReadAllBytes(path);            
            tex.LoadImage(texBytes);
            tex.Apply();            
            return tex;
        }

        public static void WriteTextureToFile(Texture t,string path){
            File.WriteAllBytes(path,duplicateTexture((Texture2D)t).EncodeToPNG());
        }

        public static Texture2D duplicateTexture(Texture2D source)
        {
            RenderTexture renderTex = RenderTexture.GetTemporary(
                        source.width,
                        source.height,
                        0,
                        RenderTextureFormat.Default,
                        RenderTextureReadWrite.Linear);

            Graphics.Blit(source, renderTex);
            RenderTexture previous = RenderTexture.active;
            RenderTexture.active = renderTex;
            Texture2D readableText = new Texture2D(source.width, source.height);
            readableText.ReadPixels(new Rect(0, 0, renderTex.width, renderTex.height), 0, 0);
            readableText.Apply();
            RenderTexture.active = previous;
            RenderTexture.ReleaseTemporary(renderTex);
            return readableText;
        }
        public static Texture2D Flip(this Texture2D original,bool horizontal = true,bool vertical = false)
        {
            Texture2D flip = new Texture2D(original.width,original.height);
            if(horizontal){
                for(int i=0; i < flip.width; i++) {
                    for(int j=0; j < flip.height; j++) {
                        flip.SetPixel(flip.width-i-1, j, original.GetPixel(i,j));
                    }
                }
            }
            if(vertical){
                for(int i=0; i < flip.width; i++) {
                    for(int j=0; j < flip.height; j++) {
                        flip.SetPixel(i, flip.height-j-1, original.GetPixel(i,j));
                    }
                }
            }
            flip.Apply();
            return flip;
        }

        public static Texture2D GetRegion(this Texture2D original,Rect region)
        {
            // We create a new texture so we don't change the old one!
            Texture2D outTex = new Texture2D(original.width,original.height);


            // These for loops are for running through each individual pixel and then replacing them in the new texture.
            for(int i=(int)region.xMin; i < (int)region.xMax; i++) {
                for(int j=(int)region.yMin; j < (int)region.yMax; j++) {
                    outTex.SetPixel(i, j, original.GetPixel(i,j));
                }
            }
            
            outTex.Apply();
            return outTex;
        }

        public static string getHash(this Texture2D tex){ 
            var data = tex.EncodeToPNG();
            var sha1 = SHA1.Create();

            byte[] hashBytes = sha1.ComputeHash(data);

            string hash = BitConverter.ToString(hashBytes).Replace("-", string.Empty);

            return hash;
        }

    }
}