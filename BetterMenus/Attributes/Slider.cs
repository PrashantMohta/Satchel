using System.Reflection;

namespace Satchel.BetterMenus.Attributes;

/// <summary>
/// Add this attribute to create a <see cref="CustomSlider"/> to set this element in mod menu
/// Requires the type this attribute is on to be <see cref="float"/>
/// </summary>
public class FloatSliderAttribute : ElementAttribute
{
    public float MinValue;
    public float MaxValue;

    /// <summary>
    /// Add this attribute to create a <see cref="CustomSlider"/> to set this element in mod menu
    /// Requires the type this attribute is on to be <see cref="float"/>
    /// </summary>
    /// <param name="name">The name of the element to show in the menu. Also is the id></param>
    /// <param name="minValue">The minimum value of the slider></param>
    /// <param name="maxValue">The maximum value of the slider></param>
    public FloatSliderAttribute(string name, float minValue, float maxValue) : base(name)
    {
        MinValue = minValue;
        MaxValue = maxValue;
    }

    internal override bool VerifyCorrectFieldType(MemberInfo memberInfo) => CheckFieldType(memberInfo, typeof(float));
    internal override Element[] CreateElement<Settings>(MemberInfo memberInfo, Settings settings)
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

    /// <summary>
    /// Add this attribute to create a <see cref="CustomSlider"/> to set this element in mod menu
    /// Requires the type this attribute is on to be <see cref="int"/>
    /// </summary>
    /// <param name="name">The name of the element to show in the menu. Also is the id></param>
    /// <param name="minValue">The minimum value of the slider></param>
    /// <param name="maxValue">The maximum value of the slider></param>
    public IntSliderAttribute(string name, int minValue, int maxValue) : base(name)
    {
        MinValue = minValue;
        MaxValue = maxValue;
    }

    internal override bool VerifyCorrectFieldType(MemberInfo memberInfo) => CheckFieldType(memberInfo, typeof(int));
    
    internal override Element[] CreateElement<Settings>(MemberInfo memberInfo, Settings settings)
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
