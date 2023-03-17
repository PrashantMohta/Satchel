using System.Reflection;

namespace Satchel.BetterMenus.Attributes;

/// <summary>
/// Add this attribute on a method with a GameObject parameter to create a <see cref="StaticPanel"/>. The method will be invoked when menu is built. The GameObject passed is the static panel in the menu
/// Requires the method this attribute is on to be an instance method with one parameter which is GameObject
/// </summary>
public class StaticPanelAttribute : ElementAttribute
{
    /// <inheritdoc cref="StaticPanelAttribute"/>
    /// <param name="name">The name of the element to show in the menu. Also is the id</param>
    public StaticPanelAttribute(string name) : base(name) { }

    public override bool VerifyCorrectFieldType(MemberInfo memberInfo) => memberInfo is MethodInfo methodInfo && 
                                                                          methodInfo.GetParameters().Length == 1 && 
                                                                          methodInfo.GetParameters()[0].ParameterType == typeof(GameObject) && 
                                                                          !methodInfo.IsGenericMethod && 
                                                                          !methodInfo.IsStatic;

    public override Element[] CreateElement<Settings>(MemberInfo memberInfo, Settings settings)
    {
        var methodInfo = memberInfo as MethodInfo;
        return new Element[]
        {
            new StaticPanel(Name, 
                go => methodInfo!.Invoke(settings, new object[] {go}))
        };
    }
}

