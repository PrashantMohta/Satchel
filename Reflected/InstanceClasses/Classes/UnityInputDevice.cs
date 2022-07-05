using System.Collections.ObjectModel;
using InControl;

namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of UnityInputDevice allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class UnityInputDeviceR : InstanceClassWrapper<UnityInputDevice>
{
    public UnityInputDeviceR(UnityInputDevice _orig) : base(_orig)
    {
    }

    public string[,] analogQueries
    {
        get => GetFieldStatic<string[,]>();
        set => SetField(value);
    }

    public string[,] buttonQueries
    {
        get => GetFieldStatic<string[,]>();
        set => SetField(value);
    }

    public int MaxDevices
    {
        get => UnityInputDevice.MaxDevices;
        set => SetField(value);
    }

    public int MaxButtons
    {
        get => UnityInputDevice.MaxButtons;
        set => SetField(value);
    }

    public int MaxAnalogs
    {
        get => UnityInputDevice.MaxAnalogs;
        set => SetField(value);
    }

    public InputDeviceProfile profile
    {
        get => GetField<InputDeviceProfile>();
        set => SetField(value);
    }

    public bool Passive
    {
        get => orig.Passive;
        set => orig.Passive = value;
    }

    public int JoystickId
    {
        get => orig.JoystickId;
        set => SetProperty(value);
    }

    public bool IsSupportedOnThisPlatform => orig.IsSupportedOnThisPlatform;

    public bool IsKnown => orig.IsKnown;

    public int NumUnknownButtons => orig.NumUnknownButtons;

    public int NumUnknownAnalogs => orig.NumUnknownAnalogs;

    public string Name
    {
        get => orig.Name;
        set => SetProperty(value);
    }

    public string Meta
    {
        get => orig.Meta;
        set => SetProperty(value);
    }

    public int SortOrder
    {
        get => orig.SortOrder;
        set => SetProperty(value);
    }

    public InputDeviceClass DeviceClass
    {
        get => orig.DeviceClass;
        set => SetProperty(value);
    }

    public InputDeviceStyle DeviceStyle
    {
        get => orig.DeviceStyle;
        set => SetProperty(value);
    }

    public Guid GUID => orig.GUID;

    public ulong LastInputTick => orig.LastInputTick;

    public bool IsActive => orig.IsActive;

    public bool IsAttached => orig.IsAttached;

    public bool RawSticks => GetProperty<bool>();

    public ReadOnlyCollection<InputControl> Controls
    {
        get => orig.Controls;
        set => SetProperty(value);
    }

    public InputControl[] ControlsByTarget => GetProperty<InputControl[]>();

    public TwoAxisInputControl LeftStick => orig.LeftStick;

    public TwoAxisInputControl RightStick => orig.RightStick;

    public TwoAxisInputControl DPad => orig.DPad;

    public InputControlType LeftCommandControl => orig.LeftCommandControl;

    public InputControlType RightCommandControl => orig.RightCommandControl;


    public bool IsUnknown => orig.IsUnknown;

    public bool MenuIsPressed => orig.MenuIsPressed;

    public bool MenuWasPressed => orig.MenuWasPressed;

    public bool MenuWasReleased => orig.MenuWasReleased;

    public bool CommandIsPressed => orig.CommandIsPressed;

    public bool CommandWasPressed => orig.CommandWasPressed;

    public bool CommandWasReleased => orig.CommandWasReleased;

    public InputControl AnyButton => orig.AnyButton;

    public bool AnyButtonIsPressed => orig.AnyButtonIsPressed;

    public bool AnyButtonWasPressed => orig.AnyButtonWasPressed;

    public bool AnyButtonWasReleased => orig.AnyButtonWasReleased;

    public TwoAxisInputControl Direction => orig.Direction;

    public InputControl LeftStickUp => orig.LeftStickUp;

    public InputControl LeftStickDown => orig.LeftStickDown;

    public InputControl LeftStickLeft => orig.LeftStickLeft;

    public InputControl LeftStickRight => orig.LeftStickRight;

    public InputControl RightStickUp => orig.RightStickUp;

    public InputControl RightStickDown => orig.RightStickDown;

    public InputControl RightStickLeft => orig.RightStickLeft;

    public InputControl RightStickRight => orig.RightStickRight;

    public InputControl DPadUp => orig.DPadUp;

    public InputControl DPadDown => orig.DPadDown;

    public InputControl DPadLeft => orig.DPadLeft;

    public InputControl DPadRight => orig.DPadRight;

    public InputControl Action1 => orig.Action1;

    public InputControl Action2 => orig.Action2;

    public InputControl Action3 => orig.Action3;

    public InputControl Action4 => orig.Action4;

    public InputControl LeftTrigger => orig.LeftTrigger;

    public InputControl RightTrigger => orig.RightTrigger;

    public InputControl LeftBumper => orig.LeftBumper;

    public InputControl RightBumper => orig.RightBumper;

    public InputControl LeftStickButton => orig.LeftStickButton;

    public InputControl RightStickButton => orig.RightStickButton;

    public InputControl LeftStickX => orig.LeftStickX;

    public InputControl LeftStickY => orig.LeftStickY;

    public InputControl RightStickX => orig.RightStickX;

    public InputControl RightStickY => orig.RightStickY;

    public InputControl DPadX => orig.DPadX;

    public InputControl DPadY => orig.DPadY;

    public InputControl Command => orig.Command;

    public InputControl LeftCommand => orig.LeftCommand;

    public InputControl RightCommand => orig.RightCommand;

    public void Update(ulong updateTick, float deltaTime)
    {
        orig.Update(updateTick, deltaTime);
    }

    public void SetupAnalogQueries()
    {
        CallMethodStatic();
    }

    public void SetupButtonQueries()
    {
        CallMethodStatic();
    }

    public bool ReadRawButtonState(int index)
    {
        return orig.ReadRawButtonState(index);
    }

    public float ReadRawAnalogValue(int index)
    {
        return orig.ReadRawAnalogValue(index);
    }
}