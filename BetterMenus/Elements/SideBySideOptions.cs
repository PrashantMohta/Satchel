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
    /// Shows two Elements side-by-side.
    /// </summary>
    public class SideBySideElements : Element , IShadowElement
    {
        /// <summary>
        /// The left Element.
        /// </summary>
        public Element LeftElement;
        /// <summary>
        /// The right Element.
        /// </summary>
        public Element RightElement;
        
        public Element[] GetElements(){
            return new Element[]{LeftElement,RightElement};
        }
        /// <summary>
        /// Element X Delta, shifts the right element by this amount.
        /// </summary>
        public float XDelta = 750f;

        /// <summary>
        /// Creates a new SideBySideElements instance.
        /// </summary>
        /// <param name="LeftElement">The left Element.</param>
        /// <param name="RightElement">The right Element.</param>
        /// <param name="Id">The Id of this Element.</param>
        public SideBySideElements(
            Element LeftElement, 
            Element RightElement,
            string Id) : base(Id)
        {
            this.LeftElement = LeftElement;
            this.RightElement = RightElement;
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

            if (LeftElement is IShadowElement || RightElement is IShadowElement)
            {
                Modding.Logger.LogError("[Satchel] - You cannot create an IShadowElement inside another IShadowElement");
                return new GameObjectPair();
            }

            var layout = c.Layout as RegularGridLayout;
            var l = layout.ItemAdvance;
            l.x = new RelLength(XDelta);
            layout.ChangeColumns(2, newSize: l);

            var option1 = LeftElement.Create(c, modlistMenu, Instance, false);
            var option2 = RightElement.Create(c, modlistMenu, Instance, false);

            l.x = new RelLength(0f);
            layout.ChangeColumns(1, 0.25f, l);
            var gop = new GameObjectPair(option1, option2);
            gop.Parent = this;
            if (AddToList)
            {
                Instance.MenuOrder.Add(gop);
            }
            return gop;
        }

        public override void Update()
        {
            LeftElement?.UpdateInternal();
            RightElement?.UpdateInternal();
        }
    }

}