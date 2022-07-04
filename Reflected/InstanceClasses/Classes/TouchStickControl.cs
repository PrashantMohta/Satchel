namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of TouchStickControl allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class TouchStickControlR:InstanceClassWrapper<InControl.TouchStickControl>
{
public TouchStickControlR(InControl.TouchStickControl _orig) : base(_orig) {}
public InControl.TouchControlAnchor anchor
{
get => GetField<InControl.TouchControlAnchor>();
set => SetField(value);
}

public InControl.TouchUnitType offsetUnitType
{
get => GetField<InControl.TouchUnitType>();
set => SetField(value);
}

public UnityEngine.Vector2 offset
{
get => GetField<UnityEngine.Vector2>();
set => SetField(value);
}

public InControl.TouchUnitType areaUnitType
{
get => GetField<InControl.TouchUnitType>();
set => SetField(value);
}

public UnityEngine.Rect activeArea
{
get => GetField<UnityEngine.Rect>();
set => SetField(value);
}

public InControl.LockAxis lockToAxis
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

public UnityEngine.AnimationCurve inputCurve
{
get => orig.inputCurve;
set => orig.inputCurve = value;
}

public bool allowDragging
{
get => orig.allowDragging;
set => orig.allowDragging = value;
}

public InControl.DragAxis allowDraggingAxis
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

public InControl.TouchSprite ring
{
get => orig.ring;
set => orig.ring = value;
}

public InControl.TouchSprite knob
{
get => orig.knob;
set => orig.knob = value;
}

public float knobRange
{
get => orig.knobRange;
set => orig.knobRange = value;
}

public UnityEngine.Vector3 resetPosition
{
get => GetField<UnityEngine.Vector3>();
set => SetField(value);
}

public UnityEngine.Vector3 beganPosition
{
get => GetField<UnityEngine.Vector3>();
set => SetField(value);
}

public UnityEngine.Vector3 movedPosition
{
get => GetField<UnityEngine.Vector3>();
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

public UnityEngine.Rect worldActiveArea
{
get => GetField<UnityEngine.Rect>();
set => SetField(value);
}

public float worldKnobRange
{
get => GetField<float>();
set => SetField(value);
}

public UnityEngine.Vector3 value
{
get => GetField<UnityEngine.Vector3>();
set => SetField(value);
}

public InControl.Touch currentTouch
{
get => GetField<InControl.Touch>();
set => SetField(value);
}

public bool dirty
{
get => GetField<bool>();
set => SetField(value);
}

public bool IsActive
{
get => orig.IsActive;
}

public bool IsNotActive
{
get => orig.IsNotActive;
}

public UnityEngine.Vector3 RingPosition
{
get => orig.RingPosition;
set => orig.RingPosition = value;
}

public UnityEngine.Vector3 KnobPosition
{
get => orig.KnobPosition;
set => orig.KnobPosition = value;
}

public InControl.TouchControlAnchor Anchor
{
get => orig.Anchor;
set => orig.Anchor = value;
}

public UnityEngine.Vector2 Offset
{
get => orig.Offset;
set => orig.Offset = value;
}

public InControl.TouchUnitType OffsetUnitType
{
get => orig.OffsetUnitType;
set => orig.OffsetUnitType = value;
}

public UnityEngine.Rect ActiveArea
{
get => orig.ActiveArea;
set => orig.ActiveArea = value;
}

public InControl.TouchUnitType AreaUnitType
{
get => orig.AreaUnitType;
set => orig.AreaUnitType = value;
}



public void CreateControl () =>
orig.CreateControl();

public void DestroyControl () =>
orig.DestroyControl();

public void ConfigureControl () =>
orig.ConfigureControl();

public void DrawGizmos () =>
orig.DrawGizmos();

public void Update () =>
CallMethod();

public void SubmitControlState (System.UInt64 updateTick, float deltaTime) =>
orig.SubmitControlState(updateTick, deltaTime);

public void CommitControlState (System.UInt64 updateTick, float deltaTime) =>
orig.CommitControlState(updateTick, deltaTime);

public void TouchBegan (InControl.Touch touch) =>
orig.TouchBegan(touch);

public void TouchMoved (InControl.Touch touch) =>
orig.TouchMoved(touch);

public void TouchEnded (InControl.Touch touch) =>
orig.TouchEnded(touch);

}
}
