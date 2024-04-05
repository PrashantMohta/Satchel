using System.Reflection;

namespace Satchel.BetterMenus.Attributes;

/// <summary>
/// The base element attribute for building menus
/// </summary>
public abstract class ElementAttribute : Attribute
{
    public string Name;
    public int Order;

    /// <inheritdoc cref="ElementAttribute"/>
    /// <param name="name">The name of the element to show in the menu. Also is the id</param>
    /// <param name="order">The lower the order the higher up it is on the menu.
    /// Defaults to the declaration order (using <see cref="System.Runtime.CompilerServices.CallerLineNumberAttribute"/>)
    /// but can be overridden if needed.</param>
    protected ElementAttribute(string name, int order)
    {
        Name = name;
        Order = order;
    }

    public abstract bool VerifyCorrectFieldType(MemberInfo memberInfo);
    public abstract Element[] CreateElement<Settings>(MemberInfo memberInfo, Settings settings);

    protected const BindingFlags flags = BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.Instance;

    /// <summary>
    /// Check if MemberInfo is a field or property and check if the type matches
    /// </summary>
    protected static bool CheckFieldOrPropertyType(MemberInfo memberInfo, Type type)
    {
        return memberInfo is FieldInfo fieldInfo && fieldInfo.FieldType == type ||
        memberInfo is PropertyInfo propertyInfo && propertyInfo.PropertyType == type;
    }

    /// <summary>
    /// Used to set value when you have MemberInfo which is either a FieldInfo or PropertyInfo
    /// </summary>
    protected static void SetValue<Settings>(MemberInfo member, Settings settings, object value)
    {
        switch (member)
        {
            case FieldInfo field:
                field.SetValue(settings, value);
                break;
            case PropertyInfo property:
                property.SetValue(settings, value);
                break;
            default:
                throw new InvalidOperationException("You cannot call set value on members that arent fields or properties");
        }
    }
    protected static Type GetMemberType(MemberInfo memberInfo) =>
        memberInfo is FieldInfo fieldInfo ? fieldInfo.FieldType : (memberInfo as PropertyInfo)!.PropertyType;

    /// <summary>
    /// Used to get value when you have MemberInfo which is either a FieldInfo or PropertyInfo
    /// </summary>
    protected static object GetValue<Settings>(MemberInfo member, Settings settings)
    {
        return member switch
        {
            FieldInfo field => field.GetValue(settings),
            PropertyInfo property => property.GetValue(settings),
            _ => throw new InvalidOperationException(
                "You cannot call get value on members that arent fields or properties")
        };
    }
}

/// <summary>
/// Adding this attribute will cause satchel to ignore this field
/// </summary>
public class BetterMenusIgnore : Attribute { }