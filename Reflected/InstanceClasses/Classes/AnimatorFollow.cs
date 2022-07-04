namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of AnimatorFollow allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class AnimatorFollowR : InstanceClassWrapper<AnimatorFollow>
{
    public AnimatorFollowR(AnimatorFollow _orig) : base(_orig)
    {
    }

    public FsmOwnerDefault gameObject
    {
        get => orig.gameObject;
        set => orig.gameObject = value;
    }

    public FsmGameObject target
    {
        get => orig.target;
        set => orig.target = value;
    }

    public FsmFloat minimumDistance
    {
        get => orig.minimumDistance;
        set => orig.minimumDistance = value;
    }

    public FsmFloat speedDampTime
    {
        get => orig.speedDampTime;
        set => orig.speedDampTime = value;
    }

    public FsmFloat directionDampTime
    {
        get => orig.directionDampTime;
        set => orig.directionDampTime = value;
    }

    public GameObject _go
    {
        get => GetField<GameObject>();
        set => SetField(value);
    }

    public PlayMakerAnimatorMoveProxy _animatorProxy
    {
        get => GetField<PlayMakerAnimatorMoveProxy>();
        set => SetField(value);
    }

    public Animator avatar
    {
        get => GetField<Animator>();
        set => SetField(value);
    }

    public CharacterController controller
    {
        get => GetField<CharacterController>();
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

    public void OnUpdate()
    {
        orig.OnUpdate();
    }

    public void OnExit()
    {
        orig.OnExit();
    }

    public void OnAnimatorMoveEvent()
    {
        orig.OnAnimatorMoveEvent();
    }
}