namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of GetNextLineCast2d allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class GetNextLineCast2dR : InstanceClassWrapper<GetNextLineCast2d>
{
    public GetNextLineCast2dR(GetNextLineCast2d _orig) : base(_orig)
    {
    }

    public FsmOwnerDefault fromGameObject
    {
        get => orig.fromGameObject;
        set => orig.fromGameObject = value;
    }

    public FsmVector2 fromPosition
    {
        get => orig.fromPosition;
        set => orig.fromPosition = value;
    }

    public FsmGameObject toGameObject
    {
        get => orig.toGameObject;
        set => orig.toGameObject = value;
    }

    public FsmVector2 toPosition
    {
        get => orig.toPosition;
        set => orig.toPosition = value;
    }

    public FsmInt minDepth
    {
        get => orig.minDepth;
        set => orig.minDepth = value;
    }

    public FsmInt maxDepth
    {
        get => orig.maxDepth;
        set => orig.maxDepth = value;
    }

    public FsmInt[] layerMask
    {
        get => orig.layerMask;
        set => orig.layerMask = value;
    }

    public FsmBool invertMask
    {
        get => orig.invertMask;
        set => orig.invertMask = value;
    }

    public FsmInt collidersCount
    {
        get => orig.collidersCount;
        set => orig.collidersCount = value;
    }

    public FsmGameObject storeNextCollider
    {
        get => orig.storeNextCollider;
        set => orig.storeNextCollider = value;
    }

    public FsmVector2 storeNextHitPoint
    {
        get => orig.storeNextHitPoint;
        set => orig.storeNextHitPoint = value;
    }

    public FsmVector2 storeNextHitNormal
    {
        get => orig.storeNextHitNormal;
        set => orig.storeNextHitNormal = value;
    }

    public FsmFloat storeNextHitDistance
    {
        get => orig.storeNextHitDistance;
        set => orig.storeNextHitDistance = value;
    }

    public FsmEvent loopEvent
    {
        get => orig.loopEvent;
        set => orig.loopEvent = value;
    }

    public FsmEvent finishedEvent
    {
        get => orig.finishedEvent;
        set => orig.finishedEvent = value;
    }

    public RaycastHit2D[] hits
    {
        get => GetField<RaycastHit2D[]>();
        set => SetField(value);
    }

    public int colliderCount
    {
        get => GetField<int>();
        set => SetField(value);
    }

    public int nextColliderIndex
    {
        get => GetField<int>();
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

    public void DoGetNextCollider()
    {
        CallMethod();
    }

    public RaycastHit2D[] GetLineCastAll()
    {
        return CallMethod<RaycastHit2D[]>();
    }
}