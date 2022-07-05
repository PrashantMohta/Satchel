namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of Climber allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class ClimberR : InstanceClassWrapper<Climber>
{
    public ClimberR(Climber _orig) : base(_orig)
    {
    }

    public bool startRight
    {
        get => orig.startRight;
        set => orig.startRight = value;
    }

    public bool clockwise
    {
        get => GetField<bool>();
        set => SetField(value);
    }

    public float speed
    {
        get => orig.speed;
        set => orig.speed = value;
    }

    public float spinTime
    {
        get => orig.spinTime;
        set => orig.spinTime = value;
    }

    public float wallRayPadding
    {
        get => orig.wallRayPadding;
        set => orig.wallRayPadding = value;
    }

    public Vector2 constrain
    {
        get => orig.constrain;
        set => orig.constrain = value;
    }

    public Vector2 previousPos
    {
        get => GetField<Vector2>();
        set => SetField(value);
    }

    public float minTurnDistance
    {
        get => orig.minTurnDistance;
        set => orig.minTurnDistance = value;
    }

    public Vector2 previousTurnPos
    {
        get => GetField<Vector2>();
        set => SetField(value);
    }

    public Coroutine turnRoutine
    {
        get => GetField<Coroutine>();
        set => SetField(value);
    }

    public Rigidbody2D body
    {
        get => GetField<Rigidbody2D>();
        set => SetField(value);
    }

    public BoxCollider2D col
    {
        get => GetField<BoxCollider2D>();
        set => SetField(value);
    }

    public tk2dSpriteAnimator anim
    {
        get => GetField<tk2dSpriteAnimator>();
        set => SetField(value);
    }


    public void Awake()
    {
        CallMethod();
    }

    public void Start()
    {
        CallMethod();
    }

    public IEnumerator Walk()
    {
        return CallMethod<IEnumerator>();
    }

    public IEnumerator Turn(bool turnClockwise, bool tweenPos = false)
    {
        return CallMethod<IEnumerator>(new object[] { turnClockwise, tweenPos });
    }

    public bool CheckGround()
    {
        return CallMethod<bool>();
    }

    public bool CheckWall()
    {
        return CallMethod<bool>();
    }

    public void Stun()
    {
        orig.Stun();
    }

    public IEnumerator DoStun()
    {
        return CallMethod<IEnumerator>();
    }

    public RaycastHit2D FireRayLocal(Vector2 direction, float length)
    {
        return CallMethod<RaycastHit2D>(new object[] { direction, length });
    }

    public void StickToGround()
    {
        CallMethod();
    }
}