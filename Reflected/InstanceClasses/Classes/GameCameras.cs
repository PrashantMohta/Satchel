using UnityEngine.UI;

namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of GameCameras allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class GameCamerasR : InstanceClassWrapper<GameCameras>
{
    public GameCamerasR(GameCameras _orig) : base(_orig)
    {
    }

    public Camera hudCamera
    {
        get => orig.hudCamera;
        set => orig.hudCamera = value;
    }

    public Camera mainCamera
    {
        get => orig.mainCamera;
        set => orig.mainCamera = value;
    }

    public CameraController cameraController
    {
        get => orig.cameraController;
        set => orig.cameraController = value;
    }

    public CameraTarget cameraTarget
    {
        get => orig.cameraTarget;
        set => orig.cameraTarget = value;
    }

    public ForceCameraAspect forceCameraAspect
    {
        get => orig.forceCameraAspect;
        set => orig.forceCameraAspect = value;
    }

    public PlayMakerFSM cameraFadeFSM
    {
        get => orig.cameraFadeFSM;
        set => orig.cameraFadeFSM = value;
    }

    public PlayMakerFSM cameraShakeFSM
    {
        get => orig.cameraShakeFSM;
        set => orig.cameraShakeFSM = value;
    }

    public PlayMakerFSM soulOrbFSM
    {
        get => orig.soulOrbFSM;
        set => orig.soulOrbFSM = value;
    }

    public PlayMakerFSM soulVesselFSM
    {
        get => orig.soulVesselFSM;
        set => orig.soulVesselFSM = value;
    }

    public PlayMakerFSM openStagFSM
    {
        get => orig.openStagFSM;
        set => orig.openStagFSM = value;
    }

    public SceneColorManager sceneColorManager
    {
        get => orig.sceneColorManager;
        set => orig.sceneColorManager = value;
    }

    public BrightnessEffect brightnessEffect
    {
        get => orig.brightnessEffect;
        set => orig.brightnessEffect = value;
    }

    public SceneParticlesController sceneParticlesPrefab
    {
        get => orig.sceneParticlesPrefab;
        set => orig.sceneParticlesPrefab = value;
    }

    public tk2dCamera tk2dCam
    {
        get => orig.tk2dCam;
        set => orig.tk2dCam = value;
    }

    public GameObject hudCanvas
    {
        get => orig.hudCanvas;
        set => orig.hudCanvas = value;
    }

    public Transform cameraParent
    {
        get => orig.cameraParent;
        set => orig.cameraParent = value;
    }

    public GeoCounter geoCounter
    {
        get => orig.geoCounter;
        set => orig.geoCounter = value;
    }

    public GameManager gm
    {
        get => GetField<GameManager>();
        set => SetField(value);
    }

    public GameSettings gs
    {
        get => GetField<GameSettings>();
        set => SetField(value);
    }

    public CanvasScaler canvasScaler
    {
        get => GetField<CanvasScaler>();
        set => SetField(value);
    }

    public bool init
    {
        get => GetField<bool>();
        set => SetField(value);
    }

    public GameCameras _instance
    {
        get => GetFieldStatic<GameCameras>();
        set => SetField(value);
    }

    public SceneParticlesController sceneParticles
    {
        get => orig.sceneParticles;
        set => SetProperty(value);
    }

    public GameCameras instance => GameCameras.instance;


    public void Awake()
    {
        CallMethod();
    }

    public void Start()
    {
        CallMethod();
    }

    public void SceneInit()
    {
        orig.SceneInit();
    }

    public void OnDestroy()
    {
        CallMethod();
    }

    public void SetupGameRefs()
    {
        CallMethod();
    }

    public void StartScene()
    {
        CallMethod();
    }

    public void MoveMenuToHUDCamera()
    {
        orig.MoveMenuToHUDCamera();
    }

    public void DisableHUDCamIfAllowed()
    {
        orig.DisableHUDCamIfAllowed();
    }

    public void StopCameraShake()
    {
        orig.StopCameraShake();
    }

    public void ResumeCameraShake()
    {
        orig.ResumeCameraShake();
    }

    public void DisableImageEffects()
    {
        orig.DisableImageEffects();
    }

    public void EnableImageEffects(bool isGameplayLevel, bool isBloomForced)
    {
        orig.EnableImageEffects(isGameplayLevel, isBloomForced);
    }

    public void SetOverscan(float value)
    {
        orig.SetOverscan(value);
    }

    public void TestParentForPosition()
    {
        orig.TestParentForPosition();
    }

    public GameCameras orig_get_instance()
    {
        return GameCameras.orig_get_instance();
    }
}