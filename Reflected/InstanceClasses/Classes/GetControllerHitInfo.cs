namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of GetControllerHitInfo allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class GetControllerHitInfoR:InstanceClassWrapper<HutongGames.PlayMaker.Actions.GetControllerHitInfo>
{
public GetControllerHitInfoR(HutongGames.PlayMaker.Actions.GetControllerHitInfo _orig) : base(_orig) {}
public HutongGames.PlayMaker.FsmGameObject gameObjectHit
{
get => orig.gameObjectHit;
set => orig.gameObjectHit = value;
}

public HutongGames.PlayMaker.FsmVector3 contactPoint
{
get => orig.contactPoint;
set => orig.contactPoint = value;
}

public HutongGames.PlayMaker.FsmVector3 contactNormal
{
get => orig.contactNormal;
set => orig.contactNormal = value;
}

public HutongGames.PlayMaker.FsmVector3 moveDirection
{
get => orig.moveDirection;
set => orig.moveDirection = value;
}

public HutongGames.PlayMaker.FsmFloat moveLength
{
get => orig.moveLength;
set => orig.moveLength = value;
}

public HutongGames.PlayMaker.FsmString physicsMaterialName
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

public void StoreTriggerInfo () =>
CallMethod();

public void OnEnter () =>
orig.OnEnter();

public string ErrorCheck () =>
orig.ErrorCheck();

}
}
