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
    /// Represents a pair of GameObjects.
    /// </summary>
    public class GameObjectPair
    {
        /// <summary>
        /// The left GameObject.
        /// </summary>
        public GameObject LeftGo;
        /// <summary>
        /// The right GameObject.
        /// </summary>
        public GameObject RightGo;
        
        /// <summary>
        /// The Parent Element (only not null for SideBySideOptions)
        /// </summary>
        public Element Parent;

        /// <summary>
        /// Generates a GameObjectPair from 2 GameObjects.
        /// </summary>
        /// <param name="LeftGo">The left GameObject to add.</param>
        /// <param name="RightGo">The right GameObject to add.</param>
        public GameObjectPair(GameObject LeftGo, GameObject RightGo)
        {
            this.LeftGo = LeftGo;
            this.RightGo = RightGo;
        }

        /// <summary>
        /// Generates a GameObjectPair when there is only 1 GameObject
        /// </summary>
        /// <param name="LeftGo">The left GameObject to add.</param>
        public GameObjectPair(GameObject LeftGo)
        {
            this.LeftGo = LeftGo;
            RightGo = Menu.TempObj;
        }
        /// <summary>
        /// Generates a new GameObjectPair from the provided GameObjectPair.
        /// </summary>
        /// <param name="menuOptionGos">The GameObjectPair to build on.</param>
        public GameObjectPair(GameObjectPair menuOptionGos)
        {
            LeftGo = menuOptionGos.LeftGo;
            RightGo = menuOptionGos.RightGo;
        }
        /// <summary>
        /// Generates a new GameObjectPair from 2 GameObjectPairs that contain 1 Real GameObject each
        /// </summary>
        /// <param name="LeftOptionGo">The left GameObjectPair.</param>
        /// <param name="RightOptionGo">The right GameObjectPair.</param>
        public GameObjectPair(GameObjectPair LeftOptionGo, GameObjectPair RightOptionGo)
        {
            LeftGo = LeftOptionGo.LeftGo;
            RightGo = RightOptionGo.LeftGo;
        }
        /// <summary>
        /// Generates an empty GameObjectPair. To be used as instead of null
        /// </summary>
        public GameObjectPair()
        {
            LeftGo = Menu.TempObj;
            RightGo = Menu.TempObj;
        }
    }
}