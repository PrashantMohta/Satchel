namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of ScenePreloader allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class ScenePreloaderR : InstanceClassWrapper<ScenePreloader>
{
    public ScenePreloaderR(ScenePreloader _orig) : base(_orig)
    {
    }

    public string sceneNameToLoad
    {
        get => orig.sceneNameToLoad;
        set => orig.sceneNameToLoad = value;
    }

    public string needsPlayerDataBool
    {
        get => orig.needsPlayerDataBool;
        set => orig.needsPlayerDataBool = value;
    }

    public bool playerDataBoolValue
    {
        get => orig.playerDataBoolValue;
        set => orig.playerDataBoolValue = value;
    }

    public float startLoadTime
    {
        get => GetField<float>();
        set => SetField(value);
    }

    public float endLoadTime
    {
        get => GetField<float>();
        set => SetField(value);
    }

    public float? loadTime
    {
        get => GetField<float?>();
        set => SetField(value);
    }

    public List<ScenePreloader.SceneLoadOp> pendingOperations
    {
        get => GetFieldStatic<List<ScenePreloader.SceneLoadOp>>();
        set => SetField(value);
    }

    public List<ScenePreloader.SceneLoadOp> completedOperations
    {
        get => GetFieldStatic<List<ScenePreloader.SceneLoadOp>>();
        set => SetField(value);
    }


    public void Start()
    {
        CallMethod();
    }

    public void OnGUI()
    {
        CallMethod();
    }

    public IEnumerator LoadRoutine()
    {
        return CallMethod<IEnumerator>();
    }

    public IEnumerator FinishPendingOperations()
    {
        return ScenePreloader.FinishPendingOperations();
    }

    public void Cleanup()
    {
        ScenePreloader.Cleanup();
    }
}