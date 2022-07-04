namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of SendTrigger2DEvent allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class SendTrigger2DEventR:InstanceClassWrapper<HutongGames.PlayMaker.Actions.SendTrigger2DEvent>
{
public SendTrigger2DEventR(HutongGames.PlayMaker.Actions.SendTrigger2DEvent _orig) : base(_orig) {}
public HutongGames.PlayMaker.FsmEventTarget eventTarget
{
get => orig.eventTarget;
set => orig.eventTarget = value;
}

public HutongGames.PlayMaker.FsmString collideTag
{
get => orig.collideTag;
set => orig.collideTag = value;
}

public HutongGames.PlayMaker.FsmInt collideLayer
{
get => orig.collideLayer;
set => orig.collideLayer = value;
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

public PlayMakerUnity2DProxy _proxy
{
get => GetField<PlayMakerUnity2DProxy>();
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

public void OnEnter () =>
orig.OnEnter();

public void OnExit () =>
orig.OnExit();

public void StoreCollisionInfo (UnityEngine.Collider2D collisionInfo) =>
CallMethod(new object[] {collisionInfo});

public void DoTriggerEnter2D (UnityEngine.Collider2D collisionInfo) =>
orig.DoTriggerEnter2D(collisionInfo);

public void DoTriggerStay2D (UnityEngine.Collider2D collisionInfo) =>
orig.DoTriggerStay2D(collisionInfo);

public void DoTriggerExit2D (UnityEngine.Collider2D collisionInfo) =>
orig.DoTriggerExit2D(collisionInfo);

public string ErrorCheck () =>
orig.ErrorCheck();

}
}
