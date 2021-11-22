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
    /// A static panel.
    /// </summary>
    public class StaticPanel: Element
    {
        //the paramater that will be passed in is the static panel that you'll have to make the new object the parent of
        /// <summary>
        /// The Action(GameObject) te be called on creation.
        /// </summary>
        public Action<GameObject> CreateCustomItem;
        /// <summary>
        /// The width of the panel (default 1500f).
        /// </summary>
        public float Width;
        

        /// <summary>
        /// Creates a new StaticPanel.
        /// </summary>
        /// <param name="name">The name to be displayed.</param>
        /// <param name="createCustomItem">The Action(GameObject) te be called on creation.</param>
        /// <param name="width">The width of the panel.</param>
        public StaticPanel(string name, Action<GameObject> createCustomItem, float width = 1500f)
        {
            Name = name;
            CreateCustomItem = createCustomItem;
            Width = width;
        }

        /// <summary>
        /// Creates a GameObjectPair based on the current variables.
        /// </summary>
                /// <returns>The created GameObjectPair which can be used to add to the corresponding Lists.</returns>
        public override GameObjectPair Create(ContentArea c, MenuScreen modlistMenu, Menu Instance, bool AddToList = true)
        {
            c.AddStaticPanel(
                Name,
                new RelVector2(new Vector2(Width, 105f)),
                out var option);
            CreateCustomItem.Invoke(option);
            if (AddToList)
            {
                Instance.MenuOrder.Add(new GameObjectPair(option.gameObject));
            }

            return new GameObjectPair(option.gameObject);
        }
    }

}