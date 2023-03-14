using System.Linq;
using System.Reflection;

namespace Satchel.BetterMenus.Attributes;

/// <summary>
/// Add this attribute to create a <see cref="HorizontalOption"/> to set this element in mod menu.
/// Can be put on any type that can be converted to string.
/// Should not be used, use either:
/// <see cref="HorizontalStringOptionAttribute"/>, <see cref="HorizontalBoolOptionAttribute"/>
/// <see cref="HorizontalEnumOptionAttribute{T}"/>, <see cref="HorizontalIntOptionAttribute"/> or
/// <see cref="HorizontalFloatOptionAttribute"/>.
/// Alternatively create your own child class similar to these.
/// </summary>
public abstract class GenericHorizontalOptionAttribute<T> : ElementAttribute 
{
    public List<string> Options;
    public string Description;
    public Func<string, T> FromStringConvertor;
    
    /// <inheritdoc cref="GenericHorizontalOptionAttribute{T}"/>
    /// <param name="name">The name of the element to show in the menu. Also is the id</param>
    /// <param name="description">The description of the element</param>
    /// <param name="options">The possible options in the horizontal option</param>
    /// <param name="fromStringConvertor">The function that will convert from the generic type to a string</param>
    public GenericHorizontalOptionAttribute(string name, string description, string[] options, Func<string, T> fromStringConvertor) : base(name)
    {
        Description = description;
        Options = options.ToList();
        FromStringConvertor = fromStringConvertor;
    }

    /// <inheritdoc cref="GenericHorizontalOptionAttribute{T}"/>
    /// <param name="name">The name of the element to show in the menu. Also is the id</param>
    /// <param name="description">The description of the element</param>
    /// <param name="options">The possible options in the horizontal option</param>
    /// <param name="fromStringConvertor">The function that will convert from the generic type to a string</param>
    public GenericHorizontalOptionAttribute(string name, string description, T[] options, Func<string, T> fromStringConvertor) :
        this(name, description, options.Select(x => x.ToString()).ToArray(), fromStringConvertor)
    { }

    public override bool VerifyCorrectFieldType(MemberInfo memberInfo) => memberInfo is FieldInfo or PropertyInfo;
    
    public override Element[] CreateElement<Settings>(MemberInfo memberInfo, Settings settings)
    {
        return new Element[]
        {
            new HorizontalOption(Name,
                Description,
                Options.ToArray(),
                i =>
                {
                    SetValue(memberInfo, settings, FromStringConvertor(Options[i]));
                },
                () =>
                {
                    var value = (T) GetValue(memberInfo, settings); 
                    return Options.FindIndex(x => EqualityComparer<T>.Default.Equals(FromStringConvertor(x), value));
                })
        };
    }
}

/// <summary>
/// Add this attribute to create a <see cref="HorizontalOption"/> to set this element in mod menu
/// Requires the type this attribute is on to be <see cref="string"/>
/// </summary>
public class HorizontalStringOptionAttribute : GenericHorizontalOptionAttribute<string>
{
    /// <inheritdoc cref="HorizontalStringOptionAttribute"/>
    /// <param name="name">The name of the element to show in the menu. Also is the id</param>
    /// <param name="description">The description of the element</param>
    /// <param name="options">The possible options in the horizontal option</param>
    public HorizontalStringOptionAttribute(string name, string description, string[] options) : base(name, description, options, s => s)
    { }

    public override bool VerifyCorrectFieldType(MemberInfo memberInfo) => CheckFieldOrPropertyType(memberInfo, typeof(string));
}

/// <summary>
/// Add this attribute to create a <see cref="HorizontalOption"/> to set this element in mod menu
/// Requires the type this attribute is on to be <see cref="Enum"/>
/// </summary>
public class HorizontalEnumOptionAttribute<T> : GenericHorizontalOptionAttribute<T> where T : Enum
{
    /// <inheritdoc cref="HorizontalEnumOptionAttribute{T}"/>
    /// <param name="name">The name of the element to show in the menu. Also is the id</param>
    /// <param name="description">The description of the element</param>
    public HorizontalEnumOptionAttribute(string name, string description) : base(name, description,
        Enum.GetNames(typeof(T)), s => (T) Enum.Parse(typeof(T), s))
    { }

    public override bool VerifyCorrectFieldType(MemberInfo memberInfo) =>
        memberInfo is FieldInfo fieldInfo && fieldInfo.FieldType.IsSubclassOf(typeof(Enum)) ||
        memberInfo is PropertyInfo propertyInfo && propertyInfo.PropertyType.IsSubclassOf(typeof(Enum));
}

/// <summary>
/// Add this attribute to create a <see cref="HorizontalOption"/> to set this element in mod menu
/// Requires the type this attribute is on to be <see cref="bool"/>
/// </summary>
public class HorizontalBoolOptionAttribute : GenericHorizontalOptionAttribute<bool>
{
    /// <inheritdoc cref="HorizontalBoolOptionAttribute"/>
    /// <param name="name">The name of the element to show in the menu. Also is the id</param>
    /// <param name="description">The description of the element</param>
    /// <param name="_true">the text that shows when bool is true</param>
    /// <param name="_false">the text that shows when bool is false</param>
    public HorizontalBoolOptionAttribute(string name, string description, string _true = "True", string _false = "False") : base(name, description, new [] {_true, _false} , s => s == _true)
    { }

    public override bool VerifyCorrectFieldType(MemberInfo memberInfo) => CheckFieldOrPropertyType(memberInfo, typeof(bool));
}

/// <summary>
/// Add this attribute to create a <see cref="HorizontalOption"/> to set this element in mod menu
/// Requires the type this attribute is on to be <see cref="int"/>
/// </summary>
public class HorizontalIntOptionAttribute : GenericHorizontalOptionAttribute<int>
{
    /// <inheritdoc cref="HorizontalIntOptionAttribute"/>
    /// <param name="name">The name of the element to show in the menu. Also is the id</param>
    /// <param name="description">The description of the element</param>
    /// <param name="options">The possible options in the horizontal option</param>
    public HorizontalIntOptionAttribute(string name, string description, int[] options) : base(name, description, options, int.Parse)
    { }
    
    /// <inheritdoc cref="HorizontalIntOptionAttribute"/>
    /// <param name="name">The name of the element to show in the menu. Also is the id</param>
    /// <param name="description">The description of the element</param>
    /// <param name="start">The start of the sequence</param>
    /// <param name="stop">The end of the sequence</param>
    /// <param name="step">The amount increased between 2 elements in the sequence</param>
    public HorizontalIntOptionAttribute(string name, string description, int start, int stop, int step = 1) : base(name, description, GetOptions(start, stop, step), int.Parse)
    { }

    private static int[] GetOptions(int start, int stop, int step)
    {
        List<int> options = new();
        for (int i = start; i < stop; i += step) {
			options.Add(i);
		}
        return options.ToArray();
    }

    public override bool VerifyCorrectFieldType(MemberInfo memberInfo) => CheckFieldOrPropertyType(memberInfo, typeof(int));
}

/// <summary>
/// Add this attribute to create a <see cref="HorizontalOption"/> to set this element in mod menu
/// Requires the type this attribute is on to be <see cref="float"/>
/// </summary>
public class HorizontalFloatOptionAttribute : GenericHorizontalOptionAttribute<float>
{
    /// <inheritdoc cref="HorizontalFloatOptionAttribute"/>
    /// <param name="name">The name of the element to show in the menu. Also is the id</param>
    /// <param name="description">The description of the element</param>
    /// <param name="options">The possible options in the horizontal option</param>
    public HorizontalFloatOptionAttribute(string name, string description, float[] options) : base(name, description, options, float.Parse)
    { }

    /// <inheritdoc cref="HorizontalFloatOptionAttribute"/>
    /// <param name="name">The name of the element to show in the menu. Also is the id</param>
    /// <param name="description">The description of the element</param>
    /// <param name="start">The start of the sequence</param>
    /// <param name="stop">The end of the sequence</param>
    /// <param name="step">The amount increased between 2 elements in the sequence</param>
    public HorizontalFloatOptionAttribute(string name, string description, float start, float stop, float step = 1) : base(name, description, GetOptions(start, stop, step), float.Parse)
    { }

    private static float[] GetOptions(float start, float stop, float step)
    {
        List<float> options = new();

		decimal decimalStop = (decimal) stop, decimalStep = (decimal) step;
		for (decimal i = (decimal) start; i < decimalStop; i += decimalStep) {
			options.Add(decimal.ToSingle(i));
		}

		options.Add(stop);

		return options.ToArray();
    }

    public override bool VerifyCorrectFieldType(MemberInfo memberInfo) => CheckFieldOrPropertyType(memberInfo, typeof(float));
}

