namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of CameraTarget allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class CameraTargetR:InstanceClassWrapper<CameraTarget>
{
public CameraTargetR(CameraTarget _orig) : base(_orig) {}
public bool verboseMode
{
get => GetField<bool>();
set => SetField(value);
}

public GameManager gm
{
get => orig.gm;
set => orig.gm = value;
}

public HeroController hero_ctrl
{
get => orig.hero_ctrl;
set => orig.hero_ctrl = value;
}

public UnityEngine.Transform heroTransform
{
get => GetField<UnityEngine.Transform>();
set => SetField(value);
}

public CameraController cameraCtrl
{
get => orig.cameraCtrl;
set => orig.cameraCtrl = value;
}

public UnityEngine.Vector3 destination
{
get => orig.destination;
set => orig.destination = value;
}

public UnityEngine.Vector3 velocityX
{
get => GetField<UnityEngine.Vector3>();
set => SetField(value);
}

public UnityEngine.Vector3 velocityY
{
get => GetField<UnityEngine.Vector3>();
set => SetField(value);
}

public float xOffset
{
get => orig.xOffset;
set => orig.xOffset = value;
}

public float dashOffset
{
get => orig.dashOffset;
set => orig.dashOffset = value;
}

public float fallOffset
{
get => orig.fallOffset;
set => orig.fallOffset = value;
}

public float fallOffset_multiplier
{
get => orig.fallOffset_multiplier;
set => orig.fallOffset_multiplier = value;
}

public float xLockMin
{
get => orig.xLockMin;
set => orig.xLockMin = value;
}

public float xLockMax
{
get => orig.xLockMax;
set => orig.xLockMax = value;
}

public float yLockMin
{
get => orig.yLockMin;
set => orig.yLockMin = value;
}

public float yLockMax
{
get => orig.yLockMax;
set => orig.yLockMax = value;
}

public bool enteredLeft
{
get => orig.enteredLeft;
set => orig.enteredLeft = value;
}

public bool enteredRight
{
get => orig.enteredRight;
set => orig.enteredRight = value;
}

public bool enteredTop
{
get => orig.enteredTop;
set => orig.enteredTop = value;
}

public bool enteredBot
{
get => orig.enteredBot;
set => orig.enteredBot = value;
}

public bool exitedLeft
{
get => orig.exitedLeft;
set => orig.exitedLeft = value;
}

public bool exitedRight
{
get => orig.exitedRight;
set => orig.exitedRight = value;
}

public bool exitedTop
{
get => orig.exitedTop;
set => orig.exitedTop = value;
}

public bool exitedBot
{
get => orig.exitedBot;
set => orig.exitedBot = value;
}

public bool superDashing
{
get => orig.superDashing;
set => orig.superDashing = value;
}

public bool quaking
{
get => orig.quaking;
set => orig.quaking = value;
}

public float slowTime
{
get => orig.slowTime;
set => orig.slowTime = value;
}

public float dampTimeNormal
{
get => orig.dampTimeNormal;
set => orig.dampTimeNormal = value;
}

public float dampTimeSlow
{
get => orig.dampTimeSlow;
set => orig.dampTimeSlow = value;
}

public float xLookAhead
{
get => orig.xLookAhead;
set => orig.xLookAhead = value;
}

public float dashLookAhead
{
get => orig.dashLookAhead;
set => orig.dashLookAhead = value;
}

public float superDashLookAhead
{
get => orig.superDashLookAhead;
set => orig.superDashLookAhead = value;
}

public UnityEngine.Vector3 heroPrevPosition
{
get => GetField<UnityEngine.Vector3>();
set => SetField(value);
}

public float dampTime
{
get => GetField<float>();
set => SetField(value);
}

public float dampTimeX
{
get => GetField<float>();
set => SetField(value);
}

public float dampTimeY
{
get => GetField<float>();
set => SetField(value);
}

public float slowTimer
{
get => GetField<float>();
set => SetField(value);
}

public float snapDistance
{
get => GetField<float>();
set => SetField(value);
}

public float fallCatcher
{
get => orig.fallCatcher;
set => orig.fallCatcher = value;
}

public bool stickToHeroX
{
get => orig.stickToHeroX;
set => orig.stickToHeroX = value;
}

public bool stickToHeroY
{
get => orig.stickToHeroY;
set => orig.stickToHeroY = value;
}

public bool enteredFromLockZone
{
get => orig.enteredFromLockZone;
set => orig.enteredFromLockZone = value;
}

public float prevTarget_y
{
get => GetField<float>();
set => SetField(value);
}

public float prevCam_y
{
get => GetField<float>();
set => SetField(value);
}

public bool fallStick
{
get => orig.fallStick;
set => orig.fallStick = value;
}

public bool isGameplayScene
{
get => GetField<bool>();
set => SetField(value);
}



public void GameInit () =>
orig.GameInit();

public void SceneInit () =>
orig.SceneInit();

public void Update () =>
orig.Update();

public void EnterLockZone (float xLockMin_var, float xLockMax_var, float yLockMin_var, float yLockMax_var) =>
orig.EnterLockZone(xLockMin_var, xLockMax_var, yLockMin_var, yLockMax_var);

public void EnterLockZoneInstant (float xLockMin_var, float xLockMax_var, float yLockMin_var, float yLockMax_var) =>
orig.EnterLockZoneInstant(xLockMin_var, xLockMax_var, yLockMin_var, yLockMax_var);

public void ExitLockZone () =>
orig.ExitLockZone();

public void SetDampTime () =>
CallMethod();

public void SetSuperDash (bool active) =>
orig.SetSuperDash(active);

public void SetQuake (bool quake) =>
orig.SetQuake(quake);

public void FreezeInPlace () =>
orig.FreezeInPlace();

public void PositionToStart () =>
orig.PositionToStart();

}
}
