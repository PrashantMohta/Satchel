namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of InControlInputModule allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class InControlInputModuleR:InstanceClassWrapper<InControl.InControlInputModule>
{
public InControlInputModuleR(InControl.InControlInputModule _orig) : base(_orig) {}
public float analogMoveThreshold
{
get => orig.analogMoveThreshold;
set => orig.analogMoveThreshold = value;
}

public float moveRepeatFirstDuration
{
get => orig.moveRepeatFirstDuration;
set => orig.moveRepeatFirstDuration = value;
}

public float moveRepeatDelayDuration
{
get => orig.moveRepeatDelayDuration;
set => orig.moveRepeatDelayDuration = value;
}

public bool forceModuleActive
{
get => orig.forceModuleActive;
set => orig.forceModuleActive = value;
}

public bool allowMouseInput
{
get => orig.allowMouseInput;
set => orig.allowMouseInput = value;
}

public bool focusOnMouseHover
{
get => orig.focusOnMouseHover;
set => orig.focusOnMouseHover = value;
}

public bool allowTouchInput
{
get => orig.allowTouchInput;
set => orig.allowTouchInput = value;
}

public InControl.InputDevice inputDevice
{
get => GetField<InControl.InputDevice>();
set => SetField(value);
}

public UnityEngine.Vector3 thisMousePosition
{
get => GetField<UnityEngine.Vector3>();
set => SetField(value);
}

public UnityEngine.Vector3 lastMousePosition
{
get => GetField<UnityEngine.Vector3>();
set => SetField(value);
}

public UnityEngine.Vector2 thisVectorState
{
get => GetField<UnityEngine.Vector2>();
set => SetField(value);
}

public UnityEngine.Vector2 lastVectorState
{
get => GetField<UnityEngine.Vector2>();
set => SetField(value);
}

public bool thisSubmitState
{
get => GetField<bool>();
set => SetField(value);
}

public bool lastSubmitState
{
get => GetField<bool>();
set => SetField(value);
}

public bool thisCancelState
{
get => GetField<bool>();
set => SetField(value);
}

public bool lastCancelState
{
get => GetField<bool>();
set => SetField(value);
}

public bool moveWasRepeated
{
get => GetField<bool>();
set => SetField(value);
}

public float nextMoveRepeatTime
{
get => GetField<float>();
set => SetField(value);
}

public InControl.TwoAxisInputControl direction
{
get => GetField<InControl.TwoAxisInputControl>();
set => SetField(value);
}

public System.Collections.Generic.Dictionary<System.Int32,UnityEngine.EventSystems.PointerEventData> m_PointerData
{
get => GetField<System.Collections.Generic.Dictionary<System.Int32,UnityEngine.EventSystems.PointerEventData>>();
set => SetField(value);
}

public System.Collections.Generic.List<UnityEngine.EventSystems.RaycastResult> m_RaycastResultCache
{
get => GetField<System.Collections.Generic.List<UnityEngine.EventSystems.RaycastResult>>();
set => SetField(value);
}

public UnityEngine.EventSystems.BaseInput m_InputOverride
{
get => GetField<UnityEngine.EventSystems.BaseInput>();
set => SetField(value);
}

public InControl.PlayerAction SubmitAction
{
get => orig.SubmitAction;
set => orig.SubmitAction = value;
}

public InControl.PlayerAction CancelAction
{
get => orig.CancelAction;
set => orig.CancelAction = value;
}

public InControl.PlayerTwoAxisAction MoveAction
{
get => orig.MoveAction;
set => orig.MoveAction = value;
}

public InControl.InputDevice Device
{
get => orig.Device;
set => orig.Device = value;
}

public InControl.InputControl SubmitButton
{
get => GetProperty<InControl.InputControl>();
}

public InControl.InputControl CancelButton
{
get => GetProperty<InControl.InputControl>();
}

public bool VectorIsPressed
{
get => GetProperty<bool>();
}

public bool VectorIsReleased
{
get => GetProperty<bool>();
}

public bool VectorHasChanged
{
get => GetProperty<bool>();
}

public bool VectorWasPressed
{
get => GetProperty<bool>();
}

public bool SubmitWasPressed
{
get => GetProperty<bool>();
}

public bool SubmitWasReleased
{
get => GetProperty<bool>();
}

public bool CancelWasPressed
{
get => GetProperty<bool>();
}

public bool MouseHasMoved
{
get => GetProperty<bool>();
}

public bool MouseButtonWasPressed
{
get => GetPropertyStatic<bool>();
}

public UnityEngine.EventSystems.BaseInput input
{
get => orig.input;
}

public UnityEngine.EventSystems.BaseInput inputOverride
{
get => orig.inputOverride;
set => orig.inputOverride = value;
}

public UnityEngine.EventSystems.EventSystem eventSystem
{
get => GetProperty<UnityEngine.EventSystems.EventSystem>();
}



public void UpdateModule () =>
orig.UpdateModule();

public bool IsModuleSupported () =>
orig.IsModuleSupported();

public bool ShouldActivateModule () =>
orig.ShouldActivateModule();

public void ActivateModule () =>
orig.ActivateModule();

public void Process () =>
orig.Process();

public bool ProcessTouchEvents () =>
CallMethod<bool>();

public bool SendButtonEventToSelectedObject () =>
CallMethod<bool>();

public bool SendVectorEventToSelectedObject () =>
CallMethod<bool>();

public void ProcessMove (UnityEngine.EventSystems.PointerEventData pointerEvent) =>
CallMethod(new object[] {pointerEvent});

public void Update () =>
CallMethod();

public void UpdateInputState () =>
CallMethod();

public void SetVectorRepeatTimer () =>
CallMethod();

public bool SendUpdateEventToSelectedObject () =>
CallMethod<bool>();

public void ProcessMouseEvent () =>
CallMethod();

public void ProcessMouseEvent (int id) =>
CallMethod(new object[] {id});

public void ProcessMousePress (UnityEngine.EventSystems.PointerInputModule.MouseButtonEventData data) =>
CallMethod(new object[] {data});

public void ProcessTouchPress (UnityEngine.EventSystems.PointerEventData pointerEvent, bool pressed, bool released) =>
CallMethod(new object[] {pointerEvent, pressed, released});

}
}
