namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of GetAnimatorCurrentTransitionInfoIsName allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class GetAnimatorCurrentTransitionInfoIsNameR:InstanceClassWrapper<HutongGames.PlayMaker.Actions.GetAnimatorCurrentTransitionInfoIsName>
{
public GetAnimatorCurrentTransitionInfoIsNameR(HutongGames.PlayMaker.Actions.GetAnimatorCurrentTransitionInfoIsName _orig) : base(_orig) {}
public HutongGames.PlayMaker.FsmOwnerDefault gameObject
{
get => orig.gameObject;
set => orig.gameObject = value;
}

public HutongGames.PlayMaker.FsmInt layerIndex
{
get => orig.layerIndex;
set => orig.layerIndex = value;
}

public HutongGames.PlayMaker.FsmString name
{
get => orig.name;
set => orig.name = value;
}

public HutongGames.PlayMaker.FsmBool nameMatch
{
get => orig.nameMatch;
set => orig.nameMatch = value;
}

public HutongGames.PlayMaker.FsmEvent nameMatchEvent
{
get => orig.nameMatchEvent;
set => orig.nameMatchEvent = value;
}

public HutongGames.PlayMaker.FsmEvent nameDoNotMatchEvent
{
get => orig.nameDoNotMatchEvent;
set => orig.nameDoNotMatchEvent = value;
}

public UnityEngine.Animator _animator
{
get => GetField<UnityEngine.Animator>();
set => SetField(value);
}

public bool everyFrame
{
get => orig.everyFrame;
set => orig.everyFrame = value;
}

public int IklayerIndex
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

public void OnActionUpdate () =>
orig.OnActionUpdate();

public void IsName () =>
CallMethod();

}
}
