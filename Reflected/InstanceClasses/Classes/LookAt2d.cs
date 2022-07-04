namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of LookAt2d allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class LookAt2dR:InstanceClassWrapper<HutongGames.PlayMaker.Actions.LookAt2d>
{
public LookAt2dR(HutongGames.PlayMaker.Actions.LookAt2d _orig) : base(_orig) {}
public HutongGames.PlayMaker.FsmOwnerDefault gameObject
{
get => orig.gameObject;
set => orig.gameObject = value;
}

public HutongGames.PlayMaker.FsmVector2 vector2Target
{
get => orig.vector2Target;
set => orig.vector2Target = value;
}

public HutongGames.PlayMaker.FsmVector3 vector3Target
{
get => orig.vector3Target;
set => orig.vector3Target = value;
}

public HutongGames.PlayMaker.FsmFloat rotationOffset
{
get => orig.rotationOffset;
set => orig.rotationOffset = value;
}

public HutongGames.PlayMaker.FsmBool debug
{
get => orig.debug;
set => orig.debug = value;
}

public HutongGames.PlayMaker.FsmColor debugLineColor
{
get => orig.debugLineColor;
set => orig.debugLineColor = value;
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

public void DoLookAt () =>
CallMethod();

}
}
