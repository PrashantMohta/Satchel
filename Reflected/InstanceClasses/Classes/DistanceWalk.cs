namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of DistanceWalk allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class DistanceWalkR : InstanceClassWrapper<DistanceWalk>
{
    public DistanceWalkR(DistanceWalk _orig) : base(_orig)
    {
    }

    public FsmOwnerDefault gameObject
    {
        get => orig.gameObject;
        set => orig.gameObject = value;
    }

    public FsmGameObject target
    {
        get => orig.target;
        set => orig.target = value;
    }

    public FsmFloat distance
    {
        get => orig.distance;
        set => orig.distance = value;
    }

    public FsmFloat speed
    {
        get => orig.speed;
        set => orig.speed = value;
    }

    public FsmFloat range
    {
        get => orig.range;
        set => orig.range = value;
    }

    public bool changeAnimation
    {
        get => orig.changeAnimation;
        set => orig.changeAnimation = value;
    }

    public bool spriteFacesRight
    {
        get => orig.spriteFacesRight;
        set => orig.spriteFacesRight = value;
    }

    public FsmString forwardAnimation
    {
        get => orig.forwardAnimation;
        set => orig.forwardAnimation = value;
    }

    public FsmString backAnimation
    {
        get => orig.backAnimation;
        set => orig.backAnimation = value;
    }

    public float distanceAway
    {
        get => GetField<float>();
        set => SetField(value);
    }

    public FsmGameObject self
    {
        get => GetField<FsmGameObject>();
        set => SetField(value);
    }

    public tk2dSpriteAnimator animator
    {
        get => GetField<tk2dSpriteAnimator>();
        set => SetField(value);
    }

    public bool movingRight
    {
        get => GetField<bool>();
        set => SetField(value);
    }

    public float ANIM_CHANGE_TIME
    {
        get => GetField<float>();
        set => SetField(value);
    }

    public float changeTimer
    {
        get => GetField<float>();
        set => SetField(value);
    }

    public bool randomStart
    {
        get => GetField<bool>();
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

    public void OnUpdate()
    {
        orig.OnUpdate();
    }

    public void OnFixedUpdate()
    {
        orig.OnFixedUpdate();
    }

    public void DoWalk()
    {
        CallMethod();
    }
}