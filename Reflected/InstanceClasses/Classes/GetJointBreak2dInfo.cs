namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of GetJointBreak2dInfo allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class GetJointBreak2dInfoR:InstanceClassWrapper<HutongGames.PlayMaker.Actions.GetJointBreak2dInfo>
{
public GetJointBreak2dInfoR(HutongGames.PlayMaker.Actions.GetJointBreak2dInfo _orig) : base(_orig) {}
public HutongGames.PlayMaker.FsmObject brokenJoint
{
get => orig.brokenJoint;
set => orig.brokenJoint = value;
}

public HutongGames.PlayMaker.FsmVector2 reactionForce
{
get => orig.reactionForce;
set => orig.reactionForce = value;
}

public HutongGames.PlayMaker.FsmFloat reactionForceMagnitude
{
get => orig.reactionForceMagnitude;
set => orig.reactionForceMagnitude = value;
}

public HutongGames.PlayMaker.FsmFloat reactionTorque
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

public void StoreInfo () =>
CallMethod();

public void OnEnter () =>
orig.OnEnter();

}
}
