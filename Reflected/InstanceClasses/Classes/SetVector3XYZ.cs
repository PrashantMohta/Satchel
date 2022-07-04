namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of SetVector3XYZ allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class SetVector3XYZR:InstanceClassWrapper<HutongGames.PlayMaker.Actions.SetVector3XYZ>
{
public SetVector3XYZR(HutongGames.PlayMaker.Actions.SetVector3XYZ _orig) : base(_orig) {}
public HutongGames.PlayMaker.FsmVector3 vector3Variable
{
get => orig.vector3Variable;
set => orig.vector3Variable = value;
}

public HutongGames.PlayMaker.FsmVector3 vector3Value
{
get => orig.vector3Value;
set => orig.vector3Value = value;
}

public HutongGames.PlayMaker.FsmFloat x
{
get => orig.x;
set => orig.x = value;
}

public HutongGames.PlayMaker.FsmFloat y
{
get => orig.y;
set => orig.y = value;
}

public HutongGames.PlayMaker.FsmFloat z
{
get => orig.z;
set => orig.z = value;
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

public void DoSetVector3XYZ () =>
CallMethod();

}
}
