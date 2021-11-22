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
    /// A bind for a button and a key.
    /// </summary>
    public class KeyAndButtonBind : Element
    {
        /// <summary>
        /// The name of the KeyBind.
        /// </summary>
        public string KeyBindName;
        /// <summary>
        /// The PlayerAction of the KeyBind.
        /// </summary>
        public InControl.PlayerAction KeyBindAction;
        /// <summary>
        /// The name of the ButtonBind,
        /// </summary>
        public string ButtonBindName;
        /// <summary>
        /// The PlayerAction of the ButtonBind.
        /// </summary>
        public InControl.PlayerAction ButtonBindAction;
        
        
        /// <summary>
        /// Creates a new KeyAndButtonBind.
        /// </summary>
        /// <param name="keyBindName">The name of the KeyBind.</param>
        /// <param name="keyBindAction">The PlayerAction of the KeyBind.</param>
        /// <param name="buttonBindName">The name of the ButtonBind.</param>
        /// <param name="buttonBindAction">The PlayerAction of the ButtonBind.</param>
        public KeyAndButtonBind(string keyBindName, InControl.PlayerAction keyBindAction, string buttonBindName, InControl.PlayerAction buttonBindAction)
        {
            KeyBindName = keyBindName;
            KeyBindAction = keyBindAction;
            ButtonBindName = buttonBindName;
            ButtonBindAction = buttonBindAction;
        }

        /// <summary>
        /// Creates a GameObjectPair based on the current variables.
        /// </summary>
                /// <returns>The created GameObjectPair which can be used to add to the corresponding Lists.</returns>
        public override GameObjectPair Create(ContentArea c, MenuScreen modlistMenu, Menu Instance, bool AddToList = true)
        {

            var NewOption = new SideBySideOptions(new KeyBind(KeyBindName, KeyBindAction),
                new ButtonBind(ButtonBindName, ButtonBindAction));

            var option = NewOption.Create(c, modlistMenu, Instance, false);
            
            if (AddToList)
            {
                Instance.MenuOrder.Add(option);
            }
            return new GameObjectPair(option);
        }
    }

}