namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of InvokeMethod allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class InvokeMethodR : InstanceClassWrapper<InvokeMethod>
{
    public InvokeMethodR(InvokeMethod _orig) : base(_orig)
    {
    }

    public FsmOwnerDefault gameObject
    {
        get => orig.gameObject;
        set => orig.gameObject = value;
    }

    public FsmString behaviour
    {
        get => orig.behaviour;
        set => orig.behaviour = value;
    }

    public FsmString methodName
    {
        get => orig.methodName;
        set => orig.methodName = value;
    }

    public FsmFloat delay
    {
        get => orig.delay;
        set => orig.delay = value;
    }

    public FsmBool repeating
    {
        get => orig.repeating;
        set => orig.repeating = value;
    }

    public FsmFloat repeatDelay
    {
        get => orig.repeatDelay;
        set => orig.repeatDelay = value;
    }

    public FsmBool cancelOnExit
    {
        get => orig.cancelOnExit;
        set => orig.cancelOnExit = value;
    }

    public MonoBehaviour component
    {
        get => GetField<MonoBehaviour>();
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

    public void DoInvokeMethod(GameObject go)
    {
        CallMethod(new object[] { go });
    }

    public void OnExit()
    {
        orig.OnExit();
    }
}