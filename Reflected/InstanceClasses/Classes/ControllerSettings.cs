namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of ControllerSettings allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class ControllerSettingsR : InstanceClassWrapper<ControllerSettings>
{
    public ControllerSettingsR(ControllerSettings _orig) : base(_orig)
    {
    }

    public FsmOwnerDefault gameObject
    {
        get => orig.gameObject;
        set => orig.gameObject = value;
    }

    public FsmFloat height
    {
        get => orig.height;
        set => orig.height = value;
    }

    public FsmFloat radius
    {
        get => orig.radius;
        set => orig.radius = value;
    }

    public FsmFloat slopeLimit
    {
        get => orig.slopeLimit;
        set => orig.slopeLimit = value;
    }

    public FsmFloat stepOffset
    {
        get => orig.stepOffset;
        set => orig.stepOffset = value;
    }

    public FsmVector3 center
    {
        get => orig.center;
        set => orig.center = value;
    }

    public FsmBool detectCollisions
    {
        get => orig.detectCollisions;
        set => orig.detectCollisions = value;
    }

    public bool everyFrame
    {
        get => orig.everyFrame;
        set => orig.everyFrame = value;
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

    public void OnEnter()
    {
        orig.OnEnter();
    }

    public void OnUpdate()
    {
        orig.OnUpdate();
    }

    public void DoControllerSettings()
    {
        CallMethod();
    }
}