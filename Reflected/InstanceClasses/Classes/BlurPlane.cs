namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of BlurPlane allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class BlurPlaneR : InstanceClassWrapper<BlurPlane>
{
    public BlurPlaneR(BlurPlane _orig) : base(_orig)
    {
    }

    public MeshRenderer meshRenderer
    {
        get => GetField<MeshRenderer>();
        set => SetField(value);
    }

    public List<BlurPlane> blurPlanes
    {
        get => GetFieldStatic<List<BlurPlane>>();
        set => SetField(value);
    }

    public Material OriginalMaterial
    {
        get => orig.OriginalMaterial;
        set => SetProperty(value);
    }

    public int BlurPlaneCount => BlurPlane.BlurPlaneCount;

    public BlurPlane ClosestBlurPlane => BlurPlane.ClosestBlurPlane;

    public float PlaneZ => orig.PlaneZ;


    public BlurPlane GetBlurPlane(int index)
    {
        return BlurPlane.GetBlurPlane(index);
    }

    public void Init()
    {
        CallMethodStatic();
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

    public void SetPlaneVisibility(bool isVisible)
    {
        orig.SetPlaneVisibility(isVisible);
    }

    public void SetPlaneMaterial(Material material)
    {
        orig.SetPlaneMaterial(material);
    }
}