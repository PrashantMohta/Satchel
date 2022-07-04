namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of ScreenSetResolution allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class ScreenSetResolutionR:InstanceClassWrapper<HutongGames.PlayMaker.Actions.ScreenSetResolution>
{
public ScreenSetResolutionR(HutongGames.PlayMaker.Actions.ScreenSetResolution _orig) : base(_orig) {}
public HutongGames.PlayMaker.FsmBool fullScreen
{
get => orig.fullScreen;
set => orig.fullScreen = value;
}

public HutongGames.PlayMaker.FsmInt width
{
get => orig.width;
set => orig.width = value;
}

public HutongGames.PlayMaker.FsmInt height
{
get => orig.height;
set => orig.height = value;
}

public HutongGames.PlayMaker.FsmInt preferedRefreshRate
{
get => orig.preferedRefreshRate;
set => orig.preferedRefreshRate = value;
}

public HutongGames.PlayMaker.FsmVector3 orResolution
{
get => orig.orResolution;
set => orig.orResolution = value;
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
