namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of Crawler allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class CrawlerR : InstanceClassWrapper<Crawler>
{
    public CrawlerR(Crawler _orig) : base(_orig)
    {
    }

    public float speed
    {
        get => orig.speed;
        set => orig.speed = value;
    }

    public Transform wallCheck
    {
        get => orig.wallCheck;
        set => orig.wallCheck = value;
    }

    public Transform groundCheck
    {
        get => orig.groundCheck;
        set => orig.groundCheck = value;
    }

    public Vector2 velocity
    {
        get => GetField<Vector2>();
        set => SetField(value);
    }

    public Rigidbody2D body
    {
        get => GetField<Rigidbody2D>();
        set => SetField(value);
    }

    public Recoil recoil
    {
        get => GetField<Recoil>();
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

    public IEnumerator Turn()
    {
        return CallMethod<IEnumerator>();
    }

    public bool CheckRayLocal(Vector2 originLocal, Vector2 directionLocal, float length)
    {
        return orig.CheckRayLocal(originLocal, directionLocal, length);
    }
}