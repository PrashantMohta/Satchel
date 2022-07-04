namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of GetMeshRendererBounds allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class GetMeshRendererBoundsR:InstanceClassWrapper<HutongGames.PlayMaker.Actions.GetMeshRendererBounds>
{
public GetMeshRendererBoundsR(HutongGames.PlayMaker.Actions.GetMeshRendererBounds _orig) : base(_orig) {}
public HutongGames.PlayMaker.FsmOwnerDefault gameObject
{
get => orig.gameObject;
set => orig.gameObject = value;
}

public HutongGames.PlayMaker.FsmFloat width
{
get => orig.width;
set => orig.width = value;
}

public HutongGames.PlayMaker.FsmFloat height
{
get => orig.height;
set => orig.height = value;
}

public HutongGames.PlayMaker.FsmFloat widthMax
{
get => orig.widthMax;
set => orig.widthMax = value;
}

public HutongGames.PlayMaker.FsmFloat heightMax
{
get => orig.heightMax;
set => orig.heightMax = value;
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

}
}
