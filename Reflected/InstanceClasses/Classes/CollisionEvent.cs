namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of CollisionEvent allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class CollisionEventR:InstanceClassWrapper<HutongGames.PlayMaker.Actions.CollisionEvent>
{
public CollisionEventR(HutongGames.PlayMaker.Actions.CollisionEvent _orig) : base(_orig) {}
public HutongGames.PlayMaker.CollisionType collision
{
get => orig.collision;
set => orig.collision = value;
}

public HutongGames.PlayMaker.FsmString collideTag
{
get => orig.collideTag;
set => orig.collideTag = value;
}

public HutongGames.PlayMaker.FsmEvent sendEvent
{
get => orig.sendEvent;
set => orig.sendEvent = value;
}

public HutongGames.PlayMaker.FsmGameObject storeCollider
{
get => orig.storeCollider;
set => orig.storeCollider = value;
}

public HutongGames.PlayMaker.FsmFloat storeForce
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

public HutongGames.PlayMaker.Fsm Fsm
{
get => orig.Fsm;
set => orig.Fsm = value;
}

public UnityEngine.GameObject Owner
{
get => orig.Owner;
set => orig.Owner = value;
}

public HutongGames.PlayMaker.FsmState State
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

public void Reset () =>
orig.Reset();

public void OnPreprocess () =>
orig.OnPreprocess();

public void StoreCollisionInfo (UnityEngine.Collision collisionInfo) =>
CallMethod(new object[] {collisionInfo});

public void DoCollisionEnter (UnityEngine.Collision collisionInfo) =>
orig.DoCollisionEnter(collisionInfo);

public void DoCollisionStay (UnityEngine.Collision collisionInfo) =>
orig.DoCollisionStay(collisionInfo);

public void DoCollisionExit (UnityEngine.Collision collisionInfo) =>
orig.DoCollisionExit(collisionInfo);

public void DoControllerColliderHit (UnityEngine.ControllerColliderHit collisionInfo) =>
orig.DoControllerColliderHit(collisionInfo);

public void DoParticleCollision (UnityEngine.GameObject other) =>
orig.DoParticleCollision(other);

public string ErrorCheck () =>
orig.ErrorCheck();

}
}
