namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of ArrayListGetGameobjectMaxFsmFloatIndex allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class ArrayListGetGameobjectMaxFsmFloatIndexR:InstanceClassWrapper<HutongGames.PlayMaker.Actions.ArrayListGetGameobjectMaxFsmFloatIndex>
{
public ArrayListGetGameobjectMaxFsmFloatIndexR(HutongGames.PlayMaker.Actions.ArrayListGetGameobjectMaxFsmFloatIndex _orig) : base(_orig) {}
public HutongGames.PlayMaker.FsmOwnerDefault gameObject
{
get => orig.gameObject;
set => orig.gameObject = value;
}

public HutongGames.PlayMaker.FsmString reference
{
get => orig.reference;
set => orig.reference = value;
}

public HutongGames.PlayMaker.FsmString fsmName
{
get => orig.fsmName;
set => orig.fsmName = value;
}

public HutongGames.PlayMaker.FsmString variableName
{
get => orig.variableName;
set => orig.variableName = value;
}

public bool everyframe
{
get => orig.everyframe;
set => orig.everyframe = value;
}

public HutongGames.PlayMaker.FsmFloat storeMaxValue
{
get => orig.storeMaxValue;
set => orig.storeMaxValue = value;
}

public HutongGames.PlayMaker.FsmGameObject maxGameObject
{
get => orig.maxGameObject;
set => orig.maxGameObject = value;
}

public HutongGames.PlayMaker.FsmInt maxIndex
{
get => orig.maxIndex;
set => orig.maxIndex = value;
}

public UnityEngine.GameObject goLastFrame
{
get => GetField<UnityEngine.GameObject>();
set => SetField(value);
}

public PlayMakerFSM fsm
{
get => GetField<PlayMakerFSM>();
set => SetField(value);
}

public PlayMakerArrayListProxy proxy
{
get => GetField<PlayMakerArrayListProxy>();
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

public void DoFindMaxGo () =>
CallMethod();

}
}
