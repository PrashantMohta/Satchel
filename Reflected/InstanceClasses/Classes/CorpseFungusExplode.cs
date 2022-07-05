namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of CorpseFungusExplode allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class CorpseFungusExplodeR : InstanceClassWrapper<CorpseFungusExplode>
{
    public CorpseFungusExplodeR(CorpseFungusExplode _orig) : base(_orig)
    {
    }

    public ParticleSystem anticSteam
    {
        get => orig.anticSteam;
        set => orig.anticSteam = value;
    }

    public ParticleSystem gasAttack
    {
        get => orig.gasAttack;
        set => orig.gasAttack = value;
    }

    public AudioEvent gushSound
    {
        get => orig.gushSound;
        set => orig.gushSound = value;
    }

    public AudioEvent explodeSound
    {
        get => orig.explodeSound;
        set => orig.explodeSound = value;
    }

    public GameObject gasHitBox
    {
        get => orig.gasHitBox;
        set => orig.gasHitBox = value;
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