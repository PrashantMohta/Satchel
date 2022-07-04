namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of iTweenMoveTo allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class iTweenMoveToR:InstanceClassWrapper<HutongGames.PlayMaker.Actions.iTweenMoveTo>
{
public iTweenMoveToR(HutongGames.PlayMaker.Actions.iTweenMoveTo _orig) : base(_orig) {}
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

public HutongGames.PlayMaker.FsmGameObject transformPosition
{
get => orig.transformPosition;
set => orig.transformPosition = value;
}

public HutongGames.PlayMaker.FsmVector3 vectorPosition
{
get => orig.vectorPosition;
set => orig.vectorPosition = value;
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

public HutongGames.PlayMaker.FsmFloat speed
{
get => orig.speed;
set => orig.speed = value;
}

public UnityEngine.Space space
{
get => orig.space;
set => orig.space = value;
}

public HutongGames.PlayMaker.FsmBool orientToPath
{
get => orig.orientToPath;
set => orig.orientToPath = value;
}

public HutongGames.PlayMaker.FsmGameObject lookAtObject
{
get => orig.lookAtObject;
set => orig.lookAtObject = value;
}

public HutongGames.PlayMaker.FsmVector3 lookAtVector
{
get => orig.lookAtVector;
set => orig.lookAtVector = value;
}

public HutongGames.PlayMaker.FsmFloat lookTime
{
get => orig.lookTime;
set => orig.lookTime = value;
}

public HutongGames.PlayMaker.FsmBool moveToPath
{
get => orig.moveToPath;
set => orig.moveToPath = value;
}

public HutongGames.PlayMaker.FsmFloat lookAhead
{
get => orig.lookAhead;
set => orig.lookAhead = value;
}

public HutongGames.PlayMaker.FsmGameObject[] transforms
{
get => orig.transforms;
set => orig.transforms = value;
}

public HutongGames.PlayMaker.FsmVector3[] vectors
{
get => orig.vectors;
set => orig.vectors = value;
}

public HutongGames.PlayMaker.FsmBool reverse
{
get => orig.reverse;
set => orig.reverse = value;
}

public UnityEngine.Vector3[] tempVct3
{
get => GetField<UnityEngine.Vector3[]>();
set => SetField(value);
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

public void OnDrawActionGizmos () =>
orig.OnDrawActionGizmos();

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
