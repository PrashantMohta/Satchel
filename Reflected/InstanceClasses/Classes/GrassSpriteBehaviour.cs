namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of GrassSpriteBehaviour allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class GrassSpriteBehaviourR : InstanceClassWrapper<GrassSpriteBehaviour>
{
    public GrassSpriteBehaviourR(GrassSpriteBehaviour _orig) : base(_orig)
    {
    }

    public bool isWindy
    {
        get => orig.isWindy;
        set => orig.isWindy = value;
    }

    public bool noPushAnimation
    {
        get => orig.noPushAnimation;
        set => orig.noPushAnimation = value;
    }

    public GameObject deathParticles
    {
        get => orig.deathParticles;
        set => orig.deathParticles = value;
    }

    public GameObject deathParticlesWindy
    {
        get => orig.deathParticlesWindy;
        set => orig.deathParticlesWindy = value;
    }

    public GameObject cutEffectPrefab
    {
        get => orig.cutEffectPrefab;
        set => orig.cutEffectPrefab = value;
    }

    public AudioClip[] pushSounds
    {
        get => orig.pushSounds;
        set => orig.pushSounds = value;
    }

    public AudioClip[] cutSounds
    {
        get => orig.cutSounds;
        set => orig.cutSounds = value;
    }

    public string idleAnimation
    {
        get => orig.idleAnimation;
        set => orig.idleAnimation = value;
    }

    public string pushAnimation
    {
        get => orig.pushAnimation;
        set => orig.pushAnimation = value;
    }

    public string cutAnimation
    {
        get => orig.cutAnimation;
        set => orig.cutAnimation = value;
    }

    public string idleWindyAnimation
    {
        get => orig.idleWindyAnimation;
        set => orig.idleWindyAnimation = value;
    }

    public string pushWindyAnimation
    {
        get => orig.pushWindyAnimation;
        set => orig.pushWindyAnimation = value;
    }

    public bool isCut
    {
        get => GetField<bool>();
        set => SetField(value);
    }

    public bool interaction
    {
        get => GetField<bool>();
        set => SetField(value);
    }

    public bool visible
    {
        get => GetField<bool>();
        set => SetField(value);
    }

    public Animator animator
    {
        get => GetField<Animator>();
        set => SetField(value);
    }

    public AudioSource source
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

    public void OnBecameVisible()
    {
        CallMethod();
    }

    public void OnBecameInvisible()
    {
        CallMethod();
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        CallMethod(new object[] { collision });
    }

    public void Init()
    {
        CallMethod();
    }

    public void SetWindy()
    {
        orig.SetWindy();
    }

    public void SetNotWindy()
    {
        orig.SetNotWindy();
    }
}