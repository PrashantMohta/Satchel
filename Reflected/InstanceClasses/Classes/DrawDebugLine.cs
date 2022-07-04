namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of DrawDebugLine allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class DrawDebugLineR:InstanceClassWrapper<HutongGames.PlayMaker.Actions.DrawDebugLine>
{
public DrawDebugLineR(HutongGames.PlayMaker.Actions.DrawDebugLine _orig) : base(_orig) {}
public HutongGames.PlayMaker.FsmGameObject fromObject
{
get => orig.fromObject;
set => orig.fromObject = value;
}

public HutongGames.PlayMaker.FsmVector3 fromPosition
{
get => orig.fromPosition;
set => orig.fromPosition = value;
}

public HutongGames.PlayMaker.FsmGameObject toObject
{
get => orig.toObject;
set => orig.toObject = value;
}

public HutongGames.PlayMaker.FsmVector3 toPosition
{
get => orig.toPosition;
set => orig.toPosition = value;
}

public HutongGames.PlayMaker.FsmColor color
{
get => orig.color;
set => orig.color = value;
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
