namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of InputControl allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class InputControlR:InstanceClassWrapper<InControl.InputControl>
{
public InputControlR(InControl.InputControl _orig) : base(_orig) {}
public InControl.InputControl Null
{
get => InControl.InputControl.Null;
set => SetField(value);
}

public bool Passive
{
get => orig.Passive;
set => orig.Passive = value;
}

public System.UInt64 zeroTick
{
get => GetField<System.UInt64>();
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

public InControl.InputControlType Target
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

public bool IsOnZeroTick
{
get => GetProperty<bool>();
}

public bool IsStandard
{
get => orig.IsStandard;
}

public System.UInt64 UpdateTick
{
get => orig.UpdateTick;
set => SetProperty(value);
}

public bool State
{
get => orig.State;
}

public bool LastState
{
get => orig.LastState;
}

public float Value
{
get => orig.Value;
}

public float LastValue
{
get => orig.LastValue;
}

public float RawValue
{
get => orig.RawValue;
}

public float NextRawValue
{
get => GetProperty<float>();
}

public bool HasInput
{
get => GetProperty<bool>();
}

public bool HasChanged
{
get => orig.HasChanged;
}

public bool IsPressed
{
get => orig.IsPressed;
}

public bool WasPressed
{
get => orig.WasPressed;
}

public bool WasReleased
{
get => orig.WasReleased;
}

public bool WasRepeated
{
get => orig.WasRepeated;
}

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

public bool IsNullControl
{
get => orig.IsNullControl;
}

public bool Enabled
{
get => orig.Enabled;
set => orig.Enabled = value;
}

public bool EnabledInHierarchy
{
get => orig.EnabledInHierarchy;
}

public void SetZeroTick () =>
CallMethod();

}
}
