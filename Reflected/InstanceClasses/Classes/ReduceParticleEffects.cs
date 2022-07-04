namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of ReduceParticleEffects allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class ReduceParticleEffectsR : InstanceClassWrapper<ReduceParticleEffects>
{
    public ReduceParticleEffectsR(ReduceParticleEffects _orig) : base(_orig)
    {
    }

    public GameManager gm
    {
        get => GetField<GameManager>();
        set => SetField(value);
    }

    public ParticleSystem emitter
    {
        get => GetField<ParticleSystem>();
        set => SetField(value);
    }

    public float emissionRateHigh
    {
        get => GetField<float>();
        set => SetField(value);
    }

    public float emissionRateLow
    {
        get => GetField<float>();
        set => SetField(value);
    }

    public int maxParticlesHigh
    {
        get => GetField<int>();
        set => SetField(value);
    }

    public int maxParticlesLow
    {
        get => GetField<int>();
        set => SetField(value);
    }

    public bool init
    {
        get => GetField<bool>();
        set => SetField(value);
    }


    public void Start()
    {
        CallMethod();
    }

    public void SetEmission()
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
}