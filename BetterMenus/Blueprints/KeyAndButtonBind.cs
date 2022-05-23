using Satchel.BetterMenus.Config;

namespace Satchel.BetterMenus
{
    public static partial class Blueprints{
        /// <summary>
        /// A blueprint to create a row with keybind and a button bind where only the binding area of them are selectable
        /// </summary>
        /// <param name="name">name of the element</param>
        /// <param name="keyBindAction">the InControl.PlayerAction for keybind</param>
        /// <param name="buttonBindAction">the InControl.PlayerAction for the button bind</param>
        ///<param name="Id">the id of the element that can be used to search for it. the keybind and buttonbind will get the id of the row appended by "key" and "button" respectively</param>
        /// <returns>The MenuRow created</returns>
        public static MenuRow KeyAndButtonBind(
            string name,
            InControl.PlayerAction keyBindAction,
            InControl.PlayerAction buttonBindAction,
            string Id = "__UseName"){
            if(Id == "__UseName"){
                Id = name;
            }
            var sbso = new MenuRow(
                new List<Element>{
                    new KeyBind(name ,keyBindAction,Id:Id+"key"){SelectableArea = SelectableArea.ButtonOnly},
                    new ButtonBind("",buttonBindAction,Id:Id+"button"){SelectableArea = SelectableArea.ButtonOnly}
                },
                Id:Id)
            {
                XDelta = 200f,
            };

            return sbso;
        }
    }
}