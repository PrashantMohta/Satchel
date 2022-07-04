namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of IntTestToBool allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class IntTestToBoolR:InstanceClassWrapper<HutongGames.PlayMaker.Actions.IntTestToBool>
{
public IntTestToBoolR(HutongGames.PlayMaker.Actions.IntTestToBool _orig) : base(_orig) {}
public HutongGames.PlayMaker.FsmInt int1
{
get => orig.int1;
set => orig.int1 = value;
}

public HutongGames.PlayMaker.FsmInt int2
{
get => orig.int2;
set => orig.int2 = value;
}

public HutongGames.PlayMaker.FsmBool equalBool
{
get => orig.equalBool;
set => orig.equalBool = value;
}

public HutongGames.PlayMaker.FsmBool lessThanBool
{
get => orig.lessThanBool;
set => orig.lessThanBool = value;
}

public HutongGames.PlayMaker.FsmBool greaterThanBool
{
get => orig.greaterThanBool;
set => orig.greaterThanBool = value;
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

public void DoCompare () =>
CallMethod();

}
}
