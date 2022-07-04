namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of EaseRect allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class EaseRectR:InstanceClassWrapper<HutongGames.PlayMaker.Actions.EaseRect>
{
public EaseRectR(HutongGames.PlayMaker.Actions.EaseRect _orig) : base(_orig) {}
public HutongGames.PlayMaker.FsmRect fromValue
{
get => orig.fromValue;
set => orig.fromValue = value;
}

public HutongGames.PlayMaker.FsmRect toValue
{
get => orig.toValue;
set => orig.toValue = value;
}

public HutongGames.PlayMaker.FsmRect rectVariable
{
get => orig.rectVariable;
set => orig.rectVariable = value;
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

public HutongGames.PlayMaker.FsmBool reverse
{
get => orig.reverse;
set => orig.reverse = value;
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

public float runningTime
{
get => GetField<float>();
set => SetField(value);
}

public float lastTime
{
get => GetField<float>();
set => SetField(value);
}

public float startTime
{
get => GetField<float>();
set => SetField(value);
}

public float deltaTime
{
get => GetField<float>();
set => SetField(value);
}

public float delayTime
{
get => GetField<float>();
set => SetField(value);
}

public float percentage
{
get => GetField<float>();
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

public System.Single[] resultFloats
{
get => GetField<System.Single[]>();
set => SetField(value);
}

public bool finishAction
{
get => GetField<bool>();
set => SetField(value);
}

public bool start
{
get => GetField<bool>();
set => SetField(value);
}

public bool finished
{
get => GetField<bool>();
set => SetField(value);
}

public bool isRunning
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
