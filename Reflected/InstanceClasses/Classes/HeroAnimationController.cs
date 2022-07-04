namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of HeroAnimationController allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class HeroAnimationControllerR:InstanceClassWrapper<HeroAnimationController>
{
public HeroAnimationControllerR(HeroAnimationController _orig) : base(_orig) {}
public tk2dSpriteAnimator animator
{
get => orig.animator;
set => orig.animator = value;
}

public HeroController heroCtrl
{
get => GetField<HeroController>();
set => SetField(value);
}

public HeroControllerStates cState
{
get => GetField<HeroControllerStates>();
set => SetField(value);
}

public PlayerData pd
{
get => GetField<PlayerData>();
set => SetField(value);
}

public bool playLanding
{
get => orig.playLanding;
set => orig.playLanding = value;
}

public bool playRunToIdle
{
get => GetField<bool>();
set => SetField(value);
}

public bool playDashToIdle
{
get => GetField<bool>();
set => SetField(value);
}

public bool playBackDashToIdleEnd
{
get => GetField<bool>();
set => SetField(value);
}

public bool wasAttacking
{
get => orig.wasAttacking;
set => orig.wasAttacking = value;
}

public bool wasFacingRight
{
get => GetField<bool>();
set => SetField(value);
}

public bool setEntryAnim
{
get => orig.setEntryAnim;
set => orig.setEntryAnim = value;
}

public bool changedClipFromLastFrame
{
get => GetField<bool>();
set => SetField(value);
}

public bool attackComplete
{
get => GetField<bool>();
set => SetField(value);
}

public GlobalEnums.ActorStates actorState
{
get => orig.actorState;
set => SetProperty(value);
}

public GlobalEnums.ActorStates prevActorState
{
get => orig.prevActorState;
set => SetProperty(value);
}

public GlobalEnums.ActorStates stateBeforeControl
{
get => orig.stateBeforeControl;
set => SetProperty(value);
}

public bool controlEnabled
{
get => orig.controlEnabled;
set => SetProperty(value);
}



public void Awake () =>
CallMethod();

public void Start () =>
CallMethod();

public void Update () =>
CallMethod();

public void ResetAll () =>
CallMethod();

public void ResetPlays () =>
CallMethod();

public void UpdateState (GlobalEnums.ActorStates newState) =>
orig.UpdateState(newState);

public void PlayClip (string clipName) =>
orig.PlayClip(clipName);

public void UpdateAnimation () =>
CallMethod();

public bool CanPlayIdle () =>
CallMethod<bool>();

public bool CanPlayLookDown () =>
CallMethod<bool>();

public bool canPlayTurn () =>
CallMethod<bool>();

public void AnimationCompleteDelegate (tk2dSpriteAnimator sprite, tk2dSpriteAnimationClip clip) =>
CallMethod(new object[] {sprite, clip});

public void PlayIdle () =>
orig.PlayIdle();

public void PlayRun () =>
CallMethod();

public void Play (string clipName) =>
CallMethod(new object[] {clipName});

public void PlayFromFrame (string clipName, int frame) =>
CallMethod(new object[] {clipName, frame});

public void StopControl () =>
orig.StopControl();

public void StartControl () =>
orig.StartControl();

public void StartControlWithoutSettingState () =>
orig.StartControlWithoutSettingState();

public void FinishedDash () =>
orig.FinishedDash();

public void StopAttack () =>
orig.StopAttack();

public float GetCurrentClipDuration () =>
orig.GetCurrentClipDuration();

public float GetClipDuration (string clipName) =>
orig.GetClipDuration(clipName);

}
}
