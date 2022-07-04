namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of LoadingCanvas allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class LoadingCanvasR:InstanceClassWrapper<LoadingCanvas>
{
public LoadingCanvasR(LoadingCanvas _orig) : base(_orig) {}
public UnityEngine.GameObject[] visualizationContainers
{
get => GetField<UnityEngine.GameObject[]>();
set => SetField(value);
}

public bool isLoading
{
get => GetField<bool>();
set => SetField(value);
}

public LoadingSpinner defaultLoadingSpinner
{
get => GetField<LoadingSpinner>();
set => SetField(value);
}

public float continueFromSaveDelayAdjustment
{
get => GetField<float>();
set => SetField(value);
}



public void Start () =>
CallMethod();

public void Update () =>
CallMethod();

}
}
