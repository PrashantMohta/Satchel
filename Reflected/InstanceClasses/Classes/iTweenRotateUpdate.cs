namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of iTweenRotateUpdate allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class iTweenRotateUpdateR : InstanceClassWrapper<iTweenRotateUpdate>
{
    public iTweenRotateUpdateR(iTweenRotateUpdate _orig) : base(_orig)
    {
    }

    public FsmOwnerDefault gameObject
    {
        get => orig.gameObject;
        set => orig.gameObject = value;
    }

    public FsmGameObject transformRotation
    {
        get => orig.transformRotation;
        set => orig.transformRotation = value;
    }

    public FsmVector3 vectorRotation
    {
        get => orig.vectorRotation;
        set => orig.vectorRotation = value;
    }

    public FsmFloat time
    {
        get => orig.time;
        set => orig.time = value;
    }

    public Space space
    {
        get => orig.space;
        set => orig.space = value;
    }

    public Hashtable hash
    {
        get => GetField<Hashtable>();
        set => SetField(value);
    }

    public GameObject go
    {
        get => GetField<GameObject>();
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

    public void OnExit()
    {
        orig.OnExit();
    }

    public void OnUpdate()
    {
        orig.OnUpdate();
    }

    public void DoiTween()
    {
        CallMethod();
    }
}