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
        /// <param name="Id">The Id of this Element.</param>
        public ButtonBind(string name, InControl.PlayerAction playerAction,string Id = "__UseName") : base(Id,name)
        {
            Name = name;
            PlayerAction = playerAction;
        }

        /// <summary>
        /// Creates a GameObjectPair based on the current variables.
        /// </summary>
        /// <param name="c">The ContentArea on which the ButtonBind is created.</param>
        /// <param name="modlistMenu">The previous MenuScreen.</param>
        /// <param name="Instance">The current Menu instance.</param>
        /// <param name="AddToList">Should this element be added to the MenuOrder (All non IShadowElements).</param>
        /// <returns>The created GameObjectPair which can be used to add to the corresponding Lists.</returns>
        public override GameObjectPair Create(ContentArea c, MenuScreen modlistMenu, Menu Instance, bool AddToList = true)
        {
            _ = Name ?? throw new ArgumentNullException(nameof(Name), "Name cannot be null");
            _ = PlayerAction ?? throw new ArgumentNullException(nameof(PlayerAction), "PlayerAction cannot be null");
            
            //todo add support for keybind styles
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