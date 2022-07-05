namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of WaterDrip allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class WaterDripR : InstanceClassWrapper<WaterDrip>
{
    public WaterDripR(WaterDrip _orig) : base(_orig)
    {
    }

    public float idleTimeMin
    {
        get => orig.idleTimeMin;
        set => orig.idleTimeMin = value;
    }

    public float idleTimeMax
    {
        get => orig.idleTimeMax;
        set => orig.idleTimeMax = value;
    }

    public float fallVelocity
    {
        get => orig.fallVelocity;
        set => orig.fallVelocity = value;
    }

    public RandomAudioClipTable impactAudioClipTable
    {
        get => orig.impactAudioClipTable;
        set => orig.impactAudioClipTable = value;
    }

    public float impactTranslation
    {
        get => orig.impactTranslation;
        set => orig.impactTranslation = value;
    }

    public bool impacted
    {
        get => GetField<bool>();
        set => SetField(value);
    }

    public Vector2 startPos
    {
        get => GetField<Vector2>();
        set => SetField(value);
    }

    public Collider2D col
    {
        get => GetField<Collider2D>();
        set => SetField(value);
    }

    public Rigidbody2D body
    {
        get => GetField<Rigidbody2D>();
        set => SetField(value);
    }

    public tk2dSpriteAnimator anim
    {
        get => GetField<tk2dSpriteAnimator>();
        set => SetField(value);
    }

    public AudioSource source
    {
        get => GetField<AudioSource>();
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

    public IEnumerator Drip()
    {
        return CallMethod<IEnumerator>();
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        CallMethod(new object[] { collision });
    }
}