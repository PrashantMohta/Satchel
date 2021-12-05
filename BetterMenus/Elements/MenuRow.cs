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
    /// Shows a row of Elements side-by-side.
    /// </summary>
    public class MenuRow : Element , IShadowElement
    {
        public List<Element> Row;
        
        public Element[] GetElements(){
            return Row.ToArray();
        }
        /// <summary>
        /// Element X Delta, shifts the right element by this amount.
        /// </summary>
        public float XDelta = 750f;

        /// <summary>
        /// Creates a new MenuRow instance.
        /// </summary>
        /// <param name="Row">The Row of Elemenst.</param>
        /// <param name="Id">The Id of this Element.</param>
        public MenuRow(
            List<Element> Row,
            string Id) : base(Id)
        {
            this.Row = Row;
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
            var columnCount = Row.Count;
                        
            var layout = c.Layout as RegularGridLayout;
            var l = layout.ItemAdvance;
            List<GameObject> rowGos = new();

            if(columnCount > 1){
                l.x = new RelLength(XDelta); // this breaks shit if not done
                layout.ChangeColumns(columnCount, newSize: l);
            }

            foreach(var elem in Row){
                if (elem is IShadowElement)
                {
                    Modding.Logger.LogError("[Satchel] - Cannot create an IShadowElement inside another IShadowElement");
                    return new GameObjectRow();
                }
                var gor = elem.Create(c, modlistMenu, Instance, false);
                foreach(var go in gor.Row){
                    rowGos.Add(go);
                }
            }

            if(columnCount > 1){
                var k = layout.ItemAdvance;
                k.x = new RelLength(0f);
                layout.ChangeColumns(1, 0.5f - (1f/(2f * columnCount)), newSize: k);
            }
            
            var gop = new GameObjectRow(rowGos);
            gop.Parent = this;
            if (AddToList)
            {
                Instance.MenuOrder.Add(gop);
            }
            return gop;
        }

        public override void Update()
        {
            foreach(var elem in Row){
                elem?.UpdateInternal();
            }
        }
    }

}