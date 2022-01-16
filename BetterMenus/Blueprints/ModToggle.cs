using System;
using System.Collections.Generic;
using System.Diagnostics;
using Modding;
using Modding.Menu;
using Modding.Menu.Config;
using UnityEngine;
using Lang = Language.Language;

namespace Satchel.BetterMenus
{
    public static partial class Blueprints{
        public static HorizontalOption CreateToggle(this ModToggleDelegates toggleDelegates, string name, string description){
            return toggleDelegates.CreateToggle(name,description,Lang.Get("MOH_ON", "MainMenu"), Lang.Get("MOH_OFF", "MainMenu"));
        }
        public static HorizontalOption CreateToggle(this ModToggleDelegates toggleDelegates, string name, string description,string on,string off){
            return new HorizontalOption(name,description,new string[]{on,off},
                i =>
                {
                    toggleDelegates.SetModEnabled(i == 0);
                }, 
                () => toggleDelegates.GetModEnabled() ? 0 : 1
            ,"ModToggle");
        }
    }
}