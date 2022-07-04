namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of GetFsmArray allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class GetFsmArrayR : InstanceClassWrapper<GetFsmArray>
{
    public GetFsmArrayR(GetFsmArray _orig) : base(_orig)
    {
    }

    public FsmOwnerDefault gameObject
    {
        get => orig.gameObject;
        set => orig.gameObject = value;
    }

    public FsmString fsmName
    {
        get => orig.fsmName;
        set => orig.fsmName = value;
    }

    public FsmString variableName
    {
        get => orig.variableName;
        set => orig.variableName = value;
    }

    public FsmArray storeValue
    {
        get => orig.storeValue;
        set => orig.storeValue = value;
    }

    public bool copyValues
    {
        get => orig.copyValues;
        set => orig.copyValues = value;
    }

    public FsmEvent fsmNotFound
    {
        get => orig.fsmNotFound;
        set => orig.fsmNotFound = value;
    }

    public FsmEvent variableNotFound
    {
        get => orig.variableNotFound;
        set => orig.variableNotFound = value;
    }

    public PlayMakerFSM fsm
    {
        get => GetField<PlayMakerFSM>();
        set => SetField(value);
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

    public void DoSetFsmArrayCopy()
    {
        CallMethod();
    }
}