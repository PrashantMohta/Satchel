using Bounds = HutongGames.PlayMaker.Actions.Bounds;

namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of Bounds allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class BoundsR : InstanceClassWrapper<Bounds>
{
    public BoundsR(Bounds _orig) : base(_orig)
    {
    }

    public FsmOwnerDefault gameObject1
    {
        get => orig.gameObject1;
        set => orig.gameObject1 = value;
    }

    public FsmVector3 scale
    {
        get => orig.scale;
        set => orig.scale = value;
    }

    public bool global
    {
        get => orig.global;
        set => orig.global = value;
    }

    public bool everyFrame
    {
        get => orig.everyFrame;
        set => orig.everyFrame = value;
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

    public void GetEm()
    {
        orig.GetEm();
    }

    public void OnEnter()
    {
        orig.OnEnter();
    }

    public void OnUpdate()
    {
        orig.OnUpdate();
    }
}