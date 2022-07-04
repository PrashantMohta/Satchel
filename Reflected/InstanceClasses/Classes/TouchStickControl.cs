using InControl;
using Touch = InControl.Touch;

namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of TouchStickControl allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class TouchStickControlR : InstanceClassWrapper<TouchStickControl>
{
    public TouchStickControlR(TouchStickControl _orig) : base(_orig)
    {
    }

    public TouchControlAnchor anchor
    {
        get => GetField<TouchControlAnchor>();
        set => SetField(value);
    }

    public TouchUnitType offsetUnitType
    {
        get => GetField<TouchUnitType>();
        set => SetField(value);
    }

    public Vector2 offset
    {
        get => GetField<Vector2>();
        set => SetField(value);
    }

    public TouchUnitType areaUnitType
    {
        get => GetField<TouchUnitType>();
        set => SetField(value);
    }

    public Rect activeArea
    {
        get => GetField<Rect>();
        set => SetField(value);
    }

    public LockAxis lockToAxis
    {
        get => orig.lockToAxis;
        set => orig.lockToAxis = value;
    }

    public float lowerDeadZone
    {
        get => orig.lowerDeadZone;
        set => orig.lowerDeadZone = value;
    }

    public float upperDeadZone
    {
        get => orig.upperDeadZone;
        set => orig.upperDeadZone = value;
    }

    public AnimationCurve inputCurve
    {
        get => orig.inputCurve;
        set => orig.inputCurve = value;
    }

    public bool allowDragging
    {
        get => orig.allowDragging;
        set => orig.allowDragging = value;
    }

    public DragAxis allowDraggingAxis
    {
        get => orig.allowDraggingAxis;
        set => orig.allowDraggingAxis = value;
    }

    public bool snapToInitialTouch
    {
        get => orig.snapToInitialTouch;
        set => orig.snapToInitialTouch = value;
    }

    public bool resetWhenDone
    {
        get => orig.resetWhenDone;
        set => orig.resetWhenDone = value;
    }

    public float resetDuration
    {
        get => orig.resetDuration;
        set => orig.resetDuration = value;
    }

    public TouchSprite ring
    {
        get => orig.ring;
        set => orig.ring = value;
    }

    public TouchSprite knob
    {
        get => orig.knob;
        set => orig.knob = value;
    }

    public float knobRange
    {
        get => orig.knobRange;
        set => orig.knobRange = value;
    }

    public Vector3 resetPosition
    {
        get => GetField<Vector3>();
        set => SetField(value);
    }

    public Vector3 beganPosition
    {
        get => GetField<Vector3>();
        set => SetField(value);
    }

    public Vector3 movedPosition
    {
        get => GetField<Vector3>();
        set => SetField(value);
    }

    public float ringResetSpeed
    {
        get => GetField<float>();
        set => SetField(value);
    }

    public float knobResetSpeed
    {
        get => GetField<float>();
        set => SetField(value);
    }

    public Rect worldActiveArea
    {
        get => GetField<Rect>();
        set => SetField(value);
    }

    public float worldKnobRange
    {
        get => GetField<float>();
        set => SetField(value);
    }

    public Vector3 value
    {
        get => GetField<Vector3>();
        set => SetField(value);
    }

    public Touch currentTouch
    {
        get => GetField<Touch>();
        set => SetField(value);
    }

    public bool dirty
    {
        get => GetField<bool>();
        set => SetField(value);
    }

    public bool IsActive => orig.IsActive;

    public bool IsNotActive => orig.IsNotActive;

    public Vector3 RingPosition
    {
        get => orig.RingPosition;
        set => orig.RingPosition = value;
    }

    public Vector3 KnobPosition
    {
        get => orig.KnobPosition;
        set => orig.KnobPosition = value;
    }

    public TouchControlAnchor Anchor
    {
        get => orig.Anchor;
        set => orig.Anchor = value;
    }

    public Vector2 Offset
    {
        get => orig.Offset;
        set => orig.Offset = value;
    }

    public TouchUnitType OffsetUnitType
    {
        get => orig.OffsetUnitType;
        set => orig.OffsetUnitType = value;
    }

    public Rect ActiveArea
    {
        get => orig.ActiveArea;
        set => orig.ActiveArea = value;
    }

    public TouchUnitType AreaUnitType
    {
        get => orig.AreaUnitType;
        set => orig.AreaUnitType = value;
    }


    public void CreateControl()
    {
        orig.CreateControl();
    }

    public void DestroyControl()
    {
        orig.DestroyControl();
    }

    public void ConfigureControl()
    {
        orig.ConfigureControl();
    }

    public void DrawGizmos()
    {
        orig.DrawGizmos();
    }

    public void Update()
    {
        CallMethod();
    }

    public void SubmitControlState(ulong updateTick, float deltaTime)
    {
        orig.SubmitControlState(updateTick, deltaTime);
    }

    public void CommitControlState(ulong updateTick, float deltaTime)
    {
        orig.CommitControlState(updateTick, deltaTime);
    }

    public void TouchBegan(Touch touch)
    {
        orig.TouchBegan(touch);
    }

    public void TouchMoved(Touch touch)
    {
        orig.TouchMoved(touch);
    }

    public void TouchEnded(Touch touch)
    {
        orig.TouchEnded(touch);
    }
}