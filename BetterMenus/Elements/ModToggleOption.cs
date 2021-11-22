using System;
using System.Collections.Generic;
using System.Diagnostics;
using Modding;
using Modding.Menu;
using Modding.Menu.Config;
using UnityEngine;

namespace Satchel.BetterMenus
{
    
    /// <summary>
    /// An option that toggles a mod.
    /// </summary>
    public class ModToggleOption: Element
    {
        /// <summary>
        /// The ModToggleDelegates of the mod.
        /// </summary>
        public ModToggleDelegates ToggleDelegates;
        /// <summary>
        /// The description to be displayed.
        /// </summary>
        public string Description;
        

        /// <summary>
        /// Creates a new ModToggleOption.
        /// </summary>
        /// <param name="name">The name to be displayed.</param>
        /// <param name="toggleDelegates">The ModToggleDelegates of the mod.</param>
        /// <param name="description">The description to be displayed.</param>
        public ModToggleOption(string name, ModToggleDelegates toggleDelegates, string description)
        {
            Name = name;
            ToggleDelegates = toggleDelegates;
            Description = description;
        }

        /// <summary>
        /// Creates a GameObjectPair based on the current variables.
        /// </summary>
                /// <returns>The created GameObjectPair which can be used to add to the corresponding Lists.</returns>
        public override GameObjectPair Create(ContentArea c, MenuScreen modlistMenu, Menu Instance, bool AddToList = true)
        {
            var horizontalOption = new HorizontalOption(Name, new[] {"On", "Off"}, Description,
                i =>
                {
                    ToggleDelegates.SetModEnabled(i == 0);
                }, () => ToggleDelegates.GetModEnabled() ? 0 : 1);
            
            var option = horizontalOption.Create(c, modlistMenu, Instance, false);
            
            if (AddToList)
            {
                Instance.MenuOrder.Add(option);
            }

            return new GameObjectPair(option);
        }
    }

}