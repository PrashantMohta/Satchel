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
    /// Represents a row of GameObjects.
    /// </summary>
    public class GameObjectRow
    {

        /// <summary>
        /// The list of GameObjects that make up a Row.
        /// </summary>
        public List<GameObject> Row;
        
        /// <summary>
        /// The Parent Element (only not null for MenuRow)
        /// </summary>
        public Element Parent;

        /// <summary>
        /// Generates a GameObjectRow from a list of GameObjects.
        /// </summary>
        /// <param name="row">The list of GameObjects.</param>
        public GameObjectRow(List<GameObject> row)
        {
            this.Row = row;
        }

        /// <summary>
        /// Generates a GameObjectRow when there is only 1 GameObject
        /// </summary>
        /// <param name="FirstGo">The first GameObject to add.</param>
        public GameObjectRow(GameObject FirstGo)
        {
            this.Row = new List<GameObject>{FirstGo};
        }
        /// <summary>
        /// Generates a new GameObjectRow from the provided GameObjectRow.
        /// </summary>
        /// <param name="menuOptionGos">The GameObjectRow to build on.</param>
        public GameObjectRow(GameObjectRow menuOptionGos)
        {
            this.Row = menuOptionGos.Row;
        }
        /// <summary>
        /// Generates a new GameObjectRow from 2 GameObjectRows that contain a few GameObjects each
        /// </summary>
        /// <param name="firstRow">The first GameObjectRow.</param>
        /// <param name="secondRow">The second GameObjectRow.</param>
        public GameObjectRow(GameObjectRow firstRow, GameObjectRow secondRow)
        {
            this.Row = new List<GameObject>();
            
            firstRow.Row.ForEach(go => Row.Add(go));
            secondRow.Row.ForEach(go => Row.Add(go));
        }
        /// <summary>
        /// Generates an empty GameObjectRow. To be used as instead of null
        /// </summary>
        public GameObjectRow()
        {
            this.Row = new List<GameObject>();
        }
        
        /// <summary>
        /// a function to give the number of active elements in the GameObject row
        /// </summary>
        /// <returns>the number of active elements</returns>
        public int ActiveCount(){
            var count = 0;
            foreach(var go in Row){
                if(go != null && go.activeInHierarchy){
                    count++;
                }
            }
            return count;
        }
    }
}