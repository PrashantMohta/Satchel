namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of GeoControl allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class GeoControlR : InstanceClassWrapper<GeoControl>
{
    public GeoControlR(GeoControl _orig) : base(_orig)
    {
    }

    public GeoControl.Size[] sizes
    {
        get => orig.sizes;
        set => orig.sizes = value;
    }

    public int type
    {
        get => orig.type;
        set => orig.type = value;
    }

    public AudioClip[] pickupSounds
    {
        get => orig.pickupSounds;
        set => orig.pickupSounds = value;
    }

    public VibrationData pickupVibration
    {
        get => orig.pickupVibration;
        set => orig.pickupVibration = value;
    }

    public ParticleSystem acidEffect
    {
        get => orig.acidEffect;
        set => orig.acidEffect = value;
    }

    public GameObject getterBug
    {
        get => orig.getterBug;
        set => orig.getterBug = value;
    }

    public Coroutine getterRoutine
    {
        get => GetField<Coroutine>();
        set => SetField(value);
    }

    public HeroController hero
    {
        get => GetField<HeroController>();
        set => SetField(value);
    }

    public Transform player
    {
        get => GetField<Transform>();
        set => SetField(value);
    }

    public bool activated
    {
        get => GetField<bool>();
        set => SetField(value);
    }

    public bool attracted
    {
        get => GetField<bool>();
        set => SetField(value);
    }

    public float pickupStartDelay
    {
        get => GetFieldStatic<float>();
        set => SetField(value);
    }

    public float pickupStartTime
    {
        get => GetField<float>();
        set => SetField(value);
    }

    public float defaultGravity
    {
        get => GetField<float>();
        set => SetField(value);
    }

    public tk2dSpriteAnimator anim
    {
        get => GetField<tk2dSpriteAnimator>();
        set => SetField(value);
    }

    public AudioSource audioSource
    {
        get => GetField<AudioSource>();
        set => SetField(value);
    }

    public Renderer rend
    {
        get => GetField<Renderer>();
        set => SetField(value);
    }

    public Rigidbody2D body
    {
        get => GetField<Rigidbody2D>();
        set => SetField(value);
    }

    public BoxCollider2D boxCollider
    {
        get => GetField<BoxCollider2D>();
        set => SetField(value);
    }

    public SpriteFlash spriteFlash
    {
        get => GetField<SpriteFlash>();
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

    public void OnEnable()
    {
        CallMethod();
    }

    public void FixedUpdate()
    {
        CallMethod();
    }

    public void SetSize(int index)
    {
        orig.SetSize(index);
    }

    public void SetFlashing()
    {
        orig.SetFlashing();
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        CallMethod(new object[] { collision });
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        CallMethod(new object[] { collision });
    }

    public float PlayCollectSound()
    {
        return CallMethod<float>();
    }

    public void Disable(float waitTime)
    {
        orig.Disable(waitTime);
    }

    public IEnumerator DisableAfterTime(float waitTime)
    {
        return CallMethod<IEnumerator>(new object[] { waitTime });
    }

    public IEnumerator Getter()
    {
        return CallMethod<IEnumerator>();
    }
}