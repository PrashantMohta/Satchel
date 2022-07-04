namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of TransformInputToWorldSpace allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class TransformInputToWorldSpaceR:InstanceClassWrapper<HutongGames.PlayMaker.Actions.TransformInputToWorldSpace>
{
public TransformInputToWorldSpaceR(HutongGames.PlayMaker.Actions.TransformInputToWorldSpace _orig) : base(_orig) {}
public HutongGames.PlayMaker.FsmFloat horizontalInput
{
get => orig.horizontalInput;
set => orig.horizontalInput = value;
}

public HutongGames.PlayMaker.FsmFloat verticalInput
{
get => orig.verticalInput;
set => orig.verticalInput = value;
}

public HutongGames.PlayMaker.FsmFloat multiplier
{
get => orig.multiplier;
set => orig.multiplier = value;
}

public HutongGames.PlayMaker.FsmGameObject relativeTo
{
get => orig.relativeTo;
set => orig.relativeTo = value;
}

public HutongGames.PlayMaker.FsmVector3 storeVector
{
get => orig.storeVector;
set => orig.storeVector = value;
}

public HutongGames.PlayMaker.FsmFloat storeMagnitude
{
get => orig.storeMagnitude;
set => orig.storeMagnitude = value;
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
