using HutongGames.PlayMaker.Ecosystem.Utils;
using UnityEngine.EventSystems;

namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of PlayMakerUGuiPointerEventsProxy allowing you
///     to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class PlayMakerUGuiPointerEventsProxyR : InstanceClassWrapper<PlayMakerUGuiPointerEventsProxy>
{
    public PlayMakerUGuiPointerEventsProxyR(PlayMakerUGuiPointerEventsProxy _orig) : base(_orig)
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

    public PlayMakerEvent onClickEvent
    {
        get => orig.onClickEvent;
        set => orig.onClickEvent = value;
    }

    public PlayMakerEvent onDownEvent
    {
        get => orig.onDownEvent;
        set => orig.onDownEvent = value;
    }

    public PlayMakerEvent onEnterEvent
    {
        get => orig.onEnterEvent;
        set => orig.onEnterEvent = value;
    }

    public PlayMakerEvent onExitEvent
    {
        get => orig.onExitEvent;
        set => orig.onExitEvent = value;
    }

    public PlayMakerEvent onUpEvent
    {
        get => orig.onUpEvent;
        set => orig.onUpEvent = value;
    }


    public void OnPointerClick(PointerEventData data)
    {
        orig.OnPointerClick(data);
    }

    public void OnPointerDown(PointerEventData data)
    {
        orig.OnPointerDown(data);
    }

    public void OnPointerEnter(PointerEventData data)
    {
        orig.OnPointerEnter(data);
    }

    public void OnPointerExit(PointerEventData data)
    {
        orig.OnPointerExit(data);
    }

    public void OnPointerUp(PointerEventData data)
    {
        orig.OnPointerUp(data);
    }
}