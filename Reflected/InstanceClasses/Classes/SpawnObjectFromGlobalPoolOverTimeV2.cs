namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of SpawnObjectFromGlobalPoolOverTimeV2 allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class SpawnObjectFromGlobalPoolOverTimeV2R:InstanceClassWrapper<HutongGames.PlayMaker.Actions.SpawnObjectFromGlobalPoolOverTimeV2>
{
public SpawnObjectFromGlobalPoolOverTimeV2R(HutongGames.PlayMaker.Actions.SpawnObjectFromGlobalPoolOverTimeV2 _orig) : base(_orig) {}
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

public HutongGames.PlayMaker.FsmVector3 rotation
{
get => orig.rotation;
set => orig.rotation = value;
}

public HutongGames.PlayMaker.FsmFloat frequency
{
get => orig.frequency;
set => orig.frequency = value;
}

public HutongGames.PlayMaker.FsmFloat scaleMin
{
get => orig.scaleMin;
set => orig.scaleMin = value;
}

public HutongGames.PlayMaker.FsmFloat scaleMax
{
get => orig.scaleMax;
set => orig.scaleMax = value;
}

public float timer
{
get => GetField<float>();
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

public void OnUpdate () =>
orig.OnUpdate();

}
}
