using System.Reflection;
using System.Runtime.CompilerServices;

namespace Satchel.BetterMenus.Attributes;

/// <summary>
/// Add this attribute on a method to create a <see cref="MenuButton"/> that when pressed will invoke the function
/// Requires the method this attribute is on to be an instance method with no parameters
/// </summary>
public class MenuButtonAttribute : ElementAttribute
{
    public string Description;
    
    /// <inheritdoc cref="MenuButtonAttribute"/>
    /// <inheritdoc cref="ElementAttribute(string, int)"/>
    /// <param name="description">The description of the element</param>
    public MenuButtonAttribute(string name, string description, [CallerLineNumber] int order = 0) : base(name, order)
    {
        Description = description;
    }

    public override bool VerifyCorrectFieldType(MemberInfo memberInfo) => memberInfo is MethodInfo methodInfo && 
                                                                          methodInfo.GetParameters().Length == 0 && 
                                                                          !methodInfo.IsGenericMethod && 
                                                                          !methodInfo.IsStatic;

    public override Element[] CreateElement<Settings>(MemberInfo memberInfo, Settings settings)
    {
        var methodInfo = memberInfo as MethodInfo;
        return new Element[]
        {
            new MenuButton(Name,
                Description, 
                _ => methodInfo!.Invoke(settings, null)),
        };
    }
}

