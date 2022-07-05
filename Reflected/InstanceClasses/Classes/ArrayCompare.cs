namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of ArrayCompare allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class ArrayCompareR : InstanceClassWrapper<ArrayCompare>
{
    public ArrayCompareR(ArrayCompare _orig) : base(_orig)
    {
    }

    public FsmArray array1
    {
        get => orig.array1;
        set => orig.array1 = value;
    }

    public FsmArray array2
    {
        get => orig.array2;
        set => orig.array2 = value;
    }

    public FsmEvent SequenceEqual
    {
        get => orig.SequenceEqual;
        set => orig.SequenceEqual = value;
    }

    public FsmEvent SequenceNotEqual
    {
        get => orig.SequenceNotEqual;
        set => orig.SequenceNotEqual = value;
    }

    public FsmBool storeResult
    {
        get => orig.storeResult;
        set => orig.storeResult = value;
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

    public void DoSequenceEqual()
    {
        CallMethod();
    }
}