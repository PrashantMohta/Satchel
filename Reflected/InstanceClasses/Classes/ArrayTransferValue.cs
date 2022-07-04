namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of ArrayTransferValue allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class ArrayTransferValueR : InstanceClassWrapper<ArrayTransferValue>
{
    public ArrayTransferValueR(ArrayTransferValue _orig) : base(_orig)
    {
    }

    public FsmArray arraySource
    {
        get => orig.arraySource;
        set => orig.arraySource = value;
    }

    public FsmArray arrayTarget
    {
        get => orig.arrayTarget;
        set => orig.arrayTarget = value;
    }

    public FsmInt indexToTransfer
    {
        get => orig.indexToTransfer;
        set => orig.indexToTransfer = value;
    }

    public FsmEnum copyType
    {
        get => orig.copyType;
        set => orig.copyType = value;
    }

    public FsmEnum pasteType
    {
        get => orig.pasteType;
        set => orig.pasteType = value;
    }

    public FsmEvent indexOutOfRange
    {
        get => orig.indexOutOfRange;
        set => orig.indexOutOfRange = value;
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

    public void DoTransferValue()
    {
        CallMethod();
    }
}