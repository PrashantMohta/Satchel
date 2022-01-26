using Satchel.BetterMenus.Base;

namespace Satchel.BetterMenus
{
    public static partial class Blueprints{
        /// <summary>
        /// A blueprint to make a horizontal option for a bool setting
        /// </summary>
        /// <param name="name">The name to be displayed</param>
        /// <param name="description">The description to be displayed</param>
        /// <param name="setting">a SettingWrapper (in Satchel.BetterMenus.Base) to hold a setting value of type bool. </param>
        /// <param name="_true">the text for what the "True" option will be default True.</param>
        /// <param name="_false">the text for what the "False" option will be default False.</param>
        /// <param name="Id">the id of the element that can be used to search for it</param>
        /// <typeparam name="SettingsClass">The class in the mod that holds the settings</typeparam>
        /// <returns>The created horizontal option</returns>
        public static HorizontalOption BoolOption<SettingsClass>(string name,
            string description,
            SettingWrapper<SettingsClass, bool> setting,
            string _true = "True",
            string _false = "False",
            string Id = "__UseName")
        {
            if (Id == "__UseName")
            {
                Id = name;
            }

            return new HorizontalOption(name, description, new [] { _true, _false },
                i => { setting.SetValue(i == 0); },
                () => setting.GetValue() ? 0 : 1
                , Id);
        }
    } 
}