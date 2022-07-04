namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of CollisionEvent allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class CollisionEventR : InstanceClassWrapper<CollisionEvent>
{
    public CollisionEventR(CollisionEvent _orig) : base(_orig)
    {
    }

    public CollisionType collision
    {
        get => orig.collision;
        set => orig.collision = value;
    }

    public FsmString collideTag
    {
        get => orig.collideTag;
        set => orig.collideTag = value;
    }

    public FsmEvent sendEvent
    {
        get => orig.sendEvent;
        set => orig.sendEvent = value;
    }

    public FsmGameObject storeCollider
    {
        get => orig.storeCollider;
        set => orig.storeCollider = value;
    }

    public FsmFloat storeForce
    {
        get => orig.storeForce;
        set => orig.storeForce = value;
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

    public void StoreCollisionInfo(Collision collisionInfo)
    {
        CallMethod(new object[] { collisionInfo });
    }

    public void DoCollisionEnter(Collision collisionInfo)
    {
        orig.DoCollisionEnter(collisionInfo);
    }

    public void DoCollisionStay(Collision collisionInfo)
    {
        orig.DoCollisionStay(collisionInfo);
    }

    public void DoCollisionExit(Collision collisionInfo)
    {
        orig.DoCollisionExit(collisionInfo);
    }

    public void DoControllerColliderHit(ControllerColliderHit collisionInfo)
    {
        orig.DoControllerColliderHit(collisionInfo);
    }

    public void DoParticleCollision(GameObject other)
    {
        orig.DoParticleCollision(other);
    }

    public string ErrorCheck()
    {
        return orig.ErrorCheck();
    }
}