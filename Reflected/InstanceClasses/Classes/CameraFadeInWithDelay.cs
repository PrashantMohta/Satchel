namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of CameraFadeInWithDelay allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class CameraFadeInWithDelayR:InstanceClassWrapper<HutongGames.PlayMaker.Actions.CameraFadeInWithDelay>
{
public CameraFadeInWithDelayR(HutongGames.PlayMaker.Actions.CameraFadeInWithDelay _orig) : base(_orig) {}
public HutongGames.PlayMaker.FsmColor color
{
get => orig.color;
set => orig.color = value;
}

public HutongGames.PlayMaker.FsmFloat delay
{
get => orig.delay;
set => orig.delay = value;
}

public HutongGames.PlayMaker.FsmFloat time
{
get => orig.time;
set => orig.time = value;
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

public float startTime
{
get => GetField<float>();
set => SetField(value);
}

public float currentTime
{
get => GetField<float>();
set => SetField(value);
}

public UnityEngine.Color colorLerp
{
get => GetField<UnityEngine.Color>();
set => SetField(value);
}

public bool delayPassed
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

public void OnUpdate () =>
orig.OnUpdate();

public void OnGUI () =>
orig.OnGUI();

}
}
