namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of GrassBehaviour allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class GrassBehaviourR : InstanceClassWrapper<GrassBehaviour>
{
    public GrassBehaviourR(GrassBehaviour _orig) : base(_orig)
    {
    }

    public float walkReactAmount
    {
        get => orig.walkReactAmount;
        set => orig.walkReactAmount = value;
    }

    public AnimationCurve walkReactCurve
    {
        get => orig.walkReactCurve;
        set => orig.walkReactCurve = value;
    }

    public float walkReactLength
    {
        get => orig.walkReactLength;
        set => orig.walkReactLength = value;
    }

    public float attackReactAmount
    {
        get => orig.attackReactAmount;
        set => orig.attackReactAmount = value;
    }

    public AnimationCurve attackReactCurve
    {
        get => orig.attackReactCurve;
        set => orig.attackReactCurve = value;
    }

    public float attackReactLength
    {
        get => orig.attackReactLength;
        set => orig.attackReactLength = value;
    }

    public string pushAnim
    {
        get => orig.pushAnim;
        set => orig.pushAnim = value;
    }

    public Animator animator
    {
        get => GetField<Animator>();
        set => SetField(value);
    }

    public AudioClip[] pushSounds
    {
        get => orig.pushSounds;
        set => orig.pushSounds = value;
    }

    public AudioClip[] cutPushSounds
    {
        get => orig.cutPushSounds;
        set => orig.cutPushSounds = value;
    }

    public AudioClip[] cutSounds
    {
        get => orig.cutSounds;
        set => orig.cutSounds = value;
    }

    public AudioSource source
    {
        get => GetField<AudioSource>();
        set => SetField(value);
    }

    public Color infectedColor
    {
        get => orig.infectedColor;
        set => orig.infectedColor = value;
    }

    public bool neverInfected
    {
        get => orig.neverInfected;
        set => orig.neverInfected = value;
    }

    public bool colorSet
    {
        get => GetFieldStatic<bool>();
        set => SetField(value);
    }

    public AnimationCurve curve
    {
        get => GetField<AnimationCurve>();
        set => SetField(value);
    }

    public float animLength
    {
        get => GetField<float>();
        set => SetField(value);
    }

    public float animElapsed
    {
        get => GetField<float>();
        set => SetField(value);
    }

    public float pushAmount
    {
        get => GetField<float>();
        set => SetField(value);
    }

    public float pushDirection
    {
        get => GetField<float>();
        set => SetField(value);
    }

    public bool returned
    {
        get => GetField<bool>();
        set => SetField(value);
    }

    public bool cutFirstFrame
    {
        get => GetField<bool>();
        set => SetField(value);
    }

    public bool isCut
    {
        get => GetField<bool>();
        set => SetField(value);
    }

    public float pushAmountError
    {
        get => GetField<float>();
        set => SetField(value);
    }

    public Rigidbody2D player
    {
        get => GetField<Rigidbody2D>();
        set => SetField(value);
    }

    public Vector3 oldPlayerPos
    {
        get => GetField<Vector3>();
        set => SetField(value);
    }

    public SpriteRenderer[] renderers
    {
        get => GetField<SpriteRenderer[]>();
        set => SetField(value);
    }

    public Dictionary<string, Material> sharedMaterials
    {
        get => GetFieldStatic<Dictionary<string, Material>>();
        set => SetField(value);
    }

    public int grassCount
    {
        get => GetFieldStatic<int>();
        set => SetField(value);
    }

    public Material sharedMaterial
    {
        get => GetField<Material>();
        set => SetField(value);
    }

    public MaterialPropertyBlock propertyBlock
    {
        get => GetField<MaterialPropertyBlock>();
        set => SetField(value);
    }

    public Material SharedMaterial => orig.SharedMaterial;


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

    public IEnumerator DelayedInfectedCheck()
    {
        return CallMethod<IEnumerator>();
    }

    public void LateUpdate()
    {
        CallMethod();
    }

    public void FixedUpdate()
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

    public void CutReact(Collider2D collision)
    {
        orig.CutReact(collision);
    }

    public void WindReact(Collider2D collision)
    {
        orig.WindReact(collision);
    }

    public void PlayRandomSound(AudioClip[] clips)
    {
        CallMethod(new object[] { clips });
    }

    public void SetPushAmount(Renderer rend, float value)
    {
        CallMethod(new object[] { rend, value });
    }
}