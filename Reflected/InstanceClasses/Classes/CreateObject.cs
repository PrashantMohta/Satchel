namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of CreateObject allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class CreateObjectR:InstanceClassWrapper<HutongGames.PlayMaker.Actions.CreateObject>
{
public CreateObjectR(HutongGames.PlayMaker.Actions.CreateObject _orig) : base(_orig) {}
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

public HutongGames.PlayMaker.FsmGameObject storeObject
{
get => orig.storeObject;
set => orig.storeObject = value;
}

public HutongGames.PlayMaker.FsmBool networkInstantiate
{
get => orig.networkInstantiate;
set => orig.networkInstantiate = value;
}

public HutongGames.PlayMaker.FsmInt networkGroup
{
get => orig.networkGroup;
set => orig.networkGroup = value;
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
