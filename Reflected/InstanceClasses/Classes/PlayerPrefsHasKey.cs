namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of PlayerPrefsHasKey allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class PlayerPrefsHasKeyR:InstanceClassWrapper<HutongGames.PlayMaker.Actions.PlayerPrefsHasKey>
{
public PlayerPrefsHasKeyR(HutongGames.PlayMaker.Actions.PlayerPrefsHasKey _orig) : base(_orig) {}
public HutongGames.PlayMaker.FsmString key
{
get => orig.key;
set => orig.key = value;
}

public HutongGames.PlayMaker.FsmBool variable
{
get => orig.variable;
set => orig.variable = value;
}

public HutongGames.PlayMaker.FsmEvent trueEvent
{
get => orig.trueEvent;
set => orig.trueEvent = value;
}

public HutongGames.PlayMaker.FsmEvent falseEvent
{
get => orig.falseEvent;
set => orig.falseEvent = value;
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
