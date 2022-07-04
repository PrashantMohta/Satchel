namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of tk2dUIManager allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class tk2dUIManagerR:InstanceClassWrapper<tk2dUIManager>
{
public tk2dUIManagerR(tk2dUIManager _orig) : base(_orig) {}
public System.Double version
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

public UnityEngine.Camera uiCamera
{
get => GetField<UnityEngine.Camera>();
set => SetField(value);
}

public System.Collections.Generic.List<tk2dUICamera> allCameras
{
get => GetFieldStatic<System.Collections.Generic.List<tk2dUICamera>>();
set => SetField(value);
}

public System.Collections.Generic.List<tk2dUICamera> sortedCameras
{
get => GetField<System.Collections.Generic.List<tk2dUICamera>>();
set => SetField(value);
}

public UnityEngine.LayerMask raycastLayerMask
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

public System.Collections.Generic.List<tk2dUIItem> prevPressedUIItemList
{
get => GetField<System.Collections.Generic.List<tk2dUIItem>>();
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

public UnityEngine.Vector2 mouseDownFirstPos
{
get => GetField<UnityEngine.Vector2>();
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

public UnityEngine.RaycastHit hit
{
get => GetField<UnityEngine.RaycastHit>();
set => SetField(value);
}

public UnityEngine.Ray ray
{
get => GetField<UnityEngine.Ray>();
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

public System.Action OnAnyPress
{
get => GetField<System.Action>();
set => SetField(value);
}

public System.Action OnInputUpdate
{
get => GetField<System.Action>();
set => SetField(value);
}

public System.Action<System.Single> OnScrollWheelChange
{
get => GetField<System.Action<System.Single>>();
set => SetField(value);
}

public tk2dUIManager Instance
{
get => tk2dUIManager.Instance;
}

public tk2dUIManager Instance__NoCreate
{
get => tk2dUIManager.Instance__NoCreate;
}

public UnityEngine.Camera UICamera
{
get => orig.UICamera;
set => orig.UICamera = value;
}

public bool InputEnabled
{
get => orig.InputEnabled;
set => orig.InputEnabled = value;
}

public tk2dUIItem PressedUIItem
{
get => orig.PressedUIItem;
}

public tk2dUIItem[] PressedUIItems
{
get => orig.PressedUIItems;
}

public bool UseMultiTouch
{
get => orig.UseMultiTouch;
set => orig.UseMultiTouch = value;
}



public UnityEngine.Camera GetUICameraForControl (UnityEngine.GameObject go) =>
orig.GetUICameraForControl(go);

public void RegisterCamera (tk2dUICamera cam) =>
tk2dUIManager.RegisterCamera(cam);

public void UnregisterCamera (tk2dUICamera cam) =>
tk2dUIManager.UnregisterCamera(cam);

public void SortCameras () =>
CallMethod();

public void Awake () =>
CallMethod();

public void HookUpLegacyCamera (UnityEngine.Camera cam) =>
CallMethod(new object[] {cam});

public void Start () =>
CallMethod();

public void Setup () =>
CallMethod();

public void Update () =>
CallMethod();

public void CheckInputs () =>
CallMethod();

public void CheckMultiTouchInputs () =>
CallMethod();

public tk2dUIItem RaycastForUIItem (UnityEngine.Vector2 screenPos) =>
CallMethod<tk2dUIItem>(new object[] {screenPos});

public void OverrideClearAllChildrenPresses (tk2dUIItem item) =>
orig.OverrideClearAllChildrenPresses(item);

}
}
