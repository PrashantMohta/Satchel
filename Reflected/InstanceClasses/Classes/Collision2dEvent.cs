namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of Collision2dEvent allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class Collision2dEventR:InstanceClassWrapper<HutongGames.PlayMaker.Actions.Collision2dEvent>
{
public Collision2dEventR(HutongGames.PlayMaker.Actions.Collision2dEvent _orig) : base(_orig) {}
public HutongGames.PlayMaker.Collision2DType collision
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

public void StoreCollisionInfo (UnityEngine.Collision2D collisionInfo) =>
CallMethod(new object[] {collisionInfo});

public void DoCollisionEnter2D (UnityEngine.Collision2D collisionInfo) =>
orig.DoCollisionEnter2D(collisionInfo);

public void DoCollisionStay2D (UnityEngine.Collision2D collisionInfo) =>
orig.DoCollisionStay2D(collisionInfo);

public void DoCollisionExit2D (UnityEngine.Collision2D collisionInfo) =>
orig.DoCollisionExit2D(collisionInfo);

public void DoParticleCollision (UnityEngine.GameObject other) =>
orig.DoParticleCollision(other);

public string ErrorCheck () =>
orig.ErrorCheck();

}
}
