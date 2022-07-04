namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of TouchObjectEvent allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class TouchObjectEventR:InstanceClassWrapper<HutongGames.PlayMaker.Actions.TouchObjectEvent>
{
public TouchObjectEventR(HutongGames.PlayMaker.Actions.TouchObjectEvent _orig) : base(_orig) {}
public HutongGames.PlayMaker.FsmOwnerDefault gameObject
{
get => orig.gameObject;
set => orig.gameObject = value;
}

public HutongGames.PlayMaker.FsmFloat pickDistance
{
get => orig.pickDistance;
set => orig.pickDistance = value;
}

public HutongGames.PlayMaker.FsmInt fingerId
{
get => orig.fingerId;
set => orig.fingerId = value;
}

public HutongGames.PlayMaker.FsmEvent touchBegan
{
get => orig.touchBegan;
set => orig.touchBegan = value;
}

public HutongGames.PlayMaker.FsmEvent touchMoved
{
get => orig.touchMoved;
set => orig.touchMoved = value;
}

public HutongGames.PlayMaker.FsmEvent touchStationary
{
get => orig.touchStationary;
set => orig.touchStationary = value;
}

public HutongGames.PlayMaker.FsmEvent touchEnded
{
get => orig.touchEnded;
set => orig.touchEnded = value;
}

public HutongGames.PlayMaker.FsmEvent touchCanceled
{
get => orig.touchCanceled;
set => orig.touchCanceled = value;
}

public HutongGames.PlayMaker.FsmInt storeFingerId
{
get => orig.storeFingerId;
set => orig.storeFingerId = value;
}

public HutongGames.PlayMaker.FsmVector3 storeHitPoint
{
get => orig.storeHitPoint;
set => orig.storeHitPoint = value;
}

public HutongGames.PlayMaker.FsmVector3 storeHitNormal
{
get => orig.storeHitNormal;
set => orig.storeHitNormal = value;
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
