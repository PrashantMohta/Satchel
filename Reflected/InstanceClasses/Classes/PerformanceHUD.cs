namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of PerformanceHUD allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class PerformanceHUDR:InstanceClassWrapper<PerformanceHUD>
{
public PerformanceHUDR(PerformanceHUD _orig) : base(_orig) {}
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

public UnityEngine.GUIContent framesLastSecondContent
{
get => GetField<UnityEngine.GUIContent>();
set => SetField(value);
}

public UnityEngine.Color framesColor
{
get => GetField<UnityEngine.Color>();
set => SetField(value);
}

public bool fpsFrames
{
get => GetField<bool>();
set => SetField(value);
}

public System.Single? instantaneousFrames
{
get => GetField<System.Single?>();
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

public UnityEngine.GUIContent versionContent
{
get => GetField<UnityEngine.GUIContent>();
set => SetField(value);
}

public UnityEngine.GUIContent memoryContent
{
get => GetField<UnityEngine.GUIContent>();
set => SetField(value);
}

public System.Collections.Generic.List<PerformanceHUD.LoadReport> loadReports
{
get => GetField<System.Collections.Generic.List<PerformanceHUD.LoadReport>>();
set => SetField(value);
}

public bool ShowVibrations
{
get => PerformanceHUD.ShowVibrations;
set => PerformanceHUD.ShowVibrations = value;
}

public UnityEngine.GUIContent vibrationsContent
{
get => GetField<UnityEngine.GUIContent>();
set => SetField(value);
}

public PerformanceHUD Shared
{
get => PerformanceHUD.Shared;
}

public bool FpsFrames
{
get => orig.FpsFrames;
set => orig.FpsFrames = value;
}



public void Init () =>
PerformanceHUD.Init();

public void Awake () =>
CallMethod();

public void OnEnable () =>
CallMethod();

public void OnDisable () =>
CallMethod();

public void Update () =>
CallMethod();

public void GameManager_SceneTransitionBegan (SceneLoad sceneLoad) =>
CallMethod(new object[] {sceneLoad});

public void UpdateSceneLoadRecordContent (SceneLoad sceneLoad, PerformanceHUD.LoadReport report) =>
CallMethod(new object[] {sceneLoad, report});

public string GetTimeStr (System.Single? time) =>
CallMethodStatic<string>(new object[] {time});

public void UpdateMemory () =>
CallMethod();

public void OnGUI () =>
CallMethod();

public void LabelWithShadow (UnityEngine.Rect rect, UnityEngine.GUIContent content) =>
CallMethod(new object[] {rect, content});

}
}
