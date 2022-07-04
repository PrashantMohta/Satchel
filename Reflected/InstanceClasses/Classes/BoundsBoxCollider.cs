namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of BoundsBoxCollider allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class BoundsBoxColliderR : InstanceClassWrapper<BoundsBoxCollider>
{
    public BoundsBoxColliderR(BoundsBoxCollider _orig) : base(_orig)
    {
    }

    public FsmOwnerDefault gameObject1
    {
        get => orig.gameObject1;
        set => orig.gameObject1 = value;
    }

    public FsmVector2 scaleVector2
    {
        get => orig.scaleVector2;
        set => orig.scaleVector2 = value;
    }

    public FsmFloat scaleX
    {
        get => orig.scaleX;
        set => orig.scaleX = value;
    }

    public FsmFloat scaleY
    {
        get => orig.scaleY;
        set => orig.scaleY = value;
    }

    public bool everyFrame
    {
        get => orig.everyFrame;
        set => orig.everyFrame = value;
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

    public void GetEm()
    {
        orig.GetEm();
    }

    public void OnEnter()
    {
        orig.OnEnter();
    }

    public void OnUpdate()
    {
        orig.OnUpdate();
    }
}