namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of RayCast2dV2 allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class RayCast2dV2R:InstanceClassWrapper<HutongGames.PlayMaker.Actions.RayCast2dV2>
{
public RayCast2dV2R(HutongGames.PlayMaker.Actions.RayCast2dV2 _orig) : base(_orig) {}
public HutongGames.PlayMaker.FsmOwnerDefault fromGameObject
{
get => orig.fromGameObject;
set => orig.fromGameObject = value;
}

public HutongGames.PlayMaker.FsmVector2 fromPosition
{
get => orig.fromPosition;
set => orig.fromPosition = value;
}

public HutongGames.PlayMaker.FsmVector2 direction
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

public HutongGames.PlayMaker.FsmInt minDepth
{
get => orig.minDepth;
set => orig.minDepth = value;
}

public HutongGames.PlayMaker.FsmInt maxDepth
{
get => orig.maxDepth;
set => orig.maxDepth = value;
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

public HutongGames.PlayMaker.FsmGameObject storeHitObject
{
get => orig.storeHitObject;
set => orig.storeHitObject = value;
}

public HutongGames.PlayMaker.FsmVector2 storeHitPoint
{
get => orig.storeHitPoint;
set => orig.storeHitPoint = value;
}

public HutongGames.PlayMaker.FsmVector2 storeHitNormal
{
get => orig.storeHitNormal;
set => orig.storeHitNormal = value;
}

public HutongGames.PlayMaker.FsmFloat storeHitDistance
{
get => orig.storeHitDistance;
set => orig.storeHitDistance = value;
}

public HutongGames.PlayMaker.FsmFloat storeDistance
{
get => orig.storeDistance;
set => orig.storeDistance = value;
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

public UnityEngine.Transform _trans
{
get => GetField<UnityEngine.Transform>();
set => SetField(value);
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
