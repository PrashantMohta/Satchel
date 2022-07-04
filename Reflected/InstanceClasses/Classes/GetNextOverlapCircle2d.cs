namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of GetNextOverlapCircle2d allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class GetNextOverlapCircle2dR : InstanceClassWrapper<GetNextOverlapCircle2d>
{
    public GetNextOverlapCircle2dR(GetNextOverlapCircle2d _orig) : base(_orig)
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

    public FsmFloat radius
    {
        get => orig.radius;
        set => orig.radius = value;
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

    public Collider2D[] colliders
    {
        get => GetField<Collider2D[]>();
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

    public Collider2D[] GetOverlapCircleAll()
    {
        return CallMethod<Collider2D[]>();
    }
}