using System;
using UnityEngine;
using System.IO;

namespace DandyCore {
    public class TextureUtils{
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


    }
}