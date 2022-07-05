using System.Collections.ObjectModel;
using InControl;
using Touch = InControl.Touch;

namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of TouchManager allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class TouchManagerR : InstanceClassWrapper<TouchManager>
{
    public TouchManagerR(TouchManager _orig) : base(_orig)
    {
    }

    public Camera touchCamera
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

    public Action OnSetup
    {
        get => GetFieldStatic<Action>();
        set => SetField(value);
    }

    public InputDevice device
    {
        get => GetField<InputDevice>();
        set => SetField(value);
    }

    public Vector3 viewSize
    {
        get => GetField<Vector3>();
        set => SetField(value);
    }

    public Vector2 screenSize
    {
        get => GetField<Vector2>();
        set => SetField(value);
    }

    public Vector2 halfScreenSize
    {
        get => GetField<Vector2>();
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

    public TouchControl[] touchControls
    {
        get => GetField<TouchControl[]>();
        set => SetField(value);
    }

    public TouchPool cachedTouches
    {
        get => GetField<TouchPool>();
        set => SetField(value);
    }

    public List<Touch> activeTouches
    {
        get => GetField<List<Touch>>();
        set => SetField(value);
    }

    public ReadOnlyCollection<Touch> readOnlyActiveTouches
    {
        get => GetField<ReadOnlyCollection<Touch>>();
        set => SetField(value);
    }

    public bool isReady
    {
        get => GetField<bool>();
        set => SetField(value);
    }

    public Touch[] mouseTouches
    {
        get => GetField<Touch[]>();
        set => SetField(value);
    }

    public bool controlsEnabled
    {
        get => orig.controlsEnabled;
        set => orig.controlsEnabled = value;
    }

    public ReadOnlyCollection<Touch> Touches => TouchManager.Touches;

    public int TouchCount => TouchManager.TouchCount;

    public Camera Camera => TouchManager.Camera;

    public InputDevice Device => TouchManager.Device;

    public Vector3 ViewSize => TouchManager.ViewSize;

    public float PercentToWorld => TouchManager.PercentToWorld;

    public float HalfPercentToWorld => TouchManager.HalfPercentToWorld;

    public float PixelToWorld => TouchManager.PixelToWorld;

    public float HalfPixelToWorld => TouchManager.HalfPixelToWorld;

    public Vector2 ScreenSize => TouchManager.ScreenSize;

    public Vector2 HalfScreenSize => TouchManager.HalfScreenSize;

    public bool ControlsEnabled
    {
        get => TouchManager.ControlsEnabled;
        set => TouchManager.ControlsEnabled = value;
    }

    public bool EnforceSingleton => GetProperty<bool>();

    public bool IsTheSingleton => GetProperty<bool>();

    public bool IsNotTheSingleton => GetProperty<bool>();


    public void OnEnable()
    {
        CallMethod();
    }

    public void OnDisable()
    {
        CallMethod();
    }

    public void Setup()
    {
        CallMethod();
    }

    public void Reset()
    {
        CallMethod();
    }

    public IEnumerator UpdateScreenSizeAtEndOfFrame()
    {
        return CallMethod<IEnumerator>();
    }

    public void Update()
    {
        CallMethod();
    }

    public void CreateDevice()
    {
        CallMethod();
    }

    public void UpdateDevice(ulong updateTick, float deltaTime)
    {
        CallMethod(new object[] { updateTick, deltaTime });
    }

    public void CommitDevice(ulong updateTick, float deltaTime)
    {
        CallMethod(new object[] { updateTick, deltaTime });
    }

    public void SubmitControlStates(ulong updateTick, float deltaTime)
    {
        CallMethod(new object[] { updateTick, deltaTime });
    }

    public void CommitControlStates(ulong updateTick, float deltaTime)
    {
        CallMethod(new object[] { updateTick, deltaTime });
    }

    public void UpdateScreenSize(Vector2 currentScreenSize)
    {
        CallMethod(new object[] { currentScreenSize });
    }

    public void CreateTouches()
    {
        CallMethod();
    }

    public void UpdateTouches(ulong updateTick, float deltaTime)
    {
        CallMethod(new object[] { updateTick, deltaTime });
    }

    public void SendTouchBegan(Touch touch)
    {
        CallMethod(new object[] { touch });
    }

    public void SendTouchMoved(Touch touch)
    {
        CallMethod(new object[] { touch });
    }

    public void SendTouchEnded(Touch touch)
    {
        CallMethod(new object[] { touch });
    }

    public void InvokeTouchEvents()
    {
        CallMethod();
    }

    public bool TouchCameraIsValid()
    {
        return CallMethod<bool>();
    }

    public Vector3 ConvertScreenToWorldPoint(Vector2 point)
    {
        return CallMethod<Vector3>(new object[] { point });
    }

    public Vector3 ConvertViewToWorldPoint(Vector2 point)
    {
        return CallMethod<Vector3>(new object[] { point });
    }

    public Vector3 ConvertScreenToViewPoint(Vector2 point)
    {
        return CallMethod<Vector3>(new object[] { point });
    }

    public Vector2 GetCurrentScreenSize()
    {
        return CallMethod<Vector2>();
    }

    public Touch GetTouch(int touchIndex)
    {
        return TouchManager.GetTouch(touchIndex);
    }

    public Touch GetTouchByFingerId(int fingerId)
    {
        return TouchManager.GetTouchByFingerId(fingerId);
    }

    public Vector3 ScreenToWorldPoint(Vector2 point)
    {
        return TouchManager.ScreenToWorldPoint(point);
    }

    public Vector3 ViewToWorldPoint(Vector2 point)
    {
        return TouchManager.ViewToWorldPoint(point);
    }

    public Vector3 ScreenToViewPoint(Vector2 point)
    {
        return TouchManager.ScreenToViewPoint(point);
    }

    public float ConvertToWorld(float value, TouchUnitType unitType)
    {
        return TouchManager.ConvertToWorld(value, unitType);
    }

    public Rect PercentToWorldRect(Rect rect)
    {
        return TouchManager.PercentToWorldRect(rect);
    }

    public Rect PixelToWorldRect(Rect rect)
    {
        return TouchManager.PixelToWorldRect(rect);
    }

    public Rect ConvertToWorld(Rect rect, TouchUnitType unitType)
    {
        return TouchManager.ConvertToWorld(rect, unitType);
    }
}