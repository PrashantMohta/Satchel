namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of GetDeviceAcceleration allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class GetDeviceAccelerationR:InstanceClassWrapper<HutongGames.PlayMaker.Actions.GetDeviceAcceleration>
{
public GetDeviceAccelerationR(HutongGames.PlayMaker.Actions.GetDeviceAcceleration _orig) : base(_orig) {}
public HutongGames.PlayMaker.FsmVector3 storeVector
{
get => orig.storeVector;
set => orig.storeVector = value;
}

public HutongGames.PlayMaker.FsmFloat storeX
{
get => orig.storeX;
set => orig.storeX = value;
}

public HutongGames.PlayMaker.FsmFloat storeY
{
get => orig.storeY;
set => orig.storeY = value;
}

public HutongGames.PlayMaker.FsmFloat storeZ
{
get => orig.storeZ;
set => orig.storeZ = value;
}

public HutongGames.PlayMaker.FsmFloat multiplier
{
get => orig.multiplier;
set => orig.multiplier = value;
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

public void DoGetDeviceAcceleration () =>
CallMethod();

}
}
