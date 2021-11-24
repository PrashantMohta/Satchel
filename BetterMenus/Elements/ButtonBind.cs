using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Modding;
using Modding.Menu;
using Modding.Menu.Config;
using UnityEngine;
using UnityEngine.UI;

namespace Satchel.BetterMenus
{
    
    public class ButtonBind : Element
    {
        /// <summary>
        /// The PlayerAction connected to this ButtonBind.
        /// </summary>
        public InControl.PlayerAction PlayerAction;
        

        /// <summary>
        /// Creates a new ButtonBind.
        /// </summary>
        /// <param name="name">The name to be displayed.</param>
        /// <param name="playerAction">The PlayerAction connected to this ButtonBind.</param>
        public ButtonBind(string name, InControl.PlayerAction playerAction)
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

            c.AddButtonBind(
                Name,
                PlayerAction,
                new ButtonBindConfig
                {
                    CancelAction = _ => UIManager.instance.UIGoToDynamicMenu(modlistMenu),
                    Label = Name,
                }, out var option);

            gameObject = option.gameObject;
            
            if (AddToList)
            {
                Instance.MenuOrder.Add(new GameObjectPair(option.gameObject));
            }

            return new GameObjectPair(option.gameObject);
        }

        public override void Update()
        {
            var mappableControllerButton = gameObject.GetComponent<MappableControllerButton>();
            mappableControllerButton.InitCustomActions(PlayerAction.Owner, PlayerAction);

            gameObject.transform.Find("Text").GetComponent<Text>().text = Name;
        }
    }
}