namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of DreamPlantOrb allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class DreamPlantOrbR : InstanceClassWrapper<DreamPlantOrb>
{
    public DreamPlantOrbR(DreamPlantOrb _orig) : base(_orig)
    {
    }

    public DreamPlant plant
    {
        get => DreamPlantOrb.plant;
        set => DreamPlantOrb.plant = value;
    }

    public BasicSpriteAnimator pickupAnim
    {
        get => orig.pickupAnim;
        set => orig.pickupAnim = value;
    }

    public Renderer rend
    {
        get => GetField<Renderer>();
        set => SetField(value);
    }

    public Vector3 initialScale
    {
        get => GetField<Vector3>();
        set => SetField(value);
    }

    public AudioSource loopSource
    {
        get => orig.loopSource;
        set => orig.loopSource = value;
    }

    public AudioSource soundSource
    {
        get => orig.soundSource;
        set => orig.soundSource = value;
    }

    public AudioClip collectSound
    {
        get => orig.collectSound;
        set => orig.collectSound = value;
    }

    public float basePitch
    {
        get => orig.basePitch;
        set => orig.basePitch = value;
    }

    public float increasePitch
    {
        get => orig.increasePitch;
        set => orig.increasePitch = value;
    }

    public float maxPitch
    {
        get => orig.maxPitch;
        set => orig.maxPitch = value;
    }

    public float pitchReturnDelay
    {
        get => orig.pitchReturnDelay;
        set => orig.pitchReturnDelay = value;
    }

    public float currentPitch
    {
        get => GetFieldStatic<float>();
        set => SetField(value);
    }

    public float pitchReturnTime
    {
        get => GetFieldStatic<float>();
        set => SetField(value);
    }

    public GameObject whiteFlash
    {
        get => orig.whiteFlash;
        set => orig.whiteFlash = value;
    }

    public ParticleSystem pickupParticles
    {
        get => orig.pickupParticles;
        set => orig.pickupParticles = value;
    }

    public ParticleSystem trailParticles
    {
        get => orig.trailParticles;
        set => orig.trailParticles = value;
    }

    public ParticleSystem activateParticles
    {
        get => orig.activateParticles;
        set => orig.activateParticles = value;
    }

    public AnimationCurve spread1Curve
    {
        get => orig.spread1Curve;
        set => orig.spread1Curve = value;
    }

    public AnimationCurve spread2Curve
    {
        get => orig.spread2Curve;
        set => orig.spread2Curve = value;
    }

    public bool pickedUp
    {
        get => GetField<bool>();
        set => SetField(value);
    }

    public bool canPickup
    {
        get => GetField<bool>();
        set => SetField(value);
    }

    public bool isActive
    {
        get => GetField<bool>();
        set => SetField(value);
    }

    public bool didEverSetSaveState
    {
        get => GetField<bool>();
        set => SetField(value);
    }

    public Coroutine spreadRoutine
    {
        get => GetField<Coroutine>();
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

    public void OnTriggerEnter2D(Collider2D collision)
    {
        CallMethod(new object[] { collision });
    }

    public void Show()
    {
        orig.Show();
    }

    public void SetActive(bool value)
    {
        CallMethod(new object[] { value });
    }

    public IEnumerator Spread()
    {
        return CallMethod<IEnumerator>();
    }

    public void Disable()
    {
        CallMethod();
    }

    public IEnumerator DisableAfterTime(GameObject obj, float time)
    {
        return CallMethod<IEnumerator>(new object[] { obj, time });
    }

    public IEnumerator TweenPosition(Vector3 position, float time, AnimationCurve curve)
    {
        return CallMethod<IEnumerator>(new object[] { position, time, curve });
    }
}