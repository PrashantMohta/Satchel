namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of SmoothFollowAction allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class SmoothFollowActionR:InstanceClassWrapper<HutongGames.PlayMaker.Actions.SmoothFollowAction>
{
public SmoothFollowActionR(HutongGames.PlayMaker.Actions.SmoothFollowAction _orig) : base(_orig) {}
public HutongGames.PlayMaker.FsmOwnerDefault gameObject
{
get => orig.gameObject;
set => orig.gameObject = value;
}

public HutongGames.PlayMaker.FsmGameObject targetObject
{
get => orig.targetObject;
set => orig.targetObject = value;
}

public HutongGames.PlayMaker.FsmFloat distance
{
get => orig.distance;
set => orig.distance = value;
}

public HutongGames.PlayMaker.FsmFloat height
{
get => orig.height;
set => orig.height = value;
}

public HutongGames.PlayMaker.FsmFloat heightDamping
{
get => orig.heightDamping;
set => orig.heightDamping = value;
}

public HutongGames.PlayMaker.FsmFloat rotationDamping
{
get => orig.rotationDamping;
set => orig.rotationDamping = value;
}

public UnityEngine.GameObject cachedObject
{
get => GetField<UnityEngine.GameObject>();
set => SetField(value);
}

public UnityEngine.Transform myTransform
{
get => GetField<UnityEngine.Transform>();
set => SetField(value);
}

public UnityEngine.GameObject cachedTarget
{
get => GetField<UnityEngine.GameObject>();
set => SetField(value);
}

public UnityEngine.Transform targetTransform
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

public void OnLateUpdate () =>
orig.OnLateUpdate();

}
}
