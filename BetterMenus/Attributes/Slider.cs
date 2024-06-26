using System.Reflection;
using System.Runtime.CompilerServices;

namespace Satchel.BetterMenus.Attributes;

/// <summary>
/// Add this attribute to create a <see cref="CustomSlider"/> to set this element in mod menu
/// Requires the type this attribute is on to be <see cref="float"/>
/// </summary>
public class FloatSliderAttribute : ElementAttribute
{
    public float MinValue;
    public float MaxValue;

    /// <inheritdoc cref="FloatSliderAttribute"/>
    /// <inheritdoc cref="ElementAttribute(string, int)"/>
    /// <param name="minValue">The minimum value of the slider</param>
    /// <param name="maxValue">The maximum value of the slider</param>
    public FloatSliderAttribute(string name, float minValue, float maxValue, [CallerLineNumber] int order = 0) : base(name, order)
    {
        MinValue = minValue;
        MaxValue = maxValue;
    }

    public override bool VerifyCorrectFieldType(MemberInfo memberInfo) => CheckFieldOrPropertyType(memberInfo, typeof(float));
    public override Element[] CreateElement<Settings>(MemberInfo memberInfo, Settings settings)
    {
        return new Element[]
        {
            new CustomSlider(Name,
                f => SetValue(memberInfo, settings, f),
                () => (float) GetValue(memberInfo, settings),
                minValue: MinValue,
                maxValue: MaxValue),
        };
    }
}

/// <summary>
/// Add this attribute to create a <see cref="CustomSlider"/> to set this element in mod menu
/// Requires the type this attribute is on to be <see cref="int"/>
/// </summary>
public class IntSliderAttribute : ElementAttribute
{
    public int MinValue;
    public int MaxValue;

    /// <inheritdoc cref="IntSliderAttribute"/>
    /// <inheritdoc cref="ElementAttribute(string, int)"/>
    /// <param name="minValue">The minimum value of the slider</param>
    /// <param name="maxValue">The maximum value of the slider</param>
    public IntSliderAttribute(string name, int minValue, int maxValue, [CallerLineNumber] int order = 0) : base(name, order)
    {
        MinValue = minValue;
        MaxValue = maxValue;
    }

    public override bool VerifyCorrectFieldType(MemberInfo memberInfo) => CheckFieldOrPropertyType(memberInfo, typeof(int));

    public override Element[] CreateElement<Settings>(MemberInfo memberInfo, Settings settings)
    {
        return new Element[]
        {
            new CustomSlider(Name,
                f => SetValue(memberInfo, settings, (int)f),
                () => (int) GetValue(memberInfo, settings),
                minValue: MinValue,
                maxValue: MaxValue,
                wholeNumbers: true),
        };
    }
}
