namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of CurveColor allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class CurveColorR:InstanceClassWrapper<HutongGames.PlayMaker.Actions.CurveColor>
{
public CurveColorR(HutongGames.PlayMaker.Actions.CurveColor _orig) : base(_orig) {}
public HutongGames.PlayMaker.FsmColor colorVariable
{
get => orig.colorVariable;
set => orig.colorVariable = value;
}

public HutongGames.PlayMaker.FsmColor fromValue
{
get => orig.fromValue;
set => orig.fromValue = value;
}

public HutongGames.PlayMaker.FsmColor toValue
{
get => orig.toValue;
set => orig.toValue = value;
}

public HutongGames.PlayMaker.FsmAnimationCurve curveR
{
get => orig.curveR;
set => orig.curveR = value;
}

public HutongGames.PlayMaker.FsmAnimationCurve curveG
{
get => orig.curveG;
set => orig.curveG = value;
}

public HutongGames.PlayMaker.FsmAnimationCurve curveB
{
get => orig.curveB;
set => orig.curveB = value;
}

public HutongGames.PlayMaker.FsmAnimationCurve curveA
{
get => orig.curveA;
set => orig.curveA = value;
}

public UnityEngine.Color clr
{
get => GetField<UnityEngine.Color>();
set => SetField(value);
}

public bool finishInNextStep
{
get => GetField<bool>();
set => SetField(value);
}

public HutongGames.PlayMaker.FsmFloat time
{
get => orig.time;
set => orig.time = value;
}

public HutongGames.PlayMaker.FsmFloat speed
{
get => orig.speed;
set => orig.speed = value;
}

public HutongGames.PlayMaker.FsmFloat delay
{
get => orig.delay;
set => orig.delay = value;
}

public HutongGames.PlayMaker.FsmBool ignoreCurveOffset
{
get => orig.ignoreCurveOffset;
set => orig.ignoreCurveOffset = value;
}

public HutongGames.PlayMaker.FsmEvent finishEvent
{
get => orig.finishEvent;
set => orig.finishEvent = value;
}

public bool realTime
{
get => orig.realTime;
set => orig.realTime = value;
}

public UnityEngine.AnimationCurve[] curves
{
get => GetField<UnityEngine.AnimationCurve[]>();
set => SetField(value);
}

public HutongGames.PlayMaker.Actions.CurveFsmAction.Calculation[] calculations
{
get => GetField<HutongGames.PlayMaker.Actions.CurveFsmAction.Calculation[]>();
set => SetField(value);
}

public System.Single[] resultFloats
{
get => GetField<System.Single[]>();
set => SetField(value);
}

public System.Single[] fromFloats
{
get => GetField<System.Single[]>();
set => SetField(value);
}

public System.Single[] toFloats
{
get => GetField<System.Single[]>();
set => SetField(value);
}

public bool finishAction
{
get => GetField<bool>();
set => SetField(value);
}

public bool isRunning
{
get => GetField<bool>();
set => SetField(value);
}

public bool looping
{
get => GetField<bool>();
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

public void OnUpdate () =>
orig.OnUpdate();

}
}
