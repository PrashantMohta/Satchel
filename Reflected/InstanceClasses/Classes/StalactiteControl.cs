namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of StalactiteControl allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class StalactiteControlR : InstanceClassWrapper<StalactiteControl>
{
    public StalactiteControlR(StalactiteControl _orig) : base(_orig)
    {
    }

    public GameObject top
    {
        get => orig.top;
        set => orig.top = value;
    }

    public float startFallOffset
    {
        get => orig.startFallOffset;
        set => orig.startFallOffset = value;
    }

    public GameObject startFallEffect
    {
        get => orig.startFallEffect;
        set => orig.startFallEffect = value;
    }

    public AudioClip startFallSound
    {
        get => orig.startFallSound;
        set => orig.startFallSound = value;
    }

    public float fallDelay
    {
        get => orig.fallDelay;
        set => orig.fallDelay = value;
    }

    public GameObject fallEffect
    {
        get => orig.fallEffect;
        set => orig.fallEffect = value;
    }

    public GameObject trailEffect
    {
        get => orig.trailEffect;
        set => orig.trailEffect = value;
    }

    public GameObject nailStrikePrefab
    {
        get => orig.nailStrikePrefab;
        set => orig.nailStrikePrefab = value;
    }

    public GameObject embeddedVersion
    {
        get => orig.embeddedVersion;
        set => orig.embeddedVersion = value;
    }

    public GameObject[] landEffectPrefabs
    {
        get => orig.landEffectPrefabs;
        set => orig.landEffectPrefabs = value;
    }

    public float hitVelocity
    {
        get => orig.hitVelocity;
        set => orig.hitVelocity = value;
    }

    public GameObject[] hitUpEffectPrefabs
    {
        get => orig.hitUpEffectPrefabs;
        set => orig.hitUpEffectPrefabs = value;
    }

    public AudioClip hitSound
    {
        get => orig.hitSound;
        set => orig.hitSound = value;
    }

    public GameObject hitUpRockPrefabs
    {
        get => orig.hitUpRockPrefabs;
        set => orig.hitUpRockPrefabs = value;
    }

    public int spawnMin
    {
        get => orig.spawnMin;
        set => orig.spawnMin = value;
    }

    public int spawnMax
    {
        get => orig.spawnMax;
        set => orig.spawnMax = value;
    }

    public int speedMin
    {
        get => orig.speedMin;
        set => orig.speedMin = value;
    }

    public int speedMax
    {
        get => orig.speedMax;
        set => orig.speedMax = value;
    }

    public AudioClip breakSound
    {
        get => orig.breakSound;
        set => orig.breakSound = value;
    }

    public TriggerEnterEvent trigger
    {
        get => GetField<TriggerEnterEvent>();
        set => SetField(value);
    }

    public DamageHero heroDamage
    {
        get => GetField<DamageHero>();
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

    public DamageEnemies damageEnemies
    {
        get => GetField<DamageEnemies>();
        set => SetField(value);
    }

    public bool fallen
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

    public void HandleTriggerEnter(Collider2D collider, GameObject sender)
    {
        CallMethod(new object[] { collider, sender });
    }

    public IEnumerator Fall(float delay)
    {
        return CallMethod<IEnumerator>(new object[] { delay });
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        CallMethod(new object[] { collision });
    }

    public void FlingObjects()
    {
        CallMethod();
    }
}