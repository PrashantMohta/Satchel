using System.Linq;
using System.Reflection;
using InControl;

namespace Satchel.BetterMenus.Attributes;

/// <summary>
/// The base element attribute for building menus
/// </summary>
public abstract class ElementAttribute : Attribute
{
    public string Name;
    
    /// <summary>
    /// The base element attribute for building menus
    /// </summary>
    /// <param name="name">The name of the element to show in the menu. Also is the id</param>
    public ElementAttribute(string name)
    {
        Name = name;
    }

    internal abstract bool VerifyCorrectFieldType(FieldInfo fieldInfo);

    //if null it wont be added to menu
    internal abstract Element[] CreateElement<Settings>(FieldInfo fieldInfo, Settings settings);

    protected const BindingFlags flags = BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.Instance;
}

/// <summary>
/// Adding this attribute will cause satchel to ignore this field
/// </summary>
public class BetterMenusIgnore : Attribute { }

/// <summary>
/// Add this attribute to a field of the class that contains the PlayerActions as fields for keybinds and button binds to be created.
/// Requires the type this attribute is on to be an inherited class of <see cref="InControl.PlayerActionSet"/>
/// Requires the fields in the custom class to have either KeyBindAttribute or ButtonBindAttribute
/// </summary>
public class KeyAndButtonBindClassAttribute : ElementAttribute
{
    /// <summary>
    /// Add this attribute to a field of the class that contains the PlayerActions as fields for keybinds and button binds to be created.
    /// Requires the type this attribute is on to be an inherited class of <see cref="InControl.PlayerActionSet"/>
    /// Requires the fields in the custom class to have either KeyBindAttribute or ButtonBindAttribute
    /// </summary>
    /// <param name="name">The name of the element to show in the menu. Also is the id></param>
    public KeyAndButtonBindClassAttribute(string name) : base(name) { }

    internal override bool VerifyCorrectFieldType(FieldInfo fieldInfo) => fieldInfo.FieldType == typeof(PlayerActionSet);

    internal override Element[] CreateElement<Settings>(FieldInfo fieldInfo, Settings settings)
    {
        List<Element> elements = new List<Element>();
        foreach (var bindField in fieldInfo.FieldType.GetFields(flags))
        {
            if (bindField.GetCustomAttribute<KeyBindAttribute>() is { } keyBindAttribute)
            {
                elements.Add(new KeyBind(keyBindAttribute.Name, bindField.GetValue(fieldInfo.GetValue(settings)) as PlayerAction));
            }
            if (bindField.GetCustomAttribute<ButtonBindAttribute>() is { } buttonBindAttribute)
            {
                elements.Add(new ButtonBind(buttonBindAttribute.Name, bindField.GetValue(fieldInfo.GetValue(settings)) as PlayerAction));
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
    /// <summary>
    /// The attribute to be used on a field in the custom class to specify its a keybind
    /// Requires the type this attribute is on to be <see cref="InControl.PlayerAction"/>
    /// </summary>
    /// <param name="name">The name of the element to show in the menu. Also is the id></param>
    public KeyBindAttribute(string name) : base(name) { }
    
    internal override bool VerifyCorrectFieldType(FieldInfo fieldInfo) => fieldInfo.FieldType == typeof(PlayerAction);
    internal override Element[] CreateElement<Settings>(FieldInfo fieldInfo, Settings settings) => Array.Empty<Element>();
}
/// <summary>
/// The attribute to be used on a field in the custom class to specify its a button bind
/// Requires the type this attribute is on to be <see cref="InControl.PlayerAction"/>
/// </summary>
public class ButtonBindAttribute : ElementAttribute
{
    /// <summary>
    /// The attribute to be used on a field in the custom class to specify its a button bind
    /// Requires the type this attribute is on to be <see cref="InControl.PlayerAction"/>
    /// </summary>
    /// <param name="name">The name of the element to show in the menu. Also is the id></param>
    public ButtonBindAttribute(string name) : base(name) { }
    
    internal override bool VerifyCorrectFieldType(FieldInfo fieldInfo) => fieldInfo.FieldType == typeof(PlayerAction);
    internal override Element[] CreateElement<Settings>(FieldInfo fieldInfo, Settings settings) => Array.Empty<Element>();
}

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

    internal override bool VerifyCorrectFieldType(FieldInfo fieldInfo) => fieldInfo.FieldType == typeof(float);
    internal override Element[] CreateElement<Settings>(FieldInfo fieldInfo, Settings settings)
    {
        return new Element[]
        {
            new CustomSlider(Name,
                f => fieldInfo.SetValue(settings, f),
                () => (float) fieldInfo.GetValue(settings),
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

    internal override bool VerifyCorrectFieldType(FieldInfo fieldInfo) => fieldInfo.FieldType == typeof(int);
    
    internal override Element[] CreateElement<Settings>(FieldInfo fieldInfo, Settings settings)
    {
        return new Element[]
        {
            new CustomSlider(Name,
                f => fieldInfo.SetValue(settings, (int)f),
                () => (float) (int) fieldInfo.GetValue(settings),
                minValue: MinValue,
                maxValue: MaxValue,
                wholeNumbers: true),
        };
    }
}

/// <summary>
/// Add this attribute to create a <see cref="HorizontalOption"/> to set this element in mod menu
/// Can be put on any type that can be converted to string
/// Normally should not use this directly, instead use
/// <see cref="HorizontalStringOptionAttribute"/>, <see cref="HorizontalBoolOptionAttribute"/>
/// <see cref="HorizontalEnumOptionAttribute{T}"/>, <see cref="HorizontalIntOptionAttribute"/>
/// <see cref="HorizontalFloatOptionAttribute"/>,
/// </summary>
public class GenericHorizontalOptionAttribute<T> : ElementAttribute 
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
    /// <param name="fromStringConvertor">The function that will convert from <see cref="T"/> to a string</param>
    public GenericHorizontalOptionAttribute(string name, string description, T[] options, Func<string, T> fromStringConvertor) : base(name)
    {
        Description = description;
        Options = options.Select(x => x.ToString()).ToList();
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
    /// <param name="fromStringConvertor">The function that will convert from <see cref="T"/> to a string</param>
    public GenericHorizontalOptionAttribute(string name, string description, string[] options, Func<string, T> fromStringConvertor) : base(name)
    {
        Description = description;
        Options = options.ToList();
        FromStringConvertor = fromStringConvertor;

    }

    internal override bool VerifyCorrectFieldType(FieldInfo fieldInfo) => true;
    
    internal override Element[] CreateElement<Settings>(FieldInfo fieldInfo, Settings settings)
    {
        return new Element[]
        {
            new HorizontalOption(Name,
                Description,
                Options.ToArray(),
                i => fieldInfo.SetValue(settings, FromStringConvertor(Options[i])),
                () =>
                {
                    var value = (T) fieldInfo.GetValue(settings); 
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

    internal override bool VerifyCorrectFieldType(FieldInfo fieldInfo) => fieldInfo.FieldType == typeof(string);
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

    internal override bool VerifyCorrectFieldType(FieldInfo fieldInfo) => fieldInfo.FieldType == typeof(Enum);
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

    internal override bool VerifyCorrectFieldType(FieldInfo fieldInfo) => fieldInfo.FieldType == typeof(bool);
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
    public HorizontalIntOptionAttribute(string name, string description, int start, int stop, int step = 1) : base(name, description, Enumerable.Range(start / step, Math.Abs(stop - start) / step + 1).Select(x => x * step).ToArray(), int.Parse)
    { }

    internal override bool VerifyCorrectFieldType(FieldInfo fieldInfo) => fieldInfo.FieldType == typeof(int);
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
    {
    }

    internal override bool VerifyCorrectFieldType(FieldInfo fieldInfo) => fieldInfo.FieldType == typeof(float);
}

//TODO: InputField
//TODO: MenuButton
//TODO: TextPanel
//TODO: StaticPanel