namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of SetWheelJoint2dProperties allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class SetWheelJoint2dPropertiesR:InstanceClassWrapper<HutongGames.PlayMaker.Actions.SetWheelJoint2dProperties>
{
public SetWheelJoint2dPropertiesR(HutongGames.PlayMaker.Actions.SetWheelJoint2dProperties _orig) : base(_orig) {}
public HutongGames.PlayMaker.FsmOwnerDefault gameObject
{
get => orig.gameObject;
set => orig.gameObject = value;
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

public HutongGames.PlayMaker.FsmFloat angle
{
get => orig.angle;
set => orig.angle = value;
}

public HutongGames.PlayMaker.FsmFloat dampingRatio
{
get => orig.dampingRatio;
set => orig.dampingRatio = value;
}

public HutongGames.PlayMaker.FsmFloat frequency
{
get => orig.frequency;
set => orig.frequency = value;
}

public bool everyFrame
{
get => orig.everyFrame;
set => orig.everyFrame = value;
}

public UnityEngine.WheelJoint2D _wj2d
{
get => GetField<UnityEngine.WheelJoint2D>();
set => SetField(value);
}

public UnityEngine.JointMotor2D _motor
{
get => GetField<UnityEngine.JointMotor2D>();
set => SetField(value);
}

public UnityEngine.JointSuspension2D _suspension
{
get => GetField<UnityEngine.JointSuspension2D>();
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
