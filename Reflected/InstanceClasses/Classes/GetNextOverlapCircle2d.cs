namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of GetNextOverlapCircle2d allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class GetNextOverlapCircle2dR:InstanceClassWrapper<HutongGames.PlayMaker.Actions.GetNextOverlapCircle2d>
{
public GetNextOverlapCircle2dR(HutongGames.PlayMaker.Actions.GetNextOverlapCircle2d _orig) : base(_orig) {}
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

public HutongGames.PlayMaker.FsmFloat radius
{
get => orig.radius;
set => orig.radius = value;
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

public HutongGames.PlayMaker.FsmInt collidersCount
{
get => orig.collidersCount;
set => orig.collidersCount = value;
}

public HutongGames.PlayMaker.FsmGameObject storeNextCollider
{
get => orig.storeNextCollider;
set => orig.storeNextCollider = value;
}

public HutongGames.PlayMaker.FsmEvent loopEvent
{
get => orig.loopEvent;
set => orig.loopEvent = value;
}

public HutongGames.PlayMaker.FsmEvent finishedEvent
{
get => orig.finishedEvent;
set => orig.finishedEvent = value;
}

public UnityEngine.Collider2D[] colliders
{
get => GetField<UnityEngine.Collider2D[]>();
set => SetField(value);
}

public int colliderCount
{
get => GetField<int>();
set => SetField(value);
}

public int nextColliderIndex
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

public void DoGetNextCollider () =>
CallMethod();

public UnityEngine.Collider2D[] GetOverlapCircleAll () =>
CallMethod<UnityEngine.Collider2D[]>();

}
}
