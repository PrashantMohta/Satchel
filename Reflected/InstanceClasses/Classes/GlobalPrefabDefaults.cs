namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of GlobalPrefabDefaults allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class GlobalPrefabDefaultsR : InstanceClassWrapper<GlobalPrefabDefaults>
{
    public GlobalPrefabDefaultsR(GlobalPrefabDefaults _orig) : base(_orig)
    {
    }

    public GlobalPrefabDefaults Instance
    {
        get => GlobalPrefabDefaults.Instance;
        set => GlobalPrefabDefaults.Instance = value;
    }

    public GameObject bloodSplatterParticle
    {
        get => orig.bloodSplatterParticle;
        set => orig.bloodSplatterParticle = value;
    }

    public float speedMultiplier
    {
        get => orig.speedMultiplier;
        set => orig.speedMultiplier = value;
    }

    public float amountMultiplier
    {
        get => orig.amountMultiplier;
        set => orig.amountMultiplier = value;
    }


    public void Awake()
    {
        CallMethod();
    }

    public void Start()
    {
        CallMethod();
    }

    public void SpawnBlood(Vector3 position, short minCount, short maxCount, float minSpeed, float maxSpeed,
        float angleMin = 0, float angleMax = 360, Color? colorOverride = null)
    {
        orig.SpawnBlood(position, minCount, maxCount, minSpeed, maxSpeed, angleMin, angleMax, colorOverride);
    }
}