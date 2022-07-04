using InControl;

namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of TwoAxisInputControl allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class TwoAxisInputControlR : InstanceClassWrapper<TwoAxisInputControl>
{
    public TwoAxisInputControlR(TwoAxisInputControl _orig) : base(_orig)
    {
    }

    public TwoAxisInputControl Null
    {
        get => TwoAxisInputControl.Null;
        set => SetField(value);
    }

    public DeadZoneFunc DeadZoneFunc
    {
        get => orig.DeadZoneFunc;
        set => orig.DeadZoneFunc = value;
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

    public bool Raw
    {
        get => orig.Raw;
        set => orig.Raw = value;
    }

    public bool thisState
    {
        get => GetField<bool>();
        set => SetField(value);
    }

    public bool lastState
    {
        get => GetField<bool>();
        set => SetField(value);
    }

    public Vector2 thisValue
    {
        get => GetField<Vector2>();
        set => SetField(value);
    }

    public Vector2 lastValue
    {
        get => GetField<Vector2>();
        set => SetField(value);
    }

    public bool clearInputState
    {
        get => GetField<bool>();
        set => SetField(value);
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

    public void ClearInputState()
    {
        orig.ClearInputState();
    }

    public void Filter(TwoAxisInputControl twoAxisInputControl, float deltaTime)
    {
        orig.Filter(twoAxisInputControl, deltaTime);
    }

    public void UpdateWithAxes(float x, float y, ulong updateTick, float deltaTime)
    {
        CallMethod(new object[] { x, y, updateTick, deltaTime });
    }
}