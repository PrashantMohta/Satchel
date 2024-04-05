using System.IO;
using System.Security.Cryptography;

namespace Satchel
{
    /// <summary>
    /// Utilities to work with Textures
    /// </summary>
    public static class TextureUtils
    {
        /// <summary>
        /// Create a Texture2D of a single Color
        /// </summary>
        /// <param name="width">width of the texture</param>
        /// <param name="height">height of the texture</param>
        /// <param name="color">Color of the texture</param>
        /// <returns>The Texture2D</returns>
        public static Texture2D createTextureOfColor(int width, int height, Color color)
        {
            Texture2D tex = new Texture2D(width, height);
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

        /// <summary>
        /// Loads an Image from a file path 
        /// </summary>
        /// <param name="path">Path of the image file</param>
        /// <returns>A Texture2D of the image</returns>
        public static Texture2D LoadTextureFromFile(string path)
        {
            Texture2D tex = new Texture2D(2, 2);
            byte[] texBytes = File.ReadAllBytes(path);
            tex.LoadImage(texBytes);
            tex.Apply();
            return tex;
        }

        /// <summary>
        /// Write a Texture to the given file path
        /// </summary>
        /// <param name="texture">The Texture to write</param>
        /// <param name="path">The Path of the file to write to</param>
        public static void WriteTextureToFile(Texture texture, string path)
        {
            File.WriteAllBytes(path, duplicateTexture((Texture2D)texture).EncodeToPNG());
        }
        /// <summary>
        /// Duplicates a Texture2D so that it is Readable
        /// </summary>
        /// <param name="source">Source Texture2D</param>
        /// <returns>A duplicate Texture2D</returns>
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

        /// <summary>
        /// Flips a Texture2D
        /// </summary>
        /// <param name="original">The Texture2D to flip</param>
        /// <param name="horizontal">Should texture be flipped horizontally</param>
        /// <param name="vertical">Should texture be flipped vertically</param>
        /// <returns>The flipped Texture2D</returns>
        public static Texture2D Flip(this Texture2D original, bool horizontal = true, bool vertical = false)
        {
            Texture2D flip = new Texture2D(original.width, original.height);
            if (horizontal)
            {
                for (int i = 0; i < flip.width; i++)
                {
                    for (int j = 0; j < flip.height; j++)
                    {
                        flip.SetPixel(flip.width - i - 1, j, original.GetPixel(i, j));
                    }
                }
            }
            if (vertical)
            {
                for (int i = 0; i < flip.width; i++)
                {
                    for (int j = 0; j < flip.height; j++)
                    {
                        flip.SetPixel(i, flip.height - j - 1, original.GetPixel(i, j));
                    }
                }
            }
            flip.Apply();
            return flip;
        }

        /// <summary>
        /// Get a region cropped from a Texture2D
        /// </summary>
        /// <param name="original">original Texture2D</param>
        /// <param name="region">The region to get</param>
        /// <returns>The region from original as a Texture2D of the cropped size</returns>
        public static Texture2D GetCropped(this Texture2D original, Rect region)
        {
            var pixData = original.GetPixels((int)region.x, (int)region.y, (int)region.width, (int)region.height);
            var newTex = new Texture2D((int)region.width, (int)region.height);
            newTex.SetPixels(pixData);
            newTex.Apply();
            return newTex;
        }

        /// <summary>
        /// Get a region from a Texture2D
        /// </summary>
        /// <param name="original">original Texture2D</param>
        /// <param name="region">The region to get</param>
        /// <returns>The region from original as a Texture2D of the same size</returns>
        [Obsolete("Use GetCropped instead to get a texture of the new size")]
        public static Texture2D GetRegion(this Texture2D original, Rect region)
        {
            // We create a new texture so we don't change the old one!
            Texture2D outTex = new Texture2D(original.width, original.height);


            // These for loops are for running through each individual pixel and then replacing them in the new texture.
            for (int i = (int)region.xMin; i < (int)region.xMax; i++)
            {
                for (int j = (int)region.yMin; j < (int)region.yMax; j++)
                {
                    outTex.SetPixel(i, j, original.GetPixel(i, j));
                }
            }

            outTex.Apply();
            return outTex;
        }
        /// <summary>
        /// Get the SHA1 hash of the texture when encoded to a png
        /// </summary>
        /// <param name="tex">The Texture2D</param>
        /// <returns>The hash as a string</returns>
        public static string getHash(this Texture2D tex)
        {
            var data = tex.EncodeToPNG();
            var sha1 = SHA1.Create();

            byte[] hashBytes = sha1.ComputeHash(data);

            string hash = BitConverter.ToString(hashBytes).Replace("-", string.Empty);

            return hash;
        }

    }
}