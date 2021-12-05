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
        /// The fontSize of the TextPanel (default 35).
        /// </summary>
        public int FontSize;

        /// <summary>
        /// Creates a new TextPanel.
        /// </summary>
        /// <param name="name">The name to be displayed.</param>
        /// <param name="width">The width of the TextPanel.</param>
        /// <param name="fontSize">The fontSize of the TextPanel.</param>
        /// <param name="Id">The Id of this Element.</param>
        public TextPanel(string name, float width = 1500f,int fontSize = 35,string Id = "__UseName") : base(Id,name)
        {
            Name = name;
            Width = width;
            FontSize = fontSize;
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
            _ = Name ?? throw new ArgumentNullException(nameof(Name), "Name cannot be null");
           //todo add support for TextFont & TextAnchor
           //todo also add support for height
            c.AddTextPanel(
                Name,
                new RelVector2(new Vector2(Width, 105f)),
                new TextPanelConfig
                {
                    Anchor = TextAnchor.MiddleCenter,
                    Font = TextPanelConfig.TextFont.TrajanBold,
                    Size = FontSize,
                    Text = Name
                }, out var option
            );
            if (AddToList)
            {
                Instance.MenuOrder.Add(new GameObjectRow(option.gameObject));
            }

            gameObject = option.gameObject;

            return new GameObjectRow(option.gameObject);
        }

        public override void Update()
        {
            gameObject.GetComponent<Text>().text = Name;
            gameObject.GetComponent<Text>().fontSize = FontSize;
            //todo add support for updating width
        }
    }

}