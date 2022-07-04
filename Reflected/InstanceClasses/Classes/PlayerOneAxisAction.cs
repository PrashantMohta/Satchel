namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of PlayerOneAxisAction allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class PlayerOneAxisActionR:InstanceClassWrapper<InControl.PlayerOneAxisAction>
{
public PlayerOneAxisActionR(InControl.PlayerOneAxisAction _orig) : base(_orig) {}
public InControl.PlayerAction negativeAction
{
get => GetField<InControl.PlayerAction>();
set => SetField(value);
}

public InControl.PlayerAction positiveAction
{
get => GetField<InControl.PlayerAction>();
set => SetField(value);
}

public InControl.BindingSourceType LastInputType
{
get => orig.LastInputType;
set => orig.LastInputType = value;
}

public System.Action<InControl.BindingSourceType> OnLastInputTypeChanged
{
get => GetField<System.Action<InControl.BindingSourceType>>();
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

public System.Object UserData
{
get => orig.UserData;
set => orig.UserData = value;
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

public void Update (System.UInt64 updateTick, float deltaTime) =>
CallMethod(new object[] {updateTick, deltaTime});

public void ProcessActionUpdate (InControl.PlayerAction action) =>
CallMethod(new object[] {action});

}
}
