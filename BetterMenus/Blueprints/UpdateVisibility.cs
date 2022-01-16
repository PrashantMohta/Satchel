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
        /// <summary>
        /// a blueprint to help update visibility of many elements
        /// </summary>
        /// <param name="menuRef">the Menu instance that created that holds the elements in the menu</param>
        /// <param name="isVisible">the new visibility of the elements</param>
        /// <param name="elements">an array of the ids of the elements that want to chance its visibility</param>
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