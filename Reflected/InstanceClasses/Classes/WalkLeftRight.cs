namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of WalkLeftRight allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class WalkLeftRightR : InstanceClassWrapper<WalkLeftRight>
{
    public WalkLeftRightR(WalkLeftRight _orig) : base(_orig)
    {
    }

    public FsmOwnerDefault gameObject
    {
        get => orig.gameObject;
        set => orig.gameObject = value;
    }

    public float walkSpeed
    {
        get => orig.walkSpeed;
        set => orig.walkSpeed = value;
    }

    public bool spriteFacesLeft
    {
        get => orig.spriteFacesLeft;
        set => orig.spriteFacesLeft = value;
    }

    public FsmString groundLayer
    {
        get => orig.groundLayer;
        set => orig.groundLayer = value;
    }

    public float turnDelay
    {
        get => orig.turnDelay;
        set => orig.turnDelay = value;
    }

    public float nextTurnTime
    {
        get => GetField<float>();
        set => SetField(value);
    }

    public FsmString walkAnimName
    {
        get => orig.walkAnimName;
        set => orig.walkAnimName = value;
    }

    public FsmString turnAnimName
    {
        get => orig.turnAnimName;
        set => orig.turnAnimName = value;
    }

    public FsmBool startLeft
    {
        get => orig.startLeft;
        set => orig.startLeft = value;
    }

    public FsmBool startRight
    {
        get => orig.startRight;
        set => orig.startRight = value;
    }

    public FsmBool keepDirection
    {
        get => orig.keepDirection;
        set => orig.keepDirection = value;
    }

    public float scaleX_pos
    {
        get => GetField<float>();
        set => SetField(value);
    }

    public float scaleX_neg
    {
        get => GetField<float>();
        set => SetField(value);
    }

    public float wallRayHeight
    {
        get => GetFieldStatic<float>();
        set => SetField(value);
    }

    public float wallRayLength
    {
        get => GetFieldStatic<float>();
        set => SetField(value);
    }

    public float groundRayLength
    {
        get => GetFieldStatic<float>();
        set => SetField(value);
    }

    public GameObject target
    {
        get => GetField<GameObject>();
        set => SetField(value);
    }

    public Rigidbody2D body
    {
        get => GetField<Rigidbody2D>();
        set => SetField(value);
    }

    public tk2dSpriteAnimator spriteAnimator
    {
        get => GetField<tk2dSpriteAnimator>();
        set => SetField(value);
    }

    public Collider2D collider
    {
        get => GetField<Collider2D>();
        set => SetField(value);
    }

    public Coroutine walkRoutine
    {
        get => GetField<Coroutine>();
        set => SetField(value);
    }

    public Coroutine turnRoutine
    {
        get => GetField<Coroutine>();
        set => SetField(value);
    }

    public bool shouldTurn
    {
        get => GetField<bool>();
        set => SetField(value);
    }

    public float Direction => GetProperty<float>();

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

    public void OnEnter()
    {
        orig.OnEnter();
    }

    public void OnExit()
    {
        orig.OnExit();
    }

    public void UpdateIfTargetChanged()
    {
        CallMethod();
    }

    public IEnumerator Walk()
    {
        return CallMethod<IEnumerator>();
    }

    public IEnumerator Turn()
    {
        return CallMethod<IEnumerator>();
    }

    public bool CheckWall()
    {
        return CallMethod<bool>();
    }

    public bool CheckFloor()
    {
        return CallMethod<bool>();
    }

    public bool CheckIsGrounded()
    {
        return CallMethod<bool>();
    }

    public void SetupStartingDirection()
    {
        CallMethod();
    }
}