using Modding.Menu;
using Satchel.BetterMenus.Config;
using UnityEngine.UI;

namespace Satchel.BetterMenus
{
    /// <summary>
    /// A KeyBind.
    /// </summary>
    public class KeyBind : Element
    {
        /// <summary>
        /// The PlayerAction connected to this bind.
        /// </summary>
        public InControl.PlayerAction PlayerAction;

        public SelectableArea SelectableArea = SelectableArea.Full;

        private KeybindConfig keybindConfig;

        /// <summary>
        /// Creates a new KeyBind.
        /// </summary>
        /// <param name="name">The name to be displayed.</param>
        /// <param name="playerAction">The PlayerAction connected to this bind.</param>
        /// <param name="Id">the id of the element that can be used to search for it</param>
        public KeyBind(string name,InControl.PlayerAction playerAction,string Id = "__UseName") : base(Id,name)
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
            keybindConfig = new KeybindConfig{
                    CancelAction = _ => Instance.CancelAction(),
                    Label = Name,
                    selectableArea = SelectableArea
                };
            //todo add KeybindStyle support
            c.AddCustomKeybind(
                Name,
                PlayerAction,
                keybindConfig,
                out var option);
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
            var mappableKey = gameObject.GetComponent<MappableKey>();
            mappableKey.InitCustomActions(PlayerAction.Owner, PlayerAction);
            gameObject.transform.Find("Text").GetComponent<Text>().text = Name;
            KeybindContent.ApplySelectableArea(mappableKey,keybindConfig);
            mappableKey.ShowCurrentBinding();
        }
    }
}