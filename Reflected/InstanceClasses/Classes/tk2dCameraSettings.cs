namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of tk2dCameraSettings allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class tk2dCameraSettingsR : InstanceClassWrapper<tk2dCameraSettings>
{
    public tk2dCameraSettingsR(tk2dCameraSettings _orig) : base(_orig)
    {
    }

    public float orthographicSize
    {
        get => orig.orthographicSize;
        set => orig.orthographicSize = value;
    }

    public float orthographicPixelsPerMeter
    {
        get => orig.orthographicPixelsPerMeter;
        set => orig.orthographicPixelsPerMeter = value;
    }

    public TransparencySortMode transparencySortMode
    {
        get => orig.transparencySortMode;
        set => orig.transparencySortMode = value;
    }

    public float fieldOfView
    {
        get => orig.fieldOfView;
        set => orig.fieldOfView = value;
    }

    public Rect rect
    {
        get => orig.rect;
        set => orig.rect = value;
    }
}