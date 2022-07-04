namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of SwitchOnPlatform allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class SwitchOnPlatformR : InstanceClassWrapper<SwitchOnPlatform>
{
    public SwitchOnPlatformR(SwitchOnPlatform _orig) : base(_orig)
    {
    }

    public FsmEvent Standalone
    {
        get => orig.Standalone;
        set => orig.Standalone = value;
    }

    public FsmEvent Switch
    {
        get => orig.Switch;
        set => orig.Switch = value;
    }

    public FsmEvent PS4
    {
        get => orig.PS4;
        set => orig.PS4 = value;
    }

    public FsmEvent XB1
    {
        get => orig.XB1;
        set => orig.XB1 = value;
    }

    public FsmEvent Other
    {
        get => orig.Other;
        set => orig.Other = value;
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

    public void OnEnter()
    {
        orig.OnEnter();
    }
}