namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of Tk2dPlayAnimationWithEvents allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class Tk2dPlayAnimationWithEventsR:InstanceClassWrapper<HutongGames.PlayMaker.Actions.Tk2dPlayAnimationWithEvents>
{
public Tk2dPlayAnimationWithEventsR(HutongGames.PlayMaker.Actions.Tk2dPlayAnimationWithEvents _orig) : base(_orig) {}
public HutongGames.PlayMaker.FsmOwnerDefault gameObject
{
get => orig.gameObject;
set => orig.gameObject = value;
}

public HutongGames.PlayMaker.FsmString clipName
{
get => orig.clipName;
set => orig.clipName = value;
}

public HutongGames.PlayMaker.FsmEvent animationTriggerEvent
{
get => orig.animationTriggerEvent;
set => orig.animationTriggerEvent = value;
}

public HutongGames.PlayMaker.FsmEvent animationCompleteEvent
{
get => orig.animationCompleteEvent;
set => orig.animationCompleteEvent = value;
}

public tk2dSpriteAnimator _sprite
{
get => GetField<tk2dSpriteAnimator>();
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

public void _getSprite () =>
CallMethod();

public void Reset () =>
orig.Reset();

public void OnEnter () =>
orig.OnEnter();

public void DoPlayAnimationWithEvents () =>
CallMethod();

public void AnimationEventDelegate (tk2dSpriteAnimator sprite, tk2dSpriteAnimationClip clip, int frameNum) =>
CallMethod(new object[] {sprite, clip, frameNum});

public void AnimationCompleteDelegate (tk2dSpriteAnimator sprite, tk2dSpriteAnimationClip clip) =>
CallMethod(new object[] {sprite, clip});

}
}
