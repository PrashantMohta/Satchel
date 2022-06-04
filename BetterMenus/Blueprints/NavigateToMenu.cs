namespace Satchel.BetterMenus
{
    public static partial class Blueprints{
        /// <summary>
        /// A blueprint to create a menubutton that takes user to a new menu screen
        /// </summary>
        /// <param name="name">the name of the button</param>
        /// <param name="description">the description of the button</param>
        /// <param name="getScreen">the new MenuScreen that will be opened on button press</param>
        /// <returns></returns>
         public static MenuButton NavigateToMenu(string name,string description,Func<MenuScreen> getScreen){
           return new MenuButton(
                name,
                description,
                (mb)=>{
                        Utils.GoToMenuScreen(getScreen());
                    },
                proceed:true
            );
        }
    }
}