namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of SetAnimatorLookAt allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class SetAnimatorLookAtR:InstanceClassWrapper<HutongGames.PlayMaker.Actions.SetAnimatorLookAt>
{
public SetAnimatorLookAtR(HutongGames.PlayMaker.Actions.SetAnimatorLookAt _orig) : base(_orig) {}
public HutongGames.PlayMaker.FsmOwnerDefault gameObject
{
get => orig.gameObject;
set => orig.gameObject = value;
}

public HutongGames.PlayMaker.FsmGameObject target
{
get => orig.target;
set => orig.target = value;
}

public HutongGames.PlayMaker.FsmVector3 targetPosition
{
get => orig.targetPosition;
set => orig.targetPosition = value;
}

public HutongGames.PlayMaker.FsmFloat weight
{
get => orig.weight;
set => orig.weight = value;
}

public HutongGames.PlayMaker.FsmFloat bodyWeight
{
get => orig.bodyWeight;
set => orig.bodyWeight = value;
}

public HutongGames.PlayMaker.FsmFloat headWeight
{
get => orig.headWeight;
set => orig.headWeight = value;
}

public HutongGames.PlayMaker.FsmFloat eyesWeight
{
get => orig.eyesWeight;
set => orig.eyesWeight = value;
}

public HutongGames.PlayMaker.FsmFloat clampWeight
{
get => orig.clampWeight;
set => orig.clampWeight = value;
}

public bool everyFrame
{
get => orig.everyFrame;
set => orig.everyFrame = value;
}

public UnityEngine.Animator _animator
{
get => GetField<UnityEngine.Animator>();
set => SetField(value);
}

public UnityEngine.Transform _transform
{
get => GetField<UnityEngine.Transform>();
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

public void OnPreprocess () =>
orig.OnPreprocess();

public void OnEnter () =>
orig.OnEnter();

public void DoAnimatorIK (int layerIndex) =>
orig.DoAnimatorIK(layerIndex);

public void DoSetLookAt () =>
CallMethod();

}
}
