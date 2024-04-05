using InControl;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace Satchel.BetterMenus.Attributes;

/// <summary>
/// Add this attribute to a field of the class that contains the <see cref="PlayerAction"/> as fields for keybinds and button binds to be created.
/// Requires the type this attribute is on to be an inherited class of <see cref="InControl.PlayerActionSet"/>
/// Requires the fields in the custom class to have either <see cref="KeyBindAttribute"/> or <see cref="ButtonBindAttribute"/>
/// </summary>
public class PlayerActionSetAttribute : ElementAttribute
{
    /// <inheritdoc cref="PlayerActionSetAttribute"/>
    /// <inheritdoc cref="ElementAttribute(string, int)"/>
    public PlayerActionSetAttribute([CallerLineNumber] int order = 0) : base("", order) { }

    public override bool VerifyCorrectFieldType(MemberInfo memberInfo) =>
        memberInfo is FieldInfo fieldInfo && fieldInfo.FieldType.IsSubclassOf(typeof(PlayerActionSet)) ||
        memberInfo is PropertyInfo propertyInfo && propertyInfo.PropertyType.IsSubclassOf(typeof(PlayerActionSet));

    public override Element[] CreateElement<Settings>(MemberInfo memberInfo, Settings settings)
    {
        return GetMemberType(memberInfo).GetFields(flags)
            .Where(bindField => bindField.GetCustomAttribute<BindAttribute>() is not null)
            .OrderBy(bindField => bindField.GetCustomAttribute<BindAttribute>().Order)
            .Select(bindField =>
                bindField.GetCustomAttribute<BindAttribute>().CreateBind(bindField, GetValue(memberInfo, settings)))
            .ToArray();
    }
}

/// <summary>
/// Base class for the attribute to be used on a field in the custom class to specify its a keybind bind
/// Requires the type this attribute is on to be <see cref="InControl.PlayerAction"/>
/// </summary>
public abstract class BindAttribute : ElementAttribute
{
    /// <inheritdoc cref="BindAttribute"/>
    /// <inheritdoc cref="ElementAttribute(string, int)"/>
    public BindAttribute(string name, [CallerLineNumber] int order = 0) : base(name, order) { }

    public override bool VerifyCorrectFieldType(MemberInfo memberInfo) => CheckFieldOrPropertyType(memberInfo, typeof(PlayerAction));
    public override Element[] CreateElement<Settings>(MemberInfo memberInfo, Settings settings) => Array.Empty<Element>();

    public abstract Element CreateBind(MemberInfo memberInfo, object playerActionSet);
}

/// <summary>
/// The attribute to be used on a field in the custom class to specify its a keybind bind
/// Requires the type this attribute is on to be <see cref="InControl.PlayerAction"/>
/// </summary>
public class KeyBindAttribute : BindAttribute
{
    /// <inheritdoc cref="KeyBindAttribute"/>
    /// <inheritdoc cref="ElementAttribute(string, int)"/>
    public KeyBindAttribute(string name, [CallerLineNumber] int order = 0) : base(name, order) { }

    public override Element CreateBind(MemberInfo memberInfo, object playerActionSet)
    {
        return new KeyBind(Name, GetValue(memberInfo, playerActionSet) as PlayerAction);
    }
}
/// <summary>
/// The attribute to be used on a field in the custom class to specify its a button bind
/// Requires the type this attribute is on to be <see cref="InControl.PlayerAction"/>
/// </summary>
public class ButtonBindAttribute : BindAttribute
{
    /// <inheritdoc cref="ButtonBindAttribute"/>
    /// <inheritdoc cref="ElementAttribute(string, int)"/>
    public ButtonBindAttribute(string name, [CallerLineNumber] int order = 0) : base(name, order) { }

    public override Element CreateBind(MemberInfo memberInfo, object playerActionSet)
    {
        return new ButtonBind(Name, GetValue(memberInfo, playerActionSet) as PlayerAction);
    }
}

/// <summary>
/// Add this attribute to create a key and button bind element in the mod menu
/// Requires the type this attribute is on to be <see cref="KeyAndButtonActionSet"/>
/// </summary>
public class KeyAndButtonBindAttribute : ElementAttribute
{
    /// <inheritdoc cref="KeyAndButtonBindAttribute"/>
    /// <inheritdoc cref="ElementAttribute(string, int)"/>
    public KeyAndButtonBindAttribute(string name, [CallerLineNumber] int order = 0) : base(name, order) { }

    public override bool VerifyCorrectFieldType(MemberInfo memberInfo) =>
        CheckFieldOrPropertyType(memberInfo, typeof(KeyAndButtonActionSet));

    public override Element[] CreateElement<Settings>(MemberInfo memberInfo, Settings settings)
    {
        return new Element[]
        {
            Blueprints.KeyAndButtonBind(Name, (KeyAndButtonActionSet) GetValue(memberInfo, settings))
        };
    }
}

