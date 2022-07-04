namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of UnityInputDevice allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class UnityInputDeviceR:InstanceClassWrapper<InControl.UnityInputDevice>
{
public UnityInputDeviceR(InControl.UnityInputDevice _orig) : base(_orig) {}
public System.String[,] analogQueries
{
get => GetFieldStatic<System.String[,]>();
set => SetField(value);
}

public System.String[,] buttonQueries
{
get => GetFieldStatic<System.String[,]>();
set => SetField(value);
}

public int MaxDevices
{
get => InControl.UnityInputDevice.MaxDevices;
set =>SetField(value);
}

public int MaxButtons
{
get => InControl.UnityInputDevice.MaxButtons;
set => SetField(value);
}

public int MaxAnalogs
{
get => InControl.UnityInputDevice.MaxAnalogs;
set => SetField(value);
}

public InControl.InputDeviceProfile profile
{
get => GetField<InControl.InputDeviceProfile>();
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

public bool IsSupportedOnThisPlatform
{
get => orig.IsSupportedOnThisPlatform;
}

public bool IsKnown
{
get => orig.IsKnown;
}

public int NumUnknownButtons
{
get => orig.NumUnknownButtons;
}

public int NumUnknownAnalogs
{
get => orig.NumUnknownAnalogs;
}

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

public InControl.InputDeviceClass DeviceClass
{
get => orig.DeviceClass;
set => SetProperty(value);
}

public InControl.InputDeviceStyle DeviceStyle
{
get => orig.DeviceStyle;
set => SetProperty(value);
}

public System.Guid GUID
{
get => orig.GUID;
}

public System.UInt64 LastInputTick
{
get => orig.LastInputTick;
}

public bool IsActive
{
get => orig.IsActive;
}

public bool IsAttached
{
get => orig.IsAttached;
}

public bool RawSticks
{
get => GetProperty<bool>();
}

public System.Collections.ObjectModel.ReadOnlyCollection<InControl.InputControl> Controls
{
get => orig.Controls;
set => SetProperty(value);
}

public InControl.InputControl[] ControlsByTarget
{
get => GetProperty<InControl.InputControl[]>();
}

public InControl.TwoAxisInputControl LeftStick
{
get => orig.LeftStick;
}

public InControl.TwoAxisInputControl RightStick
{
get => orig.RightStick;
}

public InControl.TwoAxisInputControl DPad
{
get => orig.DPad;
}

public InControl.InputControlType LeftCommandControl
{
get => orig.LeftCommandControl;
}

public InControl.InputControlType RightCommandControl
{
get => orig.RightCommandControl;
}



public bool IsUnknown
{
get => orig.IsUnknown;
}

public bool MenuIsPressed
{
get => orig.MenuIsPressed;
}

public bool MenuWasPressed
{
get => orig.MenuWasPressed;
}

public bool MenuWasReleased
{
get => orig.MenuWasReleased;
}

public bool CommandIsPressed
{
get => orig.CommandIsPressed;
}

public bool CommandWasPressed
{
get => orig.CommandWasPressed;
}

public bool CommandWasReleased
{
get => orig.CommandWasReleased;
}

public InControl.InputControl AnyButton
{
get => orig.AnyButton;
}

public bool AnyButtonIsPressed
{
get => orig.AnyButtonIsPressed;
}

public bool AnyButtonWasPressed
{
get => orig.AnyButtonWasPressed;
}

public bool AnyButtonWasReleased
{
get => orig.AnyButtonWasReleased;
}

public InControl.TwoAxisInputControl Direction
{
get => orig.Direction;
}

public InControl.InputControl LeftStickUp
{
get => orig.LeftStickUp;
}

public InControl.InputControl LeftStickDown
{
get => orig.LeftStickDown;
}

public InControl.InputControl LeftStickLeft
{
get => orig.LeftStickLeft;
}

public InControl.InputControl LeftStickRight
{
get => orig.LeftStickRight;
}

public InControl.InputControl RightStickUp
{
get => orig.RightStickUp;
}

public InControl.InputControl RightStickDown
{
get => orig.RightStickDown;
}

public InControl.InputControl RightStickLeft
{
get => orig.RightStickLeft;
}

public InControl.InputControl RightStickRight
{
get => orig.RightStickRight;
}

public InControl.InputControl DPadUp
{
get => orig.DPadUp;
}

public InControl.InputControl DPadDown
{
get => orig.DPadDown;
}

public InControl.InputControl DPadLeft
{
get => orig.DPadLeft;
}

public InControl.InputControl DPadRight
{
get => orig.DPadRight;
}

public InControl.InputControl Action1
{
get => orig.Action1;
}

public InControl.InputControl Action2
{
get => orig.Action2;
}

public InControl.InputControl Action3
{
get => orig.Action3;
}

public InControl.InputControl Action4
{
get => orig.Action4;
}

public InControl.InputControl LeftTrigger
{
get => orig.LeftTrigger;
}

public InControl.InputControl RightTrigger
{
get => orig.RightTrigger;
}

public InControl.InputControl LeftBumper
{
get => orig.LeftBumper;
}

public InControl.InputControl RightBumper
{
get => orig.RightBumper;
}

public InControl.InputControl LeftStickButton
{
get => orig.LeftStickButton;
}

public InControl.InputControl RightStickButton
{
get => orig.RightStickButton;
}

public InControl.InputControl LeftStickX
{
get => orig.LeftStickX;
}

public InControl.InputControl LeftStickY
{
get => orig.LeftStickY;
}

public InControl.InputControl RightStickX
{
get => orig.RightStickX;
}

public InControl.InputControl RightStickY
{
get => orig.RightStickY;
}

public InControl.InputControl DPadX
{
get => orig.DPadX;
}

public InControl.InputControl DPadY
{
get => orig.DPadY;
}

public InControl.InputControl Command
{
get => orig.Command;
}

public InControl.InputControl LeftCommand
{
get => orig.LeftCommand;
}

public InControl.InputControl RightCommand
{
get => orig.RightCommand;
}

public void Update (System.UInt64 updateTick, float deltaTime) =>
orig.Update(updateTick, deltaTime);

public void SetupAnalogQueries () =>
CallMethodStatic();

public void SetupButtonQueries () =>
CallMethodStatic();

public bool ReadRawButtonState (int index) =>
orig.ReadRawButtonState(index);

public float ReadRawAnalogValue (int index) =>
orig.ReadRawAnalogValue(index);

}
}
