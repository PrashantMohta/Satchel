using InControl;

namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of ControllerMapping allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class ControllerMappingR : InstanceClassWrapper<ControllerMapping>
{
    public ControllerMappingR(ControllerMapping _orig) : base(_orig)
    {
    }

    public GamepadType gamepadType
    {
        get => orig.gamepadType;
        set => orig.gamepadType = value;
    }

    public InputControlType jump
    {
        get => orig.jump;
        set => orig.jump = value;
    }

    public InputControlType attack
    {
        get => orig.attack;
        set => orig.attack = value;
    }

    public InputControlType dash
    {
        get => orig.dash;
        set => orig.dash = value;
    }

    public InputControlType cast
    {
        get => orig.cast;
        set => orig.cast = value;
    }

    public InputControlType superDash
    {
        get => orig.superDash;
        set => orig.superDash = value;
    }

    public InputControlType dreamNail
    {
        get => orig.dreamNail;
        set => orig.dreamNail = value;
    }

    public InputControlType quickMap
    {
        get => orig.quickMap;
        set => orig.quickMap = value;
    }

    public InputControlType quickCast
    {
        get => orig.quickCast;
        set => orig.quickCast = value;
    }
}