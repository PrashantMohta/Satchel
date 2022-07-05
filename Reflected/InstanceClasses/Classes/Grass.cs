namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of Grass allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class GrassR : InstanceClassWrapper<Grass>
{
    public GrassR(Grass _orig) : base(_orig)
    {
    }

    public Animator animator
    {
        get => GetField<Animator>();
        set => SetField(value);
    }

    public Collider2D bodyCollider
    {
        get => GetField<Collider2D>();
        set => SetField(value);
    }

    public AudioSource audioSource
    {
        get => GetField<AudioSource>();
        set => SetField(value);
    }

    public bool isInfectable
    {
        get => GetField<bool>();
        set => SetField(value);
    }

    public float inertBackgroundThreshold
    {
        get => GetField<float>();
        set => SetField(value);
    }

    public float inertForegroundThreshold
    {
        get => GetField<float>();
        set => SetField(value);
    }

    public Color infectedColor
    {
        get => GetField<Color>();
        set => SetField(value);
    }

    public bool preventPushAnimation
    {
        get => GetField<bool>();
        set => SetField(value);
    }

    public GameObject slashImpactPrefab
    {
        get => GetField<GameObject>();
        set => SetField(value);
    }

    public float slashImpactRotationMin
    {
        get => GetField<float>();
        set => SetField(value);
    }

    public float slashImpactRotationMax
    {
        get => GetField<float>();
        set => SetField(value);
    }

    public float slashImpactScale
    {
        get => GetField<float>();
        set => SetField(value);
    }

    public GameObject infectedCutPrefab0
    {
        get => GetField<GameObject>();
        set => SetField(value);
    }

    public GameObject infectedCutPrefab1
    {
        get => GetField<GameObject>();
        set => SetField(value);
    }

    public GameObject cutPrefab0
    {
        get => GetField<GameObject>();
        set => SetField(value);
    }

    public GameObject cutPrefab1
    {
        get => GetField<GameObject>();
        set => SetField(value);
    }

    public ParticleSystem childParticleSystem
    {
        get => GetField<ParticleSystem>();
        set => SetField(value);
    }

    public float childParticleSystemDuration
    {
        get => GetField<float>();
        set => SetField(value);
    }

    public RandomAudioClipTable pushAudioClipTable
    {
        get => GetField<RandomAudioClipTable>();
        set => SetField(value);
    }

    public RandomAudioClipTable cutAudioClipTable
    {
        get => GetField<RandomAudioClipTable>();
        set => SetField(value);
    }

    public int IdleStateId
    {
        get => GetFieldStatic<int>();
        set => SetField(value);
    }

    public int PushStateId
    {
        get => GetFieldStatic<int>();
        set => SetField(value);
    }

    public int DeadStateId
    {
        get => GetFieldStatic<int>();
        set => SetField(value);
    }

    public bool isInfected
    {
        get => GetField<bool>();
        set => SetField(value);
    }

    public bool isCut
    {
        get => GetField<bool>();
        set => SetField(value);
    }

    public float childParticleSystemTimer
    {
        get => GetField<float>();
        set => SetField(value);
    }

    public List<Grass> grasses
    {
        get => GetFieldStatic<List<Grass>>();
        set => SetField(value);
    }


    public void Init()
    {
        CallMethodStatic();
    }

    public void Reset()
    {
        CallMethod();
    }

    public void Awake()
    {
        CallMethod();
    }

    public void OnDestroy()
    {
        CallMethod();
    }

    public void Start()
    {
        CallMethod();
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        CallMethod(new object[] { other });
    }

    public void Push(bool isAllGrass)
    {
        orig.Push(isAllGrass);
    }

    public void PushAll()
    {
        Grass.PushAll();
    }

    public void Hit(HitInstance damageInstance)
    {
        orig.Hit(damageInstance);
    }

    public void Update()
    {
        CallMethod();
    }
}