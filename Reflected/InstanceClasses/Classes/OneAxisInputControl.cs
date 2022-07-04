namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of OneAxisInputControl allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class OneAxisInputControlR:InstanceClassWrapper<InControl.OneAxisInputControl>
{
public OneAxisInputControlR(InControl.OneAxisInputControl _orig) : base(_orig) {}
public float sensitivity
{
get => GetField<float>();
set => SetField(value);
}

public float lowerDeadZone
{
get => GetField<float>();
set => SetField(value);
}

public float upperDeadZone
{
get => GetField<float>();
set => SetField(value);
}

public float stateThreshold
{
get => GetField<float>();
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

public bool enabled
{
get => GetField<bool>();
set => SetField(value);
}

public bool ownerEnabled
{
get => GetField<bool>();
set => SetField(value);
}

public System.UInt64 pendingTick
{
get => GetField<System.UInt64>();
set => SetField(value);
}

public bool pendingCommit
{
get => GetField<bool>();
set => SetField(value);
}

public float nextRepeatTime
{
get => GetField<float>();
set => SetField(value);
}

public bool wasRepeated
{
get => GetField<bool>();
set => SetField(value);
}

public bool clearInputState
{
get => GetField<bool>();
set => SetField(value);
}

public InControl.InputControlState lastState
{
get => GetField<InControl.InputControlState>();
set => SetField(value);
}

public InControl.InputControlState nextState
{
get => GetField<InControl.InputControlState>();
set => SetField(value);
}

public InControl.InputControlState thisState
{
get => GetField<InControl.InputControlState>();
set => SetField(value);
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

public void PrepareForUpdate (System.UInt64 updateTick) =>
CallMethod(new object[] {updateTick});

public bool UpdateWithState (bool state, System.UInt64 updateTick, float deltaTime) =>
orig.UpdateWithState(state, updateTick, deltaTime);

public bool UpdateWithValue (float value, System.UInt64 updateTick, float deltaTime) =>
orig.UpdateWithValue(value, updateTick, deltaTime);

public bool UpdateWithRawValue (float value, System.UInt64 updateTick, float deltaTime) =>
CallMethod<bool>(new object[] {value, updateTick, deltaTime});

public void SetValue (float value, System.UInt64 updateTick) =>
CallMethod(new object[] {value, updateTick});

public void ClearInputState () =>
orig.ClearInputState();

public void Commit () =>
orig.Commit();

public void CommitWithState (bool state, System.UInt64 updateTick, float deltaTime) =>
orig.CommitWithState(state, updateTick, deltaTime);

public void CommitWithValue (float value, System.UInt64 updateTick, float deltaTime) =>
orig.CommitWithValue(value, updateTick, deltaTime);

public void CommitWithSides (InControl.InputControl negativeSide, InControl.InputControl positiveSide, System.UInt64 updateTick, float deltaTime) =>
CallMethod(new object[] {negativeSide, positiveSide, updateTick, deltaTime});

}
}
