namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of SetPosition allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class SetPositionR:InstanceClassWrapper<HutongGames.PlayMaker.Actions.SetPosition>
{
public SetPositionR(HutongGames.PlayMaker.Actions.SetPosition _orig) : base(_orig) {}
public HutongGames.PlayMaker.FsmOwnerDefault gameObject
{
get => orig.gameObject;
set => orig.gameObject = value;
}

public HutongGames.PlayMaker.FsmVector3 vector
{
get => orig.vector;
set => orig.vector = value;
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

public UnityEngine.Space space
{
get => orig.space;
set => orig.space = value;
}

public bool everyFrame
{
get => orig.everyFrame;
set => orig.everyFrame = value;
}

public bool lateUpdate
{
get => orig.lateUpdate;
set => orig.lateUpdate = value;
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

public void OnPreprocess () =>
orig.OnPreprocess();

public void OnEnter () =>
orig.OnEnter();

public void OnUpdate () =>
orig.OnUpdate();

public void OnLateUpdate () =>
orig.OnLateUpdate();

public void DoSetPosition () =>
CallMethod();

}
}
