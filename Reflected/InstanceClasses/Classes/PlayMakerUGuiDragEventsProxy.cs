namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of PlayMakerUGuiDragEventsProxy allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class PlayMakerUGuiDragEventsProxyR:InstanceClassWrapper<PlayMakerUGuiDragEventsProxy>
{
public PlayMakerUGuiDragEventsProxyR(PlayMakerUGuiDragEventsProxy _orig) : base(_orig) {}
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

public HutongGames.PlayMaker.Ecosystem.Utils.PlayMakerEvent onBeginDragEvent
{
get => orig.onBeginDragEvent;
set => orig.onBeginDragEvent = value;
}

public HutongGames.PlayMaker.Ecosystem.Utils.PlayMakerEvent onDragEvent
{
get => orig.onDragEvent;
set => orig.onDragEvent = value;
}

public HutongGames.PlayMaker.Ecosystem.Utils.PlayMakerEvent onEndDragEvent
{
get => orig.onEndDragEvent;
set => orig.onEndDragEvent = value;
}



public void OnBeginDrag (UnityEngine.EventSystems.PointerEventData data) =>
orig.OnBeginDrag(data);

public void OnDrag (UnityEngine.EventSystems.PointerEventData data) =>
orig.OnDrag(data);

public void OnEndDrag (UnityEngine.EventSystems.PointerEventData data) =>
orig.OnEndDrag(data);

}
}
