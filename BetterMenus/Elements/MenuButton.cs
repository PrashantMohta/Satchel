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
    /// A menu button.
    /// </summary>
    public class MenuButton : Element, IPrimaryMenuOption
    {
        /// <summary>
        /// The Action(UnityEngine.UI.MenuButton) to call when a value is submitted.
        /// </summary>
        public Action<UnityEngine.UI.MenuButton> SubmitAction;
        /// <summary>
        /// The description to be displayed.
        /// </summary>
        public string Description;
        

        /// <summary>
        /// Creates a MenuButton.
        /// </summary>
        /// <param name="name">The name to be displayed.</param>
        /// <param name="description">The description to be displayed.</param>
        /// <param name="submitAction">The Action(UnityEngine.UI.MenuButton) to call when a value is submitted.</param>
        public MenuButton(
            string name, 
            string description, 
            Action<UnityEngine.UI.MenuButton> submitAction,
            string Id = "__UseName") : base(Id,name)
        {
            Name = name;
            Description = description;
            SubmitAction = submitAction;
        }

        /// <summary>
        /// Creates a GameObjectPair based on the current variables.
        /// </summary>
                /// <returns>The created GameObjectPair which can be used to add to the corresponding Lists.</returns>
        public override GameObjectPair Create(ContentArea c, MenuScreen modlistMenu, Menu Instance, bool AddToList = true)
        {
            
            _ = Name ?? throw new ArgumentNullException(nameof(Name), "Name cannot be null");
            _ = SubmitAction ?? throw new ArgumentNullException(nameof(SubmitAction), "SubmitAction cannot be null");
            _ = Description ?? throw new ArgumentNullException(nameof(Description), "Description cannot be null");

            c.AddMenuButton(
                Name,
                new MenuButtonConfig
                {
                    CancelAction = _ => UIManager.instance.UIGoToDynamicMenu(modlistMenu),
                    Description = new DescriptionInfo
                    {
                        Text = Description
                    },
                    Label = Name,
                    Proceed = false,
                    SubmitAction = SubmitAction,
                }, out var option);

            if (AddToList)
            {
                Instance.MenuOrder.Add(new GameObjectPair(option.gameObject));
            }

            gameObject = option.gameObject;
            return new GameObjectPair(option.gameObject);
        }

        /// <summary>
        /// Adds a new Action to when the setting is applied.
        /// </summary>
        /// <param name="UpdateMenu">The Action to add.</param>
        public void AddUpdateMenuAction(Action UpdateMenu)
        {
            SubmitAction += _ => UpdateMenu.Invoke();
        }

        internal override void Update()
        {
            gameObject.transform.Find("Label").GetComponent<Text>().text = Name;
            gameObject.transform.Find("Description").GetComponent<Text>().text = Description;
            gameObject.GetComponent<UnityEngine.UI.MenuButton>().submitAction = SubmitAction;

        }
    }

}