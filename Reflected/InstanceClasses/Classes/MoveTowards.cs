namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of MoveTowards allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class MoveTowardsR : InstanceClassWrapper<MoveTowards>
{
    public MoveTowardsR(MoveTowards _orig) : base(_orig)
    {
    }

    public FsmOwnerDefault gameObject
    {
        get => orig.gameObject;
        set => orig.gameObject = value;
    }

    public FsmGameObject targetObject
    {
        get => orig.targetObject;
        set => orig.targetObject = value;
    }

    public FsmVector3 targetPosition
    {
        get => orig.targetPosition;
        set => orig.targetPosition = value;
    }

    public FsmBool ignoreVertical
    {
        get => orig.ignoreVertical;
        set => orig.ignoreVertical = value;
    }

    public FsmFloat maxSpeed
    {
        get => orig.maxSpeed;
        set => orig.maxSpeed = value;
    }

    public FsmFloat finishDistance
    {
        get => orig.finishDistance;
        set => orig.finishDistance = value;
    }

    public FsmEvent finishEvent
    {
        get => orig.finishEvent;
        set => orig.finishEvent = value;
    }

    public GameObject go
    {
        get => GetField<GameObject>();
        set => SetField(value);
    }

    public GameObject goTarget
    {
        get => GetField<GameObject>();
        set => SetField(value);
    }

    public Vector3 targetPos
    {
        get => GetField<Vector3>();
        set => SetField(value);
    }

    public Vector3 targetPosWithVertical
    {
        get => GetField<Vector3>();
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

    public void OnUpdate()
    {
        orig.OnUpdate();
    }

    public void DoMoveTowards()
    {
        CallMethod();
    }

    public bool UpdateTargetPos()
    {
        return orig.UpdateTargetPos();
    }

    public Vector3 GetTargetPos()
    {
        return orig.GetTargetPos();
    }

    public Vector3 GetTargetPosWithVertical()
    {
        return orig.GetTargetPosWithVertical();
    }
}