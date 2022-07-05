namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of BossStatueDreamToggle allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class BossStatueDreamToggleR : InstanceClassWrapper<BossStatueDreamToggle>
{
    public BossStatueDreamToggleR(BossStatueDreamToggle _orig) : base(_orig)
    {
    }

    public GameObject litPieces
    {
        get => orig.litPieces;
        set => orig.litPieces = value;
    }

    public ParticleSystem[] particles
    {
        get => orig.particles;
        set => orig.particles = value;
    }

    public GameObject dreamImpactPrefab
    {
        get => orig.dreamImpactPrefab;
        set => orig.dreamImpactPrefab = value;
    }

    public Vector3 dreamImpactScale
    {
        get => orig.dreamImpactScale;
        set => orig.dreamImpactScale = value;
    }

    public Transform dreamImpactPoint
    {
        get => orig.dreamImpactPoint;
        set => orig.dreamImpactPoint = value;
    }

    public bool canToggle
    {
        get => GetField<bool>();
        set => SetField(value);
    }

    public ColorFader[] colorFaders
    {
        get => GetField<ColorFader[]>();
        set => SetField(value);
    }

    public int waitingForFade
    {
        get => GetField<int>();
        set => SetField(value);
    }

    public GameObject dreamBurstEffectPrefab
    {
        get => orig.dreamBurstEffectPrefab;
        set => orig.dreamBurstEffectPrefab = value;
    }

    public GameObject dreamBurstEffectOffPrefab
    {
        get => orig.dreamBurstEffectOffPrefab;
        set => orig.dreamBurstEffectOffPrefab = value;
    }

    public Transform dreamBurstSpawnPoint
    {
        get => orig.dreamBurstSpawnPoint;
        set => orig.dreamBurstSpawnPoint = value;
    }

    public GameObject dreamBurstEffect
    {
        get => GetField<GameObject>();
        set => SetField(value);
    }

    public GameObject dreamBurstEffectOff
    {
        get => GetField<GameObject>();
        set => SetField(value);
    }

    public BossStatue bossStatue
    {
        get => GetField<BossStatue>();
        set => SetField(value);
    }


    public void OnEnable()
    {
        CallMethod();
    }

    public void Start()
    {
        CallMethod();
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        CallMethod(new object[] { collision });
    }

    public IEnumerator Fade(bool usingDreamVersion)
    {
        return CallMethod<IEnumerator>(new object[] { usingDreamVersion });
    }

    public void SetOwner(BossStatue statue)
    {
        orig.SetOwner(statue);
    }

    public void SetState(bool value)
    {
        orig.SetState(value);
    }
}