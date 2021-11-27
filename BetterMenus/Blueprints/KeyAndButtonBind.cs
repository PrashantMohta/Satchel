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
        public static SideBySideOptions KeyAndButtonBind(
            string name,
            InControl.PlayerAction keyBindAction,
            InControl.PlayerAction buttonBindAction,
            string Id = "__UseName"){
            if(Id == "__UseName"){
                Id = name;
            }
            var sbso = new SideBySideOptions(
                new KeyBind(name ,keyBindAction,Id:Id+"key"),
                new ButtonBind("",keyBindAction,Id:Id+"button"),
                Id:Id);
            sbso.XDelta = 150f;
            return sbso;
        }
    }
}