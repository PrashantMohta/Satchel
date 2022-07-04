namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of SpawnBloodTime allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class SpawnBloodTimeR:InstanceClassWrapper<SpawnBloodTime>
{
public SpawnBloodTimeR(SpawnBloodTime _orig) : base(_orig) {}
public HutongGames.PlayMaker.FsmFloat delay
{
get => orig.delay;
set => orig.delay = value;
}

public float nextSpawnTime
{
get => GetField<float>();
set => SetField(value);
}

public HutongGames.PlayMaker.FsmGameObject spawnPoint
{
get => orig.spawnPoint;
set => orig.spawnPoint = value;
}

public HutongGames.PlayMaker.FsmVector3 position
{
get => orig.position;
set => orig.position = value;
}

public HutongGames.PlayMaker.FsmInt spawnMin
{
get => orig.spawnMin;
set => orig.spawnMin = value;
}

public HutongGames.PlayMaker.FsmInt spawnMax
{
get => orig.spawnMax;
set => orig.spawnMax = value;
}

public HutongGames.PlayMaker.FsmFloat speedMin
{
get => orig.speedMin;
set => orig.speedMin = value;
}

public HutongGames.PlayMaker.FsmFloat speedMax
{
get => orig.speedMax;
set => orig.speedMax = value;
}

public HutongGames.PlayMaker.FsmFloat angleMin
{
get => orig.angleMin;
set => orig.angleMin = value;
}

public HutongGames.PlayMaker.FsmFloat angleMax
{
get => orig.angleMax;
set => orig.angleMax = value;
}

public HutongGames.PlayMaker.FsmColor colorOverride
{
get => orig.colorOverride;
set => orig.colorOverride = value;
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
