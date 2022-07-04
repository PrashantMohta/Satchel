namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of FloatInterpolate allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class FloatInterpolateR : InstanceClassWrapper<FloatInterpolate>
{
    public FloatInterpolateR(FloatInterpolate _orig) : base(_orig)
    {
    }

    public InterpolationType mode
    {
        get => orig.mode;
        set => orig.mode = value;
    }

    public FsmFloat fromFloat
    {
        get => orig.fromFloat;
        set => orig.fromFloat = value;
    }

    public FsmFloat toFloat
    {
        get => orig.toFloat;
        set => orig.toFloat = value;
    }

    public FsmFloat time
    {
        get => orig.time;
        set => orig.time = value;
    }

    public FsmFloat storeResult
    {
        get => orig.storeResult;
        set => orig.storeResult = value;
    }

    public FsmEvent finishEvent
    {
        get => orig.finishEvent;
        set => orig.finishEvent = value;
    }

    public bool realTime
    {
        get => orig.realTime;
        set => orig.realTime = value;
    }

    public float startTime
    {
        get => GetField<float>();
        set => SetField(value);
    }

    public float currentTime
    {
        get => GetField<float>();
        set => SetField(value);
    }

    public string Name
    {
        get => orig.Name;
        set => orig.Name = value;
    }

    public string DisplayName
    {
        get => orig.DisplayName;
        set => orig.DisplayName = value;
    }

    public Fsm Fsm
    {
        get => orig.Fsm;
        set => orig.Fsm = value;
    }

    public GameObject Owner
    {
        get => orig.Owner;
        set => orig.Owner = value;
    }

    public FsmState State
    {
        get => orig.State;
        set => orig.State = value;
    }

    public bool Enabled
    {
        get => orig.Enabled;
        set => orig.Enabled = value;
    }

    public bool IsOpen
    {
        get => orig.IsOpen;
        set => orig.IsOpen = value;
    }

    public bool IsAutoNamed
    {
        get => orig.IsAutoNamed;
        set => orig.IsAutoNamed = value;
    }

    public bool Entered
    {
        get => orig.Entered;
        set => orig.Entered = value;
    }

    public bool Finished
    {
        get => orig.Finished;
        set => orig.Finished = value;
    }

    public bool Active
    {
        get => orig.Active;
        set => orig.Active = value;
    }

    public void Reset()
    {
        orig.Reset();
    }

    public void OnEnter()
    {
        orig.OnEnter();
    }

    public void OnUpdate()
    {
        orig.OnUpdate();
    }
}