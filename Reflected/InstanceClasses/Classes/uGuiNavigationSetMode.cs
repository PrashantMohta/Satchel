namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of uGuiNavigationSetMode allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class uGuiNavigationSetModeR:InstanceClassWrapper<HutongGames.PlayMaker.Actions.uGuiNavigationSetMode>
{
public uGuiNavigationSetModeR(HutongGames.PlayMaker.Actions.uGuiNavigationSetMode _orig) : base(_orig) {}
public HutongGames.PlayMaker.FsmOwnerDefault gameObject
{
get => orig.gameObject;
set => orig.gameObject = value;
}

public HutongGames.PlayMaker.FsmBool resetOnExit
{
get => orig.resetOnExit;
set => orig.resetOnExit = value;
}

public UnityEngine.UI.Selectable _selectable
{
get => GetField<UnityEngine.UI.Selectable>();
set => SetField(value);
}

public UnityEngine.UI.Navigation _navigation
{
get => GetField<UnityEngine.UI.Navigation>();
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

public void DoSetValue () =>
CallMethod();

public void OnExit () =>
orig.OnExit();

}
}
