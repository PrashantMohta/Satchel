namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of SpatterHoney allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class SpatterHoneyR : InstanceClassWrapper<SpatterHoney>
{
    public SpatterHoneyR(SpatterHoney _orig) : base(_orig)
    {
    }

    public Rigidbody2D rb2d
    {
        get => orig.rb2d;
        set => orig.rb2d = value;
    }

    public CircleCollider2D circleCollider
    {
        get => orig.circleCollider;
        set => orig.circleCollider = value;
    }

    public SpriteRenderer spriteRenderer
    {
        get => orig.spriteRenderer;
        set => orig.spriteRenderer = value;
    }

    public float stretchFactor
    {
        get => GetField<float>();
        set => SetField(value);
    }

    public float stretchMinX
    {
        get => GetField<float>();
        set => SetField(value);
    }

    public float stretchMaxY
    {
        get => GetField<float>();
        set => SetField(value);
    }

    public float scaleModifier
    {
        get => GetField<float>();
        set => SetField(value);
    }

    public float scaleModifierMin
    {
        get => orig.scaleModifierMin;
        set => orig.scaleModifierMin = value;
    }

    public float scaleModifierMax
    {
        get => orig.scaleModifierMax;
        set => orig.scaleModifierMax = value;
    }

    public float state
    {
        get => GetField<float>();
        set => SetField(value);
    }

    public float idleTimer
    {
        get => GetField<float>();
        set => SetField(value);
    }


    public void Start()
    {
        CallMethod();
    }

    public void OnEnable()
    {
        CallMethod();
    }

    public void Update()
    {
        CallMethod();
    }

    public void Impact()
    {
        CallMethod();
    }

    public void FaceAngle()
    {
        CallMethod();
    }

    public void ProjectileSquash()
    {
        CallMethod();
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        CallMethod(new object[] { collision });
    }
}