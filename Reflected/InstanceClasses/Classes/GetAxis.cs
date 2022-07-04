namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of GetAxis allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class GetAxisR:InstanceClassWrapper<HutongGames.PlayMaker.Actions.GetAxis>
{
public GetAxisR(HutongGames.PlayMaker.Actions.GetAxis _orig) : base(_orig) {}
public HutongGames.PlayMaker.FsmString axisName
{
get => orig.axisName;
set => orig.axisName = value;
}

public HutongGames.PlayMaker.FsmFloat multiplier
{
get => orig.multiplier;
set => orig.multiplier = value;
}

public HutongGames.PlayMaker.FsmFloat store
{
get => orig.store;
set => orig.store = value;
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

public void DoGetAxis () =>
CallMethod();

}
}
