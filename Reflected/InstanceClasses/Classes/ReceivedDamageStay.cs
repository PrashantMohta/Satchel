namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of ReceivedDamageStay allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class ReceivedDamageStayR:InstanceClassWrapper<HutongGames.PlayMaker.Actions.ReceivedDamageStay>
{
public ReceivedDamageStayR(HutongGames.PlayMaker.Actions.ReceivedDamageStay _orig) : base(_orig) {}
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

public HutongGames.PlayMaker.FsmString fsmName
{
get => orig.fsmName;
set => orig.fsmName = value;
}

public HutongGames.PlayMaker.FsmGameObject storeGameObject
{
get => orig.storeGameObject;
set => orig.storeGameObject = value;
}

public HutongGames.PlayMaker.FsmBool ignoreAcid
{
get => orig.ignoreAcid;
set => orig.ignoreAcid = value;
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

public void DoCollisionEnter2D (UnityEngine.Collision2D collisionInfo) =>
orig.DoCollisionEnter2D(collisionInfo);

public void DoCollisionStay2D (UnityEngine.Collision2D collisionInfo) =>
orig.DoCollisionStay2D(collisionInfo);

public void DoTriggerEnter2D (UnityEngine.Collider2D collisionInfo) =>
orig.DoTriggerEnter2D(collisionInfo);

public void DoTriggerStay2D (UnityEngine.Collider2D collisionInfo) =>
orig.DoTriggerStay2D(collisionInfo);

public void StoreCollisionInfo (UnityEngine.Collision2D collisionInfo) =>
CallMethod(new object[] {collisionInfo});

public void StoreCollisionInfo (UnityEngine.Collider2D collisionInfo) =>
CallMethod(new object[] {collisionInfo});

public void StoreIfDamagingObject (UnityEngine.GameObject go) =>
CallMethod(new object[] {go});

public string ErrorCheck () =>
orig.ErrorCheck();

}
}
