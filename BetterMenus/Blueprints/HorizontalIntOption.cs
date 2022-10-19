using System.Linq;

namespace Satchel.BetterMenus
{
    public static partial class Blueprints
    {
        /// <summary>
        /// Creates a Horizontal Option to toggle ints
        /// </summary>
        /// <param name="name">The name to be displayed.</param>
        /// <param name="description">The description to be displayed.</param>
        /// <param name="values">An array of available options.</param>
        /// <param name="applySetting">Gives you the selected integer to save to settings</param>
        /// <param name="loadSetting">Provide an integer from the array to be set on loading of menu.</param>
        /// <param name="Id">the id of the element that can be used to search for it</param>
        /// <returns></returns>
        public static HorizontalOption HorizontalIntOption(string name, 
            string description,
            int[] values,
            Action<int> applySetting, 
            Func<int> loadSetting, 
            string Id = "__UseName")
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
                    int val = loadSetting();
                    if(!values.Contains(val))
                    {
                        throw new IndexOutOfRangeException($"Your provided array for the horizontal option: {name} did not include {val} in it");
                    }
                    return values.ToList().IndexOf(val);
                },
                Id
                );
        }
    }
}