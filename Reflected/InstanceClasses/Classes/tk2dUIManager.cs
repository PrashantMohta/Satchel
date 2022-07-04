namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of tk2dUIManager allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class tk2dUIManagerR : InstanceClassWrapper<tk2dUIManager>
{
    public tk2dUIManagerR(tk2dUIManager _orig) : base(_orig)
    {
    }

    public double version
    {
        get => tk2dUIManager.version;
        set => tk2dUIManager.version = value;
    }

    public int releaseId
    {
        get => tk2dUIManager.releaseId;
        set => tk2dUIManager.releaseId = value;
    }

    public tk2dUIManager instance
    {
        get => GetFieldStatic<tk2dUIManager>();
        set => SetField(value);
    }

    public Camera uiCamera
    {
        get => GetField<Camera>();
        set => SetField(value);
    }

    public List<tk2dUICamera> allCameras
    {
        get => GetFieldStatic<List<tk2dUICamera>>();
        set => SetField(value);
    }

    public List<tk2dUICamera> sortedCameras
    {
        get => GetField<List<tk2dUICamera>>();
        set => SetField(value);
    }

    public LayerMask raycastLayerMask
    {
        get => orig.raycastLayerMask;
        set => orig.raycastLayerMask = value;
    }

    public bool inputEnabled
    {
        get => GetField<bool>();
        set => SetField(value);
    }

    public bool areHoverEventsTracked
    {
        get => orig.areHoverEventsTracked;
        set => orig.areHoverEventsTracked = value;
    }

    public tk2dUIItem pressedUIItem
    {
        get => GetField<tk2dUIItem>();
        set => SetField(value);
    }

    public tk2dUIItem overUIItem
    {
        get => GetField<tk2dUIItem>();
        set => SetField(value);
    }

    public tk2dUITouch firstPressedUIItemTouch
    {
        get => GetField<tk2dUITouch>();
        set => SetField(value);
    }

    public bool checkForHovers
    {
        get => GetField<bool>();
        set => SetField(value);
    }

    public bool useMultiTouch
    {
        get => GetField<bool>();
        set => SetField(value);
    }

    public int MAX_MULTI_TOUCH_COUNT
    {
        get => GetFieldStatic<int>();
        set => SetField(value);
    }

    public tk2dUITouch[] allTouches
    {
        get => GetField<tk2dUITouch[]>();
        set => SetField(value);
    }

    public List<tk2dUIItem> prevPressedUIItemList
    {
        get => GetField<List<tk2dUIItem>>();
        set => SetField(value);
    }

    public tk2dUIItem[] pressedUIItems
    {
        get => GetField<tk2dUIItem[]>();
        set => SetField(value);
    }

    public int touchCounter
    {
        get => GetField<int>();
        set => SetField(value);
    }

    public Vector2 mouseDownFirstPos
    {
        get => GetField<Vector2>();
        set => SetField(value);
    }

    public string MOUSE_WHEEL_AXES_NAME
    {
        get => GetFieldStatic<string>();
        set => SetField(value);
    }

    public tk2dUITouch primaryTouch
    {
        get => GetField<tk2dUITouch>();
        set => SetField(value);
    }

    public tk2dUITouch secondaryTouch
    {
        get => GetField<tk2dUITouch>();
        set => SetField(value);
    }

    public tk2dUITouch resultTouch
    {
        get => GetField<tk2dUITouch>();
        set => SetField(value);
    }

    public tk2dUIItem hitUIItem
    {
        get => GetField<tk2dUIItem>();
        set => SetField(value);
    }

    public RaycastHit hit
    {
        get => GetField<RaycastHit>();
        set => SetField(value);
    }

    public Ray ray
    {
        get => GetField<Ray>();
        set => SetField(value);
    }

    public tk2dUITouch currTouch
    {
        get => GetField<tk2dUITouch>();
        set => SetField(value);
    }

    public tk2dUIItem currPressedItem
    {
        get => GetField<tk2dUIItem>();
        set => SetField(value);
    }

    public tk2dUIItem prevPressedItem
    {
        get => GetField<tk2dUIItem>();
        set => SetField(value);
    }

    public Action OnAnyPress
    {
        get => GetField<Action>();
        set => SetField(value);
    }

    public Action OnInputUpdate
    {
        get => GetField<Action>();
        set => SetField(value);
    }

    public Action<float> OnScrollWheelChange
    {
        get => GetField<Action<float>>();
        set => SetField(value);
    }

    public tk2dUIManager Instance => tk2dUIManager.Instance;

    public tk2dUIManager Instance__NoCreate => tk2dUIManager.Instance__NoCreate;

    public Camera UICamera
    {
        get => orig.UICamera;
        set => orig.UICamera = value;
    }

    public bool InputEnabled
    {
        get => orig.InputEnabled;
        set => orig.InputEnabled = value;
    }

    public tk2dUIItem PressedUIItem => orig.PressedUIItem;

    public tk2dUIItem[] PressedUIItems => orig.PressedUIItems;

    public bool UseMultiTouch
    {
        get => orig.UseMultiTouch;
        set => orig.UseMultiTouch = value;
    }


    public Camera GetUICameraForControl(GameObject go)
    {
        return orig.GetUICameraForControl(go);
    }

    public void RegisterCamera(tk2dUICamera cam)
    {
        tk2dUIManager.RegisterCamera(cam);
    }

    public void UnregisterCamera(tk2dUICamera cam)
    {
        tk2dUIManager.UnregisterCamera(cam);
    }

    public void SortCameras()
    {
        CallMethod();
    }

    public void Awake()
    {
        CallMethod();
    }

    public void HookUpLegacyCamera(Camera cam)
    {
        CallMethod(new object[] { cam });
    }

    public void Start()
    {
        CallMethod();
    }

    public void Setup()
    {
        CallMethod();
    }

    public void Update()
    {
        CallMethod();
    }

    public void CheckInputs()
    {
        CallMethod();
    }

    public void CheckMultiTouchInputs()
    {
        CallMethod();
    }

    public tk2dUIItem RaycastForUIItem(Vector2 screenPos)
    {
        return CallMethod<tk2dUIItem>(new object[] { screenPos });
    }

    public void OverrideClearAllChildrenPresses(tk2dUIItem item)
    {
        orig.OverrideClearAllChildrenPresses(item);
    }
}