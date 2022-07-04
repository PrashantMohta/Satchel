namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of GetSpeed2d allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class GetSpeed2dR:InstanceClassWrapper<HutongGames.PlayMaker.Actions.GetSpeed2d>
{
public GetSpeed2dR(HutongGames.PlayMaker.Actions.GetSpeed2d _orig) : base(_orig) {}
public HutongGames.PlayMaker.FsmOwnerDefault gameObject
{
get => orig.gameObject;
set => orig.gameObject = value;
}

public HutongGames.PlayMaker.FsmFloat storeResult
{
get => orig.storeResult;
set => orig.storeResult = value;
}

public bool everyFrame
{
get => orig.everyFrame;
set => orig.everyFrame = value;
}

public UnityEngine.Rigidbody rigidbody
{
get => GetProperty<UnityEngine.Rigidbody>();
}

public UnityEngine.Rigidbody2D rigidbody2d
{
get => GetProperty<UnityEngine.Rigidbody2D>();
}

public UnityEngine.Renderer renderer
{
get => GetProperty<UnityEngine.Renderer>();
}

public UnityEngine.Animation animation
{
get => GetProperty<UnityEngine.Animation>();
}

public UnityEngine.AudioSource audio
{
get => GetProperty<UnityEngine.AudioSource>();
}

public UnityEngine.Camera camera
{
get => GetProperty<UnityEngine.Camera>();
}

public UnityEngine.Light light
{
get => GetProperty<UnityEngine.Light>();
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

public void DoGetSpeed () =>
CallMethod();

}
}
