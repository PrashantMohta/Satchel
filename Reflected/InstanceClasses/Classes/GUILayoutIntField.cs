namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of GUILayoutIntField allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class GUILayoutIntFieldR:InstanceClassWrapper<HutongGames.PlayMaker.Actions.GUILayoutIntField>
{
public GUILayoutIntFieldR(HutongGames.PlayMaker.Actions.GUILayoutIntField _orig) : base(_orig) {}
public HutongGames.PlayMaker.FsmInt intVariable
{
get => orig.intVariable;
set => orig.intVariable = value;
}

public HutongGames.PlayMaker.FsmString style
{
get => orig.style;
set => orig.style = value;
}

public HutongGames.PlayMaker.FsmEvent changedEvent
{
get => orig.changedEvent;
set => orig.changedEvent = value;
}

public HutongGames.PlayMaker.LayoutOption[] layoutOptions
{
get => orig.layoutOptions;
set => orig.layoutOptions = value;
}

public UnityEngine.GUILayoutOption[] LayoutOptions
{
get => orig.LayoutOptions;
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

public void OnGUI () =>
orig.OnGUI();

}
}
