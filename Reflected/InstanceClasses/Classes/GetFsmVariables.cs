namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of GetFsmVariables allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class GetFsmVariablesR:InstanceClassWrapper<HutongGames.PlayMaker.Actions.GetFsmVariables>
{
public GetFsmVariablesR(HutongGames.PlayMaker.Actions.GetFsmVariables _orig) : base(_orig) {}
public HutongGames.PlayMaker.FsmOwnerDefault gameObject
{
get => orig.gameObject;
set => orig.gameObject = value;
}

public HutongGames.PlayMaker.FsmString fsmName
{
get => orig.fsmName;
set => orig.fsmName = value;
}

public HutongGames.PlayMaker.FsmVar[] getVariables
{
get => orig.getVariables;
set => orig.getVariables = value;
}

public bool everyFrame
{
get => orig.everyFrame;
set => orig.everyFrame = value;
}

public UnityEngine.GameObject cachedGO
{
get => GetField<UnityEngine.GameObject>();
set => SetField(value);
}

public PlayMakerFSM sourceFsm
{
get => GetField<PlayMakerFSM>();
set => SetField(value);
}

public HutongGames.PlayMaker.INamedVariable[] sourceVariables
{
get => GetField<HutongGames.PlayMaker.INamedVariable[]>();
set => SetField(value);
}

public HutongGames.PlayMaker.NamedVariable[] targetVariables
{
get => GetField<HutongGames.PlayMaker.NamedVariable[]>();
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

public void InitFsmVars () =>
CallMethod();

public void OnEnter () =>
orig.OnEnter();

public void OnUpdate () =>
orig.OnUpdate();

public void DoGetFsmVariables () =>
CallMethod();

}
}
