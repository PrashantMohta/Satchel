namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of SetFsmVariable allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class SetFsmVariableR:InstanceClassWrapper<HutongGames.PlayMaker.Actions.SetFsmVariable>
{
public SetFsmVariableR(HutongGames.PlayMaker.Actions.SetFsmVariable _orig) : base(_orig) {}
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

public HutongGames.PlayMaker.FsmString variableName
{
get => orig.variableName;
set => orig.variableName = value;
}

public HutongGames.PlayMaker.FsmVar setValue
{
get => orig.setValue;
set => orig.setValue = value;
}

public bool everyFrame
{
get => orig.everyFrame;
set => orig.everyFrame = value;
}

public PlayMakerFSM targetFsm
{
get => GetField<PlayMakerFSM>();
set => SetField(value);
}

public HutongGames.PlayMaker.NamedVariable targetVariable
{
get => GetField<HutongGames.PlayMaker.NamedVariable>();
set => SetField(value);
}

public HutongGames.PlayMaker.INamedVariable sourceVariable
{
get => GetField<HutongGames.PlayMaker.INamedVariable>();
set => SetField(value);
}

public UnityEngine.GameObject cachedGameObject
{
get => GetField<UnityEngine.GameObject>();
set => SetField(value);
}

public string cachedFsmName
{
get => GetField<string>();
set => SetField(value);
}

public string cachedVariableName
{
get => GetField<string>();
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

public void DoSetFsmVariable () =>
CallMethod();

}
}
