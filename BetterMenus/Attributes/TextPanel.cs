using System.Reflection;

namespace Satchel.BetterMenus.Attributes;

/// <summary>
/// Add this attribute to create a <see cref="TextPanel"/> the text will be the value of the string
/// Requires the type this attribute is on to be <see cref="string"/>
/// </summary>
public class TextPanelAttribute : ElementAttribute
{
    public float Width;
    public int FontSize;
    
    /// <summary>
    /// Add this attribute to create a <see cref="TextPanel"/> the text will be the value of the string
    /// Requires the type this attribute is on to be <see cref="string"/>
    /// </summary>
    /// <param name="width">The width of the TextPanel.</param>
    /// <param name="fontSize">The fontSize of the TextPanel.</param>
    public TextPanelAttribute(float width = 1000f, int fontSize = 35) : base("")
    {
        Width = width;
        FontSize = fontSize;
    }

    internal override bool VerifyCorrectFieldType(MemberInfo memberInfo) => CheckFieldType(memberInfo, typeof(string));
    internal override Element[] CreateElement<Settings>(MemberInfo memberInfo, Settings settings)
    {
        return new Element[]
        {
            new TextPanel((string) GetValue(memberInfo, settings),
                Width,
                FontSize)
        };
    }
}

