namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of SetAnimatorStabilizeFeet allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class SetAnimatorStabilizeFeetR:InstanceClassWrapper<HutongGames.PlayMaker.Actions.SetAnimatorStabilizeFeet>
{
public SetAnimatorStabilizeFeetR(HutongGames.PlayMaker.Actions.SetAnimatorStabilizeFeet _orig) : base(_orig) {}
public HutongGames.PlayMaker.FsmOwnerDefault gameObject
{
get => orig.gameObject;
set => orig.gameObject = value;
}

public HutongGames.PlayMaker.FsmBool stabilizeFeet
{
get => orig.stabilizeFeet;
set => orig.stabilizeFeet = value;
}

public UnityEngine.Animator _animator
{
get => GetField<UnityEngine.Animator>();
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

public void DoStabilizeFeet () =>
CallMethod();

}
}
