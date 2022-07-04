namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of PlayMakerUGuiPointerEventsProxy allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class PlayMakerUGuiPointerEventsProxyR:InstanceClassWrapper<PlayMakerUGuiPointerEventsProxy>
{
public PlayMakerUGuiPointerEventsProxyR(PlayMakerUGuiPointerEventsProxy _orig) : base(_orig) {}
public bool debug
{
get => orig.debug;
set => orig.debug = value;
}

public HutongGames.PlayMaker.Ecosystem.Utils.PlayMakerEventTarget eventTarget
{
get => orig.eventTarget;
set => orig.eventTarget = value;
}

public HutongGames.PlayMaker.Ecosystem.Utils.PlayMakerEvent onClickEvent
{
get => orig.onClickEvent;
set => orig.onClickEvent = value;
}

public HutongGames.PlayMaker.Ecosystem.Utils.PlayMakerEvent onDownEvent
{
get => orig.onDownEvent;
set => orig.onDownEvent = value;
}

public HutongGames.PlayMaker.Ecosystem.Utils.PlayMakerEvent onEnterEvent
{
get => orig.onEnterEvent;
set => orig.onEnterEvent = value;
}

public HutongGames.PlayMaker.Ecosystem.Utils.PlayMakerEvent onExitEvent
{
get => orig.onExitEvent;
set => orig.onExitEvent = value;
}

public HutongGames.PlayMaker.Ecosystem.Utils.PlayMakerEvent onUpEvent
{
get => orig.onUpEvent;
set => orig.onUpEvent = value;
}



public void OnPointerClick (UnityEngine.EventSystems.PointerEventData data) =>
orig.OnPointerClick(data);

public void OnPointerDown (UnityEngine.EventSystems.PointerEventData data) =>
orig.OnPointerDown(data);

public void OnPointerEnter (UnityEngine.EventSystems.PointerEventData data) =>
orig.OnPointerEnter(data);

public void OnPointerExit (UnityEngine.EventSystems.PointerEventData data) =>
orig.OnPointerExit(data);

public void OnPointerUp (UnityEngine.EventSystems.PointerEventData data) =>
orig.OnPointerUp(data);

}
}
