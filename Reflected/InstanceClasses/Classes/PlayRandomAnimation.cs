namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of PlayRandomAnimation allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class PlayRandomAnimationR:InstanceClassWrapper<HutongGames.PlayMaker.Actions.PlayRandomAnimation>
{
public PlayRandomAnimationR(HutongGames.PlayMaker.Actions.PlayRandomAnimation _orig) : base(_orig) {}
public HutongGames.PlayMaker.FsmOwnerDefault gameObject
{
get => orig.gameObject;
set => orig.gameObject = value;
}

public HutongGames.PlayMaker.FsmString[] animations
{
get => orig.animations;
set => orig.animations = value;
}

public HutongGames.PlayMaker.FsmFloat[] weights
{
get => orig.weights;
set => orig.weights = value;
}

public UnityEngine.PlayMode playMode
{
get => orig.playMode;
set => orig.playMode = value;
}

public HutongGames.PlayMaker.FsmFloat blendTime
{
get => orig.blendTime;
set => orig.blendTime = value;
}

public HutongGames.PlayMaker.FsmEvent finishEvent
{
get => orig.finishEvent;
set => orig.finishEvent = value;
}

public HutongGames.PlayMaker.FsmEvent loopEvent
{
get => orig.loopEvent;
set => orig.loopEvent = value;
}

public bool stopOnExit
{
get => orig.stopOnExit;
set => orig.stopOnExit = value;
}

public UnityEngine.AnimationState anim
{
get => GetField<UnityEngine.AnimationState>();
set => SetField(value);
}

public float prevAnimtTime
{
get => GetField<float>();
set => SetField(value);
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

public void DoPlayRandomAnimation () =>
CallMethod();

public void DoPlayAnimation (string animName) =>
CallMethod(new object[] {animName});

public void OnUpdate () =>
orig.OnUpdate();

public void OnExit () =>
orig.OnExit();

public void StopAnimation () =>
CallMethod();

}
}
