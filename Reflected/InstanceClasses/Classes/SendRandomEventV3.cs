namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of SendRandomEventV3 allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class SendRandomEventV3R : InstanceClassWrapper<SendRandomEventV3>
{
    public SendRandomEventV3R(SendRandomEventV3 _orig) : base(_orig)
    {
    }

    public FsmEvent[] events
    {
        get => orig.events;
        set => orig.events = value;
    }

    public FsmFloat[] weights
    {
        get => orig.weights;
        set => orig.weights = value;
    }

    public FsmInt[] trackingInts
    {
        get => orig.trackingInts;
        set => orig.trackingInts = value;
    }

    public FsmInt[] eventMax
    {
        get => orig.eventMax;
        set => orig.eventMax = value;
    }

    public FsmInt[] trackingIntsMissed
    {
        get => orig.trackingIntsMissed;
        set => orig.trackingIntsMissed = value;
    }

    public FsmInt[] missedMax
    {
        get => orig.missedMax;
        set => orig.missedMax = value;
    }

    public int loops
    {
        get => GetField<int>();
        set => SetField(value);
    }

    public DelayedEvent delayedEvent
    {
        get => GetField<DelayedEvent>();
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
}