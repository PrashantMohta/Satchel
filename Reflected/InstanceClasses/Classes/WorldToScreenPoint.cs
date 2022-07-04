namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of WorldToScreenPoint allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class WorldToScreenPointR:InstanceClassWrapper<HutongGames.PlayMaker.Actions.WorldToScreenPoint>
{
public WorldToScreenPointR(HutongGames.PlayMaker.Actions.WorldToScreenPoint _orig) : base(_orig) {}
public HutongGames.PlayMaker.FsmVector3 worldPosition
{
get => orig.worldPosition;
set => orig.worldPosition = value;
}

public HutongGames.PlayMaker.FsmFloat worldX
{
get => orig.worldX;
set => orig.worldX = value;
}

public HutongGames.PlayMaker.FsmFloat worldY
{
get => orig.worldY;
set => orig.worldY = value;
}

public HutongGames.PlayMaker.FsmFloat worldZ
{
get => orig.worldZ;
set => orig.worldZ = value;
}

public HutongGames.PlayMaker.FsmVector3 storeScreenPoint
{
get => orig.storeScreenPoint;
set => orig.storeScreenPoint = value;
}

public HutongGames.PlayMaker.FsmFloat storeScreenX
{
get => orig.storeScreenX;
set => orig.storeScreenX = value;
}

public HutongGames.PlayMaker.FsmFloat storeScreenY
{
get => orig.storeScreenY;
set => orig.storeScreenY = value;
}

public HutongGames.PlayMaker.FsmBool normalize
{
get => orig.normalize;
set => orig.normalize = value;
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

public void DoWorldToScreenPoint () =>
CallMethod();

}
}
