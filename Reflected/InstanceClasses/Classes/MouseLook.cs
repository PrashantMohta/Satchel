namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of MouseLook allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class MouseLookR:InstanceClassWrapper<HutongGames.PlayMaker.Actions.MouseLook>
{
public MouseLookR(HutongGames.PlayMaker.Actions.MouseLook _orig) : base(_orig) {}
public HutongGames.PlayMaker.FsmOwnerDefault gameObject
{
get => orig.gameObject;
set => orig.gameObject = value;
}

public HutongGames.PlayMaker.FsmFloat sensitivityX
{
get => orig.sensitivityX;
set => orig.sensitivityX = value;
}

public HutongGames.PlayMaker.FsmFloat sensitivityY
{
get => orig.sensitivityY;
set => orig.sensitivityY = value;
}

public HutongGames.PlayMaker.FsmFloat minimumX
{
get => orig.minimumX;
set => orig.minimumX = value;
}

public HutongGames.PlayMaker.FsmFloat maximumX
{
get => orig.maximumX;
set => orig.maximumX = value;
}

public HutongGames.PlayMaker.FsmFloat minimumY
{
get => orig.minimumY;
set => orig.minimumY = value;
}

public HutongGames.PlayMaker.FsmFloat maximumY
{
get => orig.maximumY;
set => orig.maximumY = value;
}

public bool everyFrame
{
get => orig.everyFrame;
set => orig.everyFrame = value;
}

public float rotationX
{
get => GetField<float>();
set => SetField(value);
}

public float rotationY
{
get => GetField<float>();
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

public void DoMouseLook () =>
CallMethod();

public float GetXRotation () =>
CallMethod<float>();

public float GetYRotation () =>
CallMethod<float>();

public float ClampAngle (float angle, HutongGames.PlayMaker.FsmFloat min, HutongGames.PlayMaker.FsmFloat max) =>
CallMethodStatic<float>(new object[] {angle, min, max});

}
}
