using InControl;

namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of InputControl allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class InputControlR : InstanceClassWrapper<InputControl>
{
    public InputControlR(InputControl _orig) : base(_orig)
    {
    }

    public InputControl Null
    {
        get => InputControl.Null;
        set => SetField(value);
    }

    public bool Passive
    {
        get => orig.Passive;
        set => orig.Passive = value;
    }

    public ulong zeroTick
    {
        get => GetField<ulong>();
        set => SetField(value);
    }

    public bool isNullControl
    {
        get => GetField<bool>();
        set => SetField(value);
    }

    public float FirstRepeatDelay
    {
        get => orig.FirstRepeatDelay;
        set => orig.FirstRepeatDelay = value;
    }

    public float RepeatDelay
    {
        get => orig.RepeatDelay;
        set => orig.RepeatDelay = value;
    }

    public bool Raw
    {
        get => orig.Raw;
        set => orig.Raw = value;
    }

    public bool ownerEnabled
    {
        get => GetField<bool>();
        set => SetField(value);
    }

    public string Handle
    {
        get => orig.Handle;
        set => SetProperty(value);
    }

    public InputControlType Target
    {
        get => orig.Target;
        set => SetProperty(value);
    }

    public bool IsButton
    {
        get => orig.IsButton;
        set => SetProperty(value);
    }

    public bool IsAnalog
    {
        get => orig.IsAnalog;
        set => SetProperty(value);
    }

    public bool IsOnZeroTick => GetProperty<bool>();

    public bool IsStandard => orig.IsStandard;

    public ulong UpdateTick
    {
        get => orig.UpdateTick;
        set => SetProperty(value);
    }

    public bool State => orig.State;

    public bool LastState => orig.LastState;

    public float Value => orig.Value;

    public float LastValue => orig.LastValue;

    public float RawValue => orig.RawValue;

    public float NextRawValue => GetProperty<float>();

    public bool HasInput => GetProperty<bool>();

    public bool HasChanged => orig.HasChanged;

    public bool IsPressed => orig.IsPressed;

    public bool WasPressed => orig.WasPressed;

    public bool WasReleased => orig.WasReleased;

    public bool WasRepeated => orig.WasRepeated;

    public float Sensitivity
    {
        get => orig.Sensitivity;
        set => orig.Sensitivity = value;
    }

    public float LowerDeadZone
    {
        get => orig.LowerDeadZone;
        set => orig.LowerDeadZone = value;
    }

    public float UpperDeadZone
    {
        get => orig.UpperDeadZone;
        set => orig.UpperDeadZone = value;
    }

    public float StateThreshold
    {
        get => orig.StateThreshold;
        set => orig.StateThreshold = value;
    }

    public bool IsNullControl => orig.IsNullControl;

    public bool Enabled
    {
        get => orig.Enabled;
        set => orig.Enabled = value;
    }

    public bool EnabledInHierarchy => orig.EnabledInHierarchy;

    public void SetZeroTick()
    {
        CallMethod();
    }
}