namespace Satchel.BetterMenus;

public static partial class Blueprints
{
    /// <summary>
    /// Create a float input field
    /// </summary>
    /// <param name="name">The name to be displayed</param>
    /// <param name="_storeValue">The Action that will be invoked when text is inputted. Use the float parameter to save the value to use in mod.</param>
    /// <param name="_loadValue">The initial value that you need the field to be, probably from previous session or a default</param>
    /// <param name="_defaultValue">The value it will be set to when the text box is empty</param>
    /// <param name="_placeholder">The text that shows when input text box is empty</param>
    /// <param name="_characterLimit">the maximum number of characters allowed in the box. default 6 </param>
    /// <param name="_config">Configurations for the input text. If left null, defaults to InputFieldConfig.DefaultWholeNumber. Config includes fontSize (default: 46), inputBoxWidth (default: 210f) and contentType (default: Decimal).</param>
    /// <param name="Id">the id of the element that can be used to search for it</param>
    public static InputField FloatInputField(string name, Action<float> _storeValue, Func<float> _loadValue, float _defaultValue = 0, string _placeholder = "", int _characterLimit = 7, Config.InputFieldConfig? _config = null, string Id = "__Usename")
    {
        var config = _config ?? Config.InputFieldConfig.DefaultFloatNumber;

        Action<string> finalStoreValue = s =>
        {
            var isFloat = float.TryParse(s, out var value);

            if (isFloat)
            {
                _storeValue(value);
            }
            else
            {
                if (s != string.Empty)
                {
                    Satchel.Instance.LogWarn($"Inputted value {s} is not a valid float in {name} input field");
                }
            }
        };

        Func<string> finalLoadValue = () => _loadValue().ToString();


        return new InputField(name, finalStoreValue, finalLoadValue, _placeholder, _characterLimit, config, Id);
    }
}