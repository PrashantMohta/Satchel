namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of ListenForLeft allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class ListenForLeftR:InstanceClassWrapper<HutongGames.PlayMaker.Actions.ListenForLeft>
{
public ListenForLeftR(HutongGames.PlayMaker.Actions.ListenForLeft _orig) : base(_orig) {}
public HutongGames.PlayMaker.FsmEventTarget eventTarget
{
get => orig.eventTarget;
set => orig.eventTarget = value;
}

public HutongGames.PlayMaker.FsmEvent wasPressed
{
get => orig.wasPressed;
set => orig.wasPressed = value;
}

public HutongGames.PlayMaker.FsmEvent wasReleased
{
get => orig.wasReleased;
set => orig.wasReleased = value;
}

public HutongGames.PlayMaker.FsmEvent isPressed
{
get => orig.isPressed;
set => orig.isPressed = value;
}

public HutongGames.PlayMaker.FsmEvent isNotPressed
{
get => orig.isNotPressed;
set => orig.isNotPressed = value;
}

public GameManager gm
{
get => GetField<GameManager>();
set => SetField(value);
}

public InputHandler inputHandler
{
get => GetField<InputHandler>();
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

}
}
