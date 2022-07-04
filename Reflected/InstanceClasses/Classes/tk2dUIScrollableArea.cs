namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of tk2dUIScrollableArea allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class tk2dUIScrollableAreaR:InstanceClassWrapper<tk2dUIScrollableArea>
{
public tk2dUIScrollableAreaR(tk2dUIScrollableArea _orig) : base(_orig) {}
public float contentLength
{
get => GetField<float>();
set => SetField(value);
}

public float visibleAreaLength
{
get => GetField<float>();
set => SetField(value);
}

public UnityEngine.GameObject contentContainer
{
get => orig.contentContainer;
set => orig.contentContainer = value;
}

public tk2dUIScrollbar scrollBar
{
get => orig.scrollBar;
set => orig.scrollBar = value;
}

public tk2dUIItem backgroundUIItem
{
get => orig.backgroundUIItem;
set => orig.backgroundUIItem = value;
}

public bool allowSwipeScrolling
{
get => orig.allowSwipeScrolling;
set => orig.allowSwipeScrolling = value;
}

public bool allowScrollWheel
{
get => orig.allowScrollWheel;
set => orig.allowScrollWheel = value;
}

public tk2dUILayout backgroundLayoutItem
{
get => GetField<tk2dUILayout>();
set => SetField(value);
}

public tk2dUILayoutContainer contentLayoutContainer
{
get => GetField<tk2dUILayoutContainer>();
set => SetField(value);
}

public bool isBackgroundButtonDown
{
get => GetField<bool>();
set => SetField(value);
}

public bool isBackgroundButtonOver
{
get => GetField<bool>();
set => SetField(value);
}

public UnityEngine.Vector3 swipeScrollingPressDownStartLocalPos
{
get => GetField<UnityEngine.Vector3>();
set => SetField(value);
}

public UnityEngine.Vector3 swipeScrollingContentStartLocalPos
{
get => GetField<UnityEngine.Vector3>();
set => SetField(value);
}

public UnityEngine.Vector3 swipeScrollingContentDestLocalPos
{
get => GetField<UnityEngine.Vector3>();
set => SetField(value);
}

public bool isSwipeScrollingInProgress
{
get => GetField<bool>();
set => SetField(value);
}

public float SWIPE_SCROLLING_FIRST_SCROLL_THRESHOLD
{
get => GetFieldStatic<float>();
set => SetField(value);
}

public float WITHOUT_SCROLLBAR_FIXED_SCROLL_WHEEL_PERCENT
{
get => GetFieldStatic<float>();
set => SetField(value);
}

public UnityEngine.Vector3 swipePrevScrollingContentPressLocalPos
{
get => GetField<UnityEngine.Vector3>();
set => SetField(value);
}

public float swipeCurrVelocity
{
get => GetField<float>();
set => SetField(value);
}

public float snapBackVelocity
{
get => GetField<float>();
set => SetField(value);
}

public System.Action<tk2dUIScrollableArea> OnScroll
{
get => GetField<System.Action<tk2dUIScrollableArea>>();
set => SetField(value);
}

public string SendMessageOnScrollMethodName
{
get => orig.SendMessageOnScrollMethodName;
set => orig.SendMessageOnScrollMethodName = value;
}

public float percent
{
get => GetField<float>();
set => SetField(value);
}

public UnityEngine.Vector3[] boxExtents
{
get => GetFieldStatic<UnityEngine.Vector3[]>();
set => SetField(value);
}

public float ContentLength
{
get => orig.ContentLength;
set => orig.ContentLength = value;
}

public float VisibleAreaLength
{
get => orig.VisibleAreaLength;
set => orig.VisibleAreaLength = value;
}

public tk2dUILayout BackgroundLayoutItem
{
get => orig.BackgroundLayoutItem;
set => orig.BackgroundLayoutItem = value;
}

public tk2dUILayoutContainer ContentLayoutContainer
{
get => orig.ContentLayoutContainer;
set => orig.ContentLayoutContainer = value;
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

public UnityEngine.Vector3 ContentContainerOffset
{
get => GetProperty<UnityEngine.Vector3>();
set => SetProperty(value);
}



public void SetScrollPercentWithoutEvent (float newScrollPercent) =>
orig.SetScrollPercentWithoutEvent(newScrollPercent);

public float MeasureContentLength () =>
orig.MeasureContentLength();

public void OnEnable () =>
CallMethod();

public void OnDisable () =>
CallMethod();

public void Start () =>
CallMethod();

public void BackgroundHoverOverScrollWheelChange (float mouseWheelChange) =>
CallMethod(new object[] {mouseWheelChange});

public void ScrollBarMove (tk2dUIScrollbar scrollBar) =>
CallMethod(new object[] {scrollBar});

public void SetContentPosition () =>
CallMethod();

public void BackgroundButtonDown () =>
CallMethod();

public void BackgroundOverUpdate () =>
CallMethod();

public void UpdateSwipeScrollDestintationPosition () =>
CallMethod();

public void BackgroundButtonRelease () =>
CallMethod();

public void BackgroundButtonHoverOver () =>
CallMethod();

public void BackgroundButtonHoverOut () =>
CallMethod();

public UnityEngine.Vector3 CalculateClickWorldPos (tk2dUIItem btn) =>
CallMethod<UnityEngine.Vector3>(new object[] {btn});

public void UpdateScrollbarActiveState () =>
CallMethod();

public void ContentLengthVisibleAreaLengthChange (float prevContentLength, float newContentLength, float prevVisibleAreaLength, float newVisibleAreaLength) =>
CallMethod(new object[] {prevContentLength, newContentLength, prevVisibleAreaLength, newVisibleAreaLength});

public void UnpressAllUIItemChildren () =>
CallMethod();

public void TargetOnScrollCallback () =>
CallMethod();

public void GetRendererBoundsInChildren (UnityEngine.Matrix4x4 rootWorldToLocal, UnityEngine.Vector3[] minMax, UnityEngine.Transform t) =>
CallMethodStatic(new object[] {rootWorldToLocal, minMax, t});

public void LayoutReshaped (UnityEngine.Vector3 dMin, UnityEngine.Vector3 dMax) =>
CallMethod(new object[] {dMin, dMax});

public void ContentLayoutChangeCallback () =>
CallMethod();

}
}
