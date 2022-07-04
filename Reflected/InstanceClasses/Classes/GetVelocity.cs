namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of GetVelocity allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class GetVelocityR:InstanceClassWrapper<HutongGames.PlayMaker.Actions.GetVelocity>
{
public GetVelocityR(HutongGames.PlayMaker.Actions.GetVelocity _orig) : base(_orig) {}
public HutongGames.PlayMaker.FsmOwnerDefault gameObject
{
get => orig.gameObject;
set => orig.gameObject = value;
}

public HutongGames.PlayMaker.FsmVector3 vector
{
get => orig.vector;
set => orig.vector = value;
}

public HutongGames.PlayMaker.FsmFloat x
{
get => orig.x;
set => orig.x = value;
}

public HutongGames.PlayMaker.FsmFloat y
{
get => orig.y;
set => orig.y = value;
}

public HutongGames.PlayMaker.FsmFloat z
{
get => orig.z;
set => orig.z = value;
}

public UnityEngine.Space space
{
get => orig.space;
set => orig.space = value;
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

public void DoGetVelocity () =>
CallMethod();

}
}
