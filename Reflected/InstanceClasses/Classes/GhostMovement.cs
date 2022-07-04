namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of GhostMovement allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class GhostMovementR:InstanceClassWrapper<HutongGames.PlayMaker.Actions.GhostMovement>
{
public GhostMovementR(HutongGames.PlayMaker.Actions.GhostMovement _orig) : base(_orig) {}
public HutongGames.PlayMaker.FsmOwnerDefault gameObject
{
get => orig.gameObject;
set => orig.gameObject = value;
}

public HutongGames.PlayMaker.FsmFloat xPosMin
{
get => orig.xPosMin;
set => orig.xPosMin = value;
}

public HutongGames.PlayMaker.FsmFloat xPosMax
{
get => orig.xPosMax;
set => orig.xPosMax = value;
}

public HutongGames.PlayMaker.FsmFloat accel_x
{
get => orig.accel_x;
set => orig.accel_x = value;
}

public HutongGames.PlayMaker.FsmFloat speedMax_x
{
get => orig.speedMax_x;
set => orig.speedMax_x = value;
}

public HutongGames.PlayMaker.FsmFloat yPosMin
{
get => orig.yPosMin;
set => orig.yPosMin = value;
}

public HutongGames.PlayMaker.FsmFloat yPosMax
{
get => orig.yPosMax;
set => orig.yPosMax = value;
}

public HutongGames.PlayMaker.FsmFloat accel_y
{
get => orig.accel_y;
set => orig.accel_y = value;
}

public HutongGames.PlayMaker.FsmFloat speedMax_y
{
get => orig.speedMax_y;
set => orig.speedMax_y = value;
}

public HutongGames.PlayMaker.FsmGameObject target
{
get => GetField<HutongGames.PlayMaker.FsmGameObject>();
set => SetField(value);
}

public UnityEngine.Transform transform
{
get => GetField<UnityEngine.Transform>();
set => SetField(value);
}

public HutongGames.PlayMaker.FsmInt direction_x
{
get => orig.direction_x;
set => orig.direction_x = value;
}

public HutongGames.PlayMaker.FsmInt direction_y
{
get => orig.direction_y;
set => orig.direction_y = value;
}

public UnityEngine.Rigidbody2D rb2d
{
get => GetField<UnityEngine.Rigidbody2D>();
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

public void Awake () =>
orig.Awake();

public void OnPreprocess () =>
orig.OnPreprocess();

public void OnEnter () =>
orig.OnEnter();

public void OnFixedUpdate () =>
orig.OnFixedUpdate();

public void DoMove () =>
CallMethod();

}
}
