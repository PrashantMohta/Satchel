namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of FloatAddV2 allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class FloatAddV2R : InstanceClassWrapper<FloatAddV2>
{
    public FloatAddV2R(FloatAddV2 _orig) : base(_orig)
    {
    }

    public FsmFloat floatVariable
    {
        get => orig.floatVariable;
        set => orig.floatVariable = value;
    }

    public FsmFloat add
    {
        get => orig.add;
        set => orig.add = value;
    }

    public bool everyFrame
    {
        get => orig.everyFrame;
        set => orig.everyFrame = value;
    }

    public bool perSecond
    {
        get => orig.perSecond;
        set => orig.perSecond = value;
    }

    public bool fixedUpdate
    {
        get => orig.fixedUpdate;
        set => orig.fixedUpdate = value;
    }

    public FsmBool activeBool
    {
        get => orig.activeBool;
        set => orig.activeBool = value;
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

    public void Awake()
    {
        orig.Awake();
    }

    public void OnPreprocess()
    {
        orig.OnPreprocess();
    }

    public void OnEnter()
    {
        orig.OnEnter();
    }

    public void OnUpdate()
    {
        orig.OnUpdate();
    }

    public void OnFixedUpdate()
    {
        orig.OnFixedUpdate();
    }

    public void DoFloatAdd()
    {
        CallMethod();
    }
}