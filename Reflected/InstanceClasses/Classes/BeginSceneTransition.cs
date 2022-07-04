namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of BeginSceneTransition allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class BeginSceneTransitionR:InstanceClassWrapper<HutongGames.PlayMaker.Actions.BeginSceneTransition>
{
public BeginSceneTransitionR(HutongGames.PlayMaker.Actions.BeginSceneTransition _orig) : base(_orig) {}
public HutongGames.PlayMaker.FsmString sceneName
{
get => orig.sceneName;
set => orig.sceneName = value;
}

public HutongGames.PlayMaker.FsmString entryGateName
{
get => orig.entryGateName;
set => orig.entryGateName = value;
}

public HutongGames.PlayMaker.FsmFloat entryDelay
{
get => orig.entryDelay;
set => orig.entryDelay = value;
}

public HutongGames.PlayMaker.FsmEnum visualization
{
get => orig.visualization;
set => orig.visualization = value;
}

public bool preventCameraFadeOut
{
get => orig.preventCameraFadeOut;
set => orig.preventCameraFadeOut = value;
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
