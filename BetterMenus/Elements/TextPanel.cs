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
    /// A TextPanel.
    /// </summary>
    public class TextPanel : Element
    {
        /// <summary>
        /// The width of the TextPanel (default 1500f).
        /// </summary>
        public float Width;
        

        /// <summary>
        /// Creates a new TextPanel.
        /// </summary>
        /// <param name="name">The name to be displayed.</param>
        /// <param name="width">The width of the TextPanel.</param>
        public TextPanel(string name, float width = 1500f,string Id = "__UseName") : base(Id,name)
        {
            Name = name;
            Width = width;
        }


        /// <summary>
        /// Creates a GameObjectPair based on the current variables.
        /// </summary>
        /// <returns>The created GameObjectPair which can be used to add to the corresponding Lists.</returns>
        public override GameObjectPair Create(ContentArea c, MenuScreen modlistMenu, Menu Instance, bool AddToList = true)
        {
            _ = Name ?? throw new ArgumentNullException(nameof(Name), "Name cannot be null");
           
            c.AddTextPanel(
                Name,
                new RelVector2(new Vector2(Width, 105f)),
                new TextPanelConfig
                {
                    Anchor = TextAnchor.MiddleCenter,
                    Font = TextPanelConfig.TextFont.TrajanBold,
                    Size = 46,
                    Text = Name
                }, out var option);
            if (AddToList)
            {
                Instance.MenuOrder.Add(new GameObjectPair(option.gameObject));
            }

            gameObject = option.gameObject;

            return new GameObjectPair(option.gameObject);
        }

        internal override void Update()
        {
            gameObject.GetComponent<Text>().text = Name;
        }
    }

}