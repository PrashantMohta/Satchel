using UnityEngine;

using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

using static Modding.Logger;
namespace Satchel
{

    public class SpriteUtils
    {

        public static Sprite CreateSpriteFromTexture(Texture2D texture)
        {
            return Sprite.Create(
                texture,
                new Rect(0, 0, texture.width, texture.height),
                new Vector2(texture.width / 2.0f, texture.height / 2.0f)
            );
        }

        public static void saveTriangle(bool[][] triangle, string spriteName, int num)
        {
            var outTex = new Texture2D(triangle[0].Length, triangle.Length);
            for (int x = 0; x < triangle[0].Length; x++)
                for (int y = 0; y < triangle.Length; y++)
                    outTex.SetPixel(x, y, triangle[y][x] ? Color.white : Color.black);
            outTex.Apply();
            TextureUtils.WriteTextureToFile(outTex, $"{AssemblyUtils.getCurrentDirectory()}/{spriteName}-{num}.png");
            Texture2D.DestroyImmediate(outTex);
        }

        private static float CalcTriangleArea(Vector2Int a, Vector2Int b, Vector2Int c)
        {
            return Mathf.Abs(((a.x * (b.y - c.y)) + (b.x * (c.y - a.y)) + (c.x * (a.y - b.y))) / 2f);
        }

        public static Vector2 GetSpriteOrigin(Sprite testSprite)
        {
            var testSpriteRect = (testSprite.texture.width, testSprite.texture.height);
            List<Vector2Int> texUVs = new List<Vector2Int>();

            foreach (var item in testSprite.uv)
            {
                texUVs.Add(new Vector2Int(Mathf.RoundToInt(item.x * (testSpriteRect.width - 1)), Mathf.RoundToInt(item.y * (testSpriteRect.height - 1))));
            }

            var minX = texUVs.Select(uv => uv.x).ToList().Min();
            var maxX = texUVs.Select(uv => uv.x).ToList().Max();
            var minY = texUVs.Select(uv => uv.y).ToList().Min();
            var maxY = texUVs.Select(uv => uv.y).ToList().Max();

            return new Vector2(minX, minY);
        }
        public static Texture2D ExtractTextureWithShader(Texture2D tex, Vector2Int offset,
            Vector2Int realSize, Vector2Int texSize, Vector2Int border, bool flipHorizontal,
            bool flipVertical, List<(Vector2Int, Vector2Int, Vector2Int)> triangles, bool drawMask = false)
        {
            if (Core.spriteExtract == null || Core.spriteMask == null) throw new InvalidOperationException();
            #region Make Sprite Mask
            var maskMat = new Material(Core.spriteMask);
            maskMat.SetColor("_Color", Color.red);
            var mtex = RenderTexture.GetTemporary(
                        realSize.x,
                        realSize.y,
                        0,
                        RenderTextureFormat.Default,
                        RenderTextureReadWrite.Linear);
            var mtex2 = RenderTexture.GetTemporary(
                        realSize.x,
                        realSize.y,
                        0,
                        RenderTextureFormat.Default,
                        RenderTextureReadWrite.Linear);
            foreach(var v in triangles)
            {
                var mp0 = new Vector2((float)(v.Item1.x - offset.x) / (float)realSize.x, (float)(v.Item1.y - offset.y) / (float)realSize.y);
                var mp1 = new Vector2((float)(v.Item2.x - offset.x) / (float)realSize.x, (float)(v.Item2.y - offset.y) / (float)realSize.y);
                var mp2 = new Vector2((float)(v.Item3.x - offset.x) / (float)realSize.x, (float)(v.Item3.y - offset.y) / (float)realSize.y);
                
                maskMat.SetVector("_P0", mp0);
                maskMat.SetVector("_P1", mp1);
                maskMat.SetVector("_P2", mp2);
                Graphics.Blit(mtex2, mtex, maskMat);
                Graphics.Blit(mtex, mtex2);
                Modding.Logger.Log($"triangles: {mp0} {mp1} {mp2}");
            }
            
            UnityEngine.Object.Destroy(maskMat);
            #endregion
            
            #region Extract Sprite
            var mat = new Material(Core.spriteExtract);
            mat.SetTexture("_MainTex", tex);
            mat.SetTexture("_MaskTex", mtex);

            mat.SetFloat("_DrawMask", drawMask ? 1 : 0);

            //mat.SetTexture("_MaskTex", testAll);
            mat.SetFloat("_OffsetX", offset.x);
            mat.SetFloat("_OffsetY", offset.y);
            mat.SetFloat("_SrcWidth", tex.width);
            mat.SetFloat("_SrcHeight", tex.height);
            mat.SetFloat("_Width", realSize.x);
            mat.SetFloat("_Height", realSize.y);
            mat.SetFloat("_DstWidth", texSize.x);
            mat.SetFloat("_DstHeight", texSize.y);
            mat.SetFloat("_FlipH", flipHorizontal ? 1 : -1);
            mat.SetFloat("_FlipV", flipVertical ? 1 : -1);
            mat.SetFloat("_BorderLeft", border.x);
            mat.SetFloat("_BorderBottom", border.y);
            var rtex = RenderTexture.GetTemporary(
                        texSize.x,
                        texSize.y,
                        0,
                        RenderTextureFormat.Default,
                        RenderTextureReadWrite.Linear);
            Graphics.Blit(tex, rtex, mat);
            
            var previous = RenderTexture.active;
            RenderTexture.active = rtex;
            var readableText = new Texture2D(texSize.x, texSize.y);
            readableText.ReadPixels(new Rect(0, 0, texSize.x, texSize.y), 0, 0);
            readableText.Apply();
            RenderTexture.active = previous;
            RenderTexture.ReleaseTemporary(rtex);
            RenderTexture.ReleaseTemporary(mtex2);
            UnityEngine.Object.Destroy(mat);
            RenderTexture.ReleaseTemporary(mtex);
            #endregion
            return readableText;
        }
        public static Texture2D ExtractTextureFromSprite(Sprite testSprite, bool saveTriangles = false)
        {
            var testSpriteRect = (testSprite.texture.width, testSprite.texture.height);
            List<Vector2Int> texUVs = new List<Vector2Int>();

            int i;


            float triangleArea;
            float pab, pbc, pac;
            Vector2Int p;
            int x, y;
            int minX, maxX, minY, maxY;
            int width, height;
            Vector2 pivot;

            foreach (var item in testSprite.uv)
            {
                texUVs.Add(new Vector2Int(Mathf.RoundToInt(item.x * (testSpriteRect.width - 1)), Mathf.RoundToInt(item.y * (testSpriteRect.height - 1))));
            }

            minX = texUVs.Select(uv => uv.x).ToList().Min();
            maxX = texUVs.Select(uv => uv.x).ToList().Max();
            minY = texUVs.Select(uv => uv.y).ToList().Min();
            maxY = texUVs.Select(uv => uv.y).ToList().Max();
            width = maxX - minX + 1;
            height = maxY - minY + 1;


            bool[][] contents;
            List<(Vector2Int, Vector2Int, Vector2Int)> triangles = new();
            for (i = 0; i < testSprite.triangles.Length; i += 3)
            {
                triangles.Add((texUVs[testSprite.triangles[i]], texUVs[testSprite.triangles[i + 1]], texUVs[testSprite.triangles[i + 2]]));
            }

            if (saveTriangles)
            {
                contents = new bool[height][];
                for (i = 0; i < contents.Length; i++)
                    contents[i] = new bool[width];

                foreach (var item in triangles)
                {
                    triangleArea = CalcTriangleArea(item.Item1, item.Item2, item.Item3);
                    for (x = 0; x < width; x++)
                    {
                        for (y = 0; y < height; y++)
                        {
                            p = new Vector2Int(minX + x, minY + y);
                            pab = CalcTriangleArea(item.Item1, item.Item2, p);
                            pbc = CalcTriangleArea(p, item.Item2, item.Item3);
                            pac = CalcTriangleArea(item.Item1, p, item.Item3);
                            if ((pab + pbc + pac) == triangleArea)
                            {
                                contents[y][x] = true;
                            }
                        }
                    }

                }
                saveTriangle(contents, testSprite.name, 1000000);
            }


            // take care of rotations
            var horizontal = false;
            var vertical = false;
            if (testSprite.packed)
            {
                horizontal = (testSprite.packingRotation == SpritePackingRotation.FlipHorizontal || testSprite.packingRotation == SpritePackingRotation.Rotate180);
                vertical = (testSprite.packingRotation == SpritePackingRotation.FlipVertical || testSprite.packingRotation == SpritePackingRotation.Rotate180);
            };

            // render on a new texture such that pivot is always at (50%,50%)
            pivot = testSprite.pivot;

            var newSize = new Vector2Int(width, height);
            Vector2 pivotRatio = new Vector2(0, 0);
            pivotRatio.x = pivot.x / (float)newSize.x;
            pivotRatio.y = pivot.y / (float)newSize.y;

            var offset = new Vector2Int(0, 0);


            var deltaX = 0.5f - pivotRatio.x;
            var deltaY = 0.5f - pivotRatio.y;

            // if delta is < 0 = add 2x pixels at end , if delta is > 0 add 2x at the start

            if (deltaX > 0)
            {
                // add at start
                offset.x = (int)(2f * Mathf.Abs(deltaX) * width);
                newSize.x = (int)(width + offset.x);
            }
            else
            {
                // add at end
                offset.x = 0;
                newSize.x = (int)(width + (int)(2f * Mathf.Abs(deltaX) * width));
            }

            if (deltaY < 0)
            { //Y coordinate starts from bottom in unity
                // add at start ()
                offset.y = (int)(2f * Mathf.Abs(deltaY) * height);
                newSize.y = (int)(height + offset.y);
            }
            else
            {
                // add at end
                offset.y = 0;
                newSize.y = (int)(height + (int)(2f * Mathf.Abs(deltaY) * height));
            }

            return ExtractTextureWithShader(testSprite.texture,
                new Vector2Int(minX, minY), new Vector2Int(width, height), new Vector2Int(newSize.x, newSize.y),
                offset, horizontal, vertical, triangles, false);
        }
    }

}