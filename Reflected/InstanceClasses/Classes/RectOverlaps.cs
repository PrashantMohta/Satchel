namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of RectOverlaps allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class RectOverlapsR:InstanceClassWrapper<HutongGames.PlayMaker.Actions.RectOverlaps>
{
public RectOverlapsR(HutongGames.PlayMaker.Actions.RectOverlaps _orig) : base(_orig) {}
public HutongGames.PlayMaker.FsmRect rect1
{
get => orig.rect1;
set => orig.rect1 = value;
}

public HutongGames.PlayMaker.FsmRect rect2
{
get => orig.rect2;
set => orig.rect2 = value;
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

public HutongGames.PlayMaker.FsmBool storeResult
{
get => orig.storeResult;
set => orig.storeResult = value;
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

public void DoRectOverlap () =>
CallMethod();

public bool Intersect (UnityEngine.Rect a, UnityEngine.Rect b) =>
HutongGames.PlayMaker.Actions.RectOverlaps.Intersect(a, b);

public void FlipNegative (ref UnityEngine.Rect r) =>
HutongGames.PlayMaker.Actions.RectOverlaps.FlipNegative(ref r);

}
}
