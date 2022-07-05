namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of GetCollision2dInfo allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class GetCollision2dInfoR : InstanceClassWrapper<GetCollision2dInfo>
{
    public GetCollision2dInfoR(GetCollision2dInfo _orig) : base(_orig)
    {
    }

    public FsmGameObject gameObjectHit
    {
        get => orig.gameObjectHit;
        set => orig.gameObjectHit = value;
    }

    public FsmVector3 relativeVelocity
    {
        get => orig.relativeVelocity;
        set => orig.relativeVelocity = value;
    }

    public FsmFloat relativeSpeed
    {
        get => orig.relativeSpeed;
        set => orig.relativeSpeed = value;
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

    public FsmInt shapeCount
    {
        get => orig.shapeCount;
        set => orig.shapeCount = value;
    }

    public FsmString physics2dMaterialName
    {
        get => orig.physics2dMaterialName;
        set => orig.physics2dMaterialName = value;
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

    public void StoreCollisionInfo()
    {
        CallMethod();
    }

    public void OnEnter()
    {
        orig.OnEnter();
    }
}