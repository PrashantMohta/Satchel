namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of SetAnimatorIKGoal allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class SetAnimatorIKGoalR : InstanceClassWrapper<SetAnimatorIKGoal>
{
    public SetAnimatorIKGoalR(SetAnimatorIKGoal _orig) : base(_orig)
    {
    }

    public FsmOwnerDefault gameObject
    {
        get => orig.gameObject;
        set => orig.gameObject = value;
    }

    public AvatarIKGoal iKGoal
    {
        get => orig.iKGoal;
        set => orig.iKGoal = value;
    }

    public FsmGameObject goal
    {
        get => orig.goal;
        set => orig.goal = value;
    }

    public FsmVector3 position
    {
        get => orig.position;
        set => orig.position = value;
    }

    public FsmQuaternion rotation
    {
        get => orig.rotation;
        set => orig.rotation = value;
    }

    public FsmFloat positionWeight
    {
        get => orig.positionWeight;
        set => orig.positionWeight = value;
    }

    public FsmFloat rotationWeight
    {
        get => orig.rotationWeight;
        set => orig.rotationWeight = value;
    }

    public bool everyFrame
    {
        get => orig.everyFrame;
        set => orig.everyFrame = value;
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

    public void OnEnter()
    {
        orig.OnEnter();
    }

    public void DoAnimatorIK(int layerIndex)
    {
        orig.DoAnimatorIK(layerIndex);
    }

    public void DoSetIKGoal()
    {
        CallMethod();
    }
}