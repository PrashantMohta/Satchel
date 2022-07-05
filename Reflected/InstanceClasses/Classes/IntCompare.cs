namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of IntCompare allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class IntCompareR : InstanceClassWrapper<IntCompare>
{
    public IntCompareR(IntCompare _orig) : base(_orig)
    {
    }

    public FsmInt integer1
    {
        get => orig.integer1;
        set => orig.integer1 = value;
    }

    public FsmInt integer2
    {
        get => orig.integer2;
        set => orig.integer2 = value;
    }

    public FsmEvent equal
    {
        get => orig.equal;
        set => orig.equal = value;
    }

    public FsmEvent lessThan
    {
        get => orig.lessThan;
        set => orig.lessThan = value;
    }

    public FsmEvent greaterThan
    {
        get => orig.greaterThan;
        set => orig.greaterThan = value;
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

    public void OnEnter()
    {
        orig.OnEnter();
    }

    public void OnUpdate()
    {
        orig.OnUpdate();
    }

    public void DoIntCompare()
    {
        CallMethod();
    }

    public string ErrorCheck()
    {
        return orig.ErrorCheck();
    }
}