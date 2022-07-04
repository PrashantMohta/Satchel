namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of SetHingeJoint2dProperties allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class SetHingeJoint2dPropertiesR:InstanceClassWrapper<HutongGames.PlayMaker.Actions.SetHingeJoint2dProperties>
{
public SetHingeJoint2dPropertiesR(HutongGames.PlayMaker.Actions.SetHingeJoint2dProperties _orig) : base(_orig) {}
public HutongGames.PlayMaker.FsmOwnerDefault gameObject
{
get => orig.gameObject;
set => orig.gameObject = value;
}

public HutongGames.PlayMaker.FsmBool useLimits
{
get => orig.useLimits;
set => orig.useLimits = value;
}

public HutongGames.PlayMaker.FsmFloat min
{
get => orig.min;
set => orig.min = value;
}

public HutongGames.PlayMaker.FsmFloat max
{
get => orig.max;
set => orig.max = value;
}

public HutongGames.PlayMaker.FsmBool useMotor
{
get => orig.useMotor;
set => orig.useMotor = value;
}

public HutongGames.PlayMaker.FsmFloat motorSpeed
{
get => orig.motorSpeed;
set => orig.motorSpeed = value;
}

public HutongGames.PlayMaker.FsmFloat maxMotorTorque
{
get => orig.maxMotorTorque;
set => orig.maxMotorTorque = value;
}

public bool everyFrame
{
get => orig.everyFrame;
set => orig.everyFrame = value;
}

public UnityEngine.HingeJoint2D _joint
{
get => GetField<UnityEngine.HingeJoint2D>();
set => SetField(value);
}

public UnityEngine.JointMotor2D _motor
{
get => GetField<UnityEngine.JointMotor2D>();
set => SetField(value);
}

public UnityEngine.JointAngleLimits2D _limits
{
get => GetField<UnityEngine.JointAngleLimits2D>();
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

public void SetProperties () =>
CallMethod();

}
}
