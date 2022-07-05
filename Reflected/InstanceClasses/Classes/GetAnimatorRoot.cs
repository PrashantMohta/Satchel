namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of GetAnimatorRoot allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class GetAnimatorRootR : InstanceClassWrapper<GetAnimatorRoot>
{
    public GetAnimatorRootR(GetAnimatorRoot _orig) : base(_orig)
    {
    }

    public FsmOwnerDefault gameObject
    {
        get => orig.gameObject;
        set => orig.gameObject = value;
    }

    public FsmVector3 rootPosition
    {
        get => orig.rootPosition;
        set => orig.rootPosition = value;
    }

    public FsmQuaternion rootRotation
    {
        get => orig.rootRotation;
        set => orig.rootRotation = value;
    }

    public FsmGameObject bodyGameObject
    {
        get => orig.bodyGameObject;
        set => orig.bodyGameObject = value;
    }

    public Animator _animator
    {
        get => GetField<Animator>();
        set => SetField(value);
    }

    public Transform _transform
    {
        get => GetField<Transform>();
        set => SetField(value);
    }

    public bool everyFrame
    {
        get => orig.everyFrame;
        set => orig.everyFrame = value;
    }

    public int IklayerIndex
    {
        get => GetField<int>();
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

    public void OnActionUpdate()
    {
        orig.OnActionUpdate();
    }

    public void DoGetBodyPosition()
    {
        CallMethod();
    }
}