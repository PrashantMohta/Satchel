namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of AddForce2dV2 allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class AddForce2dV2R : InstanceClassWrapper<AddForce2dV2>
{
    public AddForce2dV2R(AddForce2dV2 _orig) : base(_orig)
    {
    }

    public FsmOwnerDefault gameObject
    {
        get => orig.gameObject;
        set => orig.gameObject = value;
    }

    public FsmVector2 atPosition
    {
        get => orig.atPosition;
        set => orig.atPosition = value;
    }

    public FsmVector2 vector
    {
        get => orig.vector;
        set => orig.vector = value;
    }

    public FsmFloat x
    {
        get => orig.x;
        set => orig.x = value;
    }

    public FsmFloat y
    {
        get => orig.y;
        set => orig.y = value;
    }

    public FsmVector3 vector3
    {
        get => orig.vector3;
        set => orig.vector3 = value;
    }

    public FsmFloat maxSpeed
    {
        get => orig.maxSpeed;
        set => orig.maxSpeed = value;
    }

    public FsmFloat maxSpeedX
    {
        get => orig.maxSpeedX;
        set => orig.maxSpeedX = value;
    }

    public FsmFloat maxSpeedY
    {
        get => orig.maxSpeedY;
        set => orig.maxSpeedY = value;
    }

    public bool everyFrame
    {
        get => orig.everyFrame;
        set => orig.everyFrame = value;
    }

    public Rigidbody2D rb2d
    {
        get => GetField<Rigidbody2D>();
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

    public void OnFixedUpdate()
    {
        orig.OnFixedUpdate();
    }

    public void DoAddForce()
    {
        CallMethod();
    }
}