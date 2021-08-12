using UnityEngine;

using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace DandyCore {

    public class SpriteUtils{

        public static Sprite CreateSpriteFromTexture(Texture2D texture) {
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

        public static Texture2D ExtractTextureFromSprite(Sprite testSprite, bool saveTriangles = false)
        {
            var testSpriteRect = (testSprite.texture.width, testSprite.texture.height);
            List<Vector2Int> texUVs = new List<Vector2Int>();
            List<(Vector2Int, Vector2Int, Vector2Int)> triangles = new List<(Vector2Int, Vector2Int, Vector2Int)>();
            int i;
            bool[][] contents;
            bool[][] triangle;
            float triangleArea;
            float pab, pbc, pac;
            Vector2Int p;
            int x, y;
            int minX, maxX, minY, maxY;
            int width, height;
            Texture2D origTex, outTex;

            foreach (var item in testSprite.uv)
            {
                texUVs.Add(new Vector2Int(Mathf.RoundToInt(item.x * (testSpriteRect.width - 1)), Mathf.RoundToInt(item.y * (testSpriteRect.height - 1))));
            }
            for (i = 0; i < testSprite.triangles.Length; i += 3)
            {
                triangles.Add((texUVs[testSprite.triangles[i]], texUVs[testSprite.triangles[i+1]], texUVs[testSprite.triangles[i+2]]));
            }

            minX = texUVs.Select(uv => uv.x).ToList().Min();
            maxX = texUVs.Select(uv => uv.x).ToList().Max();
            minY = texUVs.Select(uv => uv.y).ToList().Min();
            maxY = texUVs.Select(uv => uv.y).ToList().Max();
            width = maxX - minX + 1;
            height = maxY - minY + 1;


            contents = new bool[height][];
            for (i = 0; i < contents.Length; i++)
                contents[i] = new bool[width];
            int triangleCounter = 0;
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
            if (saveTriangles)
                saveTriangle(contents, testSprite.name, 1000000);


            origTex = TextureUtils.duplicateTexture(testSprite.texture);
            outTex = new Texture2D(width, height);

            for (x = 0; x < width; x++)
            {
                for (y = 0; y < height; y++)
                {
                    if (!contents[y][x])
                        outTex.SetPixel(x, y, new Color(0, 0, 0, 0));
                    else
                        outTex.SetPixel(x, y, origTex.GetPixel(minX + x, minY + y));
                }
            }
            outTex.Apply();
            Texture2D.DestroyImmediate(origTex);
            return outTex;
        }
    }

}