namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of ArrayForEach allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class ArrayForEachR : InstanceClassWrapper<ArrayForEach>
{
    public ArrayForEachR(ArrayForEach _orig) : base(_orig)
    {
    }

    public FsmArray array
    {
        get => orig.array;
        set => orig.array = value;
    }

    public FsmVar storeItem
    {
        get => orig.storeItem;
        set => orig.storeItem = value;
    }

    public FsmTemplateControl fsmTemplateControl
    {
        get => orig.fsmTemplateControl;
        set => orig.fsmTemplateControl = value;
    }

    public FsmEvent finishEvent
    {
        get => orig.finishEvent;
        set => orig.finishEvent = value;
    }

    public int currentIndex
    {
        get => GetField<int>();
        set => SetField(value);
    }

    public Fsm runFsm
    {
        get => GetField<Fsm>();
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

    public void OnLateUpdate()
    {
        orig.OnLateUpdate();
    }

    public void StartNextFsm()
    {
        CallMethod();
    }

    public void StartFsm()
    {
        CallMethod();
    }

    public void DoStartFsm()
    {
        CallMethod();
    }

    public void CheckIfFinished()
    {
        CallMethod();
    }
}