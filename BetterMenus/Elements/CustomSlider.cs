using System;
using System.Collections.Generic;
using System.Diagnostics;
using Modding;
using Modding.Menu;
using Modding.Menu.Config;
using UnityEngine;
using UnityEngine.UI;
using GlobalEnums;

namespace Satchel.BetterMenus
{
    public class CustomSlider : Element //should be renamed to slider probs and probably needs to be remade slider needs to be added to nav graph
    {
        public GameObject currentSlider;
        public float value = 0f;
        public bool discreet = true;

        /// <summary>
        /// The Action that will be invoked when the slider is moved. Use the float paramter to save the value to use in mod.
        /// </summary>
        public Action<float> StoreValue;
        
        /// <summary>
        /// The initial value that you need the volume slider to be, probably from previous session or a default
        /// </summary>
        public Func<float> SavedValue;

        private Text label;
        private Text GetLabel(){
            if(label == null){
                label = currentSlider?.Find("Label")?.GetComponent<Text>();
            }
            return label;
        }

        private Text valueLabel;
        private Text GetValueLabel(){
            if(valueLabel == null){
                valueLabel = currentSlider?.Find("MusicValue")?.GetComponent<Text>();
            }
            return valueLabel;
        }

        private Slider slider;
        private Slider GetSlider(){
            if(slider == null){
                slider = currentSlider?.GetComponent<Slider>();
            }
            return slider;
        }

        private static GameObject prefab;
        private static GameObject GetSliderPrefab(){
            if(CustomSlider.prefab != null){
                return CustomSlider.prefab;
            }
            //todo actually make the prefab instead of stealing from Music slider.
            var prefab = GameObject.Instantiate(UIManager.instance.gameObject.transform.Find("UICanvas/AudioMenuScreen/Content/MusicVolume/MusicSlider").gameObject);
            prefab.SetActive(false);
            //fix the prefab to be better to work with
            prefab.RemoveComponent<MenuAudioSlider>(); //<= big change right here
            prefab.Find("Label")?.RemoveComponent<AutoLocalizeTextUI>();
            var mpd = prefab.GetComponent<MenuPreventDeselect>();
            mpd.cancelAction = CancelAction.CustomCancelAction; // <= another one

            CustomSlider.prefab = prefab;
            prefab.LogWithChildren();
            return CustomSlider.prefab;
        }

        public GameObject AddSlider(GameObject Parent){
            currentSlider = GameObject.Instantiate(CustomSlider.GetSliderPrefab(),Parent.transform);
            currentSlider.name = $"{Name}";
            currentSlider.transform.parent= Parent.transform;

            value = SavedValue.Invoke();

            //GetLabel().text = $"{Name}"; 
            //GetSlider().value = value;
            //Modding.Logger.Log("set value done");
            GetValueLabel().text = $"{value}";


            Action<float> updateOnEvent = value =>
            {
                GetLabel().text = $"{Name}"; 
                GetValueLabel().text = $"{value}";
                // call the StoreValue action with float
                StoreValue?.Invoke(value);
            };
            // stuff to happen whenever slider is moved
            var SliderEvent = new Slider.SliderEvent();
            SliderEvent.AddListener(updateOnEvent.Invoke);
            GetSlider().onValueChanged = SliderEvent;
            currentSlider.SetActive(true);

            return currentSlider;
        }

        private void FixSliderNavigation(){
            var slider = GetSlider();
            slider.navigation =  new Navigation
            {
                //mode = Navigation.Mode.Vertical
                mode = Navigation.Mode.Explicit,
                selectOnUp = slider.navigation.selectOnUp,
                selectOnDown = slider.navigation.selectOnDown,
                selectOnLeft = null,
                selectOnRight = null
            };
        }

        /// <summary>
        /// Creates a new CustomSlider instance.
        /// </summary>
        /// <param name="name">The name to be displayed.</param>
        /// <param name="storeValue">The Action that will be invoked when the slider is moved. Use the float paramter to save the value to use in mod.</param>
        /// <param name="savedValue">The initial value that you need the volume slider to be, probably from previous session or a default</param>
        public CustomSlider(string name, Action<float> storeValue, Func<float> savedValue,string Id = "__UseName") : base(Id,name)
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

            c.AddStaticPanel(Name+"panel", new RelVector2(new Vector2(200f, 105f)), out GameObject panel);
            AddSlider(panel);

            var slider = GetSlider();
            c.NavGraph.AddNavigationNode(slider);
            var mpd = slider.GetComponent<MenuPreventDeselect>();
            mpd.customCancelAction = _ => UIManager.instance.UIGoToDynamicMenu(modlistMenu);
            
            if (AddToList)
            {
                Instance.MenuOrder.Add(new GameObjectPair(panel));
            }
            gameObject = panel;
            ((IContainer)Parent).OnBuilt += (_,Element) => {
                FixSliderNavigation();
            };
            return new GameObjectPair(panel);
        }

        public override void Update()
        {
            //change Text
            GetLabel().text = Name;
            GetValueLabel().text = $"{value}";
            GetSlider().value = value;
            FixSliderNavigation(); // just in case the nav graph was changed
        }
    }

}
