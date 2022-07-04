namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of TouchEvent allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class TouchEventR : InstanceClassWrapper<TouchEvent>
{
    public TouchEventR(TouchEvent _orig) : base(_orig)
    {
    }

    public FsmInt fingerId
    {
        get => orig.fingerId;
        set => orig.fingerId = value;
    }

    public TouchPhase touchPhase
    {
        get => orig.touchPhase;
        set => orig.touchPhase = value;
    }

    public FsmEvent sendEvent
    {
        get => orig.sendEvent;
        set => orig.sendEvent = value;
    }

    public FsmInt storeFingerId
    {
        get => orig.storeFingerId;
        set => orig.storeFingerId = value;
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

    public void OnUpdate()
    {
        orig.OnUpdate();
    }
}