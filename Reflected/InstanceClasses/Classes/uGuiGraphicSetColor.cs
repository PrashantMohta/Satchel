namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of uGuiGraphicSetColor allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class uGuiGraphicSetColorR:InstanceClassWrapper<HutongGames.PlayMaker.Actions.uGuiGraphicSetColor>
{
public uGuiGraphicSetColorR(HutongGames.PlayMaker.Actions.uGuiGraphicSetColor _orig) : base(_orig) {}
public HutongGames.PlayMaker.FsmOwnerDefault gameObject
{
get => orig.gameObject;
set => orig.gameObject = value;
}

public HutongGames.PlayMaker.FsmColor color
{
get => orig.color;
set => orig.color = value;
}

public HutongGames.PlayMaker.FsmFloat red
{
get => orig.red;
set => orig.red = value;
}

public HutongGames.PlayMaker.FsmFloat green
{
get => orig.green;
set => orig.green = value;
}

public HutongGames.PlayMaker.FsmFloat blue
{
get => orig.blue;
set => orig.blue = value;
}

public HutongGames.PlayMaker.FsmFloat alpha
{
get => orig.alpha;
set => orig.alpha = value;
}

public HutongGames.PlayMaker.FsmBool resetOnExit
{
get => orig.resetOnExit;
set => orig.resetOnExit = value;
}

public bool everyFrame
{
get => orig.everyFrame;
set => orig.everyFrame = value;
}

public UnityEngine.UI.Graphic _component
{
get => GetField<UnityEngine.UI.Graphic>();
set => SetField(value);
}

public UnityEngine.Color _originalColor
{
get => GetField<UnityEngine.Color>();
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

public void DoSetColorValue () =>
CallMethod();

public void OnExit () =>
orig.OnExit();

}
}
