namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of SmoothFollowAction allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class SmoothFollowActionR : InstanceClassWrapper<SmoothFollowAction>
{
    public SmoothFollowActionR(SmoothFollowAction _orig) : base(_orig)
    {
    }

    public FsmOwnerDefault gameObject
    {
        get => orig.gameObject;
        set => orig.gameObject = value;
    }

    public FsmGameObject targetObject
    {
        get => orig.targetObject;
        set => orig.targetObject = value;
    }

    public FsmFloat distance
    {
        get => orig.distance;
        set => orig.distance = value;
    }

    public FsmFloat height
    {
        get => orig.height;
        set => orig.height = value;
    }

    public FsmFloat heightDamping
    {
        get => orig.heightDamping;
        set => orig.heightDamping = value;
    }

    public FsmFloat rotationDamping
    {
        get => orig.rotationDamping;
        set => orig.rotationDamping = value;
    }

    public GameObject cachedObject
    {
        get => GetField<GameObject>();
        set => SetField(value);
    }

    public Transform myTransform
    {
        get => GetField<Transform>();
        set => SetField(value);
    }

    public GameObject cachedTarget
    {
        get => GetField<GameObject>();
        set => SetField(value);
    }

    public Transform targetTransform
    {
        get => GetField<Transform>();
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

    public void OnPreprocess()
    {
        orig.OnPreprocess();
    }

    public void OnLateUpdate()
    {
        orig.OnLateUpdate();
    }
}