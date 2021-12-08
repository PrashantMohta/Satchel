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
        public static MenuRow KeyAndButtonBind(
            string name,
            InControl.PlayerAction keyBindAction,
            InControl.PlayerAction buttonBindAction,
            string Id = "__UseName"){
            if(Id == "__UseName"){
                Id = name;
            }
            var sbso = new MenuRow(
                new List<Element>{
                    new KeyBind(name ,keyBindAction,Id:Id+"key", SelectableArea.ButtonOnly),
                    new ButtonBind("",buttonBindAction,Id:Id+"button", SelectableArea.ButtonOnly)
                },
                Id:Id);
            sbso.XDelta = 150f;
            
            return sbso;
        }
    }
}