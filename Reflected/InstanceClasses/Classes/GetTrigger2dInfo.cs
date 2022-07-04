namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of GetTrigger2dInfo allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class GetTrigger2dInfoR:InstanceClassWrapper<HutongGames.PlayMaker.Actions.GetTrigger2dInfo>
{
public GetTrigger2dInfoR(HutongGames.PlayMaker.Actions.GetTrigger2dInfo _orig) : base(_orig) {}
public HutongGames.PlayMaker.FsmGameObject gameObjectHit
{
get => orig.gameObjectHit;
set => orig.gameObjectHit = value;
}

public HutongGames.PlayMaker.FsmInt shapeCount
{
get => orig.shapeCount;
set => orig.shapeCount = value;
}

public HutongGames.PlayMaker.FsmString physics2dMaterialName
{
get => orig.physics2dMaterialName;
set => orig.physics2dMaterialName = value;
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

public void StoreTriggerInfo () =>
CallMethod();

public void OnEnter () =>
orig.OnEnter();

}
}
