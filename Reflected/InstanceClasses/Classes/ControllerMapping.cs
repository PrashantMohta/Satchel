namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of ControllerMapping allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class ControllerMappingR:InstanceClassWrapper<ControllerMapping>
{
public ControllerMappingR(ControllerMapping _orig) : base(_orig) {}
public GlobalEnums.GamepadType gamepadType
{
get => orig.gamepadType;
set => orig.gamepadType = value;
}

public InControl.InputControlType jump
{
get => orig.jump;
set => orig.jump = value;
}

public InControl.InputControlType attack
{
get => orig.attack;
set => orig.attack = value;
}

public InControl.InputControlType dash
{
get => orig.dash;
set => orig.dash = value;
}

public InControl.InputControlType cast
{
get => orig.cast;
set => orig.cast = value;
}

public InControl.InputControlType superDash
{
get => orig.superDash;
set => orig.superDash = value;
}

public InControl.InputControlType dreamNail
{
get => orig.dreamNail;
set => orig.dreamNail = value;
}

public InControl.InputControlType quickMap
{
get => orig.quickMap;
set => orig.quickMap = value;
}

public InControl.InputControlType quickCast
{
get => orig.quickCast;
set => orig.quickCast = value;
}

}
}
