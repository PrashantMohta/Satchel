namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of SpawnRandomObjectsVelocity allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class SpawnRandomObjectsVelocityR:InstanceClassWrapper<HutongGames.PlayMaker.Actions.SpawnRandomObjectsVelocity>
{
public SpawnRandomObjectsVelocityR(HutongGames.PlayMaker.Actions.SpawnRandomObjectsVelocity _orig) : base(_orig) {}
public HutongGames.PlayMaker.FsmGameObject gameObject
{
get => orig.gameObject;
set => orig.gameObject = value;
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

public HutongGames.PlayMaker.FsmFloat speedMinX
{
get => orig.speedMinX;
set => orig.speedMinX = value;
}

public HutongGames.PlayMaker.FsmFloat speedMaxX
{
get => orig.speedMaxX;
set => orig.speedMaxX = value;
}

public HutongGames.PlayMaker.FsmFloat speedMinY
{
get => orig.speedMinY;
set => orig.speedMinY = value;
}

public HutongGames.PlayMaker.FsmFloat speedMaxY
{
get => orig.speedMaxY;
set => orig.speedMaxY = value;
}

public HutongGames.PlayMaker.FsmFloat originVariationX
{
get => orig.originVariationX;
set => orig.originVariationX = value;
}

public HutongGames.PlayMaker.FsmFloat originVariationY
{
get => orig.originVariationY;
set => orig.originVariationY = value;
}

public float vectorX
{
get => GetField<float>();
set => SetField(value);
}

public float vectorY
{
get => GetField<float>();
set => SetField(value);
}

public bool originAdjusted
{
get => GetField<bool>();
set => SetField(value);
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

public void OnEnter () =>
orig.OnEnter();

}
}
