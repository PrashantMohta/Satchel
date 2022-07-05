namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of EaseVector3 allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class EaseVector3R : InstanceClassWrapper<EaseVector3>
{
    public EaseVector3R(EaseVector3 _orig) : base(_orig)
    {
    }

    public FsmVector3 fromValue
    {
        get => orig.fromValue;
        set => orig.fromValue = value;
    }

    public FsmVector3 toValue
    {
        get => orig.toValue;
        set => orig.toValue = value;
    }

    public FsmVector3 vector3Variable
    {
        get => orig.vector3Variable;
        set => orig.vector3Variable = value;
    }

    public bool finishInNextStep
    {
        get => GetField<bool>();
        set => SetField(value);
    }

    public FsmFloat time
    {
        get => orig.time;
        set => orig.time = value;
    }

    public FsmFloat speed
    {
        get => orig.speed;
        set => orig.speed = value;
    }

    public FsmFloat delay
    {
        get => orig.delay;
        set => orig.delay = value;
    }

    public FsmBool reverse
    {
        get => orig.reverse;
        set => orig.reverse = value;
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

    public float runningTime
    {
        get => GetField<float>();
        set => SetField(value);
    }

    public float lastTime
    {
        get => GetField<float>();
        set => SetField(value);
    }

    public float startTime
    {
        get => GetField<float>();
        set => SetField(value);
    }

    public float deltaTime
    {
        get => GetField<float>();
        set => SetField(value);
    }

    public float delayTime
    {
        get => GetField<float>();
        set => SetField(value);
    }

    public float percentage
    {
        get => GetField<float>();
        set => SetField(value);
    }

    public float[] fromFloats
    {
        get => GetField<float[]>();
        set => SetField(value);
    }

    public float[] toFloats
    {
        get => GetField<float[]>();
        set => SetField(value);
    }

    public float[] resultFloats
    {
        get => GetField<float[]>();
        set => SetField(value);
    }

    public bool finishAction
    {
        get => GetField<bool>();
        set => SetField(value);
    }

    public bool start
    {
        get => GetField<bool>();
        set => SetField(value);
    }

    public bool finished
    {
        get => GetField<bool>();
        set => SetField(value);
    }

    public bool isRunning
    {
        get => GetField<bool>();
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

    public void OnExit()
    {
        orig.OnExit();
    }

    public void OnUpdate()
    {
        orig.OnUpdate();
    }
}