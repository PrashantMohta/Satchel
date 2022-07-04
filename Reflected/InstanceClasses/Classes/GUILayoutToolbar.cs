namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of GUILayoutToolbar allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class GUILayoutToolbarR:InstanceClassWrapper<HutongGames.PlayMaker.Actions.GUILayoutToolbar>
{
public GUILayoutToolbarR(HutongGames.PlayMaker.Actions.GUILayoutToolbar _orig) : base(_orig) {}
public HutongGames.PlayMaker.FsmInt numButtons
{
get => orig.numButtons;
set => orig.numButtons = value;
}

public HutongGames.PlayMaker.FsmInt selectedButton
{
get => orig.selectedButton;
set => orig.selectedButton = value;
}

public HutongGames.PlayMaker.FsmEvent[] buttonEventsArray
{
get => orig.buttonEventsArray;
set => orig.buttonEventsArray = value;
}

public HutongGames.PlayMaker.FsmTexture[] imagesArray
{
get => orig.imagesArray;
set => orig.imagesArray = value;
}

public HutongGames.PlayMaker.FsmString[] textsArray
{
get => orig.textsArray;
set => orig.textsArray = value;
}

public HutongGames.PlayMaker.FsmString[] tooltipsArray
{
get => orig.tooltipsArray;
set => orig.tooltipsArray = value;
}

public HutongGames.PlayMaker.FsmString style
{
get => orig.style;
set => orig.style = value;
}

public bool everyFrame
{
get => orig.everyFrame;
set => orig.everyFrame = value;
}

public UnityEngine.GUIContent[] contents
{
get => GetField<UnityEngine.GUIContent[]>();
set => SetField(value);
}

public HutongGames.PlayMaker.LayoutOption[] layoutOptions
{
get => orig.layoutOptions;
set => orig.layoutOptions = value;
}

public UnityEngine.GUIContent[] Contents
{
get => orig.Contents;
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

public void SetButtonsContent () =>
CallMethod();

public void Reset () =>
orig.Reset();

public void OnEnter () =>
orig.OnEnter();

public void OnGUI () =>
orig.OnGUI();

public string ErrorCheck () =>
orig.ErrorCheck();

}
}
