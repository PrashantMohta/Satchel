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
        /// <returns></returns>
        public static HorizontalOption BoolOption(string name, 
            string description, 
            Action<bool> applySetting, 
            Func<bool> loadSetting, 
            string _true = "True",
            string _false = "False",
            string Id = "__UseName")
        {
            if (Id == "__UseName")
            {
                Id = name;
            }

            return new HorizontalOption(name,
                description,
                new []{_true, _false},
                (i) => applySetting(i == 0),
                () => loadSetting() ? 0 : 1,
                Id
                );
        }
    }
}