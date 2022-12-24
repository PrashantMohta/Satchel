using UnityEngine.UI;

namespace Satchel.BetterMenus
{
    public static partial class Blueprints
    {
        /// <summary>
        /// Creates a Toggle Button to toggle a setting
        /// </summary>
        /// <param name="name">The name to be displayed.</param>
        /// <param name="description">The description to be displayed.</param>
        /// <param name="applySetting">Triggered when a setting is applied.</param>
        /// <param name="loadSetting">The Func(bool) to Invoke to load the current setting.</param>
        /// <param name="Id">the id of the element that can be used to search for it</param>
        /// <returns></returns>
        public static MenuButton ToggleButton(string name, 
            string description, 
            Action<bool> applySetting, 
            Func<bool> loadSetting,
            string Id = "__UseName")
        {
            if (Id == "__UseName")
            {
                Id = name;
            }
            
            Color ON = Color.white;
            Color OFF = Color.grey;
            
            MenuButton toggleButton =  new MenuButton(name,
                description,
                button =>
                {
                    //get the current state of the button
                    bool newValue = !loadSetting();
                    
                    //change text color of button to show on or off
                    button.transform.Find("Label").GetComponent<Text>().color = newValue ? ON : OFF;

                    //make the original bool change
                    applySetting(newValue);
                },
                Id: Id);

            //make sure color is correct on first open of menu
            toggleButton.OnBuilt += () =>
            {
                //change text color of button to show on or off
                toggleButton.gameObject.transform.Find("Label").GetComponent<Text>().color = loadSetting() ? ON : OFF;

            };
            
            return toggleButton;
        }
    }
}