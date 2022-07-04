namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of uGuiNavigationGetMode allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class uGuiNavigationGetModeR:InstanceClassWrapper<HutongGames.PlayMaker.Actions.uGuiNavigationGetMode>
{
public uGuiNavigationGetModeR(HutongGames.PlayMaker.Actions.uGuiNavigationGetMode _orig) : base(_orig) {}
public HutongGames.PlayMaker.FsmOwnerDefault gameObject
{
get => orig.gameObject;
set => orig.gameObject = value;
}

public HutongGames.PlayMaker.FsmString navigationMode
{
get => orig.navigationMode;
set => orig.navigationMode = value;
}

public HutongGames.PlayMaker.FsmEvent automaticEvent
{
get => orig.automaticEvent;
set => orig.automaticEvent = value;
}

public HutongGames.PlayMaker.FsmEvent horizontalEvent
{
get => orig.horizontalEvent;
set => orig.horizontalEvent = value;
}

public HutongGames.PlayMaker.FsmEvent verticalEvent
{
get => orig.verticalEvent;
set => orig.verticalEvent = value;
}

public HutongGames.PlayMaker.FsmEvent explicitEvent
{
get => orig.explicitEvent;
set => orig.explicitEvent = value;
}

public HutongGames.PlayMaker.FsmEvent noNavigationEvent
{
get => orig.noNavigationEvent;
set => orig.noNavigationEvent = value;
}

public UnityEngine.UI.Selectable _selectable
{
get => GetField<UnityEngine.UI.Selectable>();
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

public void DoGetValue () =>
CallMethod();

}
}
