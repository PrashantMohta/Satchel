namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of GhostMovement allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class GhostMovementR : InstanceClassWrapper<GhostMovement>
{
    public GhostMovementR(GhostMovement _orig) : base(_orig)
    {
    }

    public FsmOwnerDefault gameObject
    {
        get => orig.gameObject;
        set => orig.gameObject = value;
    }

    public FsmFloat xPosMin
    {
        get => orig.xPosMin;
        set => orig.xPosMin = value;
    }

    public FsmFloat xPosMax
    {
        get => orig.xPosMax;
        set => orig.xPosMax = value;
    }

    public FsmFloat accel_x
    {
        get => orig.accel_x;
        set => orig.accel_x = value;
    }

    public FsmFloat speedMax_x
    {
        get => orig.speedMax_x;
        set => orig.speedMax_x = value;
    }

    public FsmFloat yPosMin
    {
        get => orig.yPosMin;
        set => orig.yPosMin = value;
    }

    public FsmFloat yPosMax
    {
        get => orig.yPosMax;
        set => orig.yPosMax = value;
    }

    public FsmFloat accel_y
    {
        get => orig.accel_y;
        set => orig.accel_y = value;
    }

    public FsmFloat speedMax_y
    {
        get => orig.speedMax_y;
        set => orig.speedMax_y = value;
    }

    public FsmGameObject target
    {
        get => GetField<FsmGameObject>();
        set => SetField(value);
    }

    public Transform transform
    {
        get => GetField<Transform>();
        set => SetField(value);
    }

    public FsmInt direction_x
    {
        get => orig.direction_x;
        set => orig.direction_x = value;
    }

    public FsmInt direction_y
    {
        get => orig.direction_y;
        set => orig.direction_y = value;
    }

    public Rigidbody2D rb2d
    {
        get => GetField<Rigidbody2D>();
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

    public void Awake()
    {
        orig.Awake();
    }

    public void OnPreprocess()
    {
        orig.OnPreprocess();
    }

    public void OnEnter()
    {
        orig.OnEnter();
    }

    public void OnFixedUpdate()
    {
        orig.OnFixedUpdate();
    }

    public void DoMove()
    {
        CallMethod();
    }
}