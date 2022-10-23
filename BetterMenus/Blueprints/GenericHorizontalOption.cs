using System.Linq;

namespace Satchel.BetterMenus
{
    public static partial class Blueprints
    {
        /// <summary>
        /// Creates a Horizontal Option to toggle any type
        /// </summary>
        /// <param name="name">The name to be displayed.</param>
        /// <param name="description">The description to be displayed.</param>
        /// <param name="values">An array of available options.</param>
        /// <param name="applySetting">Gives you the selected integer to save to settings</param>
        /// <param name="loadSetting">Provide an integer from the array to be set on loading of menu.</param>
        /// <param name="Id">the id of the element that can be used to search for it</param>
        /// <returns>The Horizontal Option to add to the menu</returns>
        /// <typeparam name="T">The type that the values will be. The type must be able to formattable in a string representation</typeparam>
        public static HorizontalOption GenericHorizontalOption<T>(string name, 
            string description,
            T[] values,
            Action<T> applySetting, 
            Func<T> loadSetting, 
            string Id = "__UseName") where T: IFormattable //to ensure ToString
        {
            if (Id == "__UseName")
            {
                Id = name;
            }

            return new HorizontalOption(name,
                description,
                values.Select(i => i.ToString()).ToArray(),
                (i) => applySetting(values[i]),
                () =>
                {
                    T val = loadSetting();
                    if(!values.Contains(val))
                    {
                        throw new IndexOutOfRangeException($"Your provided array for the horizontal option: {name} did not include {val} in it");
                    }
                    return Array.IndexOf(values, val, 0, values.Length);
                },
                Id
                );
        }
    }
}