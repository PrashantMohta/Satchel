namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of SpellFluke allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class SpellFlukeR : InstanceClassWrapper<SpellFluke>
{
    public SpellFlukeR(SpellFluke _orig) : base(_orig)
    {
    }

    public string airAnim
    {
        get => orig.airAnim;
        set => orig.airAnim = value;
    }

    public string flopAnim
    {
        get => orig.flopAnim;
        set => orig.flopAnim = value;
    }

    public TriggerEnterEvent damager
    {
        get => orig.damager;
        set => orig.damager = value;
    }

    public GameObject splatEffect
    {
        get => orig.splatEffect;
        set => orig.splatEffect = value;
    }

    public AudioSource audioPlayerPrefab
    {
        get => orig.audioPlayerPrefab;
        set => orig.audioPlayerPrefab = value;
    }

    public AudioEventRandom splatSounds
    {
        get => orig.splatSounds;
        set => orig.splatSounds = value;
    }

    public float lifeEndTime
    {
        get => GetField<float>();
        set => SetField(value);
    }

    public int damage
    {
        get => GetField<int>();
        set => SetField(value);
    }

    public bool hasBounced
    {
        get => GetField<bool>();
        set => SetField(value);
    }

    public bool hasBursted
    {
        get => GetField<bool>();
        set => SetField(value);
    }

    public tk2dSpriteAnimator animator
    {
        get => GetField<tk2dSpriteAnimator>();
        set => SetField(value);
    }

    public MeshRenderer meshRenderer
    {
        get => GetField<MeshRenderer>();
        set => SetField(value);
    }

    public Rigidbody2D body
    {
        get => GetField<Rigidbody2D>();
        set => SetField(value);
    }

    public SpriteFlash spriteFlash
    {
        get => GetField<SpriteFlash>();
        set => SetField(value);
    }

    public ObjectBounce objectBounce
    {
        get => GetField<ObjectBounce>();
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

    public void DoDamage(GameObject obj, int upwardRecursionAmount, bool burst = true)
    {
        CallMethod(new object[] { obj, upwardRecursionAmount, burst });
    }

    public void OnEnable()
    {
        CallMethod();
    }

    public void Update()
    {
        CallMethod();
    }

    public void Burst()
    {
        CallMethod();
    }

    public IEnumerator BurstSequence()
    {
        return CallMethod<IEnumerator>();
    }
}