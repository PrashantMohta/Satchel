namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of SmoothLookAtDirection allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class SmoothLookAtDirectionR:InstanceClassWrapper<HutongGames.PlayMaker.Actions.SmoothLookAtDirection>
{
public SmoothLookAtDirectionR(HutongGames.PlayMaker.Actions.SmoothLookAtDirection _orig) : base(_orig) {}
public HutongGames.PlayMaker.FsmOwnerDefault gameObject
{
get => orig.gameObject;
set => orig.gameObject = value;
}

public HutongGames.PlayMaker.FsmVector3 targetDirection
{
get => orig.targetDirection;
set => orig.targetDirection = value;
}

public HutongGames.PlayMaker.FsmFloat minMagnitude
{
get => orig.minMagnitude;
set => orig.minMagnitude = value;
}

public HutongGames.PlayMaker.FsmVector3 upVector
{
get => orig.upVector;
set => orig.upVector = value;
}

public HutongGames.PlayMaker.FsmBool keepVertical
{
get => orig.keepVertical;
set => orig.keepVertical = value;
}

public HutongGames.PlayMaker.FsmFloat speed
{
get => orig.speed;
set => orig.speed = value;
}

public bool lateUpdate
{
get => orig.lateUpdate;
set => orig.lateUpdate = value;
}

public HutongGames.PlayMaker.FsmEvent finishEvent
{
get => orig.finishEvent;
set => orig.finishEvent = value;
}

public HutongGames.PlayMaker.FsmBool finish
{
get => orig.finish;
set => orig.finish = value;
}

public UnityEngine.GameObject previousGo
{
get => GetField<UnityEngine.GameObject>();
set => SetField(value);
}

public UnityEngine.Quaternion lastRotation
{
get => GetField<UnityEngine.Quaternion>();
set => SetField(value);
}

public UnityEngine.Quaternion desiredRotation
{
get => GetField<UnityEngine.Quaternion>();
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

public void OnPreprocess () =>
orig.OnPreprocess();

public void OnEnter () =>
orig.OnEnter();

public void OnUpdate () =>
orig.OnUpdate();

public void OnLateUpdate () =>
orig.OnLateUpdate();

public void DoSmoothLookAtDirection () =>
CallMethod();

}
}
