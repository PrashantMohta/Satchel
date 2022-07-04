namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of AccelerateVelocity allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class AccelerateVelocityR : InstanceClassWrapper<AccelerateVelocity>
{
    public AccelerateVelocityR(AccelerateVelocity _orig) : base(_orig)
    {
    }

    public FsmOwnerDefault gameObject
    {
        get => orig.gameObject;
        set => orig.gameObject = value;
    }

    public FsmFloat xAccel
    {
        get => orig.xAccel;
        set => orig.xAccel = value;
    }

    public FsmFloat yAccel
    {
        get => orig.yAccel;
        set => orig.yAccel = value;
    }

    public FsmFloat xMaxSpeed
    {
        get => orig.xMaxSpeed;
        set => orig.xMaxSpeed = value;
    }

    public FsmFloat yMaxSpeed
    {
        get => orig.yMaxSpeed;
        set => orig.yMaxSpeed = value;
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

    public void OnEnter()
    {
        orig.OnEnter();
    }

    public void OnPreprocess()
    {
        orig.OnPreprocess();
    }

    public void OnFixedUpdate()
    {
        orig.OnFixedUpdate();
    }

    public void DoSetVelocity()
    {
        CallMethod();
    }
}