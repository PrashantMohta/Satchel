using Modding;

namespace Satchel.BetterMenus.Base
{
    /// <summary>
    /// A class to help pass in value types to satchel and use Reflection to get/set the field
    /// </summary>
    /// <typeparam name="SettingClass">The class that the settings are stored in</typeparam>
    /// <typeparam name="SettingType">The type of the setting that is being passed in</typeparam>
    public class SettingWrapper<SettingClass, SettingType>
    {
        /// <summary>
        /// The fieldName of the setting. Can be easy gotten by doing nameof(setting)
        /// </summary>
        private readonly string FieldName;
        /// <summary>
        /// The instance of the settings class that the field is in
        /// </summary>
        private readonly SettingClass SettingClassInstance;

        /// <summary>
        /// Constructor for the SettingBluePrint class.
        /// </summary>
        /// <param name="settingClassInstance">The instance of the class that the setting is stored in</param>
        /// <param name="fieldName">The fieldName of the setting. Expected way of doing it is "nameof(setting)"</param>
        public SettingWrapper(SettingClass settingClassInstance, string fieldName)
        {
            FieldName = fieldName;
            SettingClassInstance = settingClassInstance;
        }

        /// <summary>
        /// Uses ReflectionHelper to get the value of the inputted bool
        /// </summary>
        /// <returns></returns>
        public SettingType GetValue()
        {
            return ReflectionHelper.GetField<SettingClass, SettingType>(SettingClassInstance, FieldName);
        }
        /// <summary>
        /// Uses ReflectionHelper to set the value of the inputted bool
        /// </summary>
        /// <param name="newValue">the new value of the setting</param>
        /// <returns></returns>
        public void SetValue(SettingType newValue)
        {
            ReflectionHelper.SetField(SettingClassInstance,FieldName, newValue);
        }
    }
}