namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of BlurPlane allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class BlurPlaneR:InstanceClassWrapper<BlurPlane>
{
public BlurPlaneR(BlurPlane _orig) : base(_orig) {}
public UnityEngine.MeshRenderer meshRenderer
{
get => GetField<UnityEngine.MeshRenderer>();
set => SetField(value);
}

public System.Collections.Generic.List<BlurPlane> blurPlanes
{
get => GetFieldStatic<System.Collections.Generic.List<BlurPlane>>();
set => SetField(value);
}

public UnityEngine.Material OriginalMaterial
{
get => orig.OriginalMaterial;
set => SetProperty(value);
}

public int BlurPlaneCount
{
get => BlurPlane.BlurPlaneCount;
}

public BlurPlane ClosestBlurPlane
{
get => BlurPlane.ClosestBlurPlane;
}

public float PlaneZ
{
get => orig.PlaneZ;
}



public BlurPlane GetBlurPlane (int index) =>
BlurPlane.GetBlurPlane(index);

public void Init () =>
CallMethodStatic();

public void Awake () =>
CallMethod();

public void OnEnable () =>
CallMethod();

public void OnDisable () =>
CallMethod();

public void SetPlaneVisibility (bool isVisible) =>
orig.SetPlaneVisibility(isVisible);

public void SetPlaneMaterial (UnityEngine.Material material) =>
orig.SetPlaneMaterial(material);

}
}
