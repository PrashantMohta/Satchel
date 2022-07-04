namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of TriggerEnterEventSubscribe allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class TriggerEnterEventSubscribeR:InstanceClassWrapper<TriggerEnterEventSubscribe>
{
public TriggerEnterEventSubscribeR(TriggerEnterEventSubscribe _orig) : base(_orig) {}
public HutongGames.PlayMaker.FsmObject trigger
{
get => orig.trigger;
set => orig.trigger = value;
}

public HutongGames.PlayMaker.FsmEvent triggerEnteredEvent
{
get => orig.triggerEnteredEvent;
set => orig.triggerEnteredEvent = value;
}

public HutongGames.PlayMaker.FsmEvent triggerExitedEvent
{
get => orig.triggerExitedEvent;
set => orig.triggerExitedEvent = value;
}

public HutongGames.PlayMaker.FsmEvent triggerStayedEvent
{
get => orig.triggerStayedEvent;
set => orig.triggerStayedEvent = value;
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

public void SendEnteredEvent (UnityEngine.Collider2D collider, UnityEngine.GameObject sender) =>
CallMethod(new object[] {collider, sender});

public void SendExitedEvent (UnityEngine.Collider2D collider, UnityEngine.GameObject sender) =>
CallMethod(new object[] {collider, sender});

public void SendStayedEvent (UnityEngine.Collider2D collider, UnityEngine.GameObject sender) =>
CallMethod(new object[] {collider, sender});

}
}
