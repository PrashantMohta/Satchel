using System;
using System.Collections.Generic;
using System.Diagnostics;
using Modding;
using Modding.Menu;
using Modding.Menu.Config;
using UnityEngine;

namespace Satchel.BetterMenus
{
    public interface IPrimaryMenuOption
    {
        public abstract GameObjectPair Create(ContentArea c, MenuScreen modlistMenu, Menu Instance, bool AddToList = true);
        public abstract void AddUpdateMenuAction(Action UpdateMenu);
    }
}
