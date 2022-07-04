namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of TriggerEvent allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class TriggerEventR : InstanceClassWrapper<TriggerEvent>
{
    public TriggerEventR(TriggerEvent _orig) : base(_orig)
    {
    }

    public TriggerType trigger
    {
        get => orig.trigger;
        set => orig.trigger = value;
    }

    public FsmString collideTag
    {
        get => orig.collideTag;
        set => orig.collideTag = value;
    }

    public FsmEvent sendEvent
    {
        get => orig.sendEvent;
        set => orig.sendEvent = value;
    }

    public FsmGameObject storeCollider
    {
        get => orig.storeCollider;
        set => orig.storeCollider = value;
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

    public void OnPreprocess()
    {
        orig.OnPreprocess();
    }

    public void StoreCollisionInfo(Collider collisionInfo)
    {
        CallMethod(new object[] { collisionInfo });
    }

    public void DoTriggerEnter(Collider other)
    {
        orig.DoTriggerEnter(other);
    }

    public void DoTriggerStay(Collider other)
    {
        orig.DoTriggerStay(other);
    }

    public void DoTriggerExit(Collider other)
    {
        orig.DoTriggerExit(other);
    }

    public string ErrorCheck()
    {
        return orig.ErrorCheck();
    }
}