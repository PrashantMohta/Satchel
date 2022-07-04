using HutongGames.PlayMaker.Ecosystem.Utils;

namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of PlayMakerEventTarget allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class PlayMakerEventTargetR : InstanceClassWrapper<PlayMakerEventTarget>
{
    public PlayMakerEventTargetR(PlayMakerEventTarget _orig) : base(_orig)
    {
    }

    public ProxyEventTarget eventTarget
    {
        get => orig.eventTarget;
        set => orig.eventTarget = value;
    }

    public GameObject gameObject
    {
        get => orig.gameObject;
        set => orig.gameObject = value;
    }

    public bool includeChildren
    {
        get => orig.includeChildren;
        set => orig.includeChildren = value;
    }

    public PlayMakerFSM fsmComponent
    {
        get => orig.fsmComponent;
        set => orig.fsmComponent = value;
    }
}