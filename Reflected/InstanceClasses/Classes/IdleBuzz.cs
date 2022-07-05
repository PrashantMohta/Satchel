namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of IdleBuzz allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class IdleBuzzR : InstanceClassWrapper<IdleBuzz>
{
    public IdleBuzzR(IdleBuzz _orig) : base(_orig)
    {
    }

    public FsmOwnerDefault gameObject
    {
        get => orig.gameObject;
        set => orig.gameObject = value;
    }

    public FsmFloat waitMin
    {
        get => orig.waitMin;
        set => orig.waitMin = value;
    }

    public FsmFloat waitMax
    {
        get => orig.waitMax;
        set => orig.waitMax = value;
    }

    public FsmFloat speedMax
    {
        get => orig.speedMax;
        set => orig.speedMax = value;
    }

    public FsmFloat accelerationMax
    {
        get => orig.accelerationMax;
        set => orig.accelerationMax = value;
    }

    public FsmFloat roamingRange
    {
        get => orig.roamingRange;
        set => orig.roamingRange = value;
    }

    public FsmGameObject target
    {
        get => GetField<FsmGameObject>();
        set => SetField(value);
    }

    public float startX
    {
        get => GetField<float>();
        set => SetField(value);
    }

    public float startY
    {
        get => GetField<float>();
        set => SetField(value);
    }

    public float accelX
    {
        get => GetField<float>();
        set => SetField(value);
    }

    public float accelY
    {
        get => GetField<float>();
        set => SetField(value);
    }

    public float waitTime
    {
        get => GetField<float>();
        set => SetField(value);
    }

    public float dampener
    {
        get => GetFieldStatic<float>();
        set => SetField(value);
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

    public void DoBuzz()
    {
        CallMethod();
    }
}