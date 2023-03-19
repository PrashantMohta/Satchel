using System.Reflection;
using System.Runtime.CompilerServices;

namespace Satchel.BetterMenus.Attributes;

/// <summary>
/// Add this attribute to create a <see cref="TextPanel"/> the text will be the value of the string
/// Requires the type this attribute is on to be <see cref="string"/>
/// </summary>
public class TextPanelAttribute : ElementAttribute
{
    public float Width;
    public int FontSize;
    
    /// <inheritdoc cref="TextPanelAttribute"/>
    /// <param name="width">The width of the TextPanel.</param>
    /// <param name="fontSize">The fontSize of the TextPanel.</param>
    public TextPanelAttribute(float width = 1000f, int fontSize = 35, [CallerLineNumber] int order = 0) : base("", order)
    {
        Width = width;
        FontSize = fontSize;
    }

    public override bool VerifyCorrectFieldType(MemberInfo memberInfo) => CheckFieldOrPropertyType(memberInfo, typeof(string));
    public override Element[] CreateElement<Settings>(MemberInfo memberInfo, Settings settings)
    {
        return new Element[]
        {
            new TextPanel((string) GetValue(memberInfo, settings),
                Width,
                FontSize)
        };
    }
}

