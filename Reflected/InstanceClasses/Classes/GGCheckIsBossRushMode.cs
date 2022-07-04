namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of GGCheckIsBossRushMode allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class GGCheckIsBossRushModeR:InstanceClassWrapper<GGCheckIsBossRushMode>
{
public GGCheckIsBossRushModeR(GGCheckIsBossRushMode _orig) : base(_orig) {}
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

public bool IsTrue
{
get => orig.IsTrue;
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

}
}
