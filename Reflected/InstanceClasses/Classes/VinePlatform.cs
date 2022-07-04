namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of VinePlatform allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class VinePlatformR : InstanceClassWrapper<VinePlatform>
{
    public VinePlatformR(VinePlatform _orig) : base(_orig)
    {
    }

    public GameObject platformSprite
    {
        get => orig.platformSprite;
        set => orig.platformSprite = value;
    }

    public GameObject activatedSprite
    {
        get => orig.activatedSprite;
        set => orig.activatedSprite = value;
    }

    public Collider2D collider
    {
        get => orig.collider;
        set => orig.collider = value;
    }

    public AudioClip playerLandSound
    {
        get => orig.playerLandSound;
        set => orig.playerLandSound = value;
    }

    public ParticleSystem playerLandParticles
    {
        get => orig.playerLandParticles;
        set => orig.playerLandParticles = value;
    }

    public AnimationCurve playerLandAnimCurve
    {
        get => orig.playerLandAnimCurve;
        set => orig.playerLandAnimCurve = value;
    }

    public float playerLandAnimLength
    {
        get => orig.playerLandAnimLength;
        set => orig.playerLandAnimLength = value;
    }

    public Coroutine landRoutine
    {
        get => orig.landRoutine;
        set => orig.landRoutine = value;
    }

    public bool respondOnLand
    {
        get => orig.respondOnLand;
        set => orig.respondOnLand = value;
    }

    public Action landReturnAction
    {
        get => GetField<Action>();
        set => SetField(value);
    }

    public TriggerEnterEvent landingDetector
    {
        get => orig.landingDetector;
        set => orig.landingDetector = value;
    }

    public AudioClip landSound
    {
        get => orig.landSound;
        set => orig.landSound = value;
    }

    public ParticleSystem[] landParticles
    {
        get => orig.landParticles;
        set => orig.landParticles = value;
    }

    public GameObject slamEffect
    {
        get => orig.slamEffect;
        set => orig.slamEffect = value;
    }

    public TriggerEnterEvent enemyDetector
    {
        get => orig.enemyDetector;
        set => orig.enemyDetector = value;
    }

    public bool acidLander
    {
        get => orig.acidLander;
        set => orig.acidLander = value;
    }

    public float acidTargetY
    {
        get => orig.acidTargetY;
        set => orig.acidTargetY = value;
    }

    public AudioClip acidSplashSound
    {
        get => orig.acidSplashSound;
        set => orig.acidSplashSound = value;
    }

    public GameObject acidSplashPrefab
    {
        get => orig.acidSplashPrefab;
        set => orig.acidSplashPrefab = value;
    }

    public AudioSource audioSource
    {
        get => GetField<AudioSource>();
        set => SetField(value);
    }

    public Rigidbody2D body
    {
        get => GetField<Rigidbody2D>();
        set => SetField(value);
    }

    public bool activated
    {
        get => GetField<bool>();
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

    public void Update()
    {
        CallMethod();
    }

    public void Land()
    {
        CallMethod();
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        CallMethod(new object[] { collision });
    }

    public void PlaySound(AudioClip clip)
    {
        CallMethod(new object[] { clip });
    }

    public IEnumerator PlayerLand()
    {
        return CallMethod<IEnumerator>();
    }

    public void OnDrawGizmosSelected()
    {
        CallMethod();
    }
}