using InControl;
using UnityEngine.EventSystems;

namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of HollowKnightInputModule allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class HollowKnightInputModuleR : InstanceClassWrapper<HollowKnightInputModule>
{
    public HollowKnightInputModuleR(HollowKnightInputModule _orig) : base(_orig)
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

    public float nextMoveRepeatTime
    {
        get => GetField<float>();
        set => SetField(value);
    }

    public float lastVectorPressedTime
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

    public PlayerAction JumpAction
    {
        get => orig.JumpAction;
        set => orig.JumpAction = value;
    }

    public PlayerAction CastAction
    {
        get => orig.CastAction;
        set => orig.CastAction = value;
    }

    public PlayerAction AttackAction
    {
        get => orig.AttackAction;
        set => orig.AttackAction = value;
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

    public bool VectorIsPressed => GetProperty<bool>();

    public bool VectorIsReleased => GetProperty<bool>();

    public bool VectorHasChanged => GetProperty<bool>();

    public bool VectorWasPressed => GetProperty<bool>();

    public bool MouseHasMoved => GetProperty<bool>();

    public bool MouseButtonIsPressed => GetProperty<bool>();

    public bool allowActivationOnMobileDevice
    {
        get => orig.allowActivationOnMobileDevice;
        set => orig.allowActivationOnMobileDevice = value;
    }

    public bool forceModuleActive
    {
        get => orig.forceModuleActive;
        set => orig.forceModuleActive = value;
    }

    public float inputActionsPerSecond
    {
        get => orig.inputActionsPerSecond;
        set => orig.inputActionsPerSecond = value;
    }

    public float repeatDelay
    {
        get => orig.repeatDelay;
        set => orig.repeatDelay = value;
    }

    public string horizontalAxis
    {
        get => orig.horizontalAxis;
        set => orig.horizontalAxis = value;
    }

    public string verticalAxis
    {
        get => orig.verticalAxis;
        set => orig.verticalAxis = value;
    }

    public string submitButton
    {
        get => orig.submitButton;
        set => orig.submitButton = value;
    }

    public string cancelButton
    {
        get => orig.cancelButton;
        set => orig.cancelButton = value;
    }

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
}