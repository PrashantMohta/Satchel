namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of Vector3ClampMagnitude allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class Vector3ClampMagnitudeR : InstanceClassWrapper<Vector3ClampMagnitude>
{
    public Vector3ClampMagnitudeR(Vector3ClampMagnitude _orig) : base(_orig)
    {
    }

    public FsmVector3 vector3Variable
    {
        get => orig.vector3Variable;
        set => orig.vector3Variable = value;
    }

    public FsmFloat maxLength
    {
        get => orig.maxLength;
        set => orig.maxLength = value;
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

    public void OnEnter()
    {
        orig.OnEnter();
    }

    public void OnUpdate()
    {
        orig.OnUpdate();
    }

    public void DoVector3ClampMagnitude()
    {
        CallMethod();
    }
}