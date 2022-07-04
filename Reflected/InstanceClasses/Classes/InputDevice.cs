namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of InputDevice allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class InputDeviceR:InstanceClassWrapper<InControl.InputDevice>
{
public InputDeviceR(InControl.InputDevice _orig) : base(_orig) {}
public InControl.InputDevice Null
{
get => InControl.InputDevice.Null;
set => SetField(value);
}

public System.Collections.Generic.List<InControl.InputControl> controls
{
get => GetField<System.Collections.Generic.List<InControl.InputControl>>();
set => SetField(value);
}

public bool hasLeftCommandControl
{
get => GetField<bool>();
set => SetField(value);
}

public InControl.InputControl leftCommandSource
{
get => GetField<InControl.InputControl>();
set => SetField(value);
}

public bool hasRightCommandControl
{
get => GetField<bool>();
set => SetField(value);
}

public InControl.InputControl rightCommandSource
{
get => GetField<InControl.InputControl>();
set => SetField(value);
}

public bool Passive
{
get => orig.Passive;
set => orig.Passive = value;
}

public InControl.InputControl cachedLeftStickUp
{
get => GetField<InControl.InputControl>();
set => SetField(value);
}

public InControl.InputControl cachedLeftStickDown
{
get => GetField<InControl.InputControl>();
set => SetField(value);
}

public InControl.InputControl cachedLeftStickLeft
{
get => GetField<InControl.InputControl>();
set => SetField(value);
}

public InControl.InputControl cachedLeftStickRight
{
get => GetField<InControl.InputControl>();
set => SetField(value);
}

public InControl.InputControl cachedRightStickUp
{
get => GetField<InControl.InputControl>();
set => SetField(value);
}

public InControl.InputControl cachedRightStickDown
{
get => GetField<InControl.InputControl>();
set => SetField(value);
}

public InControl.InputControl cachedRightStickLeft
{
get => GetField<InControl.InputControl>();
set => SetField(value);
}

public InControl.InputControl cachedRightStickRight
{
get => GetField<InControl.InputControl>();
set => SetField(value);
}

public InControl.InputControl cachedDPadUp
{
get => GetField<InControl.InputControl>();
set => SetField(value);
}

public InControl.InputControl cachedDPadDown
{
get => GetField<InControl.InputControl>();
set => SetField(value);
}

public InControl.InputControl cachedDPadLeft
{
get => GetField<InControl.InputControl>();
set => SetField(value);
}

public InControl.InputControl cachedDPadRight
{
get => GetField<InControl.InputControl>();
set => SetField(value);
}

public InControl.InputControl cachedAction1
{
get => GetField<InControl.InputControl>();
set => SetField(value);
}

public InControl.InputControl cachedAction2
{
get => GetField<InControl.InputControl>();
set => SetField(value);
}

public InControl.InputControl cachedAction3
{
get => GetField<InControl.InputControl>();
set => SetField(value);
}

public InControl.InputControl cachedAction4
{
get => GetField<InControl.InputControl>();
set => SetField(value);
}

public InControl.InputControl cachedLeftTrigger
{
get => GetField<InControl.InputControl>();
set => SetField(value);
}

public InControl.InputControl cachedRightTrigger
{
get => GetField<InControl.InputControl>();
set => SetField(value);
}

public InControl.InputControl cachedLeftBumper
{
get => GetField<InControl.InputControl>();
set => SetField(value);
}

public InControl.InputControl cachedRightBumper
{
get => GetField<InControl.InputControl>();
set => SetField(value);
}

public InControl.InputControl cachedLeftStickButton
{
get => GetField<InControl.InputControl>();
set => SetField(value);
}

public InControl.InputControl cachedRightStickButton
{
get => GetField<InControl.InputControl>();
set => SetField(value);
}

public InControl.InputControl cachedLeftStickX
{
get => GetField<InControl.InputControl>();
set => SetField(value);
}

public InControl.InputControl cachedLeftStickY
{
get => GetField<InControl.InputControl>();
set => SetField(value);
}

public InControl.InputControl cachedRightStickX
{
get => GetField<InControl.InputControl>();
set => SetField(value);
}

public InControl.InputControl cachedRightStickY
{
get => GetField<InControl.InputControl>();
set => SetField(value);
}

public InControl.InputControl cachedDPadX
{
get => GetField<InControl.InputControl>();
set => SetField(value);
}

public InControl.InputControl cachedDPadY
{
get => GetField<InControl.InputControl>();
set => SetField(value);
}

public InControl.InputControl cachedCommand
{
get => GetField<InControl.InputControl>();
set => SetField(value);
}

public InControl.InputControl cachedLeftCommand
{
get => GetField<InControl.InputControl>();
set => SetField(value);
}

public InControl.InputControl cachedRightCommand
{
get => GetField<InControl.InputControl>();
set => SetField(value);
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
set => SetProperty(value);
}

public System.UInt64 LastInputTick
{
get => orig.LastInputTick;
set => SetProperty(value);
}

public bool IsActive
{
get => orig.IsActive;
set => SetProperty(value);
}

public bool IsAttached
{
get => orig.IsAttached;
set => SetProperty(value);
}

public bool RawSticks
{
get => GetProperty<bool>();
set => SetProperty(value);
}

public System.Collections.ObjectModel.ReadOnlyCollection<InControl.InputControl> Controls
{
get => orig.Controls;
set => SetProperty(value);
}

public InControl.InputControl[] ControlsByTarget
{
get => GetProperty<InControl.InputControl[]>();
set => SetProperty(value);
}

public InControl.TwoAxisInputControl LeftStick
{
get => orig.LeftStick;
set => SetProperty(value);
}

public InControl.TwoAxisInputControl RightStick
{
get => orig.RightStick;
set => SetProperty(value);
}

public InControl.TwoAxisInputControl DPad
{
get => orig.DPad;
set => SetProperty(value);
}

public InControl.InputControlType LeftCommandControl
{
get => orig.LeftCommandControl;
set => SetProperty(value);
}

public InControl.InputControlType RightCommandControl
{
get => orig.RightCommandControl;
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

public int NumUnknownAnalogs
{
get => orig.NumUnknownAnalogs;
}

public int NumUnknownButtons
{
get => orig.NumUnknownButtons;
}

public void OnAttached () =>
CallMethod();

public void OnDetached () =>
CallMethod();

public void AddAliasControls () =>
CallMethod();

public void RemoveAliasControls () =>
CallMethod();

public void ClearControls () =>
CallMethod();

public bool HasControl (InControl.InputControlType controlType) =>
orig.HasControl(controlType);

public InControl.InputControl GetControl (InControl.InputControlType controlType) =>
orig.GetControl(controlType);

public InControl.InputControlType GetInputControlTypeByName (string inputControlName) =>
InControl.InputDevice.GetInputControlTypeByName(inputControlName);

public InControl.InputControl GetControlByName (string controlName) =>
orig.GetControlByName(controlName);

public InControl.InputControl AddControl (InControl.InputControlType controlType, string handle) =>
orig.AddControl(controlType, handle);

public InControl.InputControl AddControl (InControl.InputControlType controlType, string handle, float lowerDeadZone, float upperDeadZone) =>
orig.AddControl(controlType, handle, lowerDeadZone, upperDeadZone);

public void RemoveControl (InControl.InputControlType controlType) =>
CallMethod(new object[] {controlType});

public void ClearInputState () =>
orig.ClearInputState();

public void UpdateWithState (InControl.InputControlType controlType, bool state, System.UInt64 updateTick, float deltaTime) =>
CallMethod(new object[] {controlType, state, updateTick, deltaTime});

public void UpdateWithValue (InControl.InputControlType controlType, float value, System.UInt64 updateTick, float deltaTime) =>
CallMethod(new object[] {controlType, value, updateTick, deltaTime});

public void UpdateLeftStickWithValue (UnityEngine.Vector2 value, System.UInt64 updateTick, float deltaTime) =>
orig.UpdateLeftStickWithValue(value, updateTick, deltaTime);

public void UpdateLeftStickWithRawValue (UnityEngine.Vector2 value, System.UInt64 updateTick, float deltaTime) =>
orig.UpdateLeftStickWithRawValue(value, updateTick, deltaTime);

public void CommitLeftStick () =>
orig.CommitLeftStick();

public void UpdateRightStickWithValue (UnityEngine.Vector2 value, System.UInt64 updateTick, float deltaTime) =>
orig.UpdateRightStickWithValue(value, updateTick, deltaTime);

public void UpdateRightStickWithRawValue (UnityEngine.Vector2 value, System.UInt64 updateTick, float deltaTime) =>
orig.UpdateRightStickWithRawValue(value, updateTick, deltaTime);

public void CommitRightStick () =>
orig.CommitRightStick();

public void Update (System.UInt64 updateTick, float deltaTime) =>
orig.Update(updateTick, deltaTime);

public void ProcessLeftStick (System.UInt64 updateTick, float deltaTime) =>
CallMethod(new object[] {updateTick, deltaTime});

public void ProcessRightStick (System.UInt64 updateTick, float deltaTime) =>
CallMethod(new object[] {updateTick, deltaTime});

public void ProcessDPad (System.UInt64 updateTick, float deltaTime) =>
CallMethod(new object[] {updateTick, deltaTime});

public void Commit (System.UInt64 updateTick, float deltaTime) =>
orig.Commit(updateTick, deltaTime);

public bool LastInputAfter (InControl.InputDevice device) =>
orig.LastInputAfter(device);

public void RequestActivation () =>
orig.RequestActivation();

public void Vibrate (float leftMotor, float rightMotor) =>
orig.Vibrate(leftMotor, rightMotor);

public void Vibrate (float intensity) =>
orig.Vibrate(intensity);

public void StopVibration () =>
orig.StopVibration();

public void SetLightColor (float red, float green, float blue) =>
orig.SetLightColor(red, green, blue);

public void SetLightColor (UnityEngine.Color color) =>
orig.SetLightColor(color);

public void SetLightFlash (float flashOnDuration, float flashOffDuration) =>
orig.SetLightFlash(flashOnDuration, flashOffDuration);

public void StopLightFlash () =>
orig.StopLightFlash();

public void ExpireControlCache () =>
CallMethod();

public bool ReadRawButtonState (int index) =>
orig.ReadRawButtonState(index);

public float ReadRawAnalogValue (int index) =>
orig.ReadRawAnalogValue(index);

public void TakeSnapshot () =>
orig.TakeSnapshot();

public InControl.UnknownDeviceControl GetFirstPressedAnalog () =>
orig.GetFirstPressedAnalog();

public InControl.UnknownDeviceControl GetFirstPressedButton () =>
orig.GetFirstPressedButton();

}
}
