namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of GeoCounter allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class GeoCounterR : InstanceClassWrapper<GeoCounter>
{
    public GeoCounterR(GeoCounter _orig) : base(_orig)
    {
    }

    public float ROLLER_START_PAUSE
    {
        get => GetFieldStatic<float>();
        set => SetField(value);
    }

    public float DIGIT_CHANGE_TIME
    {
        get => GetFieldStatic<float>();
        set => SetField(value);
    }

    public PlayerData playerData
    {
        get => orig.playerData;
        set => orig.playerData = value;
    }

    public GameObject geoSprite
    {
        get => orig.geoSprite;
        set => orig.geoSprite = value;
    }

    public TextMesh geoTextMesh
    {
        get => orig.geoTextMesh;
        set => orig.geoTextMesh = value;
    }

    public TextMesh subTextMesh
    {
        get => orig.subTextMesh;
        set => orig.subTextMesh = value;
    }

    public TextMesh addTextMesh
    {
        get => orig.addTextMesh;
        set => orig.addTextMesh = value;
    }

    public PlayMakerFSM geoSpriteFsm
    {
        get => GetField<PlayMakerFSM>();
        set => SetField(value);
    }

    public PlayMakerFSM subTextFsm
    {
        get => GetField<PlayMakerFSM>();
        set => SetField(value);
    }

    public PlayMakerFSM addTextFsm
    {
        get => GetField<PlayMakerFSM>();
        set => SetField(value);
    }

    public int counterCurrent
    {
        get => GetField<int>();
        set => SetField(value);
    }

    public int geoChange
    {
        get => GetField<int>();
        set => SetField(value);
    }

    public int addCounter
    {
        get => GetField<int>();
        set => SetField(value);
    }

    public int takeCounter
    {
        get => GetField<int>();
        set => SetField(value);
    }

    public int addRollerState
    {
        get => GetField<int>();
        set => SetField(value);
    }

    public int takeRollerState
    {
        get => GetField<int>();
        set => SetField(value);
    }

    public int changePerTick
    {
        get => GetField<int>();
        set => SetField(value);
    }

    public float addRollerStartTimer
    {
        get => GetField<float>();
        set => SetField(value);
    }

    public float takeRollerStartTimer
    {
        get => GetField<float>();
        set => SetField(value);
    }

    public float digitChangeTimer
    {
        get => GetField<float>();
        set => SetField(value);
    }

    public bool toZero
    {
        get => GetField<bool>();
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

    public void UpdateGeo()
    {
        orig.UpdateGeo();
    }

    public void NewSceneRefresh()
    {
        orig.NewSceneRefresh();
    }

    public void AddGeo(int geo)
    {
        orig.AddGeo(geo);
    }

    public void TakeGeo(int geo)
    {
        orig.TakeGeo(geo);
    }

    public void ToZero()
    {
        orig.ToZero();
    }

    public void Update()
    {
        CallMethod();
    }
}