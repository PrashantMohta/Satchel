using System;
using System.Linq;
using Satchel.BetterMenus.Base;

namespace Satchel.BetterMenus
{
    public static partial class Blueprints{
        /// <summary>
        /// A blueprint to make a horizontal option for a float setting
        /// </summary>
        /// <param name="name">The name to be displayed</param>
        /// <param name="description">The description to be displayed</param>
        /// <param name="setting">a SettingWrapper (in Satchel.BetterMenus.Base) to hold a setting value of type float. </param>
        /// <param name="start">the starting value of the list of options</param>
        /// <param name="end">the ending value of the list of options.</param>
        /// <param name="step">the difference between one value and the next in the list</param>
        /// <param name="Id">the id of the element that can be used to search for it</param>
        /// <typeparam name="SettingsClass">The class in the mod that holds the settings</typeparam>
        /// <returns>The created horizontal option</returns>
        public static HorizontalOption FloatOption<SettingsClass>(string name,
            string description,
            SettingWrapper<SettingsClass, float> setting,
            float start,
            float end,
            float step,
            string Id = "__UseName")
        {
            if (Id == "__UseName")
            {
                Id = name;
            }

            return new HorizontalOption(name, description, 
                Enumerable.Range((int)(start/step), (int)(Math.Abs(end-start)/step) + 1).Select(x => (x * step).ToString()).ToArray(),
                i => setting.SetValue((i + (start / step)) * step),
                () => (int)((setting.GetValue() /step) - (start/step))
                , Id);
        }
    } 
}