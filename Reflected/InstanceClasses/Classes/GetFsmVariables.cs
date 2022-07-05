namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of GetFsmVariables allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class GetFsmVariablesR : InstanceClassWrapper<GetFsmVariables>
{
    public GetFsmVariablesR(GetFsmVariables _orig) : base(_orig)
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

    public FsmVar[] getVariables
    {
        get => orig.getVariables;
        set => orig.getVariables = value;
    }

    public bool everyFrame
    {
        get => orig.everyFrame;
        set => orig.everyFrame = value;
    }

    public GameObject cachedGO
    {
        get => GetField<GameObject>();
        set => SetField(value);
    }

    public PlayMakerFSM sourceFsm
    {
        get => GetField<PlayMakerFSM>();
        set => SetField(value);
    }

    public INamedVariable[] sourceVariables
    {
        get => GetField<INamedVariable[]>();
        set => SetField(value);
    }

    public NamedVariable[] targetVariables
    {
        get => GetField<NamedVariable[]>();
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

    public void InitFsmVars()
    {
        CallMethod();
    }

    public void OnEnter()
    {
        orig.OnEnter();
    }

    public void OnUpdate()
    {
        orig.OnUpdate();
    }

    public void DoGetFsmVariables()
    {
        CallMethod();
    }
}