namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of ScenePreloader allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class ScenePreloaderR:InstanceClassWrapper<ScenePreloader>
{
public ScenePreloaderR(ScenePreloader _orig) : base(_orig) {}
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

public System.Single? loadTime
{
get => GetField<System.Single?>();
set => SetField(value);
}

public System.Collections.Generic.List<ScenePreloader.SceneLoadOp> pendingOperations
{
get => GetFieldStatic<System.Collections.Generic.List<ScenePreloader.SceneLoadOp>>();
set => SetField(value);
}

public System.Collections.Generic.List<ScenePreloader.SceneLoadOp> completedOperations
{
get => GetFieldStatic<System.Collections.Generic.List<ScenePreloader.SceneLoadOp>>();
set => SetField(value);
}



public void Start () =>
CallMethod();

public void OnGUI () =>
CallMethod();

public System.Collections.IEnumerator LoadRoutine () =>
CallMethod<System.Collections.IEnumerator>();

public System.Collections.IEnumerator FinishPendingOperations () =>
ScenePreloader.FinishPendingOperations();

public void Cleanup () =>
ScenePreloader.Cleanup();

}
}
