using System;
using System.Collections.Generic;
using System.Diagnostics;
using Modding;
using Modding.Menu;
using Modding.Menu.Config;
using UnityEngine;

namespace Satchel.BetterMenus
{
    public static partial class Blueprints{
        public static void UpdateVisibility(this Menu menuRef,bool isVisible,string[] elements){
            foreach(var element in elements){
                var x = menuRef.Find(element);
                if(x != null){
                  x.isVisible = isVisible;
                }
            }
            menuRef.Update();
        }
    }
}