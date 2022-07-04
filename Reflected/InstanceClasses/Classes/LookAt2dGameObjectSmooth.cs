namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of LookAt2dGameObjectSmooth allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class LookAt2dGameObjectSmoothR:InstanceClassWrapper<HutongGames.PlayMaker.Actions.LookAt2dGameObjectSmooth>
{
public LookAt2dGameObjectSmoothR(HutongGames.PlayMaker.Actions.LookAt2dGameObjectSmooth _orig) : base(_orig) {}
public HutongGames.PlayMaker.FsmOwnerDefault gameObject
{
get => orig.gameObject;
set => orig.gameObject = value;
}

public HutongGames.PlayMaker.FsmGameObject targetObject
{
get => orig.targetObject;
set => orig.targetObject = value;
}

public HutongGames.PlayMaker.FsmFloat rotationOffset
{
get => orig.rotationOffset;
set => orig.rotationOffset = value;
}

public HutongGames.PlayMaker.FsmFloat speed
{
get => orig.speed;
set => orig.speed = value;
}

public HutongGames.PlayMaker.FsmBool debug
{
get => orig.debug;
set => orig.debug = value;
}

public HutongGames.PlayMaker.FsmColor debugLineColor
{
get => orig.debugLineColor;
set => orig.debugLineColor = value;
}

public UnityEngine.GameObject go
{
get => GetField<UnityEngine.GameObject>();
set => SetField(value);
}

public UnityEngine.GameObject goTarget
{
get => GetField<UnityEngine.GameObject>();
set => SetField(value);
}

public UnityEngine.Vector3 lookAtPos
{
get => GetField<UnityEngine.Vector3>();
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

public void DoLookAt () =>
CallMethod();

}
}
