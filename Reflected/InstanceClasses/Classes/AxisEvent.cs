namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of AxisEvent allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class AxisEventR:InstanceClassWrapper<HutongGames.PlayMaker.Actions.AxisEvent>
{
public AxisEventR(HutongGames.PlayMaker.Actions.AxisEvent _orig) : base(_orig) {}
public HutongGames.PlayMaker.FsmString horizontalAxis
{
get => orig.horizontalAxis;
set => orig.horizontalAxis = value;
}

public HutongGames.PlayMaker.FsmString verticalAxis
{
get => orig.verticalAxis;
set => orig.verticalAxis = value;
}

public HutongGames.PlayMaker.FsmEvent leftEvent
{
get => orig.leftEvent;
set => orig.leftEvent = value;
}

public HutongGames.PlayMaker.FsmEvent rightEvent
{
get => orig.rightEvent;
set => orig.rightEvent = value;
}

public HutongGames.PlayMaker.FsmEvent upEvent
{
get => orig.upEvent;
set => orig.upEvent = value;
}

public HutongGames.PlayMaker.FsmEvent downEvent
{
get => orig.downEvent;
set => orig.downEvent = value;
}

public HutongGames.PlayMaker.FsmEvent anyDirection
{
get => orig.anyDirection;
set => orig.anyDirection = value;
}

public HutongGames.PlayMaker.FsmEvent noDirection
{
get => orig.noDirection;
set => orig.noDirection = value;
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

public void OnUpdate () =>
orig.OnUpdate();

}
}
