namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of AddTorque allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class AddTorqueR : InstanceClassWrapper<AddTorque>
{
    public AddTorqueR(AddTorque _orig) : base(_orig)
    {
    }

    public FsmOwnerDefault gameObject
    {
        get => orig.gameObject;
        set => orig.gameObject = value;
    }

    public FsmVector3 vector
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

    public FsmFloat z
    {
        get => orig.z;
        set => orig.z = value;
    }

    public Space space
    {
        get => orig.space;
        set => orig.space = value;
    }

    public ForceMode forceMode
    {
        get => orig.forceMode;
        set => orig.forceMode = value;
    }

    public bool everyFrame
    {
        get => orig.everyFrame;
        set => orig.everyFrame = value;
    }

    public Rigidbody rigidbody => GetProperty<Rigidbody>();

    public Rigidbody2D rigidbody2d => GetProperty<Rigidbody2D>();

    public Renderer renderer => GetProperty<Renderer>();

    public UnityEngine.Animation animation => GetProperty<UnityEngine.Animation>();

    public AudioSource audio => GetProperty<AudioSource>();

    public Camera camera => GetProperty<Camera>();

    public Light light => GetProperty<Light>();

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

    public void DoAddTorque()
    {
        CallMethod();
    }
}