namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of TriggerEvent allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class TriggerEventR:InstanceClassWrapper<HutongGames.PlayMaker.Actions.TriggerEvent>
{
public TriggerEventR(HutongGames.PlayMaker.Actions.TriggerEvent _orig) : base(_orig) {}
public HutongGames.PlayMaker.TriggerType trigger
{
get => orig.trigger;
set => orig.trigger = value;
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

public void StoreCollisionInfo (UnityEngine.Collider collisionInfo) =>
CallMethod(new object[] {collisionInfo});

public void DoTriggerEnter (UnityEngine.Collider other) =>
orig.DoTriggerEnter(other);

public void DoTriggerStay (UnityEngine.Collider other) =>
orig.DoTriggerStay(other);

public void DoTriggerExit (UnityEngine.Collider other) =>
orig.DoTriggerExit(other);

public string ErrorCheck () =>
orig.ErrorCheck();

}
}
