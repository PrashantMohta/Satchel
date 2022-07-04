namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of tk2dUIScrollbar allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class tk2dUIScrollbarR:InstanceClassWrapper<tk2dUIScrollbar>
{
public tk2dUIScrollbarR(tk2dUIScrollbar _orig) : base(_orig) {}
public tk2dUIItem barUIItem
{
get => orig.barUIItem;
set => orig.barUIItem = value;
}

public float scrollBarLength
{
get => orig.scrollBarLength;
set => orig.scrollBarLength = value;
}

public tk2dUIItem thumbBtn
{
get => orig.thumbBtn;
set => orig.thumbBtn = value;
}

public UnityEngine.Transform thumbTransform
{
get => orig.thumbTransform;
set => orig.thumbTransform = value;
}

public float thumbLength
{
get => orig.thumbLength;
set => orig.thumbLength = value;
}

public tk2dUIItem upButton
{
get => orig.upButton;
set => orig.upButton = value;
}

public tk2dUIHoverItem hoverUpButton
{
get => GetField<tk2dUIHoverItem>();
set => SetField(value);
}

public tk2dUIItem downButton
{
get => orig.downButton;
set => orig.downButton = value;
}

public tk2dUIHoverItem hoverDownButton
{
get => GetField<tk2dUIHoverItem>();
set => SetField(value);
}

public float buttonUpDownScrollDistance
{
get => orig.buttonUpDownScrollDistance;
set => orig.buttonUpDownScrollDistance = value;
}

public bool allowScrollWheel
{
get => orig.allowScrollWheel;
set => orig.allowScrollWheel = value;
}

public tk2dUIProgressBar highlightProgressBar
{
get => orig.highlightProgressBar;
set => orig.highlightProgressBar = value;
}

public tk2dUILayout barLayoutItem
{
get => GetField<tk2dUILayout>();
set => SetField(value);
}

public bool isScrollThumbButtonDown
{
get => GetField<bool>();
set => SetField(value);
}

public bool isTrackHoverOver
{
get => GetField<bool>();
set => SetField(value);
}

public float percent
{
get => GetField<float>();
set => SetField(value);
}

public UnityEngine.Vector3 moveThumbBtnOffset
{
get => GetField<UnityEngine.Vector3>();
set => SetField(value);
}

public int scrollUpDownButtonState
{
get => GetField<int>();
set => SetField(value);
}

public float timeOfUpDownButtonPressStart
{
get => GetField<float>();
set => SetField(value);
}

public float repeatUpDownButtonHoldCounter
{
get => GetField<float>();
set => SetField(value);
}

public float WITHOUT_SCROLLBAR_FIXED_SCROLL_WHEEL_PERCENT
{
get => GetFieldStatic<float>();
set => SetField(value);
}

public float INITIAL_TIME_TO_REPEAT_UP_DOWN_SCROLL_BUTTON_SCROLLING_ON_HOLD
{
get => GetFieldStatic<float>();
set => SetField(value);
}

public float TIME_TO_REPEAT_UP_DOWN_SCROLL_BUTTON_SCROLLING_ON_HOLD
{
get => GetFieldStatic<float>();
set => SetField(value);
}

public System.Action<tk2dUIScrollbar> OnScroll
{
get => GetField<System.Action<tk2dUIScrollbar>>();
set => SetField(value);
}

public string SendMessageOnScrollMethodName
{
get => orig.SendMessageOnScrollMethodName;
set => orig.SendMessageOnScrollMethodName = value;
}

public tk2dUILayout BarLayoutItem
{
get => orig.BarLayoutItem;
set => orig.BarLayoutItem = value;
}

public UnityEngine.GameObject SendMessageTarget
{
get => orig.SendMessageTarget;
set => orig.SendMessageTarget = value;
}

public float Value
{
get => orig.Value;
set => orig.Value = value;
}



public void SetScrollPercentWithoutEvent (float newScrollPercent) =>
orig.SetScrollPercentWithoutEvent(newScrollPercent);

public void OnEnable () =>
CallMethod();

public void OnDisable () =>
CallMethod();

public void Awake () =>
CallMethod();

public void Start () =>
CallMethod();

public void TrackHoverScrollWheelChange (float mouseWheelChange) =>
CallMethod(new object[] {mouseWheelChange});

public void SetScrollThumbPosition () =>
CallMethod();

public void MoveScrollThumbButton () =>
CallMethod();

public UnityEngine.Vector3 CalculateClickWorldPos (tk2dUIItem btn) =>
CallMethod<UnityEngine.Vector3>(new object[] {btn});

public void ScrollToPosition (UnityEngine.Vector3 worldPos) =>
CallMethod(new object[] {worldPos});

public void ScrollTrackButtonDown () =>
CallMethod();

public void ScrollTrackButtonHoverOver () =>
CallMethod();

public void ScrollTrackButtonHoverOut () =>
CallMethod();

public void ScrollThumbButtonDown () =>
CallMethod();

public void ScrollThumbButtonRelease () =>
CallMethod();

public void ScrollUpButtonDown () =>
CallMethod();

public void ScrollUpButtonUp () =>
CallMethod();

public void ScrollDownButtonDown () =>
CallMethod();

public void ScrollDownButtonUp () =>
CallMethod();

public void ScrollUpFixed () =>
orig.ScrollUpFixed();

public void ScrollDownFixed () =>
orig.ScrollDownFixed();

public void CheckRepeatScrollUpDownButton () =>
CallMethod();

public void ScrollDirection (int dir) =>
orig.ScrollDirection(dir);

public float CalcScrollPercentOffsetButtonScrollDistance () =>
CallMethod<float>();

public void LayoutReshaped (UnityEngine.Vector3 dMin, UnityEngine.Vector3 dMax) =>
CallMethod(new object[] {dMin, dMax});

}
}
