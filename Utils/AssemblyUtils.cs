using System.IO;
using System.Reflection;
using System.Security.Cryptography;

namespace Satchel
{
    public static class AssemblyUtils{
        public static string name = "Satchel";
        public static string ver = "0.8.1";
        public static string Version(){
            var verStr = $"{name} v{ver}";
            return verStr;
        }
        //Application.runInBackground = true;

        public static string GetAssemblyHash(this Assembly asm){
            var ver = asm.GetName().Version.ToString();
            var sha1 = SHA1.Create();
            var stream = File.OpenRead(asm.Location);
            var hashBytes = sha1.ComputeHash(stream);
            var hash = BitConverter.ToString(hashBytes).Replace("-", "").ToLowerInvariant();
            stream.Close();
            sha1.Clear();
            return $"{hash.Substring(0, 6)}";
        }

        public static string GetAssemblyVersionHash()
        {
            var asm = Assembly.GetCallingAssembly();
            return asm.GetAssemblyVersionHash("");
        }

        public static string GetAssemblyVersionHash(string version = "")
        {
            var asm = Assembly.GetCallingAssembly();
            return asm.GetAssemblyVersionHash(version);
        }
        public static string GetAssemblyVersionHash(this Assembly asm,string version = "")
        {
            var ver = version == "" ? asm.GetName().Version.ToString() : version;
            var hash = asm.GetAssemblyHash();
            return $"{ver}-{hash}";
        }

        public static string getCurrentDirectory(){
           return Path.GetDirectoryName(System.Reflection.Assembly.GetCallingAssembly().Location);
        }
        public static byte[] GetBytesFromResources(this Assembly asm,string fileName){
            foreach (string res in asm.GetManifestResourceNames())
            {   
                if(!res.EndsWith(fileName)) { continue; } 
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
        public static byte[] GetBytesFromResources(string fileName){
            return Assembly.GetCallingAssembly().GetBytesFromResources(fileName);
        }

        public static Sprite GetSpriteFromResources(string fileName){
            Texture2D tex = new Texture2D(2, 2);
            byte[] buffer = Assembly.GetCallingAssembly().GetBytesFromResources(fileName);
            tex.LoadImage(buffer);
            tex.Apply();    
            Sprite sprite = Sprite.Create(tex,new Rect(0f, 0f, tex.width, tex.height), new Vector2(0.5f, 0.5f),64f); 
            return sprite;
        }
        public static Sprite GetSpriteFromResources(string fileName, float pixelsPerUnit){
            Texture2D tex = new Texture2D(2, 2);
            byte[] buffer = Assembly.GetCallingAssembly().GetBytesFromResources(fileName);
            tex.LoadImage(buffer);
            tex.Apply();    
            Sprite sprite = Sprite.Create(tex,new Rect(0f, 0f, tex.width, tex.height), new Vector2(0.5f, 0.5f),pixelsPerUnit); 
            return sprite;
        }

        public static Texture2D GetTextureFromResources(string fileName){
            Texture2D tex = new Texture2D(2, 2);
            byte[] buffer = Assembly.GetCallingAssembly().GetBytesFromResources(fileName);
            tex.LoadImage(buffer);
            tex.Apply();    
            return tex;
        }
        public static AssetBundle GetAssetBundleFromResources(string fileName){  
            byte[] buffer = Assembly.GetCallingAssembly().GetBytesFromResources(fileName);
            AssetBundle bundle = AssetBundle.LoadFromMemory(buffer); 
            return bundle;
        }

        public static Shader GetShader(this AssetBundle bundle,string shader){
            return bundle.LoadAsset<Shader>(shader);
        }

        public static void ExtractFiles(this Assembly asm,string outpath,Func<string,string> shouldExtractAs){
            IoUtils.EnsureDirectory(outpath);
            foreach (string res in asm.GetManifestResourceNames())
            {   
                var fileName = shouldExtractAs(res);
                if(fileName != "") {
                    using (Stream s = asm.GetManifestResourceStream(res))
                    {
                            if (s == null) continue;
                            var buffer = new byte[s.Length];
                            s.Read(buffer, 0, buffer.Length);
                            File.WriteAllBytes(Path.Combine(outpath,fileName),buffer);
                            s.Dispose();
                    }
                } 
            }
        }

        public static void ExtractFiles(string outpath,Func<string,string> shouldExtractAs){
            Assembly.GetCallingAssembly().ExtractFiles(outpath,shouldExtractAs);
        }

    }
}
