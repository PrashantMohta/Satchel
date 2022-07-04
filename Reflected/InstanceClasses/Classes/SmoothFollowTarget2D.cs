namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of SmoothFollowTarget2D allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class SmoothFollowTarget2DR:InstanceClassWrapper<HutongGames.PlayMaker.Actions.SmoothFollowTarget2D>
{
public SmoothFollowTarget2DR(HutongGames.PlayMaker.Actions.SmoothFollowTarget2D _orig) : base(_orig) {}
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

public float dampTime
{
get => orig.dampTime;
set => orig.dampTime = value;
}

public UnityEngine.Camera camera
{
get => GetField<UnityEngine.Camera>();
set => SetField(value);
}

public UnityEngine.GameObject target
{
get => GetField<UnityEngine.GameObject>();
set => SetField(value);
}

public UnityEngine.Transform transform
{
get => GetField<UnityEngine.Transform>();
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

}
}
