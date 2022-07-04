using System.Collections.ObjectModel;
using InControl;

namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of HeroActions allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class HeroActionsR : InstanceClassWrapper<HeroActions>
{
    public HeroActionsR(HeroActions _orig) : base(_orig)
    {
    }

    public PlayerAction left
    {
        get => orig.left;
        set => orig.left = value;
    }

    public PlayerAction right
    {
        get => orig.right;
        set => orig.right = value;
    }

    public PlayerAction up
    {
        get => orig.up;
        set => orig.up = value;
    }

    public PlayerAction down
    {
        get => orig.down;
        set => orig.down = value;
    }

    public PlayerAction menuSubmit
    {
        get => orig.menuSubmit;
        set => orig.menuSubmit = value;
    }

    public PlayerAction menuCancel
    {
        get => orig.menuCancel;
        set => orig.menuCancel = value;
    }

    public PlayerTwoAxisAction moveVector
    {
        get => orig.moveVector;
        set => orig.moveVector = value;
    }

    public PlayerAction rs_up
    {
        get => orig.rs_up;
        set => orig.rs_up = value;
    }

    public PlayerAction rs_down
    {
        get => orig.rs_down;
        set => orig.rs_down = value;
    }

    public PlayerAction rs_left
    {
        get => orig.rs_left;
        set => orig.rs_left = value;
    }

    public PlayerAction rs_right
    {
        get => orig.rs_right;
        set => orig.rs_right = value;
    }

    public PlayerTwoAxisAction rightStick
    {
        get => orig.rightStick;
        set => orig.rightStick = value;
    }

    public PlayerAction jump
    {
        get => orig.jump;
        set => orig.jump = value;
    }

    public PlayerAction evade
    {
        get => orig.evade;
        set => orig.evade = value;
    }

    public PlayerAction dash
    {
        get => orig.dash;
        set => orig.dash = value;
    }

    public PlayerAction superDash
    {
        get => orig.superDash;
        set => orig.superDash = value;
    }

    public PlayerAction dreamNail
    {
        get => orig.dreamNail;
        set => orig.dreamNail = value;
    }

    public PlayerAction attack
    {
        get => orig.attack;
        set => orig.attack = value;
    }

    public PlayerAction cast
    {
        get => orig.cast;
        set => orig.cast = value;
    }

    public PlayerAction focus
    {
        get => orig.focus;
        set => orig.focus = value;
    }

    public PlayerAction quickMap
    {
        get => orig.quickMap;
        set => orig.quickMap = value;
    }

    public PlayerAction quickCast
    {
        get => orig.quickCast;
        set => orig.quickCast = value;
    }

    public PlayerAction textSpeedup
    {
        get => orig.textSpeedup;
        set => orig.textSpeedup = value;
    }

    public PlayerAction skipCutscene
    {
        get => orig.skipCutscene;
        set => orig.skipCutscene = value;
    }

    public PlayerAction openInventory
    {
        get => orig.openInventory;
        set => orig.openInventory = value;
    }

    public PlayerAction paneRight
    {
        get => orig.paneRight;
        set => orig.paneRight = value;
    }

    public PlayerAction paneLeft
    {
        get => orig.paneLeft;
        set => orig.paneLeft = value;
    }

    public PlayerAction pause
    {
        get => orig.pause;
        set => orig.pause = value;
    }

    public BindingSourceType LastInputType
    {
        get => orig.LastInputType;
        set => orig.LastInputType = value;
    }

    public ulong LastInputTypeChangedTick
    {
        get => orig.LastInputTypeChangedTick;
        set => orig.LastInputTypeChangedTick = value;
    }

    public InputDeviceClass LastDeviceClass
    {
        get => orig.LastDeviceClass;
        set => orig.LastDeviceClass = value;
    }

    public InputDeviceStyle LastDeviceStyle
    {
        get => orig.LastDeviceStyle;
        set => orig.LastDeviceStyle = value;
    }

    public PlayerAction listenWithAction
    {
        get => GetField<PlayerAction>();
        set => SetField(value);
    }

    public InputDevice Device
    {
        get => orig.Device;
        set => orig.Device = value;
    }

    public List<InputDevice> IncludeDevices => orig.IncludeDevices;

    public List<InputDevice> ExcludeDevices => orig.ExcludeDevices;

    public ReadOnlyCollection<PlayerAction> Actions => orig.Actions;

    public ulong UpdateTick
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

    public object UserData
    {
        get => orig.UserData;
        set => orig.UserData = value;
    }

    public bool IsListeningForBinding => orig.IsListeningForBinding;

    public BindingListenOptions ListenOptions
    {
        get => orig.ListenOptions;
        set => orig.ListenOptions = value;
    }

    public InputDevice ActiveDevice => orig.ActiveDevice;
}