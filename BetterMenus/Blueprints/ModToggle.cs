using Modding;

namespace Satchel.BetterMenus
{
    public static partial class Blueprints{
        /// <summary>
        /// A blueprint to create a mod toggle (to Initialize/Unload the mod)
        /// </summary>
        /// <param name="toggleDelegates">The ModToggleDelegates that is given by MAPI in GetMenuScreen functionn</param>
        /// <param name="name">the name of the toggle</param>
        /// <param name="description">the description of the toggle</param>
        /// <param name="on">the text to display when mod is on</param>
        /// <param name="off">the text to display when mod is off</param>
        /// <returns>teh created horizontal option</returns>
        public static HorizontalOption CreateToggle(this ModToggleDelegates toggleDelegates, string name, string description,string on = "On",string off = "Off"){
            return new HorizontalOption(name,description,new []{on,off},
                i =>
                {
                    toggleDelegates.SetModEnabled(i == 0);
                }, 
                () => toggleDelegates.GetModEnabled() ? 0 : 1
            ,"ModToggle");
        }
    }
}