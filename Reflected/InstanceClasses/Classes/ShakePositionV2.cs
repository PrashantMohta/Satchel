namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of ShakePositionV2 allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class ShakePositionV2R:InstanceClassWrapper<HutongGames.PlayMaker.Actions.ShakePositionV2>
{
public ShakePositionV2R(HutongGames.PlayMaker.Actions.ShakePositionV2 _orig) : base(_orig) {}
public HutongGames.PlayMaker.FsmOwnerDefault Target
{
get => orig.Target;
set => orig.Target = value;
}

public HutongGames.PlayMaker.FsmVector3 Extents
{
get => orig.Extents;
set => orig.Extents = value;
}

public HutongGames.PlayMaker.FsmFloat Duration
{
get => orig.Duration;
set => orig.Duration = value;
}

public HutongGames.PlayMaker.FsmBool IsLooping
{
get => orig.IsLooping;
set => orig.IsLooping = value;
}

public HutongGames.PlayMaker.FsmEvent StopEvent
{
get => orig.StopEvent;
set => orig.StopEvent = value;
}

public HutongGames.PlayMaker.FsmFloat FpsLimit
{
get => orig.FpsLimit;
set => orig.FpsLimit = value;
}

public HutongGames.PlayMaker.FsmBool IsCameraShake
{
get => orig.IsCameraShake;
set => orig.IsCameraShake = value;
}

public float timer
{
get => GetField<float>();
set => SetField(value);
}

public float nextUpdateTime
{
get => GetField<float>();
set => SetField(value);
}

public UnityEngine.Transform target
{
get => GetField<UnityEngine.Transform>();
set => SetField(value);
}

public UnityEngine.Vector3 startingWorldPosition
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

public void OnExit () =>
orig.OnExit();

public void UpdateShaking () =>
CallMethod();

public void StopAndReset () =>
CallMethod();

}
}
