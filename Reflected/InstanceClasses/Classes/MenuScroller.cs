namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of MenuScroller allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class MenuScrollerR:InstanceClassWrapper<UnityEngine.UI.MenuScroller>
{
public MenuScrollerR(UnityEngine.UI.MenuScroller _orig) : base(_orig) {}
public UnityEngine.UI.ScrollRect scrollRect
{
get => orig.scrollRect;
set => orig.scrollRect = value;
}

public UnityEngine.UI.Scrollbar scrollbar
{
get => orig.scrollbar;
set => orig.scrollbar = value;
}

public InControl.HollowKnightInputModule inputModule
{
get => orig.inputModule;
set => orig.inputModule = value;
}

public float scrollRate
{
get => orig.scrollRate;
set => orig.scrollRate = value;
}

public float scrollRepeatRate
{
get => orig.scrollRepeatRate;
set => orig.scrollRepeatRate = value;
}

public float scrollFirstDelay
{
get => orig.scrollFirstDelay;
set => orig.scrollFirstDelay = value;
}

public UnityEngine.EventSystems.EventSystem eventSystem
{
get => GetField<UnityEngine.EventSystems.EventSystem>();
set => SetField(value);
}

public float prevRepeatRate
{
get => GetField<float>();
set => SetField(value);
}

public float prevInitialDelay
{
get => GetField<float>();
set => SetField(value);
}



public void OnSelect (UnityEngine.EventSystems.BaseEventData eventData) =>
orig.OnSelect(eventData);

public void OnDeselect (UnityEngine.EventSystems.BaseEventData eventData) =>
orig.OnDeselect(eventData);

public void OnSubmit (UnityEngine.EventSystems.BaseEventData eventData) =>
orig.OnSubmit(eventData);

public void OnPointerClick (UnityEngine.EventSystems.PointerEventData eventData) =>
orig.OnPointerClick(eventData);

public void OnCancel (UnityEngine.EventSystems.BaseEventData eventData) =>
orig.OnCancel(eventData);

public void OnMove (UnityEngine.EventSystems.AxisEventData move) =>
orig.OnMove(move);

}
}
