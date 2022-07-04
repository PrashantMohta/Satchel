namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of GradeOverride allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class GradeOverrideR : InstanceClassWrapper<GradeOverride>
{
    public GradeOverrideR(GradeOverride _orig) : base(_orig)
    {
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

    public float o_saturation
    {
        get => GetField<float>();
        set => SetField(value);
    }

    public AnimationCurve o_redChannel
    {
        get => GetField<AnimationCurve>();
        set => SetField(value);
    }

    public AnimationCurve o_greenChannel
    {
        get => GetField<AnimationCurve>();
        set => SetField(value);
    }

    public AnimationCurve o_blueChannel
    {
        get => GetField<AnimationCurve>();
        set => SetField(value);
    }

    public float o_ambientIntensity
    {
        get => GetField<float>();
        set => SetField(value);
    }

    public Color o_ambientColor
    {
        get => GetField<Color>();
        set => SetField(value);
    }

    public Color o_heroLightColor
    {
        get => GetField<Color>();
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

    public void Activate()
    {
        orig.Activate();
    }

    public void Deactivate()
    {
        orig.Deactivate();
    }
}