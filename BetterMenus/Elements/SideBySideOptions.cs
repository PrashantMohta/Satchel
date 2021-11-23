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
    public class SideBySideOptions : Element
    {
        /// <summary>
        /// The left options.
        /// </summary>
        public Element LeftOption;
        /// <summary>
        /// The right options.
        /// </summary>
        public Element RightOption;
        

        /// <summary>
        /// Creates a new SideBySideOptions instance.
        /// </summary>
        /// <param name="leftOption">The left options.</param>
        /// <param name="rightOption">The right options.</param>
        public SideBySideOptions(Element leftOption, Element rightOption)
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

            if (LeftOption is KeyAndButtonBind or SideBySideOptions || RightOption is KeyAndButtonBind or SideBySideOptions)
            {
                Modding.Logger.LogError("[Satchel] - You cannot create Side by side options inside itself");
                return new GameObjectPair();
            }

            var layout = c.Layout as RegularGridLayout;
            var l = layout.ItemAdvance;
            l.x = new RelLength(750f);
            layout.ChangeColumns(2, newSize: l);

            var option1 = LeftOption.Create(c, modlistMenu, Instance, false);
            var option2 = RightOption.Create(c, modlistMenu, Instance, false);

            l.x = new RelLength(0f);
            layout.ChangeColumns(1, 0.25f, l);

            if (AddToList)
            {
                Instance.MenuOrder.Add(new GameObjectPair(option1, option2));
            }
            return new GameObjectPair(option1, option2);
        }

        public override void Update()
        {
            throw new NotImplementedException();
        }
    }

}