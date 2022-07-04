namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of PerformanceHUD allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class PerformanceHUDR : InstanceClassWrapper<PerformanceHUD>
{
    public PerformanceHUDR(PerformanceHUD _orig) : base(_orig)
    {
    }

    public PerformanceHUD shared
    {
        get => GetFieldStatic<PerformanceHUD>();
        set => SetField(value);
    }

    public int frameCounter
    {
        get => GetField<int>();
        set => SetField(value);
    }

    public int lastSecond
    {
        get => GetField<int>();
        set => SetField(value);
    }

    public int framesLastSecond
    {
        get => GetField<int>();
        set => SetField(value);
    }

    public GUIContent framesLastSecondContent
    {
        get => GetField<GUIContent>();
        set => SetField(value);
    }

    public Color framesColor
    {
        get => GetField<Color>();
        set => SetField(value);
    }

    public bool fpsFrames
    {
        get => GetField<bool>();
        set => SetField(value);
    }

    public float? instantaneousFrames
    {
        get => GetField<float?>();
        set => SetField(value);
    }

    public int lastScreenWidth
    {
        get => GetField<int>();
        set => SetField(value);
    }

    public int lastScreenHeight
    {
        get => GetField<int>();
        set => SetField(value);
    }

    public GUIContent versionContent
    {
        get => GetField<GUIContent>();
        set => SetField(value);
    }

    public GUIContent memoryContent
    {
        get => GetField<GUIContent>();
        set => SetField(value);
    }

    public List<PerformanceHUD.LoadReport> loadReports
    {
        get => GetField<List<PerformanceHUD.LoadReport>>();
        set => SetField(value);
    }

    public bool ShowVibrations
    {
        get => PerformanceHUD.ShowVibrations;
        set => PerformanceHUD.ShowVibrations = value;
    }

    public GUIContent vibrationsContent
    {
        get => GetField<GUIContent>();
        set => SetField(value);
    }

    public PerformanceHUD Shared => PerformanceHUD.Shared;

    public bool FpsFrames
    {
        get => orig.FpsFrames;
        set => orig.FpsFrames = value;
    }


    public void Init()
    {
        PerformanceHUD.Init();
    }

    public void Awake()
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

    public void Update()
    {
        CallMethod();
    }

    public void GameManager_SceneTransitionBegan(SceneLoad sceneLoad)
    {
        CallMethod(new object[] { sceneLoad });
    }

    public void UpdateSceneLoadRecordContent(SceneLoad sceneLoad, PerformanceHUD.LoadReport report)
    {
        CallMethod(new object[] { sceneLoad, report });
    }

    public string GetTimeStr(float? time)
    {
        return CallMethodStatic<string>(new object[] { time });
    }

    public void UpdateMemory()
    {
        CallMethod();
    }

    public void OnGUI()
    {
        CallMethod();
    }

    public void LabelWithShadow(Rect rect, GUIContent content)
    {
        CallMethod(new object[] { rect, content });
    }
}