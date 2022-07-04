namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of NativeInputDevice allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class NativeInputDeviceR:InstanceClassWrapper<InControl.NativeInputDevice>
{
public NativeInputDeviceR(InControl.NativeInputDevice _orig) : base(_orig) {}
public int maxUnknownButtons
{
get => GetFieldStatic<int>();
set => SetField(value);
}

public int maxUnknownAnalogs
{
get => GetFieldStatic<int>();
set => SetField(value);
}

public System.Int16[] buttons
{
get => GetField<System.Int16[]>();
set => SetField(value);
}

public System.Int16[] analogs
{
get => GetField<System.Int16[]>();
set => SetField(value);
}

public InControl.InputDeviceProfile profile
{
get => GetField<InControl.InputDeviceProfile>();
set => SetField(value);
}

public int skipUpdateFrames
{
get => GetField<int>();
set => SetField(value);
}

public int numUnknownButtons
{
get => GetField<int>();
set => SetField(value);
}

public int numUnknownAnalogs
{
get => GetField<int>();
set => SetField(value);
}

public InControl.InputControlSource[] controlSourceByTarget
{
get => GetField<InControl.InputControlSource[]>();
set => SetField(value);
}

public System.Text.StringBuilder glyphName
{
get => GetField<System.Text.StringBuilder>();
set => SetField(value);
}

public string defaultGlyphName
{
get => GetFieldStatic<string>();
set => SetField(value);
}

public bool Passive
{
get => orig.Passive;
set => orig.Passive = value;
}

public System.UInt32 Handle
{
get => orig.Handle;
set => SetProperty(value);
}

public InControl.InputDeviceInfo Info
{
get => orig.Info;
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

public void Initialize (System.UInt32 deviceHandle, InControl.InputDeviceInfo deviceInfo, InControl.InputDeviceProfile deviceProfile) =>
CallMethod(new object[] {deviceHandle, deviceInfo, deviceProfile});

public void Initialize (System.UInt32 deviceHandle, InControl.InputDeviceInfo deviceInfo) =>
CallMethod(new object[] {deviceHandle, deviceInfo});

public void Update (System.UInt64 updateTick, float deltaTime) =>
orig.Update(updateTick, deltaTime);

public bool ReadRawButtonState (int index) =>
orig.ReadRawButtonState(index);

public float ReadRawAnalogValue (int index) =>
orig.ReadRawAnalogValue(index);

public System.Byte FloatToByte (float value) =>
CallMethodStatic<System.Byte>(new object[] {value});

public void Vibrate (float leftMotor, float rightMotor) =>
orig.Vibrate(leftMotor, rightMotor);

public void SetLightColor (float red, float green, float blue) =>
orig.SetLightColor(red, green, blue);

public void SetLightFlash (float flashOnDuration, float flashOffDuration) =>
orig.SetLightFlash(flashOnDuration, flashOffDuration);

public string GetAppleGlyphNameForControl (InControl.InputControlType controlType) =>
orig.GetAppleGlyphNameForControl(controlType);

public bool HasSameVendorID (InControl.InputDeviceInfo deviceInfo) =>
orig.HasSameVendorID(deviceInfo);

public bool HasSameProductID (InControl.InputDeviceInfo deviceInfo) =>
orig.HasSameProductID(deviceInfo);

public bool HasSameVersionNumber (InControl.InputDeviceInfo deviceInfo) =>
orig.HasSameVersionNumber(deviceInfo);

public bool HasSameLocation (InControl.InputDeviceInfo deviceInfo) =>
orig.HasSameLocation(deviceInfo);

public bool HasSameSerialNumber (InControl.InputDeviceInfo deviceInfo) =>
orig.HasSameSerialNumber(deviceInfo);

}
}
