namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of KnightHatchling allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class KnightHatchlingR : InstanceClassWrapper<KnightHatchling>
{
    public KnightHatchlingR(KnightHatchling _orig) : base(_orig)
    {
    }

    public TriggerEnterEvent enemyRange
    {
        get => orig.enemyRange;
        set => orig.enemyRange = value;
    }

    public TriggerEnterEvent groundRange
    {
        get => orig.groundRange;
        set => orig.groundRange = value;
    }

    public Collider2D terrainCollider
    {
        get => orig.terrainCollider;
        set => orig.terrainCollider = value;
    }

    public List<Collider2D> groundColliders
    {
        get => GetField<List<Collider2D>>();
        set => SetField(value);
    }

    public GameObject target
    {
        get => GetField<GameObject>();
        set => SetField(value);
    }

    public ParticleSystem dungPt
    {
        get => orig.dungPt;
        set => orig.dungPt = value;
    }

    public AudioClip[] loopClips
    {
        get => orig.loopClips;
        set => orig.loopClips = value;
    }

    public AudioClip attackChargeClip
    {
        get => orig.attackChargeClip;
        set => orig.attackChargeClip = value;
    }

    public AudioSource audioSourcePrefab
    {
        get => orig.audioSourcePrefab;
        set => orig.audioSourcePrefab = value;
    }

    public AudioEvent explodeSound
    {
        get => orig.explodeSound;
        set => orig.explodeSound = value;
    }

    public AudioEvent dungExplodeSound
    {
        get => orig.dungExplodeSound;
        set => orig.dungExplodeSound = value;
    }

    public AudioEventRandom dungSleepPlopSound
    {
        get => orig.dungSleepPlopSound;
        set => orig.dungSleepPlopSound = value;
    }

    public GameObject dungExplosionPrefab
    {
        get => orig.dungExplosionPrefab;
        set => orig.dungExplosionPrefab = value;
    }

    public float targetRadius
    {
        get => GetField<float>();
        set => SetField(value);
    }

    public Vector3 offset
    {
        get => GetField<Vector3>();
        set => SetField(value);
    }

    public float awayTimer
    {
        get => GetField<float>();
        set => SetField(value);
    }

    public float attackFinishTime
    {
        get => GetField<float>();
        set => SetField(value);
    }

    public float benchRestWaitTime
    {
        get => GetField<float>();
        set => SetField(value);
    }

    public bool quickSpawn
    {
        get => GetField<bool>();
        set => SetField(value);
    }

    public bool dreamSpawn
    {
        get => GetField<bool>();
        set => SetField(value);
    }

    public float startZ
    {
        get => GetField<float>();
        set => SetField(value);
    }

    public float sleepZ
    {
        get => GetField<float>();
        set => SetField(value);
    }

    public DamageEnemies damageEnemies
    {
        get => orig.damageEnemies;
        set => orig.damageEnemies = value;
    }

    public AudioSource audioSource
    {
        get => GetField<AudioSource>();
        set => SetField(value);
    }

    public MeshRenderer meshRenderer
    {
        get => GetField<MeshRenderer>();
        set => SetField(value);
    }

    public tk2dSpriteAnimator animator
    {
        get => GetField<tk2dSpriteAnimator>();
        set => SetField(value);
    }

    public Rigidbody2D body
    {
        get => GetField<Rigidbody2D>();
        set => SetField(value);
    }

    public Collider2D col
    {
        get => GetField<Collider2D>();
        set => SetField(value);
    }

    public SpriteFlash spriteFlash
    {
        get => GetField<SpriteFlash>();
        set => SetField(value);
    }

    public float pauseTimer
    {
        get => GetField<float>();
        set => SetField(value);
    }

    public float xScale
    {
        get => GetField<float>();
        set => SetField(value);
    }

    public float startX
    {
        get => GetField<float>();
        set => SetField(value);
    }

    public float startY
    {
        get => GetField<float>();
        set => SetField(value);
    }

    public float accelY
    {
        get => GetField<float>();
        set => SetField(value);
    }

    public float accelX
    {
        get => GetField<float>();
        set => SetField(value);
    }

    public float waitTime
    {
        get => GetField<float>();
        set => SetField(value);
    }

    public bool IsGrounded => orig.IsGrounded;


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

    public void OnDisable()
    {
        CallMethod();
    }

    public void FixedUpdate()
    {
        CallMethod();
    }

    public IEnumerator Spawn()
    {
        return CallMethod<IEnumerator>();
    }

    public float GetHeroDistance()
    {
        return CallMethod<float>();
    }

    public IEnumerator TeleEnd()
    {
        return CallMethod<IEnumerator>();
    }

    public void FsmHitLanded()
    {
        orig.FsmHitLanded();
    }

    public IEnumerator Explode()
    {
        return CallMethod<IEnumerator>();
    }

    public void FsmCharmsEnd()
    {
        orig.FsmCharmsEnd();
    }

    public IEnumerator CharmsEnd()
    {
        return CallMethod<IEnumerator>();
    }

    public void FsmHazardReload()
    {
        orig.FsmHazardReload();
    }

    public void FsmBenchRestStart()
    {
        orig.FsmBenchRestStart();
    }

    public void FsmBenchRestEnd()
    {
        orig.FsmBenchRestEnd();
    }

    public IEnumerator WakeUp()
    {
        return CallMethod<IEnumerator>();
    }

    public void FsmQuickSpawn()
    {
        orig.FsmQuickSpawn();
    }

    public void FsmDreamGateOut()
    {
        orig.FsmDreamGateOut();
    }

    public IEnumerator DreamGateOut()
    {
        return CallMethod<IEnumerator>();
    }

    public void DoFace(bool spriteFacesRight, bool playNewAnimation, string newAnimationClip, bool pauseBetweenTurns,
        float pauseTime)
    {
        CallMethod(new object[] { spriteFacesRight, playNewAnimation, newAnimationClip, pauseBetweenTurns, pauseTime });
    }

    public void DoChase(Transform target, float distance, float speedMax, float accelerationForce, float targetRadius,
        float deceleration, Vector2 offset)
    {
        CallMethod(new object[] { target, distance, speedMax, accelerationForce, targetRadius, deceleration, offset });
    }

    public void DoBuzz(float waitMin, float waitMax, float speedMax, float accelerationMin, float accelerationMax,
        Vector2 roamingRange)
    {
        CallMethod(new object[] { waitMin, waitMax, speedMax, accelerationMin, accelerationMax, roamingRange });
    }

    public void DoChaseSimple(Transform target, float speedMax, float accelerationForce, float offsetX, float offsetY)
    {
        CallMethod(new object[] { target, speedMax, accelerationForce, offsetX, offsetY });
    }
}