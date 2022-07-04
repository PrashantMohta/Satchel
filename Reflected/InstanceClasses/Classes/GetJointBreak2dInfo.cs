namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of GetJointBreak2dInfo allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class GetJointBreak2dInfoR : InstanceClassWrapper<GetJointBreak2dInfo>
{
    public GetJointBreak2dInfoR(GetJointBreak2dInfo _orig) : base(_orig)
    {
    }

    public FsmObject brokenJoint
    {
        get => orig.brokenJoint;
        set => orig.brokenJoint = value;
    }

    public FsmVector2 reactionForce
    {
        get => orig.reactionForce;
        set => orig.reactionForce = value;
    }

    public FsmFloat reactionForceMagnitude
    {
        get => orig.reactionForceMagnitude;
        set => orig.reactionForceMagnitude = value;
    }

    public FsmFloat reactionTorque
    {
        get => orig.reactionTorque;
        set => orig.reactionTorque = value;
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

    public void StoreInfo()
    {
        CallMethod();
    }

    public void OnEnter()
    {
        orig.OnEnter();
    }
}