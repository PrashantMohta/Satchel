using HutongGames.PlayMaker.Ecosystem.Utils;
using UnityEngine.EventSystems;

namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of PlayMakerUGuiDragEventsProxy allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class PlayMakerUGuiDragEventsProxyR : InstanceClassWrapper<PlayMakerUGuiDragEventsProxy>
{
    public PlayMakerUGuiDragEventsProxyR(PlayMakerUGuiDragEventsProxy _orig) : base(_orig)
    {
    }

    public bool debug
    {
        get => orig.debug;
        set => orig.debug = value;
    }

    public PlayMakerEventTarget eventTarget
    {
        get => orig.eventTarget;
        set => orig.eventTarget = value;
    }

    public PlayMakerEvent onBeginDragEvent
    {
        get => orig.onBeginDragEvent;
        set => orig.onBeginDragEvent = value;
    }

    public PlayMakerEvent onDragEvent
    {
        get => orig.onDragEvent;
        set => orig.onDragEvent = value;
    }

    public PlayMakerEvent onEndDragEvent
    {
        get => orig.onEndDragEvent;
        set => orig.onEndDragEvent = value;
    }


    public void OnBeginDrag(PointerEventData data)
    {
        orig.OnBeginDrag(data);
    }

    public void OnDrag(PointerEventData data)
    {
        orig.OnDrag(data);
    }

    public void OnEndDrag(PointerEventData data)
    {
        orig.OnEndDrag(data);
    }
}