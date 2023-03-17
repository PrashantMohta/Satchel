using InControl;

namespace Satchel.BetterMenus;

/// <summary>
/// A predefined <see cref="PlayerActionSet"/> to store key and button bind in settings class.
/// If used in settings class, make sure to annotate it with [<see cref="Newtonsoft.Json.JsonConverterAttribute"/>(typeof(<see cref="Modding.Converters.PlayerActionSetConverter"/>))]
/// </summary>
public class KeyAndButtonActionSet : PlayerActionSet
{
    public readonly PlayerAction KeyBind;
    public readonly PlayerAction ButtonBind;

    /// <inheritdoc cref="KeyAndButtonActionSet"/>
    public KeyAndButtonActionSet() 
    {
        KeyBind = CreatePlayerAction("KeyBind");
        ButtonBind = CreatePlayerAction("ButtonBind");
    }
    
    /// <inheritdoc cref="KeyAndButtonActionSet"/>
    /// <param name="defaultKeyBind">The default <see cref="Key"/> for the key bind</param>
    /// <param name="defaultButtonBind">The default <see cref="InputControlType"/> for the button bind</param>
    public KeyAndButtonActionSet(Key defaultKeyBind, InputControlType defaultButtonBind) : this() 
    {
        KeyBind.AddDefaultBinding(defaultKeyBind);
        ButtonBind.AddDefaultBinding(defaultButtonBind);
    }

    public bool IsPressed => KeyBind.IsPressed || ButtonBind.IsPressed;

    public bool WasPressed => KeyBind.WasPressed || ButtonBind.WasPressed;

    public bool WasReleased => KeyBind.WasReleased || ButtonBind.WasReleased;

    public bool WasRepeated => KeyBind.WasRepeated || ButtonBind.WasRepeated;
}