namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of GUILayoutBeginArea allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class GUILayoutBeginAreaR:InstanceClassWrapper<HutongGames.PlayMaker.Actions.GUILayoutBeginArea>
{
public GUILayoutBeginAreaR(HutongGames.PlayMaker.Actions.GUILayoutBeginArea _orig) : base(_orig) {}
public HutongGames.PlayMaker.FsmRect screenRect
{
get => orig.screenRect;
set => orig.screenRect = value;
}

public HutongGames.PlayMaker.FsmFloat left
{
get => orig.left;
set => orig.left = value;
}

public HutongGames.PlayMaker.FsmFloat top
{
get => orig.top;
set => orig.top = value;
}

public HutongGames.PlayMaker.FsmFloat width
{
get => orig.width;
set => orig.width = value;
}

public HutongGames.PlayMaker.FsmFloat height
{
get => orig.height;
set => orig.height = value;
}

public HutongGames.PlayMaker.FsmBool normalized
{
get => orig.normalized;
set => orig.normalized = value;
}

public HutongGames.PlayMaker.FsmString style
{
get => orig.style;
set => orig.style = value;
}

public UnityEngine.Rect rect
{
get => GetField<UnityEngine.Rect>();
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

public void OnGUI () =>
orig.OnGUI();

}
}
