namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of ArrayListGetNearestFloatValue allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class ArrayListGetNearestFloatValueR:InstanceClassWrapper<HutongGames.PlayMaker.Actions.ArrayListGetNearestFloatValue>
{
public ArrayListGetNearestFloatValueR(HutongGames.PlayMaker.Actions.ArrayListGetNearestFloatValue _orig) : base(_orig) {}
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

public HutongGames.PlayMaker.FsmFloat floatValue
{
get => orig.floatValue;
set => orig.floatValue = value;
}

public bool everyframe
{
get => orig.everyframe;
set => orig.everyframe = value;
}

public HutongGames.PlayMaker.FsmInt nearestIndex
{
get => orig.nearestIndex;
set => orig.nearestIndex = value;
}

public HutongGames.PlayMaker.FsmFloat nearestValue
{
get => orig.nearestValue;
set => orig.nearestValue = value;
}

public System.Collections.Generic.List<System.Single> _floats
{
get => GetField<System.Collections.Generic.List<System.Single>>();
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

public void DoGetNearestValue () =>
CallMethod();

}
}
