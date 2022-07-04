namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of ControllerSettings allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class ControllerSettingsR:InstanceClassWrapper<HutongGames.PlayMaker.Actions.ControllerSettings>
{
public ControllerSettingsR(HutongGames.PlayMaker.Actions.ControllerSettings _orig) : base(_orig) {}
public HutongGames.PlayMaker.FsmOwnerDefault gameObject
{
get => orig.gameObject;
set => orig.gameObject = value;
}

public HutongGames.PlayMaker.FsmFloat height
{
get => orig.height;
set => orig.height = value;
}

public HutongGames.PlayMaker.FsmFloat radius
{
get => orig.radius;
set => orig.radius = value;
}

public HutongGames.PlayMaker.FsmFloat slopeLimit
{
get => orig.slopeLimit;
set => orig.slopeLimit = value;
}

public HutongGames.PlayMaker.FsmFloat stepOffset
{
get => orig.stepOffset;
set => orig.stepOffset = value;
}

public HutongGames.PlayMaker.FsmVector3 center
{
get => orig.center;
set => orig.center = value;
}

public HutongGames.PlayMaker.FsmBool detectCollisions
{
get => orig.detectCollisions;
set => orig.detectCollisions = value;
}

public bool everyFrame
{
get => orig.everyFrame;
set => orig.everyFrame = value;
}

public UnityEngine.GameObject previousGo
{
get => GetField<UnityEngine.GameObject>();
set => SetField(value);
}

public UnityEngine.CharacterController controller
{
get => GetField<UnityEngine.CharacterController>();
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

public void DoControllerSettings () =>
CallMethod();

}
}
