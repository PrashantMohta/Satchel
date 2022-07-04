namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of CorpseGoopExplode allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class CorpseGoopExplodeR : InstanceClassWrapper<CorpseGoopExplode>
{
    public CorpseGoopExplodeR(CorpseGoopExplode _orig) : base(_orig)
    {
    }

    public GameObject gasExplosion
    {
        get => orig.gasExplosion;
        set => orig.gasExplosion = value;
    }

    public AudioEvent gushSound
    {
        get => orig.gushSound;
        set => orig.gushSound = value;
    }

    public MeshRenderer meshRenderer
    {
        get => GetField<MeshRenderer>();
        set => SetField(value);
    }

    public tk2dSprite sprite
    {
        get => GetField<tk2dSprite>();
        set => SetField(value);
    }

    public tk2dSpriteAnimator spriteAnimator
    {
        get => GetField<tk2dSpriteAnimator>();
        set => SetField(value);
    }

    public SpriteFlash spriteFlash
    {
        get => GetField<SpriteFlash>();
        set => SetField(value);
    }

    public Rigidbody2D body
    {
        get => GetField<Rigidbody2D>();
        set => SetField(value);
    }

    public Collider2D bodyCollider
    {
        get => GetField<Collider2D>();
        set => SetField(value);
    }

    public ParticleSystem corpseFlame
    {
        get => GetField<ParticleSystem>();
        set => SetField(value);
    }

    public ParticleSystem corpseSteam
    {
        get => GetField<ParticleSystem>();
        set => SetField(value);
    }

    public GameObject landEffects
    {
        get => GetField<GameObject>();
        set => SetField(value);
    }

    public AudioSource audioPlayerPrefab
    {
        get => GetField<AudioSource>();
        set => SetField(value);
    }

    public GameObject deathWaveInfectedPrefab
    {
        get => GetField<GameObject>();
        set => SetField(value);
    }

    public GameObject spatterOrangePrefab
    {
        get => GetField<GameObject>();
        set => SetField(value);
    }

    public RandomAudioClipTable splatAudioClipTable
    {
        get => GetField<RandomAudioClipTable>();
        set => SetField(value);
    }

    public bool spellBurn
    {
        get => GetField<bool>();
        set => SetField(value);
    }

    public bool hitAcid
    {
        get => GetField<bool>();
        set => SetField(value);
    }


    public void Start()
    {
        CallMethod();
    }

    public void LandEffects()
    {
        CallMethod();
    }

    public IEnumerator DoLandEffects()
    {
        return CallMethod<IEnumerator>();
    }

    public IEnumerator Jitter(float duration)
    {
        return CallMethod<IEnumerator>(new object[] { duration });
    }
}