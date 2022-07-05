namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of tk2dCameraAnchor allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class tk2dCameraAnchorR : InstanceClassWrapper<tk2dCameraAnchor>
{
    public tk2dCameraAnchorR(tk2dCameraAnchor _orig) : base(_orig)
    {
    }

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

    public Vector2 offset
    {
        get => GetField<Vector2>();
        set => SetField(value);
    }

    public tk2dCamera tk2dCamera
    {
        get => GetField<tk2dCamera>();
        set => SetField(value);
    }

    public Camera _anchorCamera
    {
        get => GetField<Camera>();
        set => SetField(value);
    }

    public Camera _anchorCameraCached
    {
        get => GetField<Camera>();
        set => SetField(value);
    }

    public tk2dCamera _anchorTk2dCamera
    {
        get => GetField<tk2dCamera>();
        set => SetField(value);
    }

    public Transform _myTransform
    {
        get => GetField<Transform>();
        set => SetField(value);
    }

    public Vector2 AnchorOffsetPixels
    {
        get => orig.AnchorOffsetPixels;
        set => orig.AnchorOffsetPixels = value;
    }

    public bool AnchorToNativeBounds
    {
        get => orig.AnchorToNativeBounds;
        set => orig.AnchorToNativeBounds = value;
    }

    public Camera AnchorCamera
    {
        get => orig.AnchorCamera;
        set => orig.AnchorCamera = value;
    }

    public tk2dCamera AnchorTk2dCamera => GetProperty<tk2dCamera>();

    public Transform myTransform => GetProperty<Transform>();


    public void Start()
    {
        CallMethod();
    }

    public void UpdateTransform()
    {
        CallMethod();
    }

    public void ForceUpdateTransform()
    {
        orig.ForceUpdateTransform();
    }

    public void LateUpdate()
    {
        CallMethod();
    }
}