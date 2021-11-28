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
    public class VolumeSlider : Element //should be renamed to slider probs and probably needs to be remade slider needs to be added to nav graph
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
        public VolumeSlider(string name, Action<float> storeValue, Func<int> savedValue,string Id = "__UseName") : base(Id,name)
        {
            Name = name;
            StoreValue = storeValue;
            SavedValue = savedValue;
        }

        public override GameObjectPair Create(ContentArea c, MenuScreen modlistMenu, Menu Instance, bool AddToList = true)
        {
            _ = Name ?? throw new ArgumentNullException(nameof(Name), "Name cannot be null");
            _ = StoreValue ?? throw new ArgumentNullException(nameof(StoreValue), "StoreValue cannot be null");
            _ = SavedValue ?? throw new ArgumentNullException(nameof(SavedValue), "SavedValue cannot be null");

            
            c.AddVolumeSlider(Name, 105f, StoreValue, SavedValue, out var option);

            if (AddToList)
            {
                Instance.MenuOrder.Add(new GameObjectPair(option));
            }

            gameObject = option;
            return new GameObjectPair(option);
        }

        public override void Update()
        {
            //change Text
            gameObject.transform.Find("Label").GetComponent<Text>().text = Name;
            
            MenuAudioSlider VolumeSlider_MenuAudioSlider = gameObject.GetComponent<MenuAudioSlider>();
            Slider VolumeSlider_Slider = gameObject.GetComponent<Slider>();
            Action<float> StoreValue_ = f =>
            {
                VolumeSlider_MenuAudioSlider.UpdateTextValue(f);
                StoreValue.Invoke(f);
            };
            var SliderEvent = new Slider.SliderEvent();
            SliderEvent.AddListener(StoreValue_.Invoke);
            VolumeSlider_Slider.onValueChanged = SliderEvent;
            
            int currentValue = SavedValue.Invoke();
            VolumeSlider_MenuAudioSlider.UpdateTextValue(currentValue);
            VolumeSlider_Slider.value = currentValue;
        }
    }

}