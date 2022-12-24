using Modding.Menu;
using Modding.Menu.Config;
using UnityEngine.UI;

namespace Satchel.BetterMenus
{
    /// <summary>
    /// A menu button.
    /// </summary>
    public class MenuButton : Element
    {
        /// <summary>
        /// The Action(UnityEngine.UI.MenuButton) to call when a value is submitted.
        /// </summary>
        public Action<UnityEngine.UI.MenuButton> SubmitAction;
        /// <summary>
        /// The description to be displayed.
        /// </summary>
        public string Description;

        /// <summary>
        /// Will this button navigate to another menu?.
        /// </summary>
        public bool Proceed;

        /// <summary>
        /// Creates a MenuButton.
        /// </summary>
        /// <param name="name">The name to be displayed.</param>
        /// <param name="description">The description to be displayed.</param>
        /// <param name="submitAction">The Action(UnityEngine.UI.MenuButton) to call when a value is submitted.</param>
        /// <param name="proceed">Will this button navigate to another menu?</param>
        /// <param name="Id">the id of the element that can be used to search for it</param>
        public MenuButton(
            string name, 
            string description, 
            Action<UnityEngine.UI.MenuButton> submitAction,
            bool proceed = false,
            string Id = "__UseName") : base(Id,name)
        {
            Name = name;
            Description = description;
            SubmitAction = submitAction;
            Proceed = proceed;
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
            _ = SubmitAction ?? throw new ArgumentNullException(nameof(SubmitAction), "SubmitAction cannot be null");
            _ = Description ?? throw new ArgumentNullException(nameof(Description), "Description cannot be null");
            //todo support DescriptionStyle & MenuButtonStyle
            c.AddMenuButton(
                Name,
                new MenuButtonConfig
                {
                    CancelAction = _ => Instance.CancelAction(),
                    Description = new DescriptionInfo
                    {
                        Text = Description
                    },
                    Label = Name,
                    Proceed = Proceed,
                    SubmitAction = SubmitAction,
                }, out var option);

            if (AddToList)
            {
                Instance.MenuOrder.Add(new GameObjectRow(option.gameObject));
            }

            gameObject = option.gameObject;
            
            ((IContainer)Parent).OnBuilt += (_,_) => {
                OnBuiltInvoke();             
            };
            
            return new GameObjectRow(option.gameObject);
        }

        public override void Update()
        {
            gameObject.transform.Find("Label").GetComponent<Text>().text = Name;
            gameObject.transform.Find("Description").GetComponent<Text>().text = Description;
            gameObject.GetComponent<UnityEngine.UI.MenuButton>().submitAction = SubmitAction;
        }
    }

}