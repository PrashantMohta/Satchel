using Modding.Menu;
using Modding.Menu.Config;
using UnityEngine.UI;
using MenuOptionHorizontal = UnityEngine.UI.MenuOptionHorizontal;

namespace Satchel.BetterMenus
{
    /// <summary>
    /// A horizontal option.
    /// </summary>
    public class HorizontalOption : Element
    {
        
        /// <summary>
        /// The description to be displayed.
        /// </summary>
        public string Description;
        /// <summary>
        /// The values the HorizontalOption can have.
        /// </summary>
        public string[] Values;
        /// <summary>
        /// Triggered when a setting is applied.
        /// </summary>
        public Action<int> ApplySetting;

        /// <summary>
        /// The Func(int) to Invoke to load the current setting.
        /// </summary>
        public Func<int> LoadSetting;

        /// <summary>
        /// Creates a new HorizontalOption.
        /// </summary>
        /// <param name="name">The name to be displayed.</param>
        /// <param name="description">The description to be displayed.</param>
        /// <param name="values">The values the HorizontalOption can have.</param>
        /// <param name="applySetting">Triggered when a setting is applied.</param>
        /// <param name="loadSetting">The Func(int) to Invoke to load the current setting.</param>
        /// <param name="Id">the id of the element that can be used to search for it</param>
        public HorizontalOption(
            string name , 
            string description,
            string[] values, 
            Action<int> applySetting, 
            Func<int> loadSetting,
            string Id = "__UseName") : base(Id,name)
        {
            Name = name;
            Description = description;
            Values = values;
            ApplySetting = applySetting;
            LoadSetting= loadSetting;
        }

        /// <summary>
        /// Creates a GameObjectRow based on the current variables.
        /// </summary>
        /// <param name="c">The ContentArea on which the ButtonBind is created.</param>
        /// <param name="Instance">The current Menu instance.</param>
        /// <param name="AddToList">Should this element be added to the MenuOrder (All non IShadowElements).</param>
        /// <returns>The created GameObjectRow which can be used to add to the corresponding Lists.</returns>
        public override GameObjectRow Create(ContentArea c, Menu Instance, bool AddToList = true)
        {
            _ = Name ?? throw new ArgumentNullException(nameof(Name), "Name cannot be null");
            _ = Description ?? throw new ArgumentNullException(nameof(Description), "Description cannot be null");
            _ = Values ?? throw new ArgumentNullException(nameof(Values), "Values cannot be null");
            _ = ApplySetting ?? throw new ArgumentNullException(nameof(ApplySetting), "ApplySetting cannot be null");
            _ = LoadSetting ?? throw new ArgumentNullException(nameof(LoadSetting), "LoadSetting cannot be null");
            //todo add support for HorizontalOptionStyle & DescriptionStyle
            c.AddHorizontalOption(
                Name,
                new HorizontalOptionConfig
                {
                    ApplySetting = (_, i) => ApplySetting(i),
                    RefreshSetting = (s, _) => s.optionList.SetOptionTo(LoadSetting()),
                    CancelAction = _ => Instance.CancelAction(),
                    Description = new DescriptionInfo
                    {
                        Text = Description
                    },
                    Label = Name,
                    Options = Values,
                    Style = HorizontalOptionStyle.VanillaStyle
                },
                out var option);
            if (AddToList)
            {
                Instance.MenuOrder.Add(new GameObjectRow(option.gameObject));
            }
			
			gameObject = option.gameObject;

            Action loadSettingOnBuild = () =>
            {
                if (option != null && option.menuSetting != null)
                {
                    option.menuSetting.RefreshValueFromGameSettings();
                }
            };

            OnBuilt += loadSettingOnBuild;
            
            ((IContainer)Parent).OnBuilt += (_,_) => {
                OnBuiltInvoke();             
            };
            return new GameObjectRow(option.gameObject);
        }
        
        public override void Update()
        {
            var option = gameObject.GetComponent<MenuOptionHorizontal>();
            option.optionList = Values;
            option.menuSetting.customApplySetting = (_, i) => ApplySetting(i);
            option.menuSetting.customRefreshSetting = (s, _) => {
                var setting = LoadSetting();
                if(setting >= 0 && setting < option.optionList.Length){
                    s.optionList.SetOptionTo(setting);
                }
            };
            option.menuSetting.RefreshValueFromGameSettings();

            gameObject.transform.Find("Label").GetComponent<Text>().text = Name;
            gameObject.transform.Find("Description").GetComponent<Text>().text = Description;
        }
    }
}