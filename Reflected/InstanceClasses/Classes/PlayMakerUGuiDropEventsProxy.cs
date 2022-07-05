using HutongGames.PlayMaker.Ecosystem.Utils;
using UnityEngine.EventSystems;

namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of PlayMakerUGuiDropEventsProxy allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class PlayMakerUGuiDropEventsProxyR : InstanceClassWrapper<PlayMakerUGuiDropEventsProxy>
{
    public PlayMakerUGuiDropEventsProxyR(PlayMakerUGuiDropEventsProxy _orig) : base(_orig)
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

    public PlayMakerEvent onDropEvent
    {
        get => orig.onDropEvent;
        set => orig.onDropEvent = value;
    }


    public void OnDrop(PointerEventData data)
    {
        orig.OnDrop(data);
    }
}