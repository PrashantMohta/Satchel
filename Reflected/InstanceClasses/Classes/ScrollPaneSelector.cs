namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of ScrollPaneSelector allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class ScrollPaneSelectorR:InstanceClassWrapper<Modding.Menu.Components.ScrollPaneSelector>
{
public ScrollPaneSelectorR(Modding.Menu.Components.ScrollPaneSelector _orig) : base(_orig) {}
public UnityEngine.RectTransform PaneRect
{
get => orig.PaneRect;
set => orig.PaneRect = value;
}

public UnityEngine.RectTransform MaskRect
{
get => orig.MaskRect;
set => orig.MaskRect = value;
}

public UnityEngine.UI.Scrollbar Scrollbar
{
get => orig.Scrollbar;
set => orig.Scrollbar = value;
}

public System.Func<UnityEngine.RectTransform,(System.Single,System.Single)> SelectionPadding
{
get => orig.SelectionPadding;
set => orig.SelectionPadding = value;
}



public void OnSelect (UnityEngine.EventSystems.BaseEventData eventData) =>
orig.OnSelect(eventData);

}
}
