namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of MousePick2dEvent allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class MousePick2dEventR:InstanceClassWrapper<HutongGames.PlayMaker.Actions.MousePick2dEvent>
{
public MousePick2dEventR(HutongGames.PlayMaker.Actions.MousePick2dEvent _orig) : base(_orig) {}
public HutongGames.PlayMaker.FsmOwnerDefault GameObject
{
get => orig.GameObject;
set => orig.GameObject = value;
}

public HutongGames.PlayMaker.FsmEvent mouseOver
{
get => orig.mouseOver;
set => orig.mouseOver = value;
}

public HutongGames.PlayMaker.FsmEvent mouseDown
{
get => orig.mouseDown;
set => orig.mouseDown = value;
}

public HutongGames.PlayMaker.FsmEvent mouseUp
{
get => orig.mouseUp;
set => orig.mouseUp = value;
}

public HutongGames.PlayMaker.FsmEvent mouseOff
{
get => orig.mouseOff;
set => orig.mouseOff = value;
}

public HutongGames.PlayMaker.FsmInt[] layerMask
{
get => orig.layerMask;
set => orig.layerMask = value;
}

public HutongGames.PlayMaker.FsmBool invertMask
{
get => orig.invertMask;
set => orig.invertMask = value;
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

public void DoMousePickEvent () =>
CallMethod();

public bool DoRaycast () =>
CallMethod<bool>();

}
}
