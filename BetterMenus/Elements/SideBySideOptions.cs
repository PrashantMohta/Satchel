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
    /// A collection of side-by-side options.
    /// </summary>
    public class SideBySideOptions : Element , IShadowElement
    {
        /// <summary>
        /// The left options.
        /// </summary>
        public Element LeftOption;
        /// <summary>
        /// The right options.
        /// </summary>
        public Element RightOption;
        
        public Element[] GetElements(){
            return new Element[]{LeftOption,RightOption};
        }
        /// <summary>
        /// Element X Delta, shifts the right element by this amount.
        /// </summary>
        public float XDelta = 750f;
        public bool isShadowElement = true;
        /// <summary>
        /// Creates a new SideBySideOptions instance.
        /// </summary>
        /// <param name="leftOption">The left options.</param>
        /// <param name="rightOption">The right options.</param>
        public SideBySideOptions(
            Element leftOption, 
            Element rightOption,
            string Id) : base(Id)
        {
            LeftOption = leftOption;
            RightOption = rightOption;
        }

        /// <summary>
        /// Creates a GameObjectPair based on the current variables.
        /// </summary>
                /// <returns>The created GameObjectPair which can be used to add to the corresponding Lists.</returns>
        public override GameObjectPair Create(ContentArea c, MenuScreen modlistMenu, Menu Instance, bool AddToList = true)
        {

            if (LeftOption is IShadowElement || RightOption is IShadowElement)
            {
                Modding.Logger.LogError("[Satchel] - You cannot create IShadowElement inside IShadowElement");
                return new GameObjectPair();
            }

            var layout = c.Layout as RegularGridLayout;
            var l = layout.ItemAdvance;
            l.x = new RelLength(XDelta);
            layout.ChangeColumns(2, newSize: l);

            var option1 = LeftOption.Create(c, modlistMenu, Instance, false);
            var option2 = RightOption.Create(c, modlistMenu, Instance, false);

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

        internal override void Update()
        {
            LeftOption?.UpdateInternal();
            RightOption?.UpdateInternal();
        }
    }

}