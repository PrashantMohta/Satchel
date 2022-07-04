namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of LookAt allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class LookAtR:InstanceClassWrapper<HutongGames.PlayMaker.Actions.LookAt>
{
public LookAtR(HutongGames.PlayMaker.Actions.LookAt _orig) : base(_orig) {}
public HutongGames.PlayMaker.FsmOwnerDefault gameObject
{
get => orig.gameObject;
set => orig.gameObject = value;
}

public HutongGames.PlayMaker.FsmGameObject targetObject
{
get => orig.targetObject;
set => orig.targetObject = value;
}

public HutongGames.PlayMaker.FsmVector3 targetPosition
{
get => orig.targetPosition;
set => orig.targetPosition = value;
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

public HutongGames.PlayMaker.FsmBool debug
{
get => orig.debug;
set => orig.debug = value;
}

public HutongGames.PlayMaker.FsmColor debugLineColor
{
get => orig.debugLineColor;
set => orig.debugLineColor = value;
}

public bool everyFrame
{
get => orig.everyFrame;
set => orig.everyFrame = value;
}

public UnityEngine.GameObject go
{
get => GetField<UnityEngine.GameObject>();
set => SetField(value);
}

public UnityEngine.GameObject goTarget
{
get => GetField<UnityEngine.GameObject>();
set => SetField(value);
}

public UnityEngine.Vector3 lookAtPos
{
get => GetField<UnityEngine.Vector3>();
set => SetField(value);
}

public UnityEngine.Vector3 lookAtPosWithVertical
{
get => GetField<UnityEngine.Vector3>();
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

public void OnLateUpdate () =>
orig.OnLateUpdate();

public void DoLookAt () =>
CallMethod();

public bool UpdateLookAtPosition () =>
orig.UpdateLookAtPosition();

public UnityEngine.Vector3 GetLookAtPosition () =>
orig.GetLookAtPosition();

public UnityEngine.Vector3 GetLookAtPositionWithVertical () =>
orig.GetLookAtPositionWithVertical();

}
}
