namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of Vector3Operator allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class Vector3OperatorR:InstanceClassWrapper<HutongGames.PlayMaker.Actions.Vector3Operator>
{
public Vector3OperatorR(HutongGames.PlayMaker.Actions.Vector3Operator _orig) : base(_orig) {}
public HutongGames.PlayMaker.FsmVector3 vector1
{
get => orig.vector1;
set => orig.vector1 = value;
}

public HutongGames.PlayMaker.FsmVector3 vector2
{
get => orig.vector2;
set => orig.vector2 = value;
}

public HutongGames.PlayMaker.FsmVector3 storeVector3Result
{
get => orig.storeVector3Result;
set => orig.storeVector3Result = value;
}

public HutongGames.PlayMaker.FsmFloat storeFloatResult
{
get => orig.storeFloatResult;
set => orig.storeFloatResult = value;
}

public bool everyFrame
{
get => orig.everyFrame;
set => orig.everyFrame = value;
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

public void OnUpdate () =>
orig.OnUpdate();

public void DoVector3Operator () =>
CallMethod();

}
}
