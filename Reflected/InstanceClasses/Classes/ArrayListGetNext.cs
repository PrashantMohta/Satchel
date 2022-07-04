namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of ArrayListGetNext allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class ArrayListGetNextR:InstanceClassWrapper<HutongGames.PlayMaker.Actions.ArrayListGetNext>
{
public ArrayListGetNextR(HutongGames.PlayMaker.Actions.ArrayListGetNext _orig) : base(_orig) {}
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

public HutongGames.PlayMaker.FsmBool reset
{
get => orig.reset;
set => orig.reset = value;
}

public HutongGames.PlayMaker.FsmInt startIndex
{
get => orig.startIndex;
set => orig.startIndex = value;
}

public HutongGames.PlayMaker.FsmInt endIndex
{
get => orig.endIndex;
set => orig.endIndex = value;
}

public HutongGames.PlayMaker.FsmEvent loopEvent
{
get => orig.loopEvent;
set => orig.loopEvent = value;
}

public HutongGames.PlayMaker.FsmEvent finishedEvent
{
get => orig.finishedEvent;
set => orig.finishedEvent = value;
}

public HutongGames.PlayMaker.FsmEvent failureEvent
{
get => orig.failureEvent;
set => orig.failureEvent = value;
}

public HutongGames.PlayMaker.FsmInt currentIndex
{
get => orig.currentIndex;
set => orig.currentIndex = value;
}

public HutongGames.PlayMaker.FsmVar result
{
get => orig.result;
set => orig.result = value;
}

public int nextItemIndex
{
get => GetField<int>();
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

public void DoGetNextItem () =>
CallMethod();

public void GetItemAtIndex () =>
orig.GetItemAtIndex();

}
}
