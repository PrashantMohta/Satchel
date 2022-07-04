using System.Collections.ObjectModel;
using InControl;

namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of InputDevice allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class InputDeviceR : InstanceClassWrapper<InputDevice>
{
    public InputDeviceR(InputDevice _orig) : base(_orig)
    {
    }

    public InputDevice Null
    {
        get => InputDevice.Null;
        set => SetField(value);
    }

    public List<InputControl> controls
    {
        get => GetField<List<InputControl>>();
        set => SetField(value);
    }

    public bool hasLeftCommandControl
    {
        get => GetField<bool>();
        set => SetField(value);
    }

    public InputControl leftCommandSource
    {
        get => GetField<InputControl>();
        set => SetField(value);
    }

    public bool hasRightCommandControl
    {
        get => GetField<bool>();
        set => SetField(value);
    }

    public InputControl rightCommandSource
    {
        get => GetField<InputControl>();
        set => SetField(value);
    }

    public bool Passive
    {
        get => orig.Passive;
        set => orig.Passive = value;
    }

    public InputControl cachedLeftStickUp
    {
        get => GetField<InputControl>();
        set => SetField(value);
    }

    public InputControl cachedLeftStickDown
    {
        get => GetField<InputControl>();
        set => SetField(value);
    }

    public InputControl cachedLeftStickLeft
    {
        get => GetField<InputControl>();
        set => SetField(value);
    }

    public InputControl cachedLeftStickRight
    {
        get => GetField<InputControl>();
        set => SetField(value);
    }

    public InputControl cachedRightStickUp
    {
        get => GetField<InputControl>();
        set => SetField(value);
    }

    public InputControl cachedRightStickDown
    {
        get => GetField<InputControl>();
        set => SetField(value);
    }

    public InputControl cachedRightStickLeft
    {
        get => GetField<InputControl>();
        set => SetField(value);
    }

    public InputControl cachedRightStickRight
    {
        get => GetField<InputControl>();
        set => SetField(value);
    }

    public InputControl cachedDPadUp
    {
        get => GetField<InputControl>();
        set => SetField(value);
    }

    public InputControl cachedDPadDown
    {
        get => GetField<InputControl>();
        set => SetField(value);
    }

    public InputControl cachedDPadLeft
    {
        get => GetField<InputControl>();
        set => SetField(value);
    }

    public InputControl cachedDPadRight
    {
        get => GetField<InputControl>();
        set => SetField(value);
    }

    public InputControl cachedAction1
    {
        get => GetField<InputControl>();
        set => SetField(value);
    }

    public InputControl cachedAction2
    {
        get => GetField<InputControl>();
        set => SetField(value);
    }

    public InputControl cachedAction3
    {
        get => GetField<InputControl>();
        set => SetField(value);
    }

    public InputControl cachedAction4
    {
        get => GetField<InputControl>();
        set => SetField(value);
    }

    public InputControl cachedLeftTrigger
    {
        get => GetField<InputControl>();
        set => SetField(value);
    }

    public InputControl cachedRightTrigger
    {
        get => GetField<InputControl>();
        set => SetField(value);
    }

    public InputControl cachedLeftBumper
    {
        get => GetField<InputControl>();
        set => SetField(value);
    }

    public InputControl cachedRightBumper
    {
        get => GetField<InputControl>();
        set => SetField(value);
    }

    public InputControl cachedLeftStickButton
    {
        get => GetField<InputControl>();
        set => SetField(value);
    }

    public InputControl cachedRightStickButton
    {
        get => GetField<InputControl>();
        set => SetField(value);
    }

    public InputControl cachedLeftStickX
    {
        get => GetField<InputControl>();
        set => SetField(value);
    }

    public InputControl cachedLeftStickY
    {
        get => GetField<InputControl>();
        set => SetField(value);
    }

    public InputControl cachedRightStickX
    {
        get => GetField<InputControl>();
        set => SetField(value);
    }

    public InputControl cachedRightStickY
    {
        get => GetField<InputControl>();
        set => SetField(value);
    }

    public InputControl cachedDPadX
    {
        get => GetField<InputControl>();
        set => SetField(value);
    }

    public InputControl cachedDPadY
    {
        get => GetField<InputControl>();
        set => SetField(value);
    }

    public InputControl cachedCommand
    {
        get => GetField<InputControl>();
        set => SetField(value);
    }

    public InputControl cachedLeftCommand
    {
        get => GetField<InputControl>();
        set => SetField(value);
    }

    public InputControl cachedRightCommand
    {
        get => GetField<InputControl>();
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

    public Guid GUID
    {
        get => orig.GUID;
        set => SetProperty(value);
    }

    public ulong LastInputTick
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

    public ReadOnlyCollection<InputControl> Controls
    {
        get => orig.Controls;
        set => SetProperty(value);
    }

    public InputControl[] ControlsByTarget
    {
        get => GetProperty<InputControl[]>();
        set => SetProperty(value);
    }

    public TwoAxisInputControl LeftStick
    {
        get => orig.LeftStick;
        set => SetProperty(value);
    }

    public TwoAxisInputControl RightStick
    {
        get => orig.RightStick;
        set => SetProperty(value);
    }

    public TwoAxisInputControl DPad
    {
        get => orig.DPad;
        set => SetProperty(value);
    }

    public InputControlType LeftCommandControl
    {
        get => orig.LeftCommandControl;
        set => SetProperty(value);
    }

    public InputControlType RightCommandControl
    {
        get => orig.RightCommandControl;
        set => SetProperty(value);
    }

    public bool IsSupportedOnThisPlatform => orig.IsSupportedOnThisPlatform;

    public bool IsKnown => orig.IsKnown;

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

    public int NumUnknownAnalogs => orig.NumUnknownAnalogs;

    public int NumUnknownButtons => orig.NumUnknownButtons;

    public void OnAttached()
    {
        CallMethod();
    }

    public void OnDetached()
    {
        CallMethod();
    }

    public void AddAliasControls()
    {
        CallMethod();
    }

    public void RemoveAliasControls()
    {
        CallMethod();
    }

    public void ClearControls()
    {
        CallMethod();
    }

    public bool HasControl(InputControlType controlType)
    {
        return orig.HasControl(controlType);
    }

    public InputControl GetControl(InputControlType controlType)
    {
        return orig.GetControl(controlType);
    }

    public InputControlType GetInputControlTypeByName(string inputControlName)
    {
        return InputDevice.GetInputControlTypeByName(inputControlName);
    }

    public InputControl GetControlByName(string controlName)
    {
        return orig.GetControlByName(controlName);
    }

    public InputControl AddControl(InputControlType controlType, string handle)
    {
        return orig.AddControl(controlType, handle);
    }

    public InputControl AddControl(InputControlType controlType, string handle, float lowerDeadZone,
        float upperDeadZone)
    {
        return orig.AddControl(controlType, handle, lowerDeadZone, upperDeadZone);
    }

    public void RemoveControl(InputControlType controlType)
    {
        CallMethod(new object[] { controlType });
    }

    public void ClearInputState()
    {
        orig.ClearInputState();
    }

    public void UpdateWithState(InputControlType controlType, bool state, ulong updateTick, float deltaTime)
    {
        CallMethod(new object[] { controlType, state, updateTick, deltaTime });
    }

    public void UpdateWithValue(InputControlType controlType, float value, ulong updateTick, float deltaTime)
    {
        CallMethod(new object[] { controlType, value, updateTick, deltaTime });
    }

    public void UpdateLeftStickWithValue(Vector2 value, ulong updateTick, float deltaTime)
    {
        orig.UpdateLeftStickWithValue(value, updateTick, deltaTime);
    }

    public void UpdateLeftStickWithRawValue(Vector2 value, ulong updateTick, float deltaTime)
    {
        orig.UpdateLeftStickWithRawValue(value, updateTick, deltaTime);
    }

    public void CommitLeftStick()
    {
        orig.CommitLeftStick();
    }

    public void UpdateRightStickWithValue(Vector2 value, ulong updateTick, float deltaTime)
    {
        orig.UpdateRightStickWithValue(value, updateTick, deltaTime);
    }

    public void UpdateRightStickWithRawValue(Vector2 value, ulong updateTick, float deltaTime)
    {
        orig.UpdateRightStickWithRawValue(value, updateTick, deltaTime);
    }

    public void CommitRightStick()
    {
        orig.CommitRightStick();
    }

    public void Update(ulong updateTick, float deltaTime)
    {
        orig.Update(updateTick, deltaTime);
    }

    public void ProcessLeftStick(ulong updateTick, float deltaTime)
    {
        CallMethod(new object[] { updateTick, deltaTime });
    }

    public void ProcessRightStick(ulong updateTick, float deltaTime)
    {
        CallMethod(new object[] { updateTick, deltaTime });
    }

    public void ProcessDPad(ulong updateTick, float deltaTime)
    {
        CallMethod(new object[] { updateTick, deltaTime });
    }

    public void Commit(ulong updateTick, float deltaTime)
    {
        orig.Commit(updateTick, deltaTime);
    }

    public bool LastInputAfter(InputDevice device)
    {
        return orig.LastInputAfter(device);
    }

    public void RequestActivation()
    {
        orig.RequestActivation();
    }

    public void Vibrate(float leftMotor, float rightMotor)
    {
        orig.Vibrate(leftMotor, rightMotor);
    }

    public void Vibrate(float intensity)
    {
        orig.Vibrate(intensity);
    }

    public void StopVibration()
    {
        orig.StopVibration();
    }

    public void SetLightColor(float red, float green, float blue)
    {
        orig.SetLightColor(red, green, blue);
    }

    public void SetLightColor(Color color)
    {
        orig.SetLightColor(color);
    }

    public void SetLightFlash(float flashOnDuration, float flashOffDuration)
    {
        orig.SetLightFlash(flashOnDuration, flashOffDuration);
    }

    public void StopLightFlash()
    {
        orig.StopLightFlash();
    }

    public void ExpireControlCache()
    {
        CallMethod();
    }

    public bool ReadRawButtonState(int index)
    {
        return orig.ReadRawButtonState(index);
    }

    public float ReadRawAnalogValue(int index)
    {
        return orig.ReadRawAnalogValue(index);
    }

    public void TakeSnapshot()
    {
        orig.TakeSnapshot();
    }

    public UnknownDeviceControl GetFirstPressedAnalog()
    {
        return orig.GetFirstPressedAnalog();
    }

    public UnknownDeviceControl GetFirstPressedButton()
    {
        return orig.GetFirstPressedButton();
    }
}