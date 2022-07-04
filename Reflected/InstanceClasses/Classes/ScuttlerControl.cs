namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of ScuttlerControl allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class ScuttlerControlR : InstanceClassWrapper<ScuttlerControl>
{
    public ScuttlerControlR(ScuttlerControl _orig) : base(_orig)
    {
    }

    public bool startIdle
    {
        get => orig.startIdle;
        set => orig.startIdle = value;
    }

    public bool startRunning
    {
        get => orig.startRunning;
        set => orig.startRunning = value;
    }

    public string killedPDBool
    {
        get => orig.killedPDBool;
        set => orig.killedPDBool = value;
    }

    public string killsPDBool
    {
        get => orig.killsPDBool;
        set => orig.killsPDBool = value;
    }

    public string newDataPDBool
    {
        get => orig.newDataPDBool;
        set => orig.newDataPDBool = value;
    }

    public string runAnim
    {
        get => orig.runAnim;
        set => orig.runAnim = value;
    }

    public string landAnim
    {
        get => orig.landAnim;
        set => orig.landAnim = value;
    }

    public GameObject corpsePrefab
    {
        get => orig.corpsePrefab;
        set => orig.corpsePrefab = value;
    }

    public GameObject splatEffectChild
    {
        get => orig.splatEffectChild;
        set => orig.splatEffectChild = value;
    }

    public GameObject journalUpdateMsgPrefab
    {
        get => orig.journalUpdateMsgPrefab;
        set => orig.journalUpdateMsgPrefab = value;
    }

    public AudioSource audioSourcePrefab
    {
        get => orig.audioSourcePrefab;
        set => orig.audioSourcePrefab = value;
    }

    public AudioEvent bounceSound
    {
        get => orig.bounceSound;
        set => orig.bounceSound = value;
    }

    public TriggerEnterEvent heroAlert
    {
        get => orig.heroAlert;
        set => orig.heroAlert = value;
    }

    public bool healthScuttler
    {
        get => orig.healthScuttler;
        set => orig.healthScuttler = value;
    }

    public GameObject strikeNailPrefab
    {
        get => orig.strikeNailPrefab;
        set => orig.strikeNailPrefab = value;
    }

    public GameObject slashImpactPrefab
    {
        get => orig.slashImpactPrefab;
        set => orig.slashImpactPrefab = value;
    }

    public GameObject fireballHitPrefab
    {
        get => orig.fireballHitPrefab;
        set => orig.fireballHitPrefab = value;
    }

    public AudioEvent deathSound1
    {
        get => orig.deathSound1;
        set => orig.deathSound1 = value;
    }

    public AudioEvent deathSound2
    {
        get => orig.deathSound2;
        set => orig.deathSound2 = value;
    }

    public GameObject pool
    {
        get => orig.pool;
        set => orig.pool = value;
    }

    public GameObject screenFlash
    {
        get => orig.screenFlash;
        set => orig.screenFlash = value;
    }

    public Color bloodColor
    {
        get => orig.bloodColor;
        set => orig.bloodColor = value;
    }

    public Transform hero
    {
        get => GetField<Transform>();
        set => SetField(value);
    }

    public float maxSpeed
    {
        get => GetField<float>();
        set => SetField(value);
    }

    public float acceleration
    {
        get => GetField<float>();
        set => SetField(value);
    }

    public bool landed
    {
        get => GetField<bool>();
        set => SetField(value);
    }

    public Coroutine runRoutine
    {
        get => GetField<Coroutine>();
        set => SetField(value);
    }

    public Coroutine bounceRoutine
    {
        get => GetField<Coroutine>();
        set => SetField(value);
    }

    public float rayLength
    {
        get => GetField<float>();
        set => SetField(value);
    }

    public Vector2 rayOrigin
    {
        get => GetField<Vector2>();
        set => SetField(value);
    }

    public tk2dSpriteAnimator anim
    {
        get => GetField<tk2dSpriteAnimator>();
        set => SetField(value);
    }

    public Rigidbody2D body
    {
        get => GetField<Rigidbody2D>();
        set => SetField(value);
    }

    public AudioSource source
    {
        get => GetField<AudioSource>();
        set => SetField(value);
    }

    public bool alive
    {
        get => GetField<bool>();
        set => SetField(value);
    }

    public bool reverseRun
    {
        get => GetField<bool>();
        set => SetField(value);
    }

    public float activateDelay
    {
        get => GetField<float>();
        set => SetField(value);
    }

    public float activateTime
    {
        get => GetField<float>();
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

    public IEnumerator Land()
    {
        return CallMethod<IEnumerator>();
    }

    public IEnumerator Run()
    {
        return CallMethod<IEnumerator>();
    }

    public IEnumerator Bounce(float angleMin, float angleMax)
    {
        return CallMethod<IEnumerator>(new object[] { angleMin, angleMax });
    }

    public IEnumerator Heal()
    {
        return CallMethod<IEnumerator>();
    }

    public void Hit(HitInstance damageInstance)
    {
        orig.Hit(damageInstance);
    }
}