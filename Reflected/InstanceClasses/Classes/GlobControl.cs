namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of GlobControl allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class GlobControlR : InstanceClassWrapper<GlobControl>
{
    public GlobControlR(GlobControl _orig) : base(_orig)
    {
    }

    public Renderer rend
    {
        get => orig.rend;
        set => orig.rend = value;
    }

    public float minScale
    {
        get => orig.minScale;
        set => orig.minScale = value;
    }

    public float maxScale
    {
        get => orig.maxScale;
        set => orig.maxScale = value;
    }

    public string landAnim
    {
        get => orig.landAnim;
        set => orig.landAnim = value;
    }

    public string wobbleAnim
    {
        get => orig.wobbleAnim;
        set => orig.wobbleAnim = value;
    }

    public string breakAnim
    {
        get => orig.breakAnim;
        set => orig.breakAnim = value;
    }

    public AudioSource audioPlayerPrefab
    {
        get => orig.audioPlayerPrefab;
        set => orig.audioPlayerPrefab = value;
    }

    public AudioEvent breakSound
    {
        get => orig.breakSound;
        set => orig.breakSound = value;
    }

    public Color bloodColorOverride
    {
        get => orig.bloodColorOverride;
        set => orig.bloodColorOverride = value;
    }

    public GameObject splatChild
    {
        get => orig.splatChild;
        set => orig.splatChild = value;
    }

    public Collider2D groundCollider
    {
        get => orig.groundCollider;
        set => orig.groundCollider = value;
    }

    public bool landed
    {
        get => GetField<bool>();
        set => SetField(value);
    }

    public bool broken
    {
        get => GetField<bool>();
        set => SetField(value);
    }

    public tk2dSpriteAnimator anim
    {
        get => GetField<tk2dSpriteAnimator>();
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

    public void Start()
    {
        CallMethod();
    }

    public void OnTriggerEnter2D(Collider2D col)
    {
        CallMethod(new object[] { col });
    }

    public IEnumerator Break()
    {
        return CallMethod<IEnumerator>();
    }

    public bool CheckForGround()
    {
        return CallMethod<bool>();
    }
}