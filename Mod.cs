using System;
using System.Collections;
using System.Collections.Generic;

using System.IO;
using UnityEngine;
using Modding;
using static Modding.Logger;

namespace Satchel{
    public class Satchel : Mod{

        new public string GetName() => AssemblyUtils.name;
        public override string GetVersion() => $"{AssemblyUtils.GetAssemblyVersionHash(AssemblyUtils.ver)}";
        public Satchel Instance;
        public override void Initialize()
        {
            if (Instance == null) 
            { 
                Instance = this;
            }
            ModHooks.LanguageGetHook += LanguageGet;
        }
        
        private static string LanguageGet(string key, string sheetTitle, string orig)
        {
            foreach (var KeyValue in CustomModMenuUtils.LanguageKeys)
            {
                if (key == KeyValue.Item1) return KeyValue.Item2;
            }
            return orig;
        }
    }
}
