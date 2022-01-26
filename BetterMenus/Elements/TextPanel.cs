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
        /// The width of the TextPanel (default 1000f).
        /// </summary>
        public float Width;

        /// <summary>
        /// The fontSize of the TextPanel (default 35).
        /// </summary>
        public int FontSize;
        
        /// <summary>
        /// The font used in the TextPanel (default TrajanBold).
        /// </summary>
        public TextPanelConfig.TextFont Font;
        
        /// <summary>
        /// The anchor of the text in the TextPanel (default Center).
        /// </summary>
        public TextAnchor Anchor;
        
        /// <summary>
        /// Creates a new TextPanel.
        /// </summary>
        /// <param name="name">The name to be displayed.</param>
        /// <param name="width">The width of the TextPanel.</param>
        /// <param name="fontSize">The fontSize of the TextPanel.</param>
        /// <param name="font">The font used in the TextPanel.</param>
        /// <param name="Id">the id of the element that can be used to search for it</param>
        /// <param name="anchor">The anchor of the text in the TextPanel (default Center).</param>
        public TextPanel(string name, float width = 1000f,int fontSize = 35, TextPanelConfig.TextFont font = TextPanelConfig.TextFont.TrajanBold, TextAnchor anchor = TextAnchor.MiddleCenter ,string Id = "__UseName") : base(Id,name)
        {
            Name = name;
            Width = width;
            FontSize = fontSize;
            Font = font;
            Anchor = anchor;
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
           //todo also add support for height
            c.AddTextPanel(
                Name,
                new RelVector2(new Vector2(Width, 105f)),
                new TextPanelConfig
                {
                    Anchor = Anchor,
                    Font = Font,
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
            gameObject.GetComponent<Text>().alignment = Anchor;
            gameObject.GetComponent<Text>().font = Font switch
            {
                TextPanelConfig.TextFont.TrajanRegular => MenuResources.TrajanRegular,
                TextPanelConfig.TextFont.TrajanBold => MenuResources.TrajanBold,
                TextPanelConfig.TextFont.Perpetua => MenuResources.Perpetua,
                _ => MenuResources.TrajanRegular
            };
            gameObject.GetComponent<RectTransform>().sizeDelta = new Vector2(Width, 105f);
        }
    }
}