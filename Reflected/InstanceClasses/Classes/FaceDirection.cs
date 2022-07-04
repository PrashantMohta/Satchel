namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of FaceDirection allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class FaceDirectionR:InstanceClassWrapper<HutongGames.PlayMaker.Actions.FaceDirection>
{
public FaceDirectionR(HutongGames.PlayMaker.Actions.FaceDirection _orig) : base(_orig) {}
public HutongGames.PlayMaker.FsmOwnerDefault gameObject
{
get => orig.gameObject;
set => orig.gameObject = value;
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

public bool everyFrame
{
get => orig.everyFrame;
set => orig.everyFrame = value;
}

public bool pauseBetweenTurns
{
get => orig.pauseBetweenTurns;
set => orig.pauseBetweenTurns = value;
}

public HutongGames.PlayMaker.FsmFloat pauseTime
{
get => orig.pauseTime;
set => orig.pauseTime = value;
}

public HutongGames.PlayMaker.FsmGameObject target
{
get => GetField<HutongGames.PlayMaker.FsmGameObject>();
set => SetField(value);
}

public tk2dSpriteAnimator _sprite
{
get => GetField<tk2dSpriteAnimator>();
set => SetField(value);
}

public float xScale
{
get => GetField<float>();
set => SetField(value);
}

public float pauseTimer
{
get => GetField<float>();
set => SetField(value);
}

public UnityEngine.Rigidbody2D rb2d
{
get => GetField<UnityEngine.Rigidbody2D>();
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
