using Modding.Menu;
using UnityEngine.UI;

namespace Satchel.BetterMenus
{
    public class CustomSlider : Element //should be renamed to slider probs and probably needs to be remade slider needs to be added to nav graph
    {
        public GameObject currentSlider;
        public float value = 0f;
        public float minValue = 0f;
        public float maxValue = 5f;
        public bool wholeNumbers = false;

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
            prefab.RemoveComponent<MenuAudioSlider>(); 
            prefab.Find("Label")?.RemoveComponent<AutoLocalizeTextUI>();
            var mpd = prefab.GetComponent<MenuPreventDeselect>();
            mpd.cancelAction = CancelAction.CustomCancelAction; 

            CustomSlider.prefab = prefab;
            return CustomSlider.prefab;
        }

        private void SetValueLabel(float value){
            if(wholeNumbers){
                GetValueLabel().text = $"{value}";
            } else {
                GetValueLabel().text = $"{value.ToString("0.0")}";
            }
        }


        public GameObject AddSlider(GameObject Parent){
            currentSlider = GameObject.Instantiate(CustomSlider.GetSliderPrefab(),Parent.transform);
            currentSlider.name = $"{Name}";
            currentSlider.transform.parent= Parent.transform;

            value = SavedValue.Invoke();

            GetLabel().text = $"{Name}"; 
            SetValueLabel(value);

            Action<float> updateOnEvent = value =>
            {
                GetLabel().text = $"{Name}"; 
                SetValueLabel(value);
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
        /// <param name="Id">the id of the element that can be used to search for it</param>
        public CustomSlider(string name, Action<float> storeValue, Func<float> savedValue,string Id = "__UseName") : base(Id,name)
        {
            Name = name;
            StoreValue = storeValue;
            SavedValue = savedValue;
        }

        public override GameObjectRow Create(ContentArea c, MenuScreen modlistMenu, Menu Instance, bool AddToList = true)
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
                Instance.MenuOrder.Add(new GameObjectRow(panel));
            }
            gameObject = panel;
            ((IContainer)Parent).OnBuilt += (_,Element) => {
                Update();
            };
            return new GameObjectRow(panel);
        }

        public override void Update()
        {
            
            var slider = GetSlider();
            //update value
            value = SavedValue.Invoke();
            slider.value = value;
            //change Text
            GetLabel().text = $"{Name}"; 
            SetValueLabel(value);
            
            slider.minValue = minValue;                
            slider.maxValue = maxValue;                
            slider.wholeNumbers = wholeNumbers;
            FixSliderNavigation(); // just in case the nav graph was changed
        }
    }

}
