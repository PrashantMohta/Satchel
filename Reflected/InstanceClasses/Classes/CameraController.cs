namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of CameraController allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class CameraControllerR : InstanceClassWrapper<CameraController>
{
    public CameraControllerR(CameraController _orig) : base(_orig)
    {
    }

    public bool verboseMode
    {
        get => GetField<bool>();
        set => SetField(value);
    }

    public bool atSceneBounds
    {
        get => orig.atSceneBounds;
        set => orig.atSceneBounds = value;
    }

    public bool atHorizontalSceneBounds
    {
        get => orig.atHorizontalSceneBounds;
        set => orig.atHorizontalSceneBounds = value;
    }

    public bool isGameplayScene
    {
        get => GetField<bool>();
        set => SetField(value);
    }

    public bool teleporting
    {
        get => GetField<bool>();
        set => SetField(value);
    }

    public Vector3 lastFramePosition
    {
        get => orig.lastFramePosition;
        set => orig.lastFramePosition = value;
    }

    public Vector2 lastLockPosition
    {
        get => orig.lastLockPosition;
        set => orig.lastLockPosition = value;
    }

    public Coroutine fadeInFailSafeCo
    {
        get => GetField<Coroutine>();
        set => SetField(value);
    }

    public float dampTime
    {
        get => orig.dampTime;
        set => orig.dampTime = value;
    }

    public float dampTimeX
    {
        get => orig.dampTimeX;
        set => orig.dampTimeX = value;
    }

    public float dampTimeY
    {
        get => orig.dampTimeY;
        set => orig.dampTimeY = value;
    }

    public float dampTimeFalling
    {
        get => orig.dampTimeFalling;
        set => orig.dampTimeFalling = value;
    }

    public float heroBotYLimit
    {
        get => orig.heroBotYLimit;
        set => orig.heroBotYLimit = value;
    }

    public float panTime
    {
        get => GetField<float>();
        set => SetField(value);
    }

    public float currentPanTime
    {
        get => GetField<float>();
        set => SetField(value);
    }

    public Vector3 velocity
    {
        get => GetField<Vector3>();
        set => SetField(value);
    }

    public Vector3 velocityX
    {
        get => GetField<Vector3>();
        set => SetField(value);
    }

    public Vector3 velocityY
    {
        get => GetField<Vector3>();
        set => SetField(value);
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

    public Vector3 destination
    {
        get => orig.destination;
        set => orig.destination = value;
    }

    public float maxVelocity
    {
        get => orig.maxVelocity;
        set => orig.maxVelocity = value;
    }

    public float maxVelocityFalling
    {
        get => orig.maxVelocityFalling;
        set => orig.maxVelocityFalling = value;
    }

    public float maxVelocityCurrent
    {
        get => GetField<float>();
        set => SetField(value);
    }

    public float horizontalOffset
    {
        get => GetField<float>();
        set => SetField(value);
    }

    public float lookOffset
    {
        get => orig.lookOffset;
        set => orig.lookOffset = value;
    }

    public float startLockedTimer
    {
        get => GetField<float>();
        set => SetField(value);
    }

    public float targetDeltaX
    {
        get => GetField<float>();
        set => SetField(value);
    }

    public float targetDeltaY
    {
        get => GetField<float>();
        set => SetField(value);
    }

    public Vector2 panToTarget
    {
        get => orig.panToTarget;
        set => orig.panToTarget = value;
    }

    public float sceneWidth
    {
        get => orig.sceneWidth;
        set => orig.sceneWidth = value;
    }

    public float sceneHeight
    {
        get => orig.sceneHeight;
        set => orig.sceneHeight = value;
    }

    public float xLimit
    {
        get => orig.xLimit;
        set => orig.xLimit = value;
    }

    public float yLimit
    {
        get => orig.yLimit;
        set => orig.yLimit = value;
    }

    public CameraLockArea currentLockArea
    {
        get => GetField<CameraLockArea>();
        set => SetField(value);
    }

    public Vector3 panStartPos
    {
        get => GetField<Vector3>();
        set => SetField(value);
    }

    public Vector3 panEndPos
    {
        get => GetField<Vector3>();
        set => SetField(value);
    }

    public Camera cam
    {
        get => orig.cam;
        set => orig.cam = value;
    }

    public HeroController hero_ctrl
    {
        get => GetField<HeroController>();
        set => SetField(value);
    }

    public GameManager gm
    {
        get => GetField<GameManager>();
        set => SetField(value);
    }

    public tk2dTileMap tilemap
    {
        get => orig.tilemap;
        set => orig.tilemap = value;
    }

    public CameraTarget camTarget
    {
        get => orig.camTarget;
        set => orig.camTarget = value;
    }

    public PlayMakerFSM fadeFSM
    {
        get => GetField<PlayMakerFSM>();
        set => SetField(value);
    }

    public Transform cameraParent
    {
        get => GetField<Transform>();
        set => SetField(value);
    }

    public List<CameraLockArea> lockZoneList
    {
        get => orig.lockZoneList;
        set => orig.lockZoneList = value;
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


    public void GameInit()
    {
        orig.GameInit();
    }

    public void SceneInit()
    {
        orig.SceneInit();
    }

    public void ApplyEffectConfiguration(bool isGameplayLevel, bool isBloomForced)
    {
        orig.ApplyEffectConfiguration(isGameplayLevel, isBloomForced);
    }

    public void LateUpdate()
    {
        CallMethod();
    }

    public void OnDisable()
    {
        CallMethod();
    }

    public void FreezeInPlace(bool freezeTargetAlso = false)
    {
        orig.FreezeInPlace(freezeTargetAlso);
    }

    public void FadeOut(CameraFadeType type)
    {
        orig.FadeOut(type);
    }

    public void FadeSceneIn()
    {
        orig.FadeSceneIn();
    }

    public void LockToArea(CameraLockArea lockArea)
    {
        orig.LockToArea(lockArea);
    }

    public void ReleaseLock(CameraLockArea lockarea)
    {
        orig.ReleaseLock(lockarea);
    }

    public void ResetStartTimer()
    {
        orig.ResetStartTimer();
    }

    public void SnapTo(float x, float y)
    {
        orig.SnapTo(x, y);
    }

    public void UpdateTargetDestinationDelta()
    {
        CallMethod();
    }

    public void SetMode(CameraController.CameraMode newMode)
    {
        orig.SetMode(newMode);
    }

    public Vector3 KeepWithinSceneBounds(Vector3 targetDest)
    {
        return orig.KeepWithinSceneBounds(targetDest);
    }

    public Vector2 KeepWithinSceneBounds(Vector2 targetDest)
    {
        return CallMethod<Vector2>(new object[] { targetDest });
    }

    public bool IsAtSceneBounds(Vector2 targetDest)
    {
        return CallMethod<bool>(new object[] { targetDest });
    }

    public bool IsAtHorizontalSceneBounds(Vector2 targetDest, bool leftSide)
    {
        return CallMethod<bool>(new object[] { targetDest, leftSide });
    }

    public bool IsTouchingSides(float x)
    {
        return CallMethod<bool>(new object[] { x });
    }

    public Vector2 KeepWithinLockBounds(Vector2 targetDest)
    {
        return orig.KeepWithinLockBounds(targetDest);
    }

    public void GetTilemapInfo()
    {
        CallMethod();
    }

    public void PositionToHero(bool forceDirect)
    {
        orig.PositionToHero(forceDirect);
    }

    public IEnumerator DoPositionToHero(bool forceDirect)
    {
        return CallMethod<IEnumerator>(new object[] { forceDirect });
    }

    public void PositionToHeroFacing()
    {
        CallMethod();
    }

    public void PositionToHeroFacing(Vector2 newPosition, bool useXOffset)
    {
        CallMethod(new object[] { newPosition, useXOffset });
    }

    public Vector2 GetPositionToHeroFacing(Vector2 newPosition, bool useXOffset)
    {
        return CallMethod<Vector2>(new object[] { newPosition, useXOffset });
    }

    public IEnumerator FadeInFailSafe()
    {
        return CallMethod<IEnumerator>();
    }

    public void StopFailSafe()
    {
        CallMethod();
    }

    public void OnLevelUnload()
    {
        CallMethod();
    }

    public void OnDestroy()
    {
        CallMethod();
    }
}