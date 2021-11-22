using System;
using System.Collections.Generic;
using System.Diagnostics;
using Modding;
using Modding.Menu;
using Modding.Menu.Config;
using UnityEngine;

namespace Satchel.BetterMenus
{
    public class VolumeSlider : Element
    {
        
        /// <summary>
        /// The Action that will be invoked when the slider is moved. Use the float paramter to save the value to use in mod.
        /// </summary>
        public Action<float> StoreValue;
        
        /// <summary>
        /// The initial value that you need the volume slider to be, probably from previous session or a default
        /// </summary>
        public Func<int> SavedValue;


        /// <summary>
        /// Creates a new VolumeSlider instance.
        /// </summary>
        /// <param name="name">The name to be displayed.</param>
        /// <param name="storeValue">The Action that will be invoked when the slider is moved. Use the float paramter to save the value to use in mod.</param>
        /// <param name="savedValue">The initial value that you need the volume slider to be, probably from previous session or a default</param>
        public VolumeSlider(string name, Action<float> storeValue, Func<int> savedValue)
        {
            Name = name;
            StoreValue = storeValue;
            SavedValue = savedValue;
        }

        public override GameObjectPair Create(ContentArea c, MenuScreen modlistMenu, Menu Instance, bool AddToList = true)
        {
            c.AddVolumeSlider(Name, 105f, StoreValue, SavedValue, out var option);

            if (AddToList)
            {
                Instance.MenuOrder.Add(new GameObjectPair(option));
            }

            return new GameObjectPair(option);
        }
    }

}