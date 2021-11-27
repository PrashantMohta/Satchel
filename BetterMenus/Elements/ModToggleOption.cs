using System;
using System.Collections.Generic;
using System.Diagnostics;
using Modding;
using Modding.Menu;
using Modding.Menu.Config;
using UnityEngine;
using UnityEngine.UI;

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
        public ModToggleOption(
            string name, 
            ModToggleDelegates toggleDelegates,
            string description,
            string Id = "__UseName") : base(Id,name)
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
            _ = Name ?? throw new ArgumentNullException(nameof(Name), "Name cannot be null");
            _ = Description ?? throw new ArgumentNullException(nameof(Description), "Description cannot be null");

            var horizontalOption = new HorizontalOption(Name, Description, new[] {"On", "Off"},
                i =>
                {
                    ToggleDelegates.SetModEnabled(i == 0);
                }, () => ToggleDelegates.GetModEnabled() ? 0 : 1,Name+"internalModToggle");
            
            var option = horizontalOption.Create(c, modlistMenu, Instance, false);
            
            if (AddToList)
            {
                Instance.MenuOrder.Add(option);
            }

            gameObject = option.LeftGo;

            return new GameObjectPair(option);
        }

        public override void Update()
        {
            //you cant change ToggleDelegates, its from mapi
            gameObject.transform.Find("Label").GetComponent<Text>().text = Name;
            gameObject.transform.Find("Description").GetComponent<Text>().text = Description;

        }
    }

}