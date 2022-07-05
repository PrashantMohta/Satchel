namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of SpatterOrange allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class SpatterOrangeR : InstanceClassWrapper<SpatterOrange>
{
    public SpatterOrangeR(SpatterOrange _orig) : base(_orig)
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

    public Sprite[] sprites
    {
        get => orig.sprites;
        set => orig.sprites = value;
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

    public float splashScaleMin
    {
        get => orig.splashScaleMin;
        set => orig.splashScaleMin = value;
    }

    public float splashScaleMax
    {
        get => orig.splashScaleMax;
        set => orig.splashScaleMax = value;
    }

    public float state
    {
        get => GetField<float>();
        set => SetField(value);
    }

    public float fps
    {
        get => orig.fps;
        set => orig.fps = value;
    }

    public float idleTimer
    {
        get => GetField<float>();
        set => SetField(value);
    }

    public float animTimer
    {
        get => GetField<float>();
        set => SetField(value);
    }

    public int animFrame
    {
        get => GetField<int>();
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

    public void OnTriggerEnter2D()
    {
        CallMethod();
    }
}