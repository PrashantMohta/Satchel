namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of CompareDistance2D allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class CompareDistance2DR:InstanceClassWrapper<HutongGames.PlayMaker.Actions.CompareDistance2D>
{
public CompareDistance2DR(HutongGames.PlayMaker.Actions.CompareDistance2D _orig) : base(_orig) {}
public HutongGames.PlayMaker.FsmVector2 point1
{
get => orig.point1;
set => orig.point1 = value;
}

public HutongGames.PlayMaker.FsmVector2 point2
{
get => orig.point2;
set => orig.point2 = value;
}

public HutongGames.PlayMaker.FsmFloat knownDistance
{
get => orig.knownDistance;
set => orig.knownDistance = value;
}

public bool everyFrame
{
get => orig.everyFrame;
set => orig.everyFrame = value;
}

public float sqrDistanceTest
{
get => GetField<float>();
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

public void OnUpdate () =>
orig.OnUpdate();

public void DoCalcDistance () =>
CallMethod();

public void DoCompareDistance () =>
CallMethod();

}
}
