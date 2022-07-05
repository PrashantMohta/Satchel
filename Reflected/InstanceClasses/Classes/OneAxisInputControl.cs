using InControl;

namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of OneAxisInputControl allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class OneAxisInputControlR : InstanceClassWrapper<OneAxisInputControl>
{
    public OneAxisInputControlR(OneAxisInputControl _orig) : base(_orig)
    {
    }

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

    public ulong pendingTick
    {
        get => GetField<ulong>();
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

    public InputControlState lastState
    {
        get => GetField<InputControlState>();
        set => SetField(value);
    }

    public InputControlState nextState
    {
        get => GetField<InputControlState>();
        set => SetField(value);
    }

    public InputControlState thisState
    {
        get => GetField<InputControlState>();
        set => SetField(value);
    }

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

    public void PrepareForUpdate(ulong updateTick)
    {
        CallMethod(new object[] { updateTick });
    }

    public bool UpdateWithState(bool state, ulong updateTick, float deltaTime)
    {
        return orig.UpdateWithState(state, updateTick, deltaTime);
    }

    public bool UpdateWithValue(float value, ulong updateTick, float deltaTime)
    {
        return orig.UpdateWithValue(value, updateTick, deltaTime);
    }

    public bool UpdateWithRawValue(float value, ulong updateTick, float deltaTime)
    {
        return CallMethod<bool>(new object[] { value, updateTick, deltaTime });
    }

    public void SetValue(float value, ulong updateTick)
    {
        CallMethod(new object[] { value, updateTick });
    }

    public void ClearInputState()
    {
        orig.ClearInputState();
    }

    public void Commit()
    {
        orig.Commit();
    }

    public void CommitWithState(bool state, ulong updateTick, float deltaTime)
    {
        orig.CommitWithState(state, updateTick, deltaTime);
    }

    public void CommitWithValue(float value, ulong updateTick, float deltaTime)
    {
        orig.CommitWithValue(value, updateTick, deltaTime);
    }

    public void CommitWithSides(InputControl negativeSide, InputControl positiveSide, ulong updateTick, float deltaTime)
    {
        CallMethod(new object[] { negativeSide, positiveSide, updateTick, deltaTime });
    }
}