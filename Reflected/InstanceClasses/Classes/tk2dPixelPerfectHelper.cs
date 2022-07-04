namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of tk2dPixelPerfectHelper allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class tk2dPixelPerfectHelperR : InstanceClassWrapper<tk2dPixelPerfectHelper>
{
    public tk2dPixelPerfectHelperR(tk2dPixelPerfectHelper _orig) : base(_orig)
    {
    }

    public tk2dPixelPerfectHelper _inst
    {
        get => GetFieldStatic<tk2dPixelPerfectHelper>();
        set => SetField(value);
    }

    public Camera cam
    {
        get => orig.cam;
        set => orig.cam = value;
    }

    public int collectionTargetHeight
    {
        get => orig.collectionTargetHeight;
        set => orig.collectionTargetHeight = value;
    }

    public float collectionOrthoSize
    {
        get => orig.collectionOrthoSize;
        set => orig.collectionOrthoSize = value;
    }

    public float targetResolutionHeight
    {
        get => orig.targetResolutionHeight;
        set => orig.targetResolutionHeight = value;
    }

    public float scaleD
    {
        get => orig.scaleD;
        set => orig.scaleD = value;
    }

    public float scaleK
    {
        get => orig.scaleK;
        set => orig.scaleK = value;
    }

    public tk2dPixelPerfectHelper inst => tk2dPixelPerfectHelper.inst;

    public bool CameraIsOrtho => orig.CameraIsOrtho;


    public void Awake()
    {
        CallMethod();
    }

    public void Setup()
    {
        orig.Setup();
    }

    public float CalculateScaleForPerspectiveCamera(float fov, float zdist)
    {
        return tk2dPixelPerfectHelper.CalculateScaleForPerspectiveCamera(fov, zdist);
    }
}