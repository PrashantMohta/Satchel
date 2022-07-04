namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of ForceCameraAspectLite allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class ForceCameraAspectLiteR:InstanceClassWrapper<ForceCameraAspectLite>
{
public ForceCameraAspectLiteR(ForceCameraAspectLite _orig) : base(_orig) {}
public UnityEngine.Camera sceneCamera
{
get => orig.sceneCamera;
set => orig.sceneCamera = value;
}

public bool viewportChanged
{
get => GetField<bool>();
set => SetField(value);
}

public int lastX
{
get => GetField<int>();
set => SetField(value);
}

public int lastY
{
get => GetField<int>();
set => SetField(value);
}

public float scaleAdjust
{
get => GetField<float>();
set => SetField(value);
}



public void Start () =>
CallMethod();

public void Update () =>
CallMethod();

public void AutoScaleViewport () =>
CallMethod();

}
}
