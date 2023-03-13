using System.Linq;
using System.Reflection;

namespace Satchel.BetterMenus.Attributes;

/// <summary>
/// The base element attribute for building menus
/// </summary>
public abstract class ElementAttribute : Attribute
{
    public string Name;
    
    /// <summary>
    /// The base element attribute for building menus
    /// </summary>
    /// <param name="name">The name of the element to show in the menu. Also is the id</param>
    public ElementAttribute(string name)
    {
        Name = name;
    }

    internal abstract bool VerifyCorrectFieldType(MemberInfo memberInfo);

    //if null it wont be added to menu
    internal abstract Element[] CreateElement<Settings>(MemberInfo memberInfo, Settings settings);

    protected const BindingFlags flags = BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.Instance;

    protected bool CheckFieldType(MemberInfo memberInfo, Type type)
    {
        return memberInfo is FieldInfo fieldInfo && fieldInfo.FieldType == type ||
        memberInfo is PropertyInfo propertyInfo && propertyInfo.PropertyType == type;
    }

    protected void SetValue<Settings>(MemberInfo member, Settings settings, object value)
    {
        if (member is FieldInfo field)
        {
            field.SetValue(settings, value);
        }
        else if (member is PropertyInfo property)
        {
            property.SetValue(settings, value);
        }
        else
        {
            throw new InvalidOperationException("You cannot call set value on members that arent fields or properties");
        }
    }
    
    protected object GetValue<Settings>(MemberInfo member, Settings settings)
    {
        if (member is FieldInfo field)
        {
            return field.GetValue(settings);
        }
        else if (member is PropertyInfo property)
        {
            return property.GetValue(settings);
        }
        else
        {
            throw new InvalidOperationException("You cannot call get value on members that arent fields or properties");
        }
    }
}

/// <summary>
/// Adding this attribute will cause satchel to ignore this field
/// </summary>
public class BetterMenusIgnore : Attribute { }