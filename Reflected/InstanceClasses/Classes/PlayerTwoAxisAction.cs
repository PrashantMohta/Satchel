using InControl;

namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of PlayerTwoAxisAction allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class PlayerTwoAxisActionR : InstanceClassWrapper<PlayerTwoAxisAction>
{
    public PlayerTwoAxisActionR(PlayerTwoAxisAction _orig) : base(_orig)
    {
    }

    public PlayerAction negativeXAction
    {
        get => GetField<PlayerAction>();
        set => SetField(value);
    }

    public PlayerAction positiveXAction
    {
        get => GetField<PlayerAction>();
        set => SetField(value);
    }

    public PlayerAction negativeYAction
    {
        get => GetField<PlayerAction>();
        set => SetField(value);
    }

    public PlayerAction positiveYAction
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

    public DeadZoneFunc DeadZoneFunc
    {
        get => orig.DeadZoneFunc;
        set => orig.DeadZoneFunc = value;
    }

    public bool Raw
    {
        get => orig.Raw;
        set => orig.Raw = value;
    }

    public bool InvertXAxis
    {
        get => orig.InvertXAxis;
        set => orig.InvertXAxis = value;
    }

    public bool InvertYAxis
    {
        get => orig.InvertYAxis;
        set => orig.InvertYAxis = value;
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

    public float X
    {
        get => orig.X;
        set => SetProperty(value);
    }

    public float Y
    {
        get => orig.Y;
        set => SetProperty(value);
    }

    public OneAxisInputControl Left
    {
        get => orig.Left;
        set => SetProperty(value);
    }

    public OneAxisInputControl Right
    {
        get => orig.Right;
        set => SetProperty(value);
    }

    public OneAxisInputControl Up
    {
        get => orig.Up;
        set => SetProperty(value);
    }

    public OneAxisInputControl Down
    {
        get => orig.Down;
        set => SetProperty(value);
    }

    public ulong UpdateTick
    {
        get => orig.UpdateTick;
        set => SetProperty(value);
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

    public bool State => orig.State;

    public bool LastState => orig.LastState;

    public Vector2 Value => orig.Value;

    public Vector2 LastValue => orig.LastValue;

    public Vector2 Vector => orig.Vector;

    public bool HasChanged
    {
        get => orig.HasChanged;
        set => SetProperty(value);
    }

    public bool IsPressed => orig.IsPressed;

    public bool WasPressed => orig.WasPressed;

    public bool WasReleased => orig.WasReleased;

    public float Angle => orig.Angle;

    public void Update(ulong updateTick, float deltaTime)
    {
        CallMethod(new object[] { updateTick, deltaTime });
    }

    public void ProcessActionUpdate(PlayerAction action)
    {
        CallMethod(new object[] { action });
    }
}