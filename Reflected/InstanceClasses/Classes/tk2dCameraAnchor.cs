namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of tk2dCameraAnchor allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class tk2dCameraAnchorR:InstanceClassWrapper<tk2dCameraAnchor>
{
public tk2dCameraAnchorR(tk2dCameraAnchor _orig) : base(_orig) {}
public int anchor
{
get => GetField<int>();
set => SetField(value);
}

public bool anchorToNativeBounds
{
get => GetField<bool>();
set => SetField(value);
}

public UnityEngine.Vector2 offset
{
get => GetField<UnityEngine.Vector2>();
set => SetField(value);
}

public tk2dCamera tk2dCamera
{
get => GetField<tk2dCamera>();
set => SetField(value);
}

public UnityEngine.Camera _anchorCamera
{
get => GetField<UnityEngine.Camera>();
set => SetField(value);
}

public UnityEngine.Camera _anchorCameraCached
{
get => GetField<UnityEngine.Camera>();
set => SetField(value);
}

public tk2dCamera _anchorTk2dCamera
{
get => GetField<tk2dCamera>();
set => SetField(value);
}

public UnityEngine.Transform _myTransform
{
get => GetField<UnityEngine.Transform>();
set => SetField(value);
}

public UnityEngine.Vector2 AnchorOffsetPixels
{
get => orig.AnchorOffsetPixels;
set => orig.AnchorOffsetPixels = value;
}

public bool AnchorToNativeBounds
{
get => orig.AnchorToNativeBounds;
set => orig.AnchorToNativeBounds = value;
}

public UnityEngine.Camera AnchorCamera
{
get => orig.AnchorCamera;
set => orig.AnchorCamera = value;
}

public tk2dCamera AnchorTk2dCamera
{
get => GetProperty<tk2dCamera>();
}

public UnityEngine.Transform myTransform
{
get => GetProperty<UnityEngine.Transform>();
}



public void Start () =>
CallMethod();

public void UpdateTransform () =>
CallMethod();

public void ForceUpdateTransform () =>
orig.ForceUpdateTransform();

public void LateUpdate () =>
CallMethod();

}
}
