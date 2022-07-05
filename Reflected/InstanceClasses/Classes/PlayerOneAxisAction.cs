using InControl;

namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of PlayerOneAxisAction allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class PlayerOneAxisActionR : InstanceClassWrapper<PlayerOneAxisAction>
{
    public PlayerOneAxisActionR(PlayerOneAxisAction _orig) : base(_orig)
    {
    }

    public PlayerAction negativeAction
    {
        get => GetField<PlayerAction>();
        set => SetField(value);
    }

    public PlayerAction positiveAction
    {
        get => GetField<PlayerAction>();
        set => SetField(value);
    }

    public BindingSourceType LastInputType
    {
        get => orig.LastInputType;
        set => orig.LastInputType = value;
    }

    public Action<BindingSourceType> OnLastInputTypeChanged
    {
        get => GetField<Action<BindingSourceType>>();
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

    public object UserData
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

    public void Update(ulong updateTick, float deltaTime)
    {
        CallMethod(new object[] { updateTick, deltaTime });
    }

    public void ProcessActionUpdate(PlayerAction action)
    {
        CallMethod(new object[] { action });
    }
}