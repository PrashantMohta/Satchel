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
        /// <summary>
        /// The Action(GameObject) te be called on creation. the Gameobject that will be passed in is the static panel go that will be the parent of the custom item you make
        /// </summary>
        public Action<GameObject> CreateCustomItem;
        /// <summary>
        /// The width of the panel (default 1000f).
        /// </summary>
        public float Width;
        

        /// <summary>
        /// Creates a new StaticPanel.
        /// </summary>
        /// <param name="name">The name to be displayed.</param>
        /// <param name="createCustomItem">The Action(GameObject) te be called on creation. the Gameobject that will be passed in is the static panel go that will be the parent of the custom item you make.</param>
        /// <param name="width">The width of the panel.</param>
        /// <param name="Id">the id of the element that can be used to search for it</param>
        public StaticPanel(
            string name,
            Action<GameObject> createCustomItem, 
            float width = 1000f,
            string Id = "__UseName") : base(Id,name)
        {
            Name = name;
            CreateCustomItem = createCustomItem;
            Width = width;
        }

        /// <summary>
        /// Creates a GameObjectRow based on the current variables.
        /// </summary>
        /// <param name="c">The ContentArea on which the ButtonBind is created.</param>
        /// <param name="modlistMenu">The previous MenuScreen.</param>
        /// <param name="Instance">The current Menu instance.</param>
        /// <param name="AddToList">Should this element be added to the MenuOrder (All non IShadowElements).</param>
        /// <returns>The created GameObjectRow which can be used to add to the corresponding Lists.</returns>
        public override GameObjectRow Create(ContentArea c, MenuScreen modlistMenu, Menu Instance, bool AddToList = true)
        {
            _ = CreateCustomItem ?? throw new ArgumentNullException(nameof(CreateCustomItem), "CreateCustomItem cannot be null");
             
            c.AddStaticPanel(
                Name,
                new RelVector2(new Vector2(Width, 105f)),
                out var option);
            CreateCustomItem.Invoke(option);
            
            if (AddToList)
            {
                Instance.MenuOrder.Add(new GameObjectRow(option));
            }

            gameObject = option;

            return new GameObjectRow(option);
        }

        public override void Update()
        {
            gameObject.GetComponent<RectTransform>().sizeDelta = new Vector2(Width, 105f);
        }
    }

}