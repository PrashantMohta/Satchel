namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of SendRandomEventV3 allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class SendRandomEventV3R:InstanceClassWrapper<HutongGames.PlayMaker.Actions.SendRandomEventV3>
{
public SendRandomEventV3R(HutongGames.PlayMaker.Actions.SendRandomEventV3 _orig) : base(_orig) {}
public HutongGames.PlayMaker.FsmEvent[] events
{
get => orig.events;
set => orig.events = value;
}

public HutongGames.PlayMaker.FsmFloat[] weights
{
get => orig.weights;
set => orig.weights = value;
}

public HutongGames.PlayMaker.FsmInt[] trackingInts
{
get => orig.trackingInts;
set => orig.trackingInts = value;
}

public HutongGames.PlayMaker.FsmInt[] eventMax
{
get => orig.eventMax;
set => orig.eventMax = value;
}

public HutongGames.PlayMaker.FsmInt[] trackingIntsMissed
{
get => orig.trackingIntsMissed;
set => orig.trackingIntsMissed = value;
}

public HutongGames.PlayMaker.FsmInt[] missedMax
{
get => orig.missedMax;
set => orig.missedMax = value;
}

public int loops
{
get => GetField<int>();
set => SetField(value);
}

public HutongGames.PlayMaker.DelayedEvent delayedEvent
{
get => GetField<HutongGames.PlayMaker.DelayedEvent>();
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

}
}
