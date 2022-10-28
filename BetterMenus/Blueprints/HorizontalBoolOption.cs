using JetBrains.Annotations;

namespace Satchel.BetterMenus
{
    public static partial class Blueprints
    {
        /// <summary>
        /// Creates a Horizontal Option to toggle bools
        /// </summary>
        /// <param name="name">The name to be displayed.</param>
        /// <param name="description">The description to be displayed.</param>
        /// <param name="applySetting">Triggered when a setting is applied.</param>
        /// <param name="loadSetting">The Func(bool) to Invoke to load the current setting.</param>
        /// <param name="_true">the text that shows when bool is true</param>
        /// <param name="_false">the text that shows when bool is false</param>
        /// <param name="Id">the id of the element that can be used to search for it</param>
        /// <returns>The Horizontal Option to add to the menu</returns>
        public static HorizontalOption HorizontalBoolOption(string name, 
            string description, 
            Action<bool> applySetting, 
            Func<bool> loadSetting, 
            [CanBeNull] string _true = null,
            [CanBeNull] string _false = null,
            string Id = "__UseName")
        {
            return new HorizontalOption(name,
                description,
                new []
                {
                    _true ?? Language.Language.Get("MOH_ON","MainMenu"), 
                    _false ?? Language.Language.Get("MOH_OFF","MainMenu")
                },
                (i) => applySetting(i == 0),
                () => loadSetting() ? 0 : 1,
                Id
                );
        }
    }
}