namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of RayCast2d allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class RayCast2dR : InstanceClassWrapper<RayCast2d>
{
    public RayCast2dR(RayCast2d _orig) : base(_orig)
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

    public FsmVector2 direction
    {
        get => orig.direction;
        set => orig.direction = value;
    }

    public Space space
    {
        get => orig.space;
        set => orig.space = value;
    }

    public FsmFloat distance
    {
        get => orig.distance;
        set => orig.distance = value;
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

    public FsmEvent hitEvent
    {
        get => orig.hitEvent;
        set => orig.hitEvent = value;
    }

    public FsmBool storeDidHit
    {
        get => orig.storeDidHit;
        set => orig.storeDidHit = value;
    }

    public FsmGameObject storeHitObject
    {
        get => orig.storeHitObject;
        set => orig.storeHitObject = value;
    }

    public FsmVector2 storeHitPoint
    {
        get => orig.storeHitPoint;
        set => orig.storeHitPoint = value;
    }

    public FsmVector2 storeHitNormal
    {
        get => orig.storeHitNormal;
        set => orig.storeHitNormal = value;
    }

    public FsmFloat storeHitDistance
    {
        get => orig.storeHitDistance;
        set => orig.storeHitDistance = value;
    }

    public FsmFloat storeHitFraction
    {
        get => orig.storeHitFraction;
        set => orig.storeHitFraction = value;
    }

    public FsmInt repeatInterval
    {
        get => orig.repeatInterval;
        set => orig.repeatInterval = value;
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

    public FsmColor debugColor
    {
        get => orig.debugColor;
        set => orig.debugColor = value;
    }

    public FsmBool debug
    {
        get => orig.debug;
        set => orig.debug = value;
    }

    public Transform _transform
    {
        get => GetField<Transform>();
        set => SetField(value);
    }

    public int repeat
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

    public void OnUpdate()
    {
        orig.OnUpdate();
    }

    public void DoRaycast()
    {
        CallMethod();
    }
}