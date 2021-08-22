using System;
using System.IO;
using System.Reflection;
using System.Collections;
using System.Security.Cryptography;

using UnityEngine;
using UnityEngine.SceneManagement;
using static Modding.Logger;

namespace DandyCore{
    public static class AssemblyUtils{

        public static string Version(){
            var version = "0.5";
            var verStr = $"DandyCore v{version}";
            Log($"{verStr}\n{Assembly.GetExecutingAssembly().GetName()}");
            return verStr;
        }
        //Application.runInBackground = true;
        public static string GetAssemblyVersionHash()
        {
            var asm = Assembly.GetCallingAssembly();
            var ver = asm.GetName().Version.ToString();
            var sha1 = SHA1.Create();
            var stream = File.OpenRead(asm.Location);
            var hashBytes = sha1.ComputeHash(stream);
            var hash = BitConverter.ToString(hashBytes).Replace("-", "").ToLowerInvariant();
            stream.Close();
            sha1.Clear();
            return $"{ver}-{hash.Substring(0, 6)}";
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
        public static AssetBundle GetAssetBundleFromResources(string fileName){  
            byte[] buffer = Assembly.GetCallingAssembly().GetBytesFromResources(fileName);
            AssetBundle bundle = AssetBundle.LoadFromMemory(buffer); 
            return bundle;
        }

        public static Shader GetShader(this AssetBundle bundle,string shader){
            return bundle.LoadAsset<Shader>(shader);
        }

    }
}