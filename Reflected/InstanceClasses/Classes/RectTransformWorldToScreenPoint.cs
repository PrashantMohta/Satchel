namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of RectTransformWorldToScreenPoint allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class RectTransformWorldToScreenPointR:InstanceClassWrapper<HutongGames.PlayMaker.Actions.RectTransformWorldToScreenPoint>
{
public RectTransformWorldToScreenPointR(HutongGames.PlayMaker.Actions.RectTransformWorldToScreenPoint _orig) : base(_orig) {}
public HutongGames.PlayMaker.FsmOwnerDefault gameObject
{
get => orig.gameObject;
set => orig.gameObject = value;
}

public HutongGames.PlayMaker.FsmOwnerDefault camera
{
get => orig.camera;
set => orig.camera = value;
}

public HutongGames.PlayMaker.FsmVector3 screenPoint
{
get => orig.screenPoint;
set => orig.screenPoint = value;
}

public HutongGames.PlayMaker.FsmFloat screenX
{
get => orig.screenX;
set => orig.screenX = value;
}

public HutongGames.PlayMaker.FsmFloat screenY
{
get => orig.screenY;
set => orig.screenY = value;
}

public HutongGames.PlayMaker.FsmBool normalize
{
get => orig.normalize;
set => orig.normalize = value;
}

public UnityEngine.RectTransform _rt
{
get => GetField<UnityEngine.RectTransform>();
set => SetField(value);
}

public UnityEngine.Camera _cam
{
get => GetField<UnityEngine.Camera>();
set => SetField(value);
}

public bool everyFrame
{
get => orig.everyFrame;
set => orig.everyFrame = value;
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

public void OnActionUpdate () =>
orig.OnActionUpdate();

public void DoWorldToScreenPoint () =>
CallMethod();

}
}
