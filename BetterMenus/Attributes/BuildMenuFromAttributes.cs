using System.Linq;
using System.Reflection;

namespace Satchel.BetterMenus.Attributes;

public static class BuildMenuFromAttributes
{
    public static Menu Build<T>(string name, T settings)
    {
        var menuRef = new Menu(name);

        foreach (var member in typeof(T).GetMembers())
        {
            if (member.GetCustomAttribute<BetterMenusIgnore>() != null) continue;
            
            if (member.GetCustomAttribute<ElementAttribute>() is not { } elementAttribute) continue;
            
            if (elementAttribute.VerifyCorrectFieldType(member))
            {
                elementAttribute.CreateElement(member, settings).ToList().ForEach(menuRef.AddElement);
            }
            else
            {
                menuRef.AddElement(new TextPanel($"the type of {member.Name} is incorrect see docs"));
            }
            
        }

        return menuRef;

    }
}