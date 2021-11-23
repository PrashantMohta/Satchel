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
    /// A KeyBind.
    /// </summary>
    public class KeyBind : Element
    {
        /// <summary>
        /// The PlayerAction connected to this bind.
        /// </summary>
        public InControl.PlayerAction PlayerAction;
        

        /// <summary>
        /// Creates a new KeyBind.
        /// </summary>
        /// <param name="name">The name to be displayed.</param>
        /// <param name="playerAction">The PlayerAction connected to this bind.</param>
        public KeyBind(string name,InControl.PlayerAction playerAction)
        {
            Name = name;
            PlayerAction = playerAction;
        }

        /// <summary>
        /// Creates a GameObjectPair based on the current variables.
        /// </summary>
                /// <returns>The created GameObjectPair which can be used to add to the corresponding Lists.</returns>
        public override GameObjectPair Create(ContentArea c, MenuScreen modlistMenu, Menu Instance, bool AddToList = true)
        {
            
            _ = Name ?? throw new ArgumentNullException(nameof(Name), "Name cannot be null");
            _ = PlayerAction ?? throw new ArgumentNullException(nameof(PlayerAction), "PlayerAction cannot be null");

            c.AddKeybind(
                Name,
                PlayerAction,
                new KeybindConfig
                {
                    CancelAction = _ => UIManager.instance.UIGoToDynamicMenu(modlistMenu),
                    Label = Name,
                }, out var option);
            if (AddToList)
            {
                Instance.MenuOrder.Add(new GameObjectPair(option.gameObject));
            }

            gameObject = option.gameObject;
            return new GameObjectPair(option.gameObject);
        }
        
        public override void Update()
        {
            var mappableControllerButton = gameObject.GetComponent<MappableKey>();
            mappableControllerButton.InitCustomActions(PlayerAction.Owner, PlayerAction);

            gameObject.transform.Find("Text").GetComponent<Text>().text = Name;
        }
    }
}