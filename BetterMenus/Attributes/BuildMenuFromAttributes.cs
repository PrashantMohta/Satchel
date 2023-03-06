using System.Linq;
using System.Reflection;

namespace Satchel.BetterMenus.Attributes;

public static class BuildMenuFromAttributes
{
    public static Menu Build<T>(string name, T settings)
    {
        var menuRef = new Menu(name);

        foreach (var field in typeof(T).GetFields())
        {
            if (field.GetCustomAttribute<BetterMenusIgnore>() != null) continue;

            if (field.GetCustomAttribute<ElementAttribute>() is { } elementAttribute)
            {
                if (elementAttribute.VerifyCorrectFieldType(field))
                {
                    elementAttribute.CreateElement(field, settings).ToList().ForEach(menuRef.AddElement);
                }
                else
                {
                    menuRef.AddElement(new TextPanel($"the type of {field.Name} ({field.FieldType}) is incorrect see docs"));
                }
            }
            else
            {
                var elem = CreateDefault(field, settings);
                if (elem != null)
                {
                    menuRef.AddElement(elem);
                }
            }
        }

        return menuRef;

    }

    private static Element CreateDefault<T>(FieldInfo fieldInfo, T settings)
    {
        //TODO: implement
        return null;
    }
}