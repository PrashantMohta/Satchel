namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of RaycastAll allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class RaycastAllR:InstanceClassWrapper<HutongGames.PlayMaker.Actions.RaycastAll>
{
public RaycastAllR(HutongGames.PlayMaker.Actions.RaycastAll _orig) : base(_orig) {}
public UnityEngine.RaycastHit[] RaycastAllHitInfo
{
get => HutongGames.PlayMaker.Actions.RaycastAll.RaycastAllHitInfo;
set => HutongGames.PlayMaker.Actions.RaycastAll.RaycastAllHitInfo = value;
}

public HutongGames.PlayMaker.FsmOwnerDefault fromGameObject
{
get => orig.fromGameObject;
set => orig.fromGameObject = value;
}

public HutongGames.PlayMaker.FsmVector3 fromPosition
{
get => orig.fromPosition;
set => orig.fromPosition = value;
}

public HutongGames.PlayMaker.FsmVector3 direction
{
get => orig.direction;
set => orig.direction = value;
}

public UnityEngine.Space space
{
get => orig.space;
set => orig.space = value;
}

public HutongGames.PlayMaker.FsmFloat distance
{
get => orig.distance;
set => orig.distance = value;
}

public HutongGames.PlayMaker.FsmEvent hitEvent
{
get => orig.hitEvent;
set => orig.hitEvent = value;
}

public HutongGames.PlayMaker.FsmBool storeDidHit
{
get => orig.storeDidHit;
set => orig.storeDidHit = value;
}

public HutongGames.PlayMaker.FsmArray storeHitObjects
{
get => orig.storeHitObjects;
set => orig.storeHitObjects = value;
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

public HutongGames.PlayMaker.FsmFloat storeHitDistance
{
get => orig.storeHitDistance;
set => orig.storeHitDistance = value;
}

public HutongGames.PlayMaker.FsmInt repeatInterval
{
get => orig.repeatInterval;
set => orig.repeatInterval = value;
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

public HutongGames.PlayMaker.FsmColor debugColor
{
get => orig.debugColor;
set => orig.debugColor = value;
}

public HutongGames.PlayMaker.FsmBool debug
{
get => orig.debug;
set => orig.debug = value;
}

public int repeat
{
get => GetField<int>();
set => SetField(value);
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

public void DoRaycast () =>
CallMethod();

}
}
