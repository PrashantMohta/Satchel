namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of FsmEventOptions allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class FsmEventOptionsR : InstanceClassWrapper<FsmEventOptions>
{
    public FsmEventOptionsR(FsmEventOptions _orig) : base(_orig)
    {
    }

    public PlayMakerFSM sendToFsmComponent
    {
        get => orig.sendToFsmComponent;
        set => orig.sendToFsmComponent = value;
    }

    public FsmGameObject sendToGameObject
    {
        get => orig.sendToGameObject;
        set => orig.sendToGameObject = value;
    }

    public FsmString fsmName
    {
        get => orig.fsmName;
        set => orig.fsmName = value;
    }

    public FsmBool sendToChildren
    {
        get => orig.sendToChildren;
        set => orig.sendToChildren = value;
    }

    public FsmBool broadcastToAll
    {
        get => orig.broadcastToAll;
        set => orig.broadcastToAll = value;
    }

    public string Name
    {
        get => orig.Name;
        set => orig.Name = value;
    }

    public string DisplayName
    {
        get => orig.DisplayName;
        set => orig.DisplayName = value;
    }

    public Fsm Fsm
    {
        get => orig.Fsm;
        set => orig.Fsm = value;
    }

    public GameObject Owner
    {
        get => orig.Owner;
        set => orig.Owner = value;
    }

    public FsmState State
    {
        get => orig.State;
        set => orig.State = value;
    }

    public bool Enabled
    {
        get => orig.Enabled;
        set => orig.Enabled = value;
    }

    public bool IsOpen
    {
        get => orig.IsOpen;
        set => orig.IsOpen = value;
    }

    public bool IsAutoNamed
    {
        get => orig.IsAutoNamed;
        set => orig.IsAutoNamed = value;
    }

    public bool Entered
    {
        get => orig.Entered;
        set => orig.Entered = value;
    }

    public bool Finished
    {
        get => orig.Finished;
        set => orig.Finished = value;
    }

    public bool Active
    {
        get => orig.Active;
        set => orig.Active = value;
    }

    public void Reset()
    {
        orig.Reset();
    }

    public void OnUpdate()
    {
        orig.OnUpdate();
    }
}