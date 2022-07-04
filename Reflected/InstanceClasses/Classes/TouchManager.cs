namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of TouchManager allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class TouchManagerR:InstanceClassWrapper<InControl.TouchManager>
{
public TouchManagerR(InControl.TouchManager _orig) : base(_orig) {}
public UnityEngine.Camera touchCamera
{
get => orig.touchCamera;
set => orig.touchCamera = value;
}

public bool enableControlsOnTouch
{
get => orig.enableControlsOnTouch;
set => orig.enableControlsOnTouch = value;
}

public bool _controlsEnabled
{
get => GetField<bool>();
set => SetField(value);
}

public int controlsLayer
{
get => orig.controlsLayer;
set => orig.controlsLayer = value;
}

public System.Action OnSetup
{
get => GetFieldStatic<System.Action>();
set => SetField(value);
}

public InControl.InputDevice device
{
get => GetField<InControl.InputDevice>();
set => SetField(value);
}

public UnityEngine.Vector3 viewSize
{
get => GetField<UnityEngine.Vector3>();
set => SetField(value);
}

public UnityEngine.Vector2 screenSize
{
get => GetField<UnityEngine.Vector2>();
set => SetField(value);
}

public UnityEngine.Vector2 halfScreenSize
{
get => GetField<UnityEngine.Vector2>();
set => SetField(value);
}

public float percentToWorld
{
get => GetField<float>();
set => SetField(value);
}

public float halfPercentToWorld
{
get => GetField<float>();
set => SetField(value);
}

public float pixelToWorld
{
get => GetField<float>();
set => SetField(value);
}

public float halfPixelToWorld
{
get => GetField<float>();
set => SetField(value);
}

public InControl.TouchControl[] touchControls
{
get => GetField<InControl.TouchControl[]>();
set => SetField(value);
}

public InControl.TouchPool cachedTouches
{
get => GetField<InControl.TouchPool>();
set => SetField(value);
}

public System.Collections.Generic.List<InControl.Touch> activeTouches
{
get => GetField<System.Collections.Generic.List<InControl.Touch>>();
set => SetField(value);
}

public System.Collections.ObjectModel.ReadOnlyCollection<InControl.Touch> readOnlyActiveTouches
{
get => GetField<System.Collections.ObjectModel.ReadOnlyCollection<InControl.Touch>>();
set => SetField(value);
}

public bool isReady
{
get => GetField<bool>();
set => SetField(value);
}

public InControl.Touch[] mouseTouches
{
get => GetField<InControl.Touch[]>();
set => SetField(value);
}

public bool controlsEnabled
{
get => orig.controlsEnabled;
set => orig.controlsEnabled = value;
}

public System.Collections.ObjectModel.ReadOnlyCollection<InControl.Touch> Touches
{
get => InControl.TouchManager.Touches;
}

public int TouchCount
{
get => InControl.TouchManager.TouchCount;
}

public UnityEngine.Camera Camera
{
get => InControl.TouchManager.Camera;
}

public InControl.InputDevice Device
{
get => InControl.TouchManager.Device;
}

public UnityEngine.Vector3 ViewSize
{
get => InControl.TouchManager.ViewSize;
}

public float PercentToWorld
{
get => InControl.TouchManager.PercentToWorld;
}

public float HalfPercentToWorld
{
get => InControl.TouchManager.HalfPercentToWorld;
}

public float PixelToWorld
{
get => InControl.TouchManager.PixelToWorld;
}

public float HalfPixelToWorld
{
get => InControl.TouchManager.HalfPixelToWorld;
}

public UnityEngine.Vector2 ScreenSize
{
get => InControl.TouchManager.ScreenSize;
}

public UnityEngine.Vector2 HalfScreenSize
{
get => InControl.TouchManager.HalfScreenSize;
}

public bool ControlsEnabled
{
get => InControl.TouchManager.ControlsEnabled;
set => InControl.TouchManager.ControlsEnabled = value;
}

public bool EnforceSingleton
{
get => GetProperty<bool>();
}

public bool IsTheSingleton
{
get => GetProperty<bool>();
}

public bool IsNotTheSingleton
{
get => GetProperty<bool>();
}



public void OnEnable () =>
CallMethod();

public void OnDisable () =>
CallMethod();

public void Setup () =>
CallMethod();

public void Reset () =>
CallMethod();

public System.Collections.IEnumerator UpdateScreenSizeAtEndOfFrame () =>
CallMethod<System.Collections.IEnumerator>();

public void Update () =>
CallMethod();

public void CreateDevice () =>
CallMethod();

public void UpdateDevice (System.UInt64 updateTick, float deltaTime) =>
CallMethod(new object[] {updateTick, deltaTime});

public void CommitDevice (System.UInt64 updateTick, float deltaTime) =>
CallMethod(new object[] {updateTick, deltaTime});

public void SubmitControlStates (System.UInt64 updateTick, float deltaTime) =>
CallMethod(new object[] {updateTick, deltaTime});

public void CommitControlStates (System.UInt64 updateTick, float deltaTime) =>
CallMethod(new object[] {updateTick, deltaTime});

public void UpdateScreenSize (UnityEngine.Vector2 currentScreenSize) =>
CallMethod(new object[] {currentScreenSize});

public void CreateTouches () =>
CallMethod();

public void UpdateTouches (System.UInt64 updateTick, float deltaTime) =>
CallMethod(new object[] {updateTick, deltaTime});

public void SendTouchBegan (InControl.Touch touch) =>
CallMethod(new object[] {touch});

public void SendTouchMoved (InControl.Touch touch) =>
CallMethod(new object[] {touch});

public void SendTouchEnded (InControl.Touch touch) =>
CallMethod(new object[] {touch});

public void InvokeTouchEvents () =>
CallMethod();

public bool TouchCameraIsValid () =>
CallMethod<bool>();

public UnityEngine.Vector3 ConvertScreenToWorldPoint (UnityEngine.Vector2 point) =>
CallMethod<UnityEngine.Vector3>(new object[] {point});

public UnityEngine.Vector3 ConvertViewToWorldPoint (UnityEngine.Vector2 point) =>
CallMethod<UnityEngine.Vector3>(new object[] {point});

public UnityEngine.Vector3 ConvertScreenToViewPoint (UnityEngine.Vector2 point) =>
CallMethod<UnityEngine.Vector3>(new object[] {point});

public UnityEngine.Vector2 GetCurrentScreenSize () =>
CallMethod<UnityEngine.Vector2>();

public InControl.Touch GetTouch (int touchIndex) =>
InControl.TouchManager.GetTouch(touchIndex);

public InControl.Touch GetTouchByFingerId (int fingerId) =>
InControl.TouchManager.GetTouchByFingerId(fingerId);

public UnityEngine.Vector3 ScreenToWorldPoint (UnityEngine.Vector2 point) =>
InControl.TouchManager.ScreenToWorldPoint(point);

public UnityEngine.Vector3 ViewToWorldPoint (UnityEngine.Vector2 point) =>
InControl.TouchManager.ViewToWorldPoint(point);

public UnityEngine.Vector3 ScreenToViewPoint (UnityEngine.Vector2 point) =>
InControl.TouchManager.ScreenToViewPoint(point);

public float ConvertToWorld (float value, InControl.TouchUnitType unitType) =>
InControl.TouchManager.ConvertToWorld(value, unitType);

public UnityEngine.Rect PercentToWorldRect (UnityEngine.Rect rect) =>
InControl.TouchManager.PercentToWorldRect(rect);

public UnityEngine.Rect PixelToWorldRect (UnityEngine.Rect rect) =>
InControl.TouchManager.PixelToWorldRect(rect);

public UnityEngine.Rect ConvertToWorld (UnityEngine.Rect rect, InControl.TouchUnitType unitType) =>
InControl.TouchManager.ConvertToWorld(rect, unitType);

}
}
