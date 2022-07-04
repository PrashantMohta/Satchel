namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of tk2dUICamera allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class tk2dUICameraR:InstanceClassWrapper<tk2dUICamera>
{
public tk2dUICameraR(tk2dUICamera _orig) : base(_orig) {}
public UnityEngine.LayerMask raycastLayerMask
{
get => GetField<UnityEngine.LayerMask>();
set => SetField(value);
}

public UnityEngine.LayerMask FilteredMask
{
get => orig.FilteredMask;
}

public UnityEngine.Camera HostCamera
{
get => orig.HostCamera;
}



public void AssignRaycastLayerMask (UnityEngine.LayerMask mask) =>
orig.AssignRaycastLayerMask(mask);

public void OnEnable () =>
CallMethod();

public void OnDisable () =>
CallMethod();

}
}
