using InControl;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of MenuScroller allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class MenuScrollerR : InstanceClassWrapper<MenuScroller>
{
    public MenuScrollerR(MenuScroller _orig) : base(_orig)
    {
    }

    public ScrollRect scrollRect
    {
        get => orig.scrollRect;
        set => orig.scrollRect = value;
    }

    public Scrollbar scrollbar
    {
        get => orig.scrollbar;
        set => orig.scrollbar = value;
    }

    public HollowKnightInputModule inputModule
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

    public EventSystem eventSystem
    {
        get => GetField<EventSystem>();
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


    public void OnSelect(BaseEventData eventData)
    {
        orig.OnSelect(eventData);
    }

    public void OnDeselect(BaseEventData eventData)
    {
        orig.OnDeselect(eventData);
    }

    public void OnSubmit(BaseEventData eventData)
    {
        orig.OnSubmit(eventData);
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        orig.OnPointerClick(eventData);
    }

    public void OnCancel(BaseEventData eventData)
    {
        orig.OnCancel(eventData);
    }

    public void OnMove(AxisEventData move)
    {
        orig.OnMove(move);
    }
}