namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of FlipPlatform allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class FlipPlatformR : InstanceClassWrapper<FlipPlatform>
{
    public FlipPlatformR(FlipPlatform _orig) : base(_orig)
    {
    }

    public tk2dSpriteAnimator spriteAnimator
    {
        get => orig.spriteAnimator;
        set => orig.spriteAnimator = value;
    }

    public AudioClip flipSound
    {
        get => orig.flipSound;
        set => orig.flipSound = value;
    }

    public AudioClip flipBackSound
    {
        get => orig.flipBackSound;
        set => orig.flipBackSound = value;
    }

    public AudioClip hitSound
    {
        get => orig.hitSound;
        set => orig.hitSound = value;
    }

    public GameObject strikeEffect
    {
        get => orig.strikeEffect;
        set => orig.strikeEffect = value;
    }

    public GameObject nailStrikePrefab
    {
        get => orig.nailStrikePrefab;
        set => orig.nailStrikePrefab = value;
    }

    public ParticleSystem crystalParticles
    {
        get => orig.crystalParticles;
        set => orig.crystalParticles = value;
    }

    public ParticleSystem crystalHitParticles
    {
        get => orig.crystalHitParticles;
        set => orig.crystalHitParticles = value;
    }

    public GameObject topSpikes
    {
        get => orig.topSpikes;
        set => orig.topSpikes = value;
    }

    public GameObject bottomSpikes
    {
        get => orig.bottomSpikes;
        set => orig.bottomSpikes = value;
    }

    public Coroutine idleRoutine
    {
        get => GetField<Coroutine>();
        set => SetField(value);
    }

    public Coroutine flipRoutine
    {
        get => GetField<Coroutine>();
        set => SetField(value);
    }

    public bool hitCancel
    {
        get => GetField<bool>();
        set => SetField(value);
    }

    public TriggerEnterEvent triggerEnter
    {
        get => GetField<TriggerEnterEvent>();
        set => SetField(value);
    }

    public AudioSource audioSource
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

    public void OnCollisionEnter2D(Collision2D collision)
    {
        CallMethod(new object[] { collision });
    }

    public void PlaySound(AudioClip clip)
    {
        CallMethod(new object[] { clip });
    }

    public IEnumerator Idle()
    {
        return CallMethod<IEnumerator>();
    }

    public IEnumerator Flip()
    {
        return CallMethod<IEnumerator>();
    }

    public IEnumerator Jitter(float duration)
    {
        return CallMethod<IEnumerator>(new object[] { duration });
    }
}