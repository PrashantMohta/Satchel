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
    /// A horizontal option.
    /// </summary>
    public class HorizontalOption : Element, IPrimaryMenuOption
    {
        
        /// <summary>
        /// The description to be displayed.
        /// </summary>
        public string Description;
        /// <summary>
        /// The values the HorizontalOption can have.
        /// </summary>
        public string[] Values;
        /// <summary>
        /// Triggered when a setting is applied.
        /// </summary>
        public Action<int> ApplySetting;
        /// <summary>
        /// The Func(int) to call when settings are being loaded.
        /// </summary>
        public Func<int> LoadSetting;

        /// <summary>
        /// Creates a new HorizontalOption.
        /// </summary>
        /// <param name="name">The name to be displayed.</param>
        /// <param name="values">The values the HorizontalOption can have.</param>
        /// <param name="description">The description to be displayed.</param>
        /// <param name="applySetting">Triggered when a setting is applied.</param>
        /// <param name="loadSetting">The Func(int) to call when settings are being loaded.</param>
        public HorizontalOption(string name, string[] values, string description, Action<int> applySetting, Func<int> loadSetting)
        {
            Name = name;
            Description = description;
            Values = values;
            ApplySetting = applySetting;
            LoadSetting= loadSetting;
        }

        /// <summary>
        /// Creates a GameObjectPair based on the current variables.
        /// </summary>
                /// <returns>The created GameObjectPair which can be used to add to the corresponding Lists.</returns>
        public override GameObjectPair Create(ContentArea c, MenuScreen modlistMenu, Menu Instance, bool AddToList = true)
        {
            c.AddHorizontalOption(
                Name,
                new HorizontalOptionConfig
                {
                    ApplySetting = (_, i) => ApplySetting(i),
                    RefreshSetting = (s, _) => s.optionList.SetOptionTo(LoadSetting()),
                    CancelAction = _ => UIManager.instance.UIGoToDynamicMenu(modlistMenu),
                    Description = new DescriptionInfo
                    {
                        Text = Description
                    },
                    Label = Name,
                    Options = Values,
                    Style = HorizontalOptionStyle.VanillaStyle
                },
                out var option);
            if (AddToList)
            {
                Instance.MenuOrder.Add(new GameObjectPair(option.gameObject));
            }

            return new GameObjectPair(option.gameObject);
        }

        /// <summary>
        /// Adds a new Action to when the setting is applied.
        /// </summary>
        /// <param name="UpdateMenu">The Action to add.</param>
        public void AddUpdateMenuAction(Action UpdateMenu)
        {
            ApplySetting += _ => UpdateMenu.Invoke();
        }
    }
}