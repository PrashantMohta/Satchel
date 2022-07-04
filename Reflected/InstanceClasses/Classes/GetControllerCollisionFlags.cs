namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of GetControllerCollisionFlags allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class GetControllerCollisionFlagsR : InstanceClassWrapper<GetControllerCollisionFlags>
{
    public GetControllerCollisionFlagsR(GetControllerCollisionFlags _orig) : base(_orig)
    {
    }

    public FsmOwnerDefault gameObject
    {
        get => orig.gameObject;
        set => orig.gameObject = value;
    }

    public FsmBool isGrounded
    {
        get => orig.isGrounded;
        set => orig.isGrounded = value;
    }

    public FsmBool none
    {
        get => orig.none;
        set => orig.none = value;
    }

    public FsmBool sides
    {
        get => orig.sides;
        set => orig.sides = value;
    }

    public FsmBool above
    {
        get => orig.above;
        set => orig.above = value;
    }

    public FsmBool below
    {
        get => orig.below;
        set => orig.below = value;
    }

    public GameObject previousGo
    {
        get => GetField<GameObject>();
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

    public void OnUpdate()
    {
        orig.OnUpdate();
    }
}