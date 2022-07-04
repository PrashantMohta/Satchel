namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of GetControllerHitInfo allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class GetControllerHitInfoR : InstanceClassWrapper<GetControllerHitInfo>
{
    public GetControllerHitInfoR(GetControllerHitInfo _orig) : base(_orig)
    {
    }

    public FsmGameObject gameObjectHit
    {
        get => orig.gameObjectHit;
        set => orig.gameObjectHit = value;
    }

    public FsmVector3 contactPoint
    {
        get => orig.contactPoint;
        set => orig.contactPoint = value;
    }

    public FsmVector3 contactNormal
    {
        get => orig.contactNormal;
        set => orig.contactNormal = value;
    }

    public FsmVector3 moveDirection
    {
        get => orig.moveDirection;
        set => orig.moveDirection = value;
    }

    public FsmFloat moveLength
    {
        get => orig.moveLength;
        set => orig.moveLength = value;
    }

    public FsmString physicsMaterialName
    {
        get => orig.physicsMaterialName;
        set => orig.physicsMaterialName = value;
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

    public void StoreTriggerInfo()
    {
        CallMethod();
    }

    public void OnEnter()
    {
        orig.OnEnter();
    }

    public string ErrorCheck()
    {
        return orig.ErrorCheck();
    }
}