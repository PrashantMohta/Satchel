using HutongGames.PlayMaker.Ecosystem.Utils;

namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of PlayMakerEvent allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class PlayMakerEventR : InstanceClassWrapper<PlayMakerEvent>
{
    public PlayMakerEventR(PlayMakerEvent _orig) : base(_orig)
    {
    }

    public string eventName
    {
        get => orig.eventName;
        set => orig.eventName = value;
    }

    public bool allowLocalEvents
    {
        get => orig.allowLocalEvents;
        set => orig.allowLocalEvents = value;
    }

    public string defaultEventName
    {
        get => orig.defaultEventName;
        set => orig.defaultEventName = value;
    }

    public bool SendEvent(PlayMakerFSM fromFsm, PlayMakerEventTarget eventTarget)
    {
        return orig.SendEvent(fromFsm, eventTarget);
    }
}