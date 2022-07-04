namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of HardLandEffect allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class HardLandEffectR : InstanceClassWrapper<HardLandEffect>
{
    public HardLandEffectR(HardLandEffect _orig) : base(_orig)
    {
    }

    public GameObject dustObj
    {
        get => orig.dustObj;
        set => orig.dustObj = value;
    }

    public GameObject grassObj
    {
        get => orig.grassObj;
        set => orig.grassObj = value;
    }

    public GameObject boneObj
    {
        get => orig.boneObj;
        set => orig.boneObj = value;
    }

    public GameObject spaObj
    {
        get => orig.spaObj;
        set => orig.spaObj = value;
    }

    public GameObject metalObj
    {
        get => orig.metalObj;
        set => orig.metalObj = value;
    }

    public GameObject wetObj
    {
        get => orig.wetObj;
        set => orig.wetObj = value;
    }

    public GameObject particleRockPrefab
    {
        get => orig.particleRockPrefab;
        set => orig.particleRockPrefab = value;
    }

    public GameObject spatterWhitePrefab
    {
        get => orig.spatterWhitePrefab;
        set => orig.spatterWhitePrefab = value;
    }

    public float recycleTime
    {
        get => GetField<float>();
        set => SetField(value);
    }


    public void OnEnable()
    {
        CallMethod();
    }

    public void Update()
    {
        CallMethod();
    }
}