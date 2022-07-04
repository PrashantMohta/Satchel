namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of FloatInRange allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class FloatInRangeR:InstanceClassWrapper<HutongGames.PlayMaker.Actions.FloatInRange>
{
public FloatInRangeR(HutongGames.PlayMaker.Actions.FloatInRange _orig) : base(_orig) {}
public HutongGames.PlayMaker.FsmFloat floatVariable
{
get => orig.floatVariable;
set => orig.floatVariable = value;
}

public HutongGames.PlayMaker.FsmFloat lowerValue
{
get => orig.lowerValue;
set => orig.lowerValue = value;
}

public HutongGames.PlayMaker.FsmFloat upperValue
{
get => orig.upperValue;
set => orig.upperValue = value;
}

public HutongGames.PlayMaker.FsmBool boolVariable
{
get => orig.boolVariable;
set => orig.boolVariable = value;
}

public HutongGames.PlayMaker.FsmEvent trueEvent
{
get => orig.trueEvent;
set => orig.trueEvent = value;
}

public HutongGames.PlayMaker.FsmEvent falseEvent
{
get => orig.falseEvent;
set => orig.falseEvent = value;
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

public void DoFloatRange () =>
CallMethod();

}
}
