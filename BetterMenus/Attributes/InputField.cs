using System.Reflection;
using System.Runtime.CompilerServices;

namespace Satchel.BetterMenus.Attributes;

/// <summary>
/// Add this attribute to create a <see cref="InputField"/> to set this element in mod menu
/// Requires the type this attribute is on to be <see cref="string"/>
/// </summary>
public class StringInputFieldAttribute : ElementAttribute
{    
    public string PlaceHolder;
    public int CharacterLimit;

    /// <inheritdoc cref="StringInputFieldAttribute"/>
    /// <inheritdoc cref="ElementAttribute(string, int)"/>
    /// <param name="placeHolder">The text that will be shown when the box is empty</param>
    /// <param name="characterLimit">The maximum number of characters allowed in the box. default 10 </param>
    public StringInputFieldAttribute(string name, string placeHolder = "", int characterLimit = 10, [CallerLineNumber] int order = 0) 
        : base(name, order)
    {
        PlaceHolder = placeHolder;
        CharacterLimit = characterLimit;
    }

    public override bool VerifyCorrectFieldType(MemberInfo memberInfo) => CheckFieldOrPropertyType(memberInfo, typeof(string));
    public override Element[] CreateElement<Settings>(MemberInfo memberInfo, Settings settings)
    {
        return new Element[]
        {
            new InputField(Name,
                s => SetValue(memberInfo, settings, s),
                () => (string) GetValue(memberInfo, settings),
                PlaceHolder,
                CharacterLimit)
            
        };
    }
}

/// <summary>
/// Add this attribute to create a <see cref="InputField"/> to set this element in mod menu
/// Requires the type this attribute is on to be <see cref="int"/>
/// </summary>
public class IntInputFieldAttribute : ElementAttribute
{    

    public int DefaultValue;
    public string PlaceHolder;
    public int CharacterLimit;

    /// <inheritdoc cref="IntInputFieldAttribute"/>
    /// <inheritdoc cref="ElementAttribute(string, int)"/>
    /// <param name="defaultValue">The value it will be set to when the text box is empty</param>
    /// <param name="placeHolder">The text that will be shown when the box is empty</param>
    /// <param name="characterLimit">The maximum number of characters allowed in the box. default 10 </param>
    public IntInputFieldAttribute(string name, int defaultValue = 0, string placeHolder = "", int characterLimit = 5, [CallerLineNumber] int order = 0) 
        : base(name, order)
    {
        DefaultValue = defaultValue;
        PlaceHolder = placeHolder;
        CharacterLimit = characterLimit;
    }

    public override bool VerifyCorrectFieldType(MemberInfo memberInfo) => CheckFieldOrPropertyType(memberInfo, typeof(int));

    public override Element[] CreateElement<Settings>(MemberInfo memberInfo, Settings settings)
    {
        return new Element[]
        {
            Blueprints.IntInputField(Name,
                i => SetValue(memberInfo, settings, i),
                () => (int) GetValue(memberInfo, settings),
                DefaultValue,
                PlaceHolder,
                CharacterLimit
            )
        };
    }
}

/// <summary>
/// Add this attribute to create a <see cref="InputField"/> to set this element in mod menu
/// Requires the type this attribute is on to be <see cref="float"/>
/// </summary>
public class FloatInputFieldAttribute : ElementAttribute
{    

    public float DefaultValue;
    public string PlaceHolder;
    public int CharacterLimit;

    /// <inheritdoc cref="FloatInputFieldAttribute"/>
    /// <inheritdoc cref="ElementAttribute(string, int)"/>
    /// <param name="defaultValue">The value it will be set to when the text box is empty</param>
    /// <param name="placeHolder">The text that will be shown when the box is empty</param>
    /// <param name="characterLimit">The maximum number of characters allowed in the box. default 7 </param>
    public FloatInputFieldAttribute(string name, float defaultValue = 0, string placeHolder = "", int characterLimit = 7, [CallerLineNumber] int order = 0) 
        : base(name, order)
    {
        DefaultValue = defaultValue;
        PlaceHolder = placeHolder;
        CharacterLimit = characterLimit;
    }

    public override bool VerifyCorrectFieldType(MemberInfo memberInfo) => CheckFieldOrPropertyType(memberInfo, typeof(float));

    public override Element[] CreateElement<Settings>(MemberInfo memberInfo, Settings settings)
    {
        return new Element[]
        {
            Blueprints.FloatInputField(Name,
                f => SetValue(memberInfo, settings, f),
                () => (float) GetValue(memberInfo, settings),
                DefaultValue,
                PlaceHolder,
                CharacterLimit
            )
        };
    }
}