namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of tk2dCamera allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class tk2dCameraR:InstanceClassWrapper<tk2dCamera>
{
public tk2dCameraR(tk2dCamera _orig) : base(_orig) {}
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

public UnityEngine.Camera _unityCamera
{
get => GetField<UnityEngine.Camera>();
set => SetField(value);
}

public tk2dCamera inst
{
get => GetFieldStatic<tk2dCamera>();
set => SetField(value);
}

public System.Collections.Generic.List<tk2dCamera> allCameras
{
get => GetFieldStatic<System.Collections.Generic.List<tk2dCamera>>();
set => SetField(value);
}

public bool viewportClippingEnabled
{
get => orig.viewportClippingEnabled;
set => orig.viewportClippingEnabled = value;
}

public UnityEngine.Vector4 viewportRegion
{
get => orig.viewportRegion;
set => orig.viewportRegion = value;
}

public UnityEngine.Vector2 _targetResolution
{
get => GetField<UnityEngine.Vector2>();
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

public UnityEngine.Vector2 forceResolution
{
get => orig.forceResolution;
set => orig.forceResolution = value;
}

public UnityEngine.Rect _screenExtents
{
get => GetField<UnityEngine.Rect>();
set => SetField(value);
}

public UnityEngine.Rect _nativeScreenExtents
{
get => GetField<UnityEngine.Rect>();
set => SetField(value);
}

public UnityEngine.Rect unitRect
{
get => GetField<UnityEngine.Rect>();
set => SetField(value);
}

public tk2dCamera _settingsRoot
{
get => GetField<tk2dCamera>();
set => SetField(value);
}

public tk2dCameraSettings CameraSettings
{
get => orig.CameraSettings;
}

public tk2dCameraResolutionOverride CurrentResolutionOverride
{
get => orig.CurrentResolutionOverride;
}

public tk2dCamera InheritConfig
{
get => orig.InheritConfig;
set => orig.InheritConfig = value;
}

public UnityEngine.Camera UnityCamera
{
get => GetProperty<UnityEngine.Camera>();
}

public tk2dCamera Instance
{
get => tk2dCamera.Instance;
}

public UnityEngine.Rect ScreenExtents
{
get => orig.ScreenExtents;
}

public UnityEngine.Rect NativeScreenExtents
{
get => orig.NativeScreenExtents;
}

public UnityEngine.Vector2 TargetResolution
{
get => orig.TargetResolution;
}

public UnityEngine.Vector2 NativeResolution
{
get => orig.NativeResolution;
}

public UnityEngine.Vector2 ScreenOffset
{
get => orig.ScreenOffset;
}

public UnityEngine.Vector2 resolution
{
get => orig.resolution;
}

public UnityEngine.Vector2 ScreenResolution
{
get => orig.ScreenResolution;
}

public UnityEngine.Vector2 ScaledResolution
{
get => orig.ScaledResolution;
}

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

public UnityEngine.Camera ScreenCamera
{
get => orig.ScreenCamera;
}

public tk2dCamera SettingsRoot
{
get => orig.SettingsRoot;
}



public tk2dCamera CameraForLayer (int layer) =>
tk2dCamera.CameraForLayer(layer);

public void Awake () =>
CallMethod();

public void OnEnable () =>
CallMethod();

public void OnDestroy () =>
CallMethod();

public void OnPreCull () =>
CallMethod();

public float GetSizeAtDistance (float distance) =>
orig.GetSizeAtDistance(distance);

public UnityEngine.Matrix4x4 OrthoOffCenter (UnityEngine.Vector2 scale, float left, float right, float bottom, float top, float near, float far) =>
orig.OrthoOffCenter(scale, left, right, bottom, top, near, far);

public UnityEngine.Vector2 GetScaleForOverride (tk2dCamera settings, tk2dCameraResolutionOverride currentOverride, float width, float height) =>
CallMethod<UnityEngine.Vector2>(new object[] {settings, currentOverride, width, height});

public UnityEngine.Vector2 GetOffsetForOverride (tk2dCamera settings, tk2dCameraResolutionOverride currentOverride, UnityEngine.Vector2 scale, float width, float height) =>
CallMethod<UnityEngine.Vector2>(new object[] {settings, currentOverride, scale, width, height});

public UnityEngine.Matrix4x4 GetProjectionMatrixForOverride (tk2dCamera settings, tk2dCameraResolutionOverride currentOverride, float pixelWidth, float pixelHeight, bool halfTexelOffset, UnityEngine.Rect screenExtents, UnityEngine.Rect unscaledScreenExtents) =>
CallMethod<UnityEngine.Matrix4x4>(new object[] {settings, currentOverride, pixelWidth, pixelHeight, halfTexelOffset, screenExtents, unscaledScreenExtents});

public UnityEngine.Vector2 GetScreenPixelDimensions (tk2dCamera settings) =>
CallMethod<UnityEngine.Vector2>(new object[] {settings});

public void Upgrade () =>
CallMethod();

public void UpdateCameraMatrix () =>
orig.UpdateCameraMatrix();

}
}
