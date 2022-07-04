namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of Walker allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class WalkerR:InstanceClassWrapper<Walker>
{
public WalkerR(Walker _orig) : base(_orig) {}
public LineOfSightDetector lineOfSightDetector
{
get => GetField<LineOfSightDetector>();
set => SetField(value);
}

public AlertRange alertRange
{
get => GetField<AlertRange>();
set => SetField(value);
}

public UnityEngine.Rigidbody2D body
{
get => GetField<UnityEngine.Rigidbody2D>();
set => SetField(value);
}

public UnityEngine.Collider2D bodyCollider
{
get => GetField<UnityEngine.Collider2D>();
set => SetField(value);
}

public tk2dSpriteAnimator animator
{
get => GetField<tk2dSpriteAnimator>();
set => SetField(value);
}

public UnityEngine.AudioSource audioSource
{
get => GetField<UnityEngine.AudioSource>();
set => SetField(value);
}

public UnityEngine.Camera mainCamera
{
get => GetField<UnityEngine.Camera>();
set => SetField(value);
}

public HeroController hero
{
get => GetField<HeroController>();
set => SetField(value);
}

public float CameraDistanceForActivation
{
get => GetFieldStatic<float>();
set => SetField(value);
}

public float WaitHeroXThreshold
{
get => GetFieldStatic<float>();
set => SetField(value);
}

public bool ambush
{
get => GetField<bool>();
set => SetField(value);
}

public string idleClip
{
get => GetField<string>();
set => SetField(value);
}

public string turnClip
{
get => GetField<string>();
set => SetField(value);
}

public string walkClip
{
get => GetField<string>();
set => SetField(value);
}

public float edgeXAdjuster
{
get => GetField<float>();
set => SetField(value);
}

public bool preventScaleChange
{
get => GetField<bool>();
set => SetField(value);
}

public bool preventTurn
{
get => GetField<bool>();
set => SetField(value);
}

public float pauseTimeMin
{
get => GetField<float>();
set => SetField(value);
}

public float pauseTimeMax
{
get => GetField<float>();
set => SetField(value);
}

public float pauseWaitMin
{
get => GetField<float>();
set => SetField(value);
}

public float pauseWaitMax
{
get => GetField<float>();
set => SetField(value);
}

public bool pauses
{
get => GetField<bool>();
set => SetField(value);
}

public float rightScale
{
get => GetField<float>();
set => SetField(value);
}

public bool startInactive
{
get => orig.startInactive;
set => orig.startInactive = value;
}

public int turnAfterIdlePercentage
{
get => GetField<int>();
set => SetField(value);
}

public float turnPause
{
get => GetField<float>();
set => SetField(value);
}

public bool waitForHeroX
{
get => GetField<bool>();
set => SetField(value);
}

public float waitHeroX
{
get => GetField<float>();
set => SetField(value);
}

public float walkSpeedL
{
get => orig.walkSpeedL;
set => orig.walkSpeedL = value;
}

public float walkSpeedR
{
get => orig.walkSpeedR;
set => orig.walkSpeedR = value;
}

public bool ignoreHoles
{
get => orig.ignoreHoles;
set => orig.ignoreHoles = value;
}

public bool preventTurningToFaceHero
{
get => GetField<bool>();
set => SetField(value);
}

public bool didFulfilCameraDistanceCondition
{
get => GetField<bool>();
set => SetField(value);
}

public bool didFulfilHeroXCondition
{
get => GetField<bool>();
set => SetField(value);
}

public int currentFacing
{
get => GetField<int>();
set => SetField(value);
}

public int turningFacing
{
get => GetField<int>();
set => SetField(value);
}

public float walkTimeRemaining
{
get => GetField<float>();
set => SetField(value);
}

public float pauseTimeRemaining
{
get => GetField<float>();
set => SetField(value);
}

public float turnCooldownRemaining
{
get => GetField<float>();
set => SetField(value);
}



public void Awake () =>
CallMethod();

public void Start () =>
CallMethod();

public void Update () =>
CallMethod();

public void StartMoving () =>
orig.StartMoving();

public void CancelTurn () =>
orig.CancelTurn();

public void Go (int facing) =>
orig.Go(facing);

public void RecieveGoMessage (int facing) =>
orig.RecieveGoMessage(facing);

public void Stop (Walker.StopReasons reason) =>
orig.Stop(reason);

public void ChangeFacing (int facing) =>
orig.ChangeFacing(facing);

public void BeginWaitingForConditions () =>
CallMethod();

public void UpdateWaitingForConditions () =>
CallMethod();

public void BeginStopped (Walker.StopReasons reason) =>
CallMethod(new object[] {reason});

public void UpdateStopping () =>
CallMethod();

public void EndStopping () =>
CallMethod();

public void BeginWalkingOrTurning (int facing) =>
CallMethod(new object[] {facing});

public void BeginWalking (int facing) =>
CallMethod(new object[] {facing});

public void UpdateWalking () =>
CallMethod();

public void BeginTurning (int facing) =>
CallMethod(new object[] {facing});

public void UpdateTurning () =>
CallMethod();

public void EndTurning () =>
CallMethod();

public void ClearTurnCooldown () =>
orig.ClearTurnCooldown();

}
}
