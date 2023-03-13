using System.Linq;
using System.Reflection;

namespace Satchel.BetterMenus.Attributes;

/// <summary>
/// Add this attribute to create a <see cref="HorizontalOption"/> to set this element in mod menu
/// Can be put on any type that can be converted to string
/// Normally should not use this directly, instead use
/// <see cref="HorizontalStringOptionAttribute"/>, <see cref="HorizontalBoolOptionAttribute"/>
/// <see cref="HorizontalEnumOptionAttribute{T}"/>, <see cref="HorizontalIntOptionAttribute"/>
/// <see cref="HorizontalFloatOptionAttribute"/>,
/// </summary>
public abstract class GenericHorizontalOptionAttribute<T> : ElementAttribute 
{
    public List<string> Options;
    public string Description;
    public Func<string, T> FromStringConvertor;
    
    /// <summary>
    /// Add this attribute to create a <see cref="HorizontalOption"/> to set this element in mod menu
    /// Requires the type this attribute is on to be <see cref="string"/>
    /// Normally should not use this directly, instead use
    /// <see cref="HorizontalStringOptionAttribute"/>, <see cref="HorizontalBoolOptionAttribute"/>
    /// <see cref="HorizontalEnumOptionAttribute{T}"/>, <see cref="HorizontalIntOptionAttribute"/>
    /// <see cref="HorizontalFloatOptionAttribute"/>,
    /// </summary>
    /// <param name="name">The name of the element to show in the menu. Also is the id></param>
    /// <param name="description">The description of the element></param>
    /// <param name="options">The possible options in the horizontal option></param>
    /// <param name="fromStringConvertor">The function that will convert from the generic type to a string</param>
    public GenericHorizontalOptionAttribute(string name, string description, string[] options, Func<string, T> fromStringConvertor) : base(name)
    {
        Description = description;
        Options = options.ToList();
        FromStringConvertor = fromStringConvertor;
    }

    /// <summary>
    /// Add this attribute to create a <see cref="HorizontalOption"/> to set this element in mod menu
    /// Requires the type this attribute is on to be <see cref="string"/>
    /// Normally should not use this directly, instead use
    /// <see cref="HorizontalStringOptionAttribute"/>, <see cref="HorizontalBoolOptionAttribute"/>
    /// <see cref="HorizontalEnumOptionAttribute{T}"/>, <see cref="HorizontalIntOptionAttribute"/>
    /// <see cref="HorizontalFloatOptionAttribute"/>,
    /// </summary>
    /// <param name="name">The name of the element to show in the menu. Also is the id></param>
    /// <param name="description">The description of the element></param>
    /// <param name="options">The possible options in the horizontal option></param>
    /// <param name="fromStringConvertor">The function that will convert from the generic type to a string</param>
    public GenericHorizontalOptionAttribute(string name, string description, T[] options, Func<string, T> fromStringConvertor) :
        this(name, description, options.Select(x => x.ToString()).ToArray(), fromStringConvertor)
    { }

    internal override bool VerifyCorrectFieldType(MemberInfo memberInfo) => memberInfo is FieldInfo or PropertyInfo;
    
    internal override Element[] CreateElement<Settings>(MemberInfo memberInfo, Settings settings)
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
    /// <summary>
    /// Add this attribute to create a <see cref="HorizontalOption"/> to set this element in mod menu
    /// Requires the type this attribute is on to be <see cref="string"/>
    /// </summary>
    /// <param name="name">The name of the element to show in the menu. Also is the id></param>
    /// <param name="description">The description of the element></param>
    /// <param name="options">The possible options in the horizontal option></param>
    public HorizontalStringOptionAttribute(string name, string description, string[] options) : base(name, description, options, s => s)
    { }

    internal override bool VerifyCorrectFieldType(MemberInfo memberInfo) => CheckFieldType(memberInfo, typeof(string));
}

/// <summary>
/// Add this attribute to create a <see cref="HorizontalOption"/> to set this element in mod menu
/// Requires the type this attribute is on to be <see cref="Enum"/>
/// </summary>
public class HorizontalEnumOptionAttribute<T> : GenericHorizontalOptionAttribute<T> where T : Enum
{
    /// <summary>
    /// Add this attribute to create a <see cref="HorizontalOption"/> to set this element in mod menu
    /// Requires the type this attribute is on to be <see cref="Enum"/>
    /// </summary>
    /// <param name="name">The name of the element to show in the menu. Also is the id></param>
    /// <param name="description">The description of the element></param>
    public HorizontalEnumOptionAttribute(string name, string description) : base(name, description,
        Enum.GetNames(typeof(T)), s => (T) Enum.Parse(typeof(T), s))
    { }

    internal override bool VerifyCorrectFieldType(MemberInfo memberInfo) =>
        memberInfo is FieldInfo fieldInfo && fieldInfo.FieldType.IsSubclassOf(typeof(Enum)) ||
        memberInfo is PropertyInfo propertyInfo && propertyInfo.PropertyType.IsSubclassOf(typeof(Enum)); //TODO: Test
}

/// <summary>
/// Add this attribute to create a <see cref="HorizontalOption"/> to set this element in mod menu
/// Requires the type this attribute is on to be <see cref="bool"/>
/// </summary>
public class HorizontalBoolOptionAttribute : GenericHorizontalOptionAttribute<bool>
{
    /// <summary>
    /// Add this attribute to create a <see cref="HorizontalOption"/> to set this element in mod menu
    /// Requires the type this attribute is on to be <see cref="string"/>
    /// </summary>
    /// <param name="name">The name of the element to show in the menu. Also is the id></param>
    /// <param name="description">The description of the element></param>
    public HorizontalBoolOptionAttribute(string name, string description) : base(name, description, new []{true, false}, bool.Parse)
    { }
    
    /// <summary>
    /// Add this attribute to create a <see cref="HorizontalOption"/> to set this element in mod menu
    /// Requires the type this attribute is on to be <see cref="string"/>
    /// use this constructor when you have a specific names for when the setting is true or false
    /// </summary>
    /// <param name="name">The name of the element to show in the menu. Also is the id></param>
    /// <param name="description">The description of the element></param>
    /// <param name="_true">the text that shows when bool is true</param>
    /// <param name="_false">the text that shows when bool is false</param>
    public HorizontalBoolOptionAttribute(string name, string description, string _true, string _false) : base(name, description, new [] {_true, _false} , s => s == _true)
    { }

    internal override bool VerifyCorrectFieldType(MemberInfo memberInfo) => CheckFieldType(memberInfo, typeof(bool));
}

/// <summary>
/// Add this attribute to create a <see cref="HorizontalOption"/> to set this element in mod menu
/// Requires the type this attribute is on to be <see cref="int"/>
/// </summary>
public class HorizontalIntOptionAttribute : GenericHorizontalOptionAttribute<int>
{
    /// <summary>
    /// Add this attribute to create a <see cref="HorizontalOption"/> to set this element in mod menu
    /// Requires the type this attribute is on to be <see cref="int"/>
    /// use this constructor when you have a specific set of options
    /// </summary>
    /// <param name="name">The name of the element to show in the menu. Also is the id></param>
    /// <param name="description">The description of the element></param>
    /// <param name="options">The possible options in the horizontal option></param>
    public HorizontalIntOptionAttribute(string name, string description, int[] options) : base(name, description, options, int.Parse)
    { }
    
    /// <summary>
    /// Add this attribute to create a <see cref="HorizontalOption"/> to set this element in mod menu
    /// Requires the type this attribute is on to be <see cref="int"/>
    /// use this constructor when you have a options in a regular sequence (eg. [1,2,3,4])
    /// </summary>
    /// <param name="name">The name of the element to show in the menu. Also is the id></param>
    /// <param name="description">The description of the element></param>
    /// <param name="start">The start of the sequence></param>
    /// <param name="stop">The end of the sequence></param>
    /// <param name="step">The amount increased between 2 elements in the sequence></param>
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

    internal override bool VerifyCorrectFieldType(MemberInfo memberInfo) => CheckFieldType(memberInfo, typeof(int));
}

/// <summary>
/// Add this attribute to create a <see cref="HorizontalOption"/> to set this element in mod menu
/// Requires the type this attribute is on to be <see cref="float"/>
/// </summary>
public class HorizontalFloatOptionAttribute : GenericHorizontalOptionAttribute<float>
{
    /// <summary>
    /// Add this attribute to create a <see cref="HorizontalOption"/> to set this element in mod menu
    /// Requires the type this attribute is on to be <see cref="float"/>
    /// </summary>
    /// <param name="name">The name of the element to show in the menu. Also is the id></param>
    /// <param name="description">The description of the element></param>
    /// <param name="options">The possible options in the horizontal option></param>
    public HorizontalFloatOptionAttribute(string name, string description, float[] options) : base(name, description, options, float.Parse)
    { }

    /// <summary>
    /// Add this attribute to create a <see cref="HorizontalOption"/> to set this element in mod menu
    /// Requires the type this attribute is on to be <see cref="float"/>
    /// use this constructor when you have a options in a regular sequence (eg. [1,2,3,4])
    /// </summary>
    /// <param name="name">The name of the element to show in the menu. Also is the id></param>
    /// <param name="description">The description of the element></param>
    /// <param name="start">The start of the sequence></param>
    /// <param name="stop">The end of the sequence></param>
    /// <param name="step">The amount increased between 2 elements in the sequence></param>
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

    internal override bool VerifyCorrectFieldType(MemberInfo memberInfo) => CheckFieldType(memberInfo, typeof(float));
}

