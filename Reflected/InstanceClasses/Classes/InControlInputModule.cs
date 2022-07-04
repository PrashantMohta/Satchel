using InControl;
using UnityEngine.EventSystems;

namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of InControlInputModule allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class InControlInputModuleR : InstanceClassWrapper<InControlInputModule>
{
    public InControlInputModuleR(InControlInputModule _orig) : base(_orig)
    {
    }

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

    public InputDevice inputDevice
    {
        get => GetField<InputDevice>();
        set => SetField(value);
    }

    public Vector3 thisMousePosition
    {
        get => GetField<Vector3>();
        set => SetField(value);
    }

    public Vector3 lastMousePosition
    {
        get => GetField<Vector3>();
        set => SetField(value);
    }

    public Vector2 thisVectorState
    {
        get => GetField<Vector2>();
        set => SetField(value);
    }

    public Vector2 lastVectorState
    {
        get => GetField<Vector2>();
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

    public TwoAxisInputControl direction
    {
        get => GetField<TwoAxisInputControl>();
        set => SetField(value);
    }

    public Dictionary<int, PointerEventData> m_PointerData
    {
        get => GetField<Dictionary<int, PointerEventData>>();
        set => SetField(value);
    }

    public List<RaycastResult> m_RaycastResultCache
    {
        get => GetField<List<RaycastResult>>();
        set => SetField(value);
    }

    public BaseInput m_InputOverride
    {
        get => GetField<BaseInput>();
        set => SetField(value);
    }

    public PlayerAction SubmitAction
    {
        get => orig.SubmitAction;
        set => orig.SubmitAction = value;
    }

    public PlayerAction CancelAction
    {
        get => orig.CancelAction;
        set => orig.CancelAction = value;
    }

    public PlayerTwoAxisAction MoveAction
    {
        get => orig.MoveAction;
        set => orig.MoveAction = value;
    }

    public InputDevice Device
    {
        get => orig.Device;
        set => orig.Device = value;
    }

    public InputControl SubmitButton => GetProperty<InputControl>();

    public InputControl CancelButton => GetProperty<InputControl>();

    public bool VectorIsPressed => GetProperty<bool>();

    public bool VectorIsReleased => GetProperty<bool>();

    public bool VectorHasChanged => GetProperty<bool>();

    public bool VectorWasPressed => GetProperty<bool>();

    public bool SubmitWasPressed => GetProperty<bool>();

    public bool SubmitWasReleased => GetProperty<bool>();

    public bool CancelWasPressed => GetProperty<bool>();

    public bool MouseHasMoved => GetProperty<bool>();

    public bool MouseButtonWasPressed => GetPropertyStatic<bool>();

    public BaseInput input => orig.input;

    public BaseInput inputOverride
    {
        get => orig.inputOverride;
        set => orig.inputOverride = value;
    }

    public EventSystem eventSystem => GetProperty<EventSystem>();


    public void UpdateModule()
    {
        orig.UpdateModule();
    }

    public bool IsModuleSupported()
    {
        return orig.IsModuleSupported();
    }

    public bool ShouldActivateModule()
    {
        return orig.ShouldActivateModule();
    }

    public void ActivateModule()
    {
        orig.ActivateModule();
    }

    public void Process()
    {
        orig.Process();
    }

    public bool ProcessTouchEvents()
    {
        return CallMethod<bool>();
    }

    public bool SendButtonEventToSelectedObject()
    {
        return CallMethod<bool>();
    }

    public bool SendVectorEventToSelectedObject()
    {
        return CallMethod<bool>();
    }

    public void ProcessMove(PointerEventData pointerEvent)
    {
        CallMethod(new object[] { pointerEvent });
    }

    public void Update()
    {
        CallMethod();
    }

    public void UpdateInputState()
    {
        CallMethod();
    }

    public void SetVectorRepeatTimer()
    {
        CallMethod();
    }

    public bool SendUpdateEventToSelectedObject()
    {
        return CallMethod<bool>();
    }

    public void ProcessMouseEvent()
    {
        CallMethod();
    }

    public void ProcessMouseEvent(int id)
    {
        CallMethod(new object[] { id });
    }

    public void ProcessMousePress(PointerInputModule.MouseButtonEventData data)
    {
        CallMethod(new object[] { data });
    }

    public void ProcessTouchPress(PointerEventData pointerEvent, bool pressed, bool released)
    {
        CallMethod(new object[] { pointerEvent, pressed, released });
    }
}