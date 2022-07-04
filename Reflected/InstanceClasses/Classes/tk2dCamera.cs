namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of tk2dCamera allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class tk2dCameraR : InstanceClassWrapper<tk2dCamera>
{
    public tk2dCameraR(tk2dCamera _orig) : base(_orig)
    {
    }

    public int CURRENT_VERSION
    {
        get => GetFieldStatic<int>();
        set => SetField(value);
    }

    public int version
    {
        get => orig.version;
        set => orig.version = value;
    }

    public tk2dCameraSettings cameraSettings
    {
        get => GetField<tk2dCameraSettings>();
        set => SetField(value);
    }

    public tk2dCameraResolutionOverride[] resolutionOverride
    {
        get => orig.resolutionOverride;
        set => orig.resolutionOverride = value;
    }

    public tk2dCamera inheritSettings
    {
        get => GetField<tk2dCamera>();
        set => SetField(value);
    }

    public int nativeResolutionWidth
    {
        get => orig.nativeResolutionWidth;
        set => orig.nativeResolutionWidth = value;
    }

    public int nativeResolutionHeight
    {
        get => orig.nativeResolutionHeight;
        set => orig.nativeResolutionHeight = value;
    }

    public Camera _unityCamera
    {
        get => GetField<Camera>();
        set => SetField(value);
    }

    public tk2dCamera inst
    {
        get => GetFieldStatic<tk2dCamera>();
        set => SetField(value);
    }

    public List<tk2dCamera> allCameras
    {
        get => GetFieldStatic<List<tk2dCamera>>();
        set => SetField(value);
    }

    public bool viewportClippingEnabled
    {
        get => orig.viewportClippingEnabled;
        set => orig.viewportClippingEnabled = value;
    }

    public Vector4 viewportRegion
    {
        get => orig.viewportRegion;
        set => orig.viewportRegion = value;
    }

    public Vector2 _targetResolution
    {
        get => GetField<Vector2>();
        set => SetField(value);
    }

    public float zoomFactor
    {
        get => GetField<float>();
        set => SetField(value);
    }

    public bool forceResolutionInEditor
    {
        get => orig.forceResolutionInEditor;
        set => orig.forceResolutionInEditor = value;
    }

    public Vector2 forceResolution
    {
        get => orig.forceResolution;
        set => orig.forceResolution = value;
    }

    public Rect _screenExtents
    {
        get => GetField<Rect>();
        set => SetField(value);
    }

    public Rect _nativeScreenExtents
    {
        get => GetField<Rect>();
        set => SetField(value);
    }

    public Rect unitRect
    {
        get => GetField<Rect>();
        set => SetField(value);
    }

    public tk2dCamera _settingsRoot
    {
        get => GetField<tk2dCamera>();
        set => SetField(value);
    }

    public tk2dCameraSettings CameraSettings => orig.CameraSettings;

    public tk2dCameraResolutionOverride CurrentResolutionOverride => orig.CurrentResolutionOverride;

    public tk2dCamera InheritConfig
    {
        get => orig.InheritConfig;
        set => orig.InheritConfig = value;
    }

    public Camera UnityCamera => GetProperty<Camera>();

    public tk2dCamera Instance => tk2dCamera.Instance;

    public Rect ScreenExtents => orig.ScreenExtents;

    public Rect NativeScreenExtents => orig.NativeScreenExtents;

    public Vector2 TargetResolution => orig.TargetResolution;

    public Vector2 NativeResolution => orig.NativeResolution;

    public Vector2 ScreenOffset => orig.ScreenOffset;

    public Vector2 resolution => orig.resolution;

    public Vector2 ScreenResolution => orig.ScreenResolution;

    public Vector2 ScaledResolution => orig.ScaledResolution;

    public float ZoomFactor
    {
        get => orig.ZoomFactor;
        set => orig.ZoomFactor = value;
    }

    public float zoomScale
    {
        get => orig.zoomScale;
        set => orig.zoomScale = value;
    }

    public Camera ScreenCamera => orig.ScreenCamera;

    public tk2dCamera SettingsRoot => orig.SettingsRoot;


    public tk2dCamera CameraForLayer(int layer)
    {
        return tk2dCamera.CameraForLayer(layer);
    }

    public void Awake()
    {
        CallMethod();
    }

    public void OnEnable()
    {
        CallMethod();
    }

    public void OnDestroy()
    {
        CallMethod();
    }

    public void OnPreCull()
    {
        CallMethod();
    }

    public float GetSizeAtDistance(float distance)
    {
        return orig.GetSizeAtDistance(distance);
    }

    public Matrix4x4 OrthoOffCenter(Vector2 scale, float left, float right, float bottom, float top, float near,
        float far)
    {
        return orig.OrthoOffCenter(scale, left, right, bottom, top, near, far);
    }

    public Vector2 GetScaleForOverride(tk2dCamera settings, tk2dCameraResolutionOverride currentOverride, float width,
        float height)
    {
        return CallMethod<Vector2>(new object[] { settings, currentOverride, width, height });
    }

    public Vector2 GetOffsetForOverride(tk2dCamera settings, tk2dCameraResolutionOverride currentOverride,
        Vector2 scale, float width, float height)
    {
        return CallMethod<Vector2>(new object[] { settings, currentOverride, scale, width, height });
    }

    public Matrix4x4 GetProjectionMatrixForOverride(tk2dCamera settings, tk2dCameraResolutionOverride currentOverride,
        float pixelWidth, float pixelHeight, bool halfTexelOffset, Rect screenExtents, Rect unscaledScreenExtents)
    {
        return CallMethod<Matrix4x4>(new object[]
        {
            settings, currentOverride, pixelWidth, pixelHeight, halfTexelOffset, screenExtents, unscaledScreenExtents
        });
    }

    public Vector2 GetScreenPixelDimensions(tk2dCamera settings)
    {
        return CallMethod<Vector2>(new object[] { settings });
    }

    public void Upgrade()
    {
        CallMethod();
    }

    public void UpdateCameraMatrix()
    {
        orig.UpdateCameraMatrix();
    }
}