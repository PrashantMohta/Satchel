namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of ArrayListLastIndexOf allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class ArrayListLastIndexOfR:InstanceClassWrapper<HutongGames.PlayMaker.Actions.ArrayListLastIndexOf>
{
public ArrayListLastIndexOfR(HutongGames.PlayMaker.Actions.ArrayListLastIndexOf _orig) : base(_orig) {}
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

public HutongGames.PlayMaker.FsmInt startIndex
{
get => orig.startIndex;
set => orig.startIndex = value;
}

public HutongGames.PlayMaker.FsmInt count
{
get => orig.count;
set => orig.count = value;
}

public HutongGames.PlayMaker.FsmVar variable
{
get => orig.variable;
set => orig.variable = value;
}

public HutongGames.PlayMaker.FsmInt lastIndexOf
{
get => orig.lastIndexOf;
set => orig.lastIndexOf = value;
}

public HutongGames.PlayMaker.FsmEvent itemFound
{
get => orig.itemFound;
set => orig.itemFound = value;
}

public HutongGames.PlayMaker.FsmEvent itemNotFound
{
get => orig.itemNotFound;
set => orig.itemNotFound = value;
}

public HutongGames.PlayMaker.FsmEvent failureEvent
{
get => orig.failureEvent;
set => orig.failureEvent = value;
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

public void DoArrayListLastIndex () =>
orig.DoArrayListLastIndex();

}
}
