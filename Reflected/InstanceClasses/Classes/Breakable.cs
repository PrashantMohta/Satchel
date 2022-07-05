namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of Breakable allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class BreakableR : InstanceClassWrapper<Breakable>
{
    public BreakableR(Breakable _orig) : base(_orig)
    {
    }

    public Collider2D bodyCollider
    {
        get => GetField<Collider2D>();
        set => SetField(value);
    }

    public Renderer wholeRenderer
    {
        get => GetField<Renderer>();
        set => SetField(value);
    }

    public GameObject[] wholeParts
    {
        get => GetField<GameObject[]>();
        set => SetField(value);
    }

    public GameObject[] remnantParts
    {
        get => GetField<GameObject[]>();
        set => SetField(value);
    }

    public List<GameObject> debrisParts
    {
        get => GetField<List<GameObject>>();
        set => SetField(value);
    }

    public float angleOffset
    {
        get => GetField<float>();
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

    public Vector3 effectOffset
    {
        get => GetField<Vector3>();
        set => SetField(value);
    }

    public AudioSource audioSourcePrefab
    {
        get => GetField<AudioSource>();
        set => SetField(value);
    }

    public AudioEvent breakAudioEvent
    {
        get => GetField<AudioEvent>();
        set => SetField(value);
    }

    public RandomAudioClipTable breakAudioClipTable
    {
        get => GetField<RandomAudioClipTable>();
        set => SetField(value);
    }

    public Transform dustHitRegularPrefab
    {
        get => GetField<Transform>();
        set => SetField(value);
    }

    public Transform dustHitDownPrefab
    {
        get => GetField<Transform>();
        set => SetField(value);
    }

    public float flingSpeedMin
    {
        get => GetField<float>();
        set => SetField(value);
    }

    public float flingSpeedMax
    {
        get => GetField<float>();
        set => SetField(value);
    }

    public Transform strikeEffectPrefab
    {
        get => GetField<Transform>();
        set => SetField(value);
    }

    public Transform nailHitEffectPrefab
    {
        get => GetField<Transform>();
        set => SetField(value);
    }

    public Transform spellHitEffectPrefab
    {
        get => GetField<Transform>();
        set => SetField(value);
    }

    public bool preventParticleRotation
    {
        get => GetField<bool>();
        set => SetField(value);
    }

    public GameObject hitEventReciever
    {
        get => GetField<GameObject>();
        set => SetField(value);
    }

    public bool forwardBreakEvent
    {
        get => GetField<bool>();
        set => SetField(value);
    }

    public Probability.ProbabilityGameObject[] containingParticles
    {
        get => orig.containingParticles;
        set => orig.containingParticles = value;
    }

    public Breakable.FlingObject[] flingObjectRegister
    {
        get => orig.flingObjectRegister;
        set => orig.flingObjectRegister = value;
    }

    public bool isBroken
    {
        get => GetField<bool>();
        set => SetField(value);
    }


    public void Reset()
    {
        CallMethod();
    }

    public void Awake()
    {
        CallMethod();
    }

    public void Start()
    {
        CallMethod();
    }

    public void CreateAdditionalDebrisParts(List<GameObject> debrisParts)
    {
        CallMethod(new object[] { debrisParts });
    }

    public void BreakSelf()
    {
        orig.BreakSelf();
    }

    public void Hit(HitInstance damageInstance)
    {
        orig.Hit(damageInstance);
    }

    public Transform SpawnNailHitEffect(Transform nailHitEffectPrefab, Vector3 position, float impactAngle)
    {
        return CallMethodStatic<Transform>(new object[] { nailHitEffectPrefab, position, impactAngle });
    }

    public void SetStaticPartsActivation(bool broken)
    {
        CallMethod(new object[] { broken });
    }

    public void Break(float flingAngleMin, float flingAngleMax, float impactMultiplier)
    {
        orig.Break(flingAngleMin, flingAngleMax, impactMultiplier);
    }
}