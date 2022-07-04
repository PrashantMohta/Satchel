namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of TouchObjectEvent allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class TouchObjectEventR : InstanceClassWrapper<TouchObjectEvent>
{
    public TouchObjectEventR(TouchObjectEvent _orig) : base(_orig)
    {
    }

    public FsmOwnerDefault gameObject
    {
        get => orig.gameObject;
        set => orig.gameObject = value;
    }

    public FsmFloat pickDistance
    {
        get => orig.pickDistance;
        set => orig.pickDistance = value;
    }

    public FsmInt fingerId
    {
        get => orig.fingerId;
        set => orig.fingerId = value;
    }

    public FsmEvent touchBegan
    {
        get => orig.touchBegan;
        set => orig.touchBegan = value;
    }

    public FsmEvent touchMoved
    {
        get => orig.touchMoved;
        set => orig.touchMoved = value;
    }

    public FsmEvent touchStationary
    {
        get => orig.touchStationary;
        set => orig.touchStationary = value;
    }

    public FsmEvent touchEnded
    {
        get => orig.touchEnded;
        set => orig.touchEnded = value;
    }

    public FsmEvent touchCanceled
    {
        get => orig.touchCanceled;
        set => orig.touchCanceled = value;
    }

    public FsmInt storeFingerId
    {
        get => orig.storeFingerId;
        set => orig.storeFingerId = value;
    }

    public FsmVector3 storeHitPoint
    {
        get => orig.storeHitPoint;
        set => orig.storeHitPoint = value;
    }

    public FsmVector3 storeHitNormal
    {
        get => orig.storeHitNormal;
        set => orig.storeHitNormal = value;
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