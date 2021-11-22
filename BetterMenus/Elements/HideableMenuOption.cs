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
    /// A hideable menu option.
    /// </summary>
    public class HideableMenuOption : Element
    {
        /// <summary>
        /// The primary option.
        /// </summary>
        public IPrimaryMenuOption PrimaryOption;
        /// <summary>
        /// The sub-options.
        /// </summary>
        public List<Element> SubOptions;
        //the function that will return a bool. the bool will determine whether the sub options should show or not
        /// <summary>
        /// The Func(bool) that hides/shows the options. (The bool determines whether the sub options should show or not.)
        /// </summary>
        public Func<bool> EnableSubOptions;
        

        private List<GameObjectPair> AllSubOptions = new List<GameObjectPair>();

        /// <summary>
        /// Creates a new HideableMenuOption.
        /// </summary>
        /// <param name="primaryOption">The primary option.</param>
        /// <param name="subOptions">The sub-options.</param>
        /// <param name="enableSubOptions">The Func(bool) that hides/shows the options. (The bool determines whether the sub options should show or not.)</param>
        public HideableMenuOption(IPrimaryMenuOption primaryOption, List<Element> subOptions,Func<bool> enableSubOptions)
        {
            PrimaryOption = primaryOption;
            SubOptions = subOptions;
            EnableSubOptions = enableSubOptions;
        }

        /// <summary>
        /// Creates a GameObjectPair based on the current variables.
        /// </summary>
                /// <returns>The created GameObjectPair which can be used to add to the corresponding Lists.</returns>
        public override GameObjectPair Create(ContentArea c, MenuScreen modlistMenu, Menu Instance, bool AddToList = true)
        {
            PrimaryOption.AddUpdateMenuAction(() =>
            {
                bool enable = EnableSubOptions.Invoke();
                foreach (GameObjectPair gos in AllSubOptions)
                {
                    if (gos.LeftGo != Menu.TempObj ) gos.LeftGo.SetActive(enable);
                    if (gos.RightGo != Menu.TempObj ) gos.RightGo.SetActive(enable);
                }
                Instance.Reorder();
            });
            
            var primaryoption = PrimaryOption.Create(c, modlistMenu, Instance, false);
            
            Instance.MenuOrder.Add(primaryoption);
            
            foreach (Element menuOption in SubOptions)
            {
                var option = menuOption.Create(c, modlistMenu,Instance, false);
                AllSubOptions.Add(option);
                Instance.MenuOrder.Add(option);
            }

            return primaryoption;
        }
    }

}