using Modding.Menu;
using Satchel.BetterMenus.Config;
using UnityEngine.UI;

namespace Satchel.BetterMenus
{
    /// <summary>
    /// a class to create a button bind in the menu
    /// </summary>
    public class ButtonBind : Element
    {
        /// <summary>
        /// The PlayerAction connected to this ButtonBind.
        /// </summary>
        public InControl.PlayerAction PlayerAction;
        
        /// <summary>
        /// decides whether the full element is selectable or only the button part is selectable
        /// </summary>
        public SelectableArea SelectableArea = SelectableArea.Full;
        
        private ButtonBindConfig buttonBindConfig;
        /// <summary>
        /// Creates a new ButtonBind.
        /// </summary>
        /// <param name="name">The name to be displayed.</param>
        /// <param name="playerAction">The PlayerAction connected to this ButtonBind.</param>
        /// <param name="Id">the id of the element that can be used to search for it</param>
        public ButtonBind(string name, InControl.PlayerAction playerAction,string Id = "__UseName") : base(Id,name)
        {
            Name = name;
            PlayerAction = playerAction;
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
            _ = PlayerAction ?? throw new ArgumentNullException(nameof(PlayerAction), "PlayerAction cannot be null");
            buttonBindConfig = new ButtonBindConfig{
                    CancelAction = _ => Instance.CancelAction(),
                    Label = Name,
                    selectableArea = SelectableArea
                };
            //todo add support for keybind styles
            c.AddCustomButtonBind(
                Name,
                PlayerAction,
                buttonBindConfig,
                out var option);

            gameObject = option.gameObject;
            
            if (AddToList)
            {
                Instance.MenuOrder.Add(new GameObjectRow(option.gameObject));
            }
            
            ((IContainer)Parent).OnBuilt += (_,_) => {
                OnBuiltInvoke();             
            };
            return new GameObjectRow(option.gameObject);
        }

        public override void Update()
        {
            var mappableControllerButton = gameObject.GetComponent<MappableControllerButton>();
            mappableControllerButton.InitCustomActions(PlayerAction.Owner, PlayerAction);
            gameObject.transform.Find("Text").GetComponent<Text>().text = Name;
            KeybindContent.ApplySelectableArea(mappableControllerButton,buttonBindConfig);
            mappableControllerButton.ShowCurrentBinding();
        }
    }
}