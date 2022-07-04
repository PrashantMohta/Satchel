using Modding.Menu.Components;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of ScrollPaneSelector allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class ScrollPaneSelectorR : InstanceClassWrapper<ScrollPaneSelector>
{
    public ScrollPaneSelectorR(ScrollPaneSelector _orig) : base(_orig)
    {
    }

    public RectTransform PaneRect
    {
        get => orig.PaneRect;
        set => orig.PaneRect = value;
    }

    public RectTransform MaskRect
    {
        get => orig.MaskRect;
        set => orig.MaskRect = value;
    }

    public Scrollbar Scrollbar
    {
        get => orig.Scrollbar;
        set => orig.Scrollbar = value;
    }

    public Func<RectTransform, (float, float)> SelectionPadding
    {
        get => orig.SelectionPadding;
        set => orig.SelectionPadding = value;
    }


    public void OnSelect(BaseEventData eventData)
    {
        orig.OnSelect(eventData);
    }
}