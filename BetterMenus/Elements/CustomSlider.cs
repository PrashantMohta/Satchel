using System.Runtime.InteropServices;
using Modding.Menu;
using UnityEngine.UI;

namespace Satchel.BetterMenus
{
    public class CustomSlider : Element //should be renamed to slider probs and probably needs to be remade slider needs to be added to nav graph
    {
        public GameObject currentSlider;
        public float minValue = 0f;
        public float maxValue = 5f;
        public bool wholeNumbers = false;

        private float _value = 0f;
        public float value
        {
            get => _value;
            set
            {
                _value = value;
                UpdateValueLabel();
            }
        }

        /// <summary>
        /// The Action that will be invoked when the slider is moved. Use the float paramter to save the value to use in mod.
        /// </summary>
        public Action<float> StoreValue;
        
        /// <summary>
        /// The initial value that you need the volume slider to be, probably from previous session or a default
        /// </summary>
        public Func<float> LoadValue;

        private Text _label;
        public Text label
        {
            get
            {
                if (_label == null)
                {
                    _label = currentSlider.Find("Label")?.GetComponent<Text>();
                }
                return _label;
            }
        }

        private Text _valueLabel;

        public Text valueLabel
        {
            get
            {
                if(_valueLabel == null)
                {
                    _valueLabel = currentSlider.Find("MusicValue")?.GetComponent<Text>();
                }
                return _valueLabel;
            }   
        }
        private Slider _slider;

        public Slider slider
        {
            get
            {
                if(_slider == null){
                    _slider = currentSlider.GetComponent<Slider>();
                }
                return _slider;
            }
        }

        private static GameObject _prefab;

        public static GameObject prefab
        {
            get
            {
                if(_prefab != null){
                    return _prefab;
                }
                //todo actually make the prefab instead of stealing from Music slider.
                var newPrefab = UnityEngine.Object.Instantiate(UIManager.instance.gameObject.transform.Find("UICanvas/AudioMenuScreen/Content/MusicVolume/MusicSlider").gameObject);
                newPrefab.SetActive(false);

                //fix the prefab to be better to work with
                newPrefab.RemoveComponent<MenuAudioSlider>(); 
                newPrefab.Find("Label")?.RemoveComponent<AutoLocalizeTextUI>();
                var mpd = newPrefab.GetComponent<MenuPreventDeselect>();
                mpd.cancelAction = CancelAction.CustomCancelAction; 

                _prefab = newPrefab;
                return _prefab;
            }
        }
        



        private void UpdateValueLabel(){
            if (wholeNumbers){
                valueLabel.text = $"{value}";
            } else {
                valueLabel.text = $"{value:0.0}";
            }
        }


        public GameObject AddSlider(GameObject SliderParent){
            currentSlider = UnityEngine.Object.Instantiate(prefab,SliderParent.transform);
            currentSlider.name = Name;
            currentSlider.transform.parent= SliderParent.transform;


            Action<float> updateOnEvent = newValue =>
            {
                value = newValue;
                label.text = Name; 
                // call the StoreValue action with float
                StoreValue?.Invoke(newValue);
            };
            // stuff to happen whenever slider is moved
            var SliderEvent = new Slider.SliderEvent();
            SliderEvent.AddListener(updateOnEvent.Invoke);
            slider.onValueChanged = SliderEvent;

            currentSlider.SetActive(true);

            //update slider value after slider event is replaced.
            slider.minValue = minValue;
            slider.maxValue = maxValue;
            value = LoadValue.Invoke();
            label.text = $"{Name}";

            return currentSlider;
        }

        private void FixSliderNavigation(){
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
        /// <param name="loadValue">The initial value that you need the volume slider to be, probably from previous session or a default</param>
        /// <param name="Id">the id of the element that can be used to search for it</param>
        [Obsolete("This Constructor is obsolete, use the one with minValue and maxValue.")]
        public CustomSlider(string name, Action<float> storeValue, Func<float> loadValue, string Id = "__UseName") : base(Id, name)
        {
            Name = name;
            StoreValue = storeValue;
            LoadValue = loadValue;
        }


        /// <summary>
        /// Creates a new CustomSlider instance.
        /// </summary>
        /// <param name="name">The name to be displayed.</param>
        /// <param name="storeValue">The Action that will be invoked when the slider is moved. Use the float paramter to save the value to use in mod.</param>
        /// <param name="loadValue">The initial value that you need the volume slider to be, probably from previous session or a default</param>
        /// <param name="minValue">the lowest value the slider will go to</param>
        /// <param name="maxValue">the highest value the slider will go to</param>
        /// <param name="wholeNumbers">Should the slider only allow whole numbers (i.e. ints)</param>
        /// <param name="Id">the id of the element that can be used to search for it</param>
        public CustomSlider(string name, Action<float> storeValue, Func<float> loadValue, float minValue, float maxValue, bool wholeNumbers = false, string Id = "__UseName") : base(Id, name)
        {
            Name = name;
            StoreValue = storeValue;
            LoadValue = loadValue;
            this.minValue = minValue;
            this.maxValue = maxValue;
            this.wholeNumbers = wholeNumbers;
        }

        public override GameObjectRow Create(ContentArea c, Menu Instance, bool AddToList = true)
        {
            _ = Name ?? throw new ArgumentNullException(nameof(Name), "Name cannot be null");
            _ = StoreValue ?? throw new ArgumentNullException(nameof(StoreValue), "StoreValue cannot be null");
            _ = LoadValue ?? throw new ArgumentNullException(nameof(LoadValue), "SavedValue cannot be null");

            c.AddStaticPanel(Name+"panel", new RelVector2(new Vector2(200f, 105f)), out GameObject panel);
            AddSlider(panel);
            
            c.NavGraph.AddNavigationNode(slider);
            var mpd = slider.GetComponent<MenuPreventDeselect>();
            mpd.customCancelAction = _ => Instance.CancelAction();
            
            if (AddToList)
            {
                Instance.MenuOrder.Add(new GameObjectRow(panel));
            }
            gameObject = panel;
            ((IContainer)Parent).OnBuilt += (_,_) => {
                Update();
            };
            return new GameObjectRow(panel);
        }

        public override void Update()
        {
            slider.wholeNumbers = wholeNumbers;

            //update value after updating constraints
            value = LoadValue.Invoke();
            slider.value = value;

            slider.minValue = minValue;
            slider.maxValue = maxValue;

            //change Text
            label.text = Name;

            FixSliderNavigation(); // just in case the nav graph was changed
        }
    }

}
