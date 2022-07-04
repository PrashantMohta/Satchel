namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of HeroActions allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class HeroActionsR:InstanceClassWrapper<HeroActions>
{
public HeroActionsR(HeroActions _orig) : base(_orig) {}
public InControl.PlayerAction left
{
get => orig.left;
set => orig.left = value;
}

public InControl.PlayerAction right
{
get => orig.right;
set => orig.right = value;
}

public InControl.PlayerAction up
{
get => orig.up;
set => orig.up = value;
}

public InControl.PlayerAction down
{
get => orig.down;
set => orig.down = value;
}

public InControl.PlayerAction menuSubmit
{
get => orig.menuSubmit;
set => orig.menuSubmit = value;
}

public InControl.PlayerAction menuCancel
{
get => orig.menuCancel;
set => orig.menuCancel = value;
}

public InControl.PlayerTwoAxisAction moveVector
{
get => orig.moveVector;
set => orig.moveVector = value;
}

public InControl.PlayerAction rs_up
{
get => orig.rs_up;
set => orig.rs_up = value;
}

public InControl.PlayerAction rs_down
{
get => orig.rs_down;
set => orig.rs_down = value;
}

public InControl.PlayerAction rs_left
{
get => orig.rs_left;
set => orig.rs_left = value;
}

public InControl.PlayerAction rs_right
{
get => orig.rs_right;
set => orig.rs_right = value;
}

public InControl.PlayerTwoAxisAction rightStick
{
get => orig.rightStick;
set => orig.rightStick = value;
}

public InControl.PlayerAction jump
{
get => orig.jump;
set => orig.jump = value;
}

public InControl.PlayerAction evade
{
get => orig.evade;
set => orig.evade = value;
}

public InControl.PlayerAction dash
{
get => orig.dash;
set => orig.dash = value;
}

public InControl.PlayerAction superDash
{
get => orig.superDash;
set => orig.superDash = value;
}

public InControl.PlayerAction dreamNail
{
get => orig.dreamNail;
set => orig.dreamNail = value;
}

public InControl.PlayerAction attack
{
get => orig.attack;
set => orig.attack = value;
}

public InControl.PlayerAction cast
{
get => orig.cast;
set => orig.cast = value;
}

public InControl.PlayerAction focus
{
get => orig.focus;
set => orig.focus = value;
}

public InControl.PlayerAction quickMap
{
get => orig.quickMap;
set => orig.quickMap = value;
}

public InControl.PlayerAction quickCast
{
get => orig.quickCast;
set => orig.quickCast = value;
}

public InControl.PlayerAction textSpeedup
{
get => orig.textSpeedup;
set => orig.textSpeedup = value;
}

public InControl.PlayerAction skipCutscene
{
get => orig.skipCutscene;
set => orig.skipCutscene = value;
}

public InControl.PlayerAction openInventory
{
get => orig.openInventory;
set => orig.openInventory = value;
}

public InControl.PlayerAction paneRight
{
get => orig.paneRight;
set => orig.paneRight = value;
}

public InControl.PlayerAction paneLeft
{
get => orig.paneLeft;
set => orig.paneLeft = value;
}

public InControl.PlayerAction pause
{
get => orig.pause;
set => orig.pause = value;
}

public InControl.BindingSourceType LastInputType
{
get => orig.LastInputType;
set => orig.LastInputType = value;
}

public System.UInt64 LastInputTypeChangedTick
{
get => orig.LastInputTypeChangedTick;
set => orig.LastInputTypeChangedTick = value;
}

public InControl.InputDeviceClass LastDeviceClass
{
get => orig.LastDeviceClass;
set => orig.LastDeviceClass = value;
}

public InControl.InputDeviceStyle LastDeviceStyle
{
get => orig.LastDeviceStyle;
set => orig.LastDeviceStyle = value;
}

public InControl.PlayerAction listenWithAction
{
get => GetField<InControl.PlayerAction>();
set => SetField(value);
}

public InControl.InputDevice Device
{
get => orig.Device;
set => orig.Device = value;
}

public System.Collections.Generic.List<InControl.InputDevice> IncludeDevices
{
get => orig.IncludeDevices;
}

public System.Collections.Generic.List<InControl.InputDevice> ExcludeDevices
{
get => orig.ExcludeDevices;
}

public System.Collections.ObjectModel.ReadOnlyCollection<InControl.PlayerAction> Actions
{
get => orig.Actions;
}

public System.UInt64 UpdateTick
{
get => orig.UpdateTick;
set => SetProperty(value);
}

public bool Enabled
{
get => orig.Enabled;
set => orig.Enabled = value;
}

public bool PreventInputWhileListeningForBinding
{
get => orig.PreventInputWhileListeningForBinding;
set => orig.PreventInputWhileListeningForBinding = value;
}

public System.Object UserData
{
get => orig.UserData;
set => orig.UserData = value;
}

public bool IsListeningForBinding
{
get => orig.IsListeningForBinding;
}

public InControl.BindingListenOptions ListenOptions
{
get => orig.ListenOptions;
set => orig.ListenOptions = value;
}

public InControl.InputDevice ActiveDevice
{
get => orig.ActiveDevice;
}

}
}
