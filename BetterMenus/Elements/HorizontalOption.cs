using System;
using System.Collections.Generic;
using System.Diagnostics;
using Modding;
using Modding.Menu;
using Modding.Menu.Config;
using On.UnityEngine.UI;
using UnityEngine;
using UnityEngine.UI;
using MenuOptionHorizontal = UnityEngine.UI.MenuOptionHorizontal;

namespace Satchel.BetterMenus
{
    /// <summary>
    /// A horizontal option.
    /// </summary>
    public class HorizontalOption : Element
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
        /// <param name="description">The description to be displayed.</param>
        /// <param name="values">The values the HorizontalOption can have.</param>
        /// <param name="applySetting">Triggered when a setting is applied.</param>
        /// <param name="loadSetting">The Func(int) to call when settings are being loaded.</param>
        public HorizontalOption(
            string name , 
            string description,
            string[] values, 
            Action<int> applySetting, 
            Func<int> loadSetting,
            string Id = "__UseName") : base(Id,name)
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
            _ = Name ?? throw new ArgumentNullException(nameof(Name), "Name cannot be null");
            _ = Description ?? throw new ArgumentNullException(nameof(Description), "Description cannot be null");
            _ = Values ?? throw new ArgumentNullException(nameof(Values), "Values cannot be null");
            _ = ApplySetting ?? throw new ArgumentNullException(nameof(ApplySetting), "ApplySetting cannot be null");
            _ = LoadSetting ?? throw new ArgumentNullException(nameof(LoadSetting), "LoadSetting cannot be null");

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
			
			gameObject = option.gameObject;

            return new GameObjectPair(option.gameObject);
        }
        
        internal override void Update()
        {
            gameObject.GetComponent<MenuOptionHorizontal>().optionList = Values;
            var menuSetting = gameObject.GetComponent<MenuSetting>();
            menuSetting.customApplySetting = (_, i) => ApplySetting(i);
            menuSetting.customRefreshSetting = (s, _) => s.optionList.SetOptionTo(LoadSetting());

            gameObject.transform.Find("Label").GetComponent<Text>().text = Name;
            gameObject.transform.Find("Description").GetComponent<Text>().text = Description;
        }
    }
}