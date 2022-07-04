namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of TakeScreenshot allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class TakeScreenshotR:InstanceClassWrapper<HutongGames.PlayMaker.Actions.TakeScreenshot>
{
public TakeScreenshotR(HutongGames.PlayMaker.Actions.TakeScreenshot _orig) : base(_orig) {}
public HutongGames.PlayMaker.FsmString customPath
{
get => orig.customPath;
set => orig.customPath = value;
}

public HutongGames.PlayMaker.FsmString filename
{
get => orig.filename;
set => orig.filename = value;
}

public HutongGames.PlayMaker.FsmBool autoNumber
{
get => orig.autoNumber;
set => orig.autoNumber = value;
}

public HutongGames.PlayMaker.FsmInt superSize
{
get => orig.superSize;
set => orig.superSize = value;
}

public HutongGames.PlayMaker.FsmBool debugLog
{
get => orig.debugLog;
set => orig.debugLog = value;
}

public int screenshotCount
{
get => GetField<int>();
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

}
}
