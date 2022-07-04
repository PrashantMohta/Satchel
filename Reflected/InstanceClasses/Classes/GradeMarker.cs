namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of GradeMarker allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class GradeMarkerR : InstanceClassWrapper<GradeMarker>
{
    public GradeMarkerR(GradeMarker _orig) : base(_orig)
    {
    }

    public bool enableGrade
    {
        get => orig.enableGrade;
        set => orig.enableGrade = value;
    }

    public bool activating
    {
        get => GetField<bool>();
        set => SetField(value);
    }

    public bool deactivating
    {
        get => GetField<bool>();
        set => SetField(value);
    }

    public float maxIntensityRadius
    {
        get => orig.maxIntensityRadius;
        set => orig.maxIntensityRadius = value;
    }

    public float cutoffRadius
    {
        get => orig.cutoffRadius;
        set => orig.cutoffRadius = value;
    }

    public float saturation
    {
        get => orig.saturation;
        set => orig.saturation = value;
    }

    public AnimationCurve redChannel
    {
        get => orig.redChannel;
        set => orig.redChannel = value;
    }

    public AnimationCurve greenChannel
    {
        get => orig.greenChannel;
        set => orig.greenChannel = value;
    }

    public AnimationCurve blueChannel
    {
        get => orig.blueChannel;
        set => orig.blueChannel = value;
    }

    public float ambientIntensity
    {
        get => orig.ambientIntensity;
        set => orig.ambientIntensity = value;
    }

    public Color ambientColor
    {
        get => orig.ambientColor;
        set => orig.ambientColor = value;
    }

    public Color heroLightColor
    {
        get => orig.heroLightColor;
        set => orig.heroLightColor = value;
    }

    public GameManager gm
    {
        get => GetField<GameManager>();
        set => SetField(value);
    }

    public GameCameras gc
    {
        get => GetField<GameCameras>();
        set => SetField(value);
    }

    public HeroController hero
    {
        get => GetField<HeroController>();
        set => SetField(value);
    }

    public SceneColorManager scm
    {
        get => GetField<SceneColorManager>();
        set => SetField(value);
    }

    public int updateEvery
    {
        get => GetField<int>();
        set => SetField(value);
    }

    public Vector2 heading
    {
        get => GetField<Vector2>();
        set => SetField(value);
    }

    public float sqrNear
    {
        get => GetField<float>();
        set => SetField(value);
    }

    public float sqrFar
    {
        get => GetField<float>();
        set => SetField(value);
    }

    public float sqrEffectRange
    {
        get => GetField<float>();
        set => SetField(value);
    }

    public float t
    {
        get => GetField<float>();
        set => SetField(value);
    }

    public float u
    {
        get => GetField<float>();
        set => SetField(value);
    }

    public float origMaxIntensityRadius
    {
        get => GetField<float>();
        set => SetField(value);
    }

    public float origCutoffRadius
    {
        get => GetField<float>();
        set => SetField(value);
    }

    public float startMaxIntensityRadius
    {
        get => GetField<float>();
        set => SetField(value);
    }

    public float startCutoffRadius
    {
        get => GetField<float>();
        set => SetField(value);
    }

    public float finalMaxIntensityRadius
    {
        get => GetField<float>();
        set => SetField(value);
    }

    public float finalCutoffRadius
    {
        get => GetField<float>();
        set => SetField(value);
    }

    public float shrunkPercentage
    {
        get => GetField<float>();
        set => SetField(value);
    }

    public float easeDuration
    {
        get => orig.easeDuration;
        set => orig.easeDuration = value;
    }

    public float easeTimer
    {
        get => GetField<float>();
        set => SetField(value);
    }

    public IEnumerator startup
    {
        get => GetField<IEnumerator>();
        set => SetField(value);
    }


    public void OnEnable()
    {
        CallMethod();
    }

    public void OnDisable()
    {
        CallMethod();
    }

    public void Start()
    {
        CallMethod();
    }

    public void OnUnloadingLevel()
    {
        CallMethod();
    }

    public void SetStartSizeForTrigger()
    {
        orig.SetStartSizeForTrigger();
    }

    public void Activate()
    {
        orig.Activate();
    }

    public void Deactivate()
    {
        orig.Deactivate();
    }

    public void ActivateGradual()
    {
        orig.ActivateGradual();
    }

    public void DeactivateGradual()
    {
        orig.DeactivateGradual();
    }

    public void Update()
    {
        CallMethod();
    }

    public void UpdateLow()
    {
        CallMethod();
    }

    public void orig_Start()
    {
        CallMethod();
    }

    public IEnumerator OnStart()
    {
        return CallMethod<IEnumerator>();
    }

    public void orig_Update()
    {
        CallMethod();
    }

    public void orig_UpdateLow()
    {
        CallMethod();
    }

    public void orig_Deactivate()
    {
        orig.orig_Deactivate();
    }
}