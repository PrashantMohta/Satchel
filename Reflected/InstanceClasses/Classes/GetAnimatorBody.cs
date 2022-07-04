namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of GetAnimatorBody allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class GetAnimatorBodyR:InstanceClassWrapper<HutongGames.PlayMaker.Actions.GetAnimatorBody>
{
public GetAnimatorBodyR(HutongGames.PlayMaker.Actions.GetAnimatorBody _orig) : base(_orig) {}
public HutongGames.PlayMaker.FsmOwnerDefault gameObject
{
get => orig.gameObject;
set => orig.gameObject = value;
}

public HutongGames.PlayMaker.FsmVector3 bodyPosition
{
get => orig.bodyPosition;
set => orig.bodyPosition = value;
}

public HutongGames.PlayMaker.FsmQuaternion bodyRotation
{
get => orig.bodyRotation;
set => orig.bodyRotation = value;
}

public HutongGames.PlayMaker.FsmGameObject bodyGameObject
{
get => orig.bodyGameObject;
set => orig.bodyGameObject = value;
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

public void DoGetBodyPosition () =>
CallMethod();

}
}
