namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of SoulOrb allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class SoulOrbR : InstanceClassWrapper<SoulOrb>
{
    public SoulOrbR(SoulOrb _orig) : base(_orig)
    {
    }

    public RandomAudioClipTable soulOrbCollectSounds
    {
        get => orig.soulOrbCollectSounds;
        set => orig.soulOrbCollectSounds = value;
    }

    public ParticleSystem getParticles
    {
        get => orig.getParticles;
        set => orig.getParticles = value;
    }

    public bool awardSoul
    {
        get => orig.awardSoul;
        set => orig.awardSoul = value;
    }

    public bool dontRecycle
    {
        get => orig.dontRecycle;
        set => orig.dontRecycle = value;
    }

    public Transform target
    {
        get => GetField<Transform>();
        set => SetField(value);
    }

    public float speed
    {
        get => GetField<float>();
        set => SetField(value);
    }

    public float acceleration
    {
        get => GetField<float>();
        set => SetField(value);
    }

    public SpriteRenderer sprite
    {
        get => GetField<SpriteRenderer>();
        set => SetField(value);
    }

    public TrailRenderer trail
    {
        get => GetField<TrailRenderer>();
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

    public Coroutine zoomRoutine
    {
        get => GetField<Coroutine>();
        set => SetField(value);
    }

    public float stretchFactor
    {
        get => orig.stretchFactor;
        set => orig.stretchFactor = value;
    }

    public float stretchMinY
    {
        get => orig.stretchMinY;
        set => orig.stretchMinY = value;
    }

    public float stretchMaxX
    {
        get => orig.stretchMaxX;
        set => orig.stretchMaxX = value;
    }

    public float scaleModifier
    {
        get => orig.scaleModifier;
        set => orig.scaleModifier = value;
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


    public void Awake()
    {
        CallMethod();
    }

    public void Start()
    {
        CallMethod();
    }

    public void OnDisable()
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

    public void SceneLoading()
    {
        CallMethod();
    }

    public IEnumerator Zoom(bool doZoom = true)
    {
        return CallMethod<IEnumerator>(new object[] { doZoom });
    }

    public void FireAtTarget()
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
}