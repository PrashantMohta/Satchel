namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of AcidCorpseSplash allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class AcidCorpseSplashR : InstanceClassWrapper<AcidCorpseSplash>
{
    public AcidCorpseSplashR(AcidCorpseSplash _orig) : base(_orig)
    {
    }

    public TriggerEnterEvent corpseDetector
    {
        get => orig.corpseDetector;
        set => orig.corpseDetector = value;
    }

    public GameObject acidSplashPrefab
    {
        get => orig.acidSplashPrefab;
        set => orig.acidSplashPrefab = value;
    }

    public GameObject acidSteamPrefab
    {
        get => orig.acidSteamPrefab;
        set => orig.acidSteamPrefab = value;
    }

    public ParticleSystem sporeCloudPrefab
    {
        get => orig.sporeCloudPrefab;
        set => orig.sporeCloudPrefab = value;
    }

    public ParticleSystem bubCloudPrefab
    {
        get => orig.bubCloudPrefab;
        set => orig.bubCloudPrefab = value;
    }

    public AudioSource audioPlayerPefab
    {
        get => orig.audioPlayerPefab;
        set => orig.audioPlayerPefab = value;
    }

    public AudioEvent splashSound
    {
        get => orig.splashSound;
        set => orig.splashSound = value;
    }


    public void Start()
    {
        CallMethod();
    }

    public IEnumerator CorpseSplash(GameObject corpseObject)
    {
        return CallMethod<IEnumerator>(new object[] { corpseObject });
    }
}