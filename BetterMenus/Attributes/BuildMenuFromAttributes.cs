using Satchel.BetterMenus.Config;
using System.Linq;
using System.Reflection;

namespace Satchel.BetterMenus.Attributes;

public static class BuildMenuFromAttributes
{
    /// <summary>
    /// Builds menu from the fields/properties/methods in the settings class provided
    /// </summary>
    /// <param name="name">The name of the menu</param>
    /// <param name="settings">The instance of your settings class</param>
    /// <typeparam name="T">The type of your settings class</typeparam>
    /// <returns>The <see cref="Menu"/> created that can be used to create the menu screen</returns>
    public static Menu Build<T>(string name, T settings)
    {
        var menuRef = new Menu(name);

        IEnumerable<MemberInfo> members = typeof(T).GetMembers()
            .Where(member => member.GetCustomAttribute<BetterMenusIgnore>() is null &&
                             member.GetCustomAttribute<ElementAttribute>() is not null)
            .OrderBy(member => member.GetCustomAttribute<ElementAttribute>().Order);

        foreach (var member in members)
        {
            if (member.GetCustomAttribute<ElementAttribute>() is not { } elementAttribute) continue;

            if (elementAttribute.VerifyCorrectFieldType(member))
            {
                elementAttribute.CreateElement(member, settings).ToList().ForEach(menuRef.AddElement);
            }
            else
            {
                menuRef.AddElement(new TextPanel($"the type of {member.Name} is incorrect")
                {
                    Config = new AdditionalTextPanelConfig()
                    {
                        color = Color.red,
                        fontStyle = FontStyle.Italic
                    }
                });
            }

        }

        return menuRef;

    }
}