using UnityEngine.UI;

namespace Satchel.BetterMenus.Config;

/// <summary>
/// struct for changing the input field size
/// </summary>
public struct InputFieldConfig
{
    /// <summary>
    /// the font size of the input text. default 46
    /// </summary>
    public int fontSize;
    /// <summary>
    /// the width of the input box. for reference, 10 characters with font 46 can fit in a space of 300f (the default)
    /// </summary>
    public float inputBoxWidth;

    /// <summary>
    /// the expected type of input, can be alphanumeric, integer or float
    /// </summary>
    public UnityEngine.UI.InputField.ContentType contentType;

    /// <summary>
    /// when should the data be saved into the settings field, on submit or on change
    /// </summary>
    public InputFieldSaveType saveType;
    
    /// <summary>
    /// the expected type of input, can be none, integer, or decimal
    /// </summary>
    public UnityEngine.UI.InputField.CharacterValidation characterValidation;

    /// <summary>
    /// the default config for text input
    /// </summary>
    public static readonly InputFieldConfig DefaultText = new InputFieldConfig()
    {
        fontSize = 46,
        inputBoxWidth = 300f,
        contentType = UnityEngine.UI.InputField.ContentType.Standard,
        characterValidation = UnityEngine.UI.InputField.CharacterValidation.None,
        saveType = InputFieldSaveType.ValueChanged,
    };
    
    /// <summary>
    /// the default config for integer inputs
    /// </summary>
    public static readonly InputFieldConfig DefaultWholeNumber = new InputFieldConfig()
    {
        fontSize = 46,
        inputBoxWidth = 150f,
        contentType = UnityEngine.UI.InputField.ContentType.IntegerNumber,
        characterValidation = UnityEngine.UI.InputField.CharacterValidation.Integer,
        saveType = InputFieldSaveType.EditEnd,
    };
    
    /// <summary>
    /// the default config for floats
    /// </summary>
    public static readonly InputFieldConfig DefaultFloatNumber = new InputFieldConfig()
    {
        fontSize = 46,
        inputBoxWidth = 210f,
        contentType = UnityEngine.UI.InputField.ContentType.DecimalNumber,
        characterValidation = UnityEngine.UI.InputField.CharacterValidation.Decimal,
        saveType = InputFieldSaveType.EditEnd,
    };
}

/// <summary>
/// struct for changing additional properties in text panel
/// </summary>
public struct AdditionalTextPanelConfig
{
    /// <summary>
    /// The <see cref="FontStyle"/> of the text (bold/italic/normal)
    /// </summary>
    public FontStyle? fontStyle;
    
    /// <summary>
    /// The <see cref="HorizontalWrapMode"/> of the text (bold/italic/normal)
    /// </summary>
    public HorizontalWrapMode? horizontalOverflow;

    /// <summary>
    /// The line spacing of the text
    /// </summary>
    public float? lineSpacing;

    /// <summary>
    /// The color of the text
    /// </summary>
    public Color? color;

    public void SetAdditionalTextProperties(Text text)
    {
        if (fontStyle.HasValue) text.fontStyle = fontStyle.Value;
        if (horizontalOverflow.HasValue) text.horizontalOverflow = horizontalOverflow.Value;
        if (lineSpacing.HasValue) text.lineSpacing = lineSpacing.Value;
        if (color.HasValue) text.color = color.Value;
    }
}

public enum SelectableArea
{
    Full,
    ButtonOnly
}

/// <summary>
/// Configuration options for creating a menu keybind option.
/// </summary>
public struct KeybindConfig
{
    /// <summary>
    /// The displayed text for the name of the keybind.
    /// </summary>
    public string Label;
    /// <summary>
    /// The style of the keybind.
    /// </summary>
    public KeybindStyle? Style;
    /// <summary>
    /// The action to run when pressing the menu cancel key while selecting this item.
    /// </summary>
    public Action<MappableKey> CancelAction;

    public SelectableArea? selectableArea;
}

/// <summary>
/// Configuration options for creating a menu buttonBind option.
/// </summary>
public struct ButtonBindConfig
{
    /// <summary>
    /// The displayed text for the name of the ButtonBind.
    /// </summary>
    public string Label;
    /// <summary>
    /// The style of the ButtonBind.
    /// </summary>
    public KeybindStyle? Style;
    /// <summary>
    /// The action to run when pressing the menu cancel key while selecting this item.
    /// </summary>
    public Action<MappableControllerButton> CancelAction;
    
    public SelectableArea? selectableArea;
}

/// <summary>
/// The styling options of a keybind menu item.
/// </summary>
public struct KeybindStyle
{
    /// <summary>
    /// The style preset of a keybind in the vanilla game.
    /// </summary>
    public static readonly KeybindStyle VanillaStyle = new KeybindStyle
    {
        LabelTextSize = 37
    };
    /// <summary>
    /// The text size of the label text.
    /// </summary>
    public int LabelTextSize;
}

public enum InputFieldSaveType
{
    /// <summary>
    /// Changes setting field after every change to the text box
    /// </summary>
    ValueChanged,
    /// <summary>
    /// Changes setting field after the user has fully inputted what they want
    /// </summary>
    EditEnd,
}


