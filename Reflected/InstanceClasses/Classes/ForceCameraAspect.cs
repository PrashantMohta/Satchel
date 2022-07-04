namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of ForceCameraAspect allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class ForceCameraAspectR:InstanceClassWrapper<ForceCameraAspect>
{
public ForceCameraAspectR(ForceCameraAspect _orig) : base(_orig) {}
public System.Action<System.Single> ViewportAspectChanged
{
get => GetFieldStatic<System.Action<System.Single>>();
set => SetField(value);
}

public tk2dCamera tk2dCam
{
get => GetField<tk2dCamera>();
set => SetField(value);
}

public UnityEngine.Camera hudCam
{
get => GetField<UnityEngine.Camera>();
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

public float CurrentViewportAspect
{
get => ForceCameraAspect.CurrentViewportAspect;
set => SetPropertyStatic(value);
}



public void Awake () =>
CallMethod();

public void Start () =>
CallMethod();

public void Update () =>
CallMethod();

public void SetOverscanViewport (float adjustment) =>
orig.SetOverscanViewport(adjustment);

public float AutoScaleViewport () =>
CallMethod<float>();

}
}
