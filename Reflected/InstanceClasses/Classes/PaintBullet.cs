namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of PaintBullet allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class PaintBulletR : InstanceClassWrapper<PaintBullet>
{
    public PaintBulletR(PaintBullet _orig) : base(_orig)
    {
    }

    public float scaleMin
    {
        get => orig.scaleMin;
        set => orig.scaleMin = value;
    }

    public float scaleMax
    {
        get => orig.scaleMax;
        set => orig.scaleMax = value;
    }

    public float scale
    {
        get => GetField<float>();
        set => SetField(value);
    }

    public float stretchFactor
    {
        get => orig.stretchFactor;
        set => orig.stretchFactor = value;
    }

    public float stretchMinX
    {
        get => orig.stretchMinX;
        set => orig.stretchMinX = value;
    }

    public float stretchMaxY
    {
        get => orig.stretchMaxY;
        set => orig.stretchMaxY = value;
    }

    public AudioSource audioSourcePrefab
    {
        get => orig.audioSourcePrefab;
        set => orig.audioSourcePrefab = value;
    }

    public List<AudioClip> splatClips
    {
        get => orig.splatClips;
        set => orig.splatClips = value;
    }

    public ParticleSystem impactParticle
    {
        get => orig.impactParticle;
        set => orig.impactParticle = value;
    }

    public ParticleSystem trailParticle
    {
        get => orig.trailParticle;
        set => orig.trailParticle = value;
    }

    public GameObject splatEffect
    {
        get => orig.splatEffect;
        set => orig.splatEffect = value;
    }

    public tk2dSprite splatEffectSprite
    {
        get => orig.splatEffectSprite;
        set => orig.splatEffectSprite = value;
    }

    public Color colourBlue
    {
        get => orig.colourBlue;
        set => orig.colourBlue = value;
    }

    public Color colourRed
    {
        get => orig.colourRed;
        set => orig.colourRed = value;
    }

    public Color colourPink
    {
        get => orig.colourPink;
        set => orig.colourPink = value;
    }

    public bool active
    {
        get => GetField<bool>();
        set => SetField(value);
    }

    public int colour
    {
        get => orig.colour;
        set => orig.colour = value;
    }

    public List<SpriteRenderer> splatList
    {
        get => GetField<List<SpriteRenderer>>();
        set => SetField(value);
    }

    public int chance
    {
        get => GetField<int>();
        set => SetField(value);
    }

    public bool painting
    {
        get => GetField<bool>();
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

    public SpriteRenderer sprite
    {
        get => GetField<SpriteRenderer>();
        set => SetField(value);
    }


    public void Awake()
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

    public void OnTriggerEnter2D(Collider2D collision)
    {
        CallMethod(new object[] { collision });
    }

    public void OnTriggerExit2D(Collider2D collision)
    {
        CallMethod(new object[] { collision });
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        CallMethod(new object[] { collision });
    }

    public void OrbitShieldHit(Transform shield)
    {
        orig.OrbitShieldHit(shield);
    }

    public IEnumerator Collision(Vector2 normal, bool doRotation)
    {
        return CallMethod<IEnumerator>(new object[] { normal, doRotation });
    }

    public void SetColourBlue()
    {
        orig.SetColourBlue();
    }

    public void SetColourRed()
    {
        orig.SetColourRed();
    }

    public void SetBlue()
    {
        orig.SetBlue();
    }

    public void SetRed()
    {
        orig.SetRed();
    }

    public void SetPink()
    {
        orig.SetPink();
    }
}