namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of iTweenShakePosition allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class iTweenShakePositionR:InstanceClassWrapper<HutongGames.PlayMaker.Actions.iTweenShakePosition>
{
public iTweenShakePositionR(HutongGames.PlayMaker.Actions.iTweenShakePosition _orig) : base(_orig) {}
public HutongGames.PlayMaker.FsmOwnerDefault gameObject
{
get => orig.gameObject;
set => orig.gameObject = value;
}

public HutongGames.PlayMaker.FsmString id
{
get => orig.id;
set => orig.id = value;
}

public HutongGames.PlayMaker.FsmVector3 vector
{
get => orig.vector;
set => orig.vector = value;
}

public HutongGames.PlayMaker.FsmFloat time
{
get => orig.time;
set => orig.time = value;
}

public HutongGames.PlayMaker.FsmFloat delay
{
get => orig.delay;
set => orig.delay = value;
}

public UnityEngine.Space space
{
get => orig.space;
set => orig.space = value;
}

public HutongGames.PlayMaker.FsmEvent startEvent
{
get => orig.startEvent;
set => orig.startEvent = value;
}

public HutongGames.PlayMaker.FsmEvent finishEvent
{
get => orig.finishEvent;
set => orig.finishEvent = value;
}

public HutongGames.PlayMaker.FsmBool realTime
{
get => orig.realTime;
set => orig.realTime = value;
}

public HutongGames.PlayMaker.FsmBool stopOnExit
{
get => orig.stopOnExit;
set => orig.stopOnExit = value;
}

public HutongGames.PlayMaker.FsmBool loopDontFinish
{
get => orig.loopDontFinish;
set => orig.loopDontFinish = value;
}

public iTweenFSMEvents itweenEvents
{
get => GetField<iTweenFSMEvents>();
set => SetField(value);
}

public string itweenType
{
get => GetField<string>();
set => SetField(value);
}

public int itweenID
{
get => GetField<int>();
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

public void OnExit () =>
orig.OnExit();

public void DoiTween () =>
CallMethod();

}
}
