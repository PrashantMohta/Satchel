using System.IO;
using System.Reflection;
using System.Security.Cryptography;

namespace Satchel
{
    /// <summary>
    /// Utilities for working with Assemblies
    /// </summary>
    public static class AssemblyUtils
    {
        /// <summary>
        /// Name of this Assembly
        /// </summary>
        public static string name = "Satchel";

        /// <summary>
        /// Version of this Assembly
        /// </summary>
        public static string ver = "0.9.2";

        /// <summary>
        /// Gets Version string
        /// </summary>
        /// <returns></returns>
        public static string Version()
        {
            var verStr = $"{name} v{ver}";
            return verStr;
        }
        /// <summary>
        /// Get Assembly SHA1 Hash 
        /// </summary>
        /// <param name="asm"></param>
        /// <returns></returns>
        public static string GetAssemblyHash(this Assembly asm)
        {
            var ver = asm.GetName().Version.ToString();
            var sha1 = SHA1.Create();
            var stream = File.OpenRead(asm.Location);
            var hashBytes = sha1.ComputeHash(stream);
            var hash = BitConverter.ToString(hashBytes).Replace("-", "").ToLowerInvariant();
            stream.Close();
            sha1.Clear();
            return $"{hash.Substring(0, 6)}";
        }
        /// <summary>
        /// Get AssemblyVersion with Hash for the calling Assembly
        /// </summary>
        /// <returns></returns>
        public static string GetAssemblyVersionHash()
        {
            var asm = Assembly.GetCallingAssembly();
            return asm.GetAssemblyVersionHash("");
        }

        /// <summary>
        /// Get AssemblyVersion with Hash for the calling Assembly
        /// </summary>
        /// <param name="version"></param>
        /// <returns></returns>
        public static string GetAssemblyVersionHash(string version = "")
        {
            var asm = Assembly.GetCallingAssembly();
            return asm.GetAssemblyVersionHash(version);
        }

        /// <summary>
        /// Get AssemblyVersion with Hash for an Assembly
        /// </summary>
        /// <param name="asm"></param>
        /// <param name="version"></param>
        /// <returns></returns>
        public static string GetAssemblyVersionHash(this Assembly asm, string version = "")
        {
            var ver = version == "" ? asm.GetName().Version.ToString() : version;
            var hash = asm.GetAssemblyHash();
            return $"{ver}-{hash}";
        }

        /// <summary>
        /// Get the directory path of the Calling Assembly
        /// </summary>
        /// <returns></returns>
        public static string getCurrentDirectory()
        {
            return Path.GetDirectoryName(System.Reflection.Assembly.GetCallingAssembly().Location);
        }

        /// <summary>
        /// Get Bytes[] from the Embedded resources in an Assembly
        /// </summary>
        /// <param name="asm"></param>
        /// <param name="fileName"></param>
        /// <returns></returns>
        public static byte[] GetBytesFromResources(this Assembly asm, string fileName)
        {
            foreach (string res in asm.GetManifestResourceNames())
            {
                if (!res.EndsWith(fileName)) { continue; }
                using (Stream s = asm.GetManifestResourceStream(res))
                {
                    if (s == null) continue;
                    byte[] buffer = new byte[s.Length];
                    s.Read(buffer, 0, buffer.Length);
                    s.Dispose();
                    return buffer;
                }
            }
            return null;
        }

        /// <summary>
        /// Get Bytes[] from the Embedded resources in calling Assembly
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        public static byte[] GetBytesFromResources(string fileName)
        {
            return Assembly.GetCallingAssembly().GetBytesFromResources(fileName);
        }

        /// <summary>
        /// Get Sprite from Embedded Resources by FileName
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        public static Sprite GetSpriteFromResources(string fileName)
        {
            Texture2D tex = new Texture2D(2, 2);
            byte[] buffer = Assembly.GetCallingAssembly().GetBytesFromResources(fileName);
            if(buffer == null)
            {
                return null;
            }
            tex.LoadImage(buffer);
            tex.Apply();
            Sprite sprite = Sprite.Create(tex, new Rect(0f, 0f, tex.width, tex.height), new Vector2(0.5f, 0.5f), 64f);
            return sprite;
        }

        /// <summary>
        ///  Get Sprite from Embedded Resources by FileName at a certain PixelsPerUnit
        /// </summary>
        /// <param name="fileName"></param>
        /// <param name="pixelsPerUnit"></param>
        /// <returns></returns>
        public static Sprite GetSpriteFromResources(string fileName, float pixelsPerUnit)
        {
            Texture2D tex = new Texture2D(2, 2);
            byte[] buffer = Assembly.GetCallingAssembly().GetBytesFromResources(fileName);
            if (buffer == null)
            {
                return null;
            }
            tex.LoadImage(buffer);
            tex.Apply();
            Sprite sprite = Sprite.Create(tex, new Rect(0f, 0f, tex.width, tex.height), new Vector2(0.5f, 0.5f), pixelsPerUnit);
            return sprite;
        }
        /// <summary>
        /// Get Texture2D from Embedded Resources by FileName
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        public static Texture2D GetTextureFromResources(string fileName)
        {
            Texture2D tex = new Texture2D(2, 2);
            byte[] buffer = Assembly.GetCallingAssembly().GetBytesFromResources(fileName);
            if (buffer == null)
            {
                return null;
            }
            tex.LoadImage(buffer);
            tex.Apply();
            return tex;
        }

        /// <summary>
        /// Get AssetBundle from Embedded Resources by FileName
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        public static AssetBundle GetAssetBundleFromResources(string fileName)
        {
            byte[] buffer = Assembly.GetCallingAssembly().GetBytesFromResources(fileName);
            if (buffer == null)
            {
                return null;
            }
            AssetBundle bundle = AssetBundle.LoadFromMemory(buffer);
            return bundle;
        }

        /// <summary>
        /// Get Shader from an AssetBundle by name
        /// </summary>
        /// <param name="bundle"></param>
        /// <param name="shader"></param>
        /// <returns></returns>
        public static Shader GetShader(this AssetBundle bundle, string shader)
        {
            return bundle.LoadAsset<Shader>(shader);
        }

        /// <summary>
        /// Extract all files in Embedded Resources of an assembly based on a predicate that returns file name or empty string (empty string means the resource is skipped)
        /// </summary>
        /// <param name="asm"></param>
        /// <param name="outpath">path to write the files into</param>
        /// <param name="shouldExtractAs">Predicate that returns file name or empty string</param>
        public static void ExtractFiles(this Assembly asm, string outpath, Func<string, string> shouldExtractAs)
        {
            IoUtils.EnsureDirectory(outpath);
            foreach (string res in asm.GetManifestResourceNames())
            {
                var fileName = shouldExtractAs(res);
                if (fileName != "")
                {
                    using (Stream s = asm.GetManifestResourceStream(res))
                    {
                        if (s == null) continue;
                        var buffer = new byte[s.Length];
                        s.Read(buffer, 0, buffer.Length);
                        File.WriteAllBytes(Path.Combine(outpath, fileName), buffer);
                        s.Dispose();
                    }
                }
            }
        }

        /// <summary>
        /// Extract all files in Embedded Resources of the calling assembly based on a predicate that returns file name or empty string (empty string means the resource is skipped)
        /// </summary>
        /// <param name="outpath">path to write the files into</param>
        /// <param name="shouldExtractAs">Predicate that returns file name or empty string</param>
        public static void ExtractFiles(string outpath, Func<string, string> shouldExtractAs)
        {
            Assembly.GetCallingAssembly().ExtractFiles(outpath, shouldExtractAs);
        }

    }
}
