namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of ScreenPick allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class ScreenPickR:InstanceClassWrapper<HutongGames.PlayMaker.Actions.ScreenPick>
{
public ScreenPickR(HutongGames.PlayMaker.Actions.ScreenPick _orig) : base(_orig) {}
public HutongGames.PlayMaker.FsmVector3 screenVector
{
get => orig.screenVector;
set => orig.screenVector = value;
}

public HutongGames.PlayMaker.FsmFloat screenX
{
get => orig.screenX;
set => orig.screenX = value;
}

public HutongGames.PlayMaker.FsmFloat screenY
{
get => orig.screenY;
set => orig.screenY = value;
}

public HutongGames.PlayMaker.FsmBool normalized
{
get => orig.normalized;
set => orig.normalized = value;
}

public HutongGames.PlayMaker.FsmFloat rayDistance
{
get => orig.rayDistance;
set => orig.rayDistance = value;
}

public HutongGames.PlayMaker.FsmBool storeDidPickObject
{
get => orig.storeDidPickObject;
set => orig.storeDidPickObject = value;
}

public HutongGames.PlayMaker.FsmGameObject storeGameObject
{
get => orig.storeGameObject;
set => orig.storeGameObject = value;
}

public HutongGames.PlayMaker.FsmVector3 storePoint
{
get => orig.storePoint;
set => orig.storePoint = value;
}

public HutongGames.PlayMaker.FsmVector3 storeNormal
{
get => orig.storeNormal;
set => orig.storeNormal = value;
}

public HutongGames.PlayMaker.FsmFloat storeDistance
{
get => orig.storeDistance;
set => orig.storeDistance = value;
}

public HutongGames.PlayMaker.FsmInt[] layerMask
{
get => orig.layerMask;
set => orig.layerMask = value;
}

public HutongGames.PlayMaker.FsmBool invertMask
{
get => orig.invertMask;
set => orig.invertMask = value;
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

public void DoScreenPick () =>
CallMethod();

}
}
