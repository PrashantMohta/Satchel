namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of Trigger2dEventToParent allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class Trigger2dEventToParentR : InstanceClassWrapper<Trigger2dEventToParent>
{
    public Trigger2dEventToParentR(Trigger2dEventToParent _orig) : base(_orig)
    {
    }

    public FsmString collideTag
    {
        get => orig.collideTag;
        set => orig.collideTag = value;
    }

    public FsmInt collideLayer
    {
        get => orig.collideLayer;
        set => orig.collideLayer = value;
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

    public PlayMakerUnity2DProxy _proxy
    {
        get => GetField<PlayMakerUnity2DProxy>();
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

    public void StoreCollisionInfo(Collider2D collisionInfo)
    {
        CallMethod(new object[] { collisionInfo });
    }

    public void DoTriggerEnter2D(Collider2D collisionInfo)
    {
        orig.DoTriggerEnter2D(collisionInfo);
    }

    public void DoTriggerStay2D(Collider2D collisionInfo)
    {
        orig.DoTriggerStay2D(collisionInfo);
    }

    public void DoTriggerExit2D(Collider2D collisionInfo)
    {
        orig.DoTriggerExit2D(collisionInfo);
    }

    public string ErrorCheck()
    {
        return orig.ErrorCheck();
    }
}