namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of GrimmChildFly allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class GrimmChildFlyR:InstanceClassWrapper<HutongGames.PlayMaker.Actions.GrimmChildFly>
{
public GrimmChildFlyR(HutongGames.PlayMaker.Actions.GrimmChildFly _orig) : base(_orig) {}
public HutongGames.PlayMaker.FsmGameObject objectA
{
get => orig.objectA;
set => orig.objectA = value;
}

public HutongGames.PlayMaker.FsmGameObject objectB
{
get => orig.objectB;
set => orig.objectB = value;
}

public HutongGames.PlayMaker.FsmBool spriteFacesRight
{
get => orig.spriteFacesRight;
set => orig.spriteFacesRight = value;
}

public bool playNewAnimation
{
get => orig.playNewAnimation;
set => orig.playNewAnimation = value;
}

public HutongGames.PlayMaker.FsmString newAnimationClip
{
get => orig.newAnimationClip;
set => orig.newAnimationClip = value;
}

public bool resetFrame
{
get => orig.resetFrame;
set => orig.resetFrame = value;
}

public HutongGames.PlayMaker.FsmFloat fastAnimSpeed
{
get => orig.fastAnimSpeed;
set => orig.fastAnimSpeed = value;
}

public HutongGames.PlayMaker.FsmString fastAnimationClip
{
get => orig.fastAnimationClip;
set => orig.fastAnimationClip = value;
}

public HutongGames.PlayMaker.FsmString normalAnimationClip
{
get => orig.normalAnimationClip;
set => orig.normalAnimationClip = value;
}

public HutongGames.PlayMaker.FsmFloat pauseBetweenAnimChange
{
get => orig.pauseBetweenAnimChange;
set => orig.pauseBetweenAnimChange = value;
}

public float xScale
{
get => GetField<float>();
set => SetField(value);
}

public bool flyingFast
{
get => orig.flyingFast;
set => orig.flyingFast = value;
}

public HutongGames.PlayMaker.FsmVector3 vector
{
get => GetField<HutongGames.PlayMaker.FsmVector3>();
set => SetField(value);
}

public tk2dSpriteAnimator _sprite
{
get => GetField<tk2dSpriteAnimator>();
set => SetField(value);
}

public UnityEngine.Rigidbody2D rb2d
{
get => GetField<UnityEngine.Rigidbody2D>();
set => SetField(value);
}

public float timer
{
get => GetField<float>();
set => SetField(value);
}

public bool animatingFast
{
get => GetField<bool>();
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

public void DoFace () =>
CallMethod();

}
}
