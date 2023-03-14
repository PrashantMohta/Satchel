using System.Reflection;
using InControl;

namespace Satchel.BetterMenus.Attributes;

/// <summary>
/// Add this attribute to a field of the class that contains the PlayerActions as fields for keybinds and button binds to be created.
/// Requires the type this attribute is on to be an inherited class of <see cref="InControl.PlayerActionSet"/>
/// Requires the fields in the custom class to have either KeyBindAttribute or ButtonBindAttribute
/// </summary>
public class KeyAndButtonBindClassAttribute : ElementAttribute
{
    /// <inheritdoc cref="KeyAndButtonBindClassAttribute"/>
    public KeyAndButtonBindClassAttribute() : base("") { }

    public override bool VerifyCorrectFieldType(MemberInfo memberInfo) =>
        memberInfo is FieldInfo fieldInfo && fieldInfo.FieldType.IsSubclassOf(typeof(PlayerActionSet)) ||
        memberInfo is PropertyInfo propertyInfo && propertyInfo.PropertyType.IsSubclassOf(typeof(PlayerActionSet)); //TODO: Test
    
    public override Element[] CreateElement<Settings>(MemberInfo memberInfo, Settings settings)
    {
        List<Element> elements = new List<Element>();
        var type = memberInfo is FieldInfo fieldInfo ? fieldInfo.FieldType : (memberInfo as PropertyInfo)!.PropertyType; 
        foreach (var bindField in type.GetFields(flags))
        {
            if (bindField.GetCustomAttribute<KeyBindAttribute>() is { } keyBindAttribute)
            {
                elements.Add(new KeyBind(keyBindAttribute.Name, bindField.GetValue(GetValue(memberInfo, settings)) as PlayerAction));
            }
            if (bindField.GetCustomAttribute<ButtonBindAttribute>() is { } buttonBindAttribute)
            {
                elements.Add(new ButtonBind(buttonBindAttribute.Name, bindField.GetValue(GetValue(memberInfo, settings)) as PlayerAction));
            }
        }

        return elements.ToArray();
    }
}
/// <summary>
/// The attribute to be used on a field in the custom class to specify its a keybind
/// Requires the type this attribute is on to be <see cref="InControl.PlayerAction"/>
/// </summary>
public class KeyBindAttribute : ElementAttribute
{
    /// <inheritdoc cref="KeyBindAttribute"/>
    /// <param name="name">The name of the element to show in the menu. Also is the id</param>
    public KeyBindAttribute(string name) : base(name) { }
    
    public override bool VerifyCorrectFieldType(MemberInfo memberInfo) => CheckFieldOrPropertyType(memberInfo, typeof(PlayerAction));
    public override Element[] CreateElement<Settings>(MemberInfo memberInfo, Settings settings) => Array.Empty<Element>();
}
/// <summary>
/// The attribute to be used on a field in the custom class to specify its a button bind
/// Requires the type this attribute is on to be <see cref="InControl.PlayerAction"/>
/// </summary>
public class ButtonBindAttribute : ElementAttribute
{
    /// <inheritdoc cref="ButtonBindAttribute"/>
    /// <param name="name">The name of the element to show in the menu. Also is the id</param>
    public ButtonBindAttribute(string name) : base(name) { }
    
    public override bool VerifyCorrectFieldType(MemberInfo memberInfo) => CheckFieldOrPropertyType(memberInfo, typeof(PlayerAction));
    public override Element[] CreateElement<Settings>(MemberInfo memberInfo, Settings settings) => Array.Empty<Element>();
}

