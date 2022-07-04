namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of ForwardEvent allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class ForwardEventR : InstanceClassWrapper<ForwardEvent>
{
    public ForwardEventR(ForwardEvent _orig) : base(_orig)
    {
    }

    public FsmEventTarget forwardTo
    {
        get => orig.forwardTo;
        set => orig.forwardTo = value;
    }

    public FsmEvent[] eventsToForward
    {
        get => orig.eventsToForward;
        set => orig.eventsToForward = value;
    }

    public bool eatEvents
    {
        get => orig.eatEvents;
        set => orig.eatEvents = value;
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

    public bool Event(FsmEvent fsmEvent)
    {
        return orig.Event(fsmEvent);
    }
}