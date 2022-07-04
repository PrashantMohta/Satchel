using UnityEngine.Audio;

namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of TransitionPoint allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class TransitionPointR : InstanceClassWrapper<TransitionPoint>
{
    public TransitionPointR(TransitionPoint _orig) : base(_orig)
    {
    }

    public GameManager gm
    {
        get => GetField<GameManager>();
        set => SetField(value);
    }

    public PlayerData playerData
    {
        get => GetField<PlayerData>();
        set => SetField(value);
    }

    public bool activated
    {
        get => GetField<bool>();
        set => SetField(value);
    }

    public bool isADoor
    {
        get => orig.isADoor;
        set => orig.isADoor = value;
    }

    public bool dontWalkOutOfDoor
    {
        get => orig.dontWalkOutOfDoor;
        set => orig.dontWalkOutOfDoor = value;
    }

    public float entryDelay
    {
        get => orig.entryDelay;
        set => orig.entryDelay = value;
    }

    public bool alwaysEnterRight
    {
        get => orig.alwaysEnterRight;
        set => orig.alwaysEnterRight = value;
    }

    public bool alwaysEnterLeft
    {
        get => orig.alwaysEnterLeft;
        set => orig.alwaysEnterLeft = value;
    }

    public bool hardLandOnExit
    {
        get => orig.hardLandOnExit;
        set => orig.hardLandOnExit = value;
    }

    public string targetScene
    {
        get => orig.targetScene;
        set => orig.targetScene = value;
    }

    public string entryPoint
    {
        get => orig.entryPoint;
        set => orig.entryPoint = value;
    }

    public Vector2 entryOffset
    {
        get => orig.entryOffset;
        set => orig.entryOffset = value;
    }

    public bool alwaysUnloadUnusedAssets
    {
        get => GetField<bool>();
        set => SetField(value);
    }

    public PlayMakerFSM customFadeFSM
    {
        get => orig.customFadeFSM;
        set => orig.customFadeFSM = value;
    }

    public bool nonHazardGate
    {
        get => orig.nonHazardGate;
        set => orig.nonHazardGate = value;
    }

    public HazardRespawnMarker respawnMarker
    {
        get => orig.respawnMarker;
        set => orig.respawnMarker = value;
    }

    public AudioMixerSnapshot atmosSnapshot
    {
        get => orig.atmosSnapshot;
        set => orig.atmosSnapshot = value;
    }

    public AudioMixerSnapshot enviroSnapshot
    {
        get => orig.enviroSnapshot;
        set => orig.enviroSnapshot = value;
    }

    public AudioMixerSnapshot actorSnapshot
    {
        get => orig.actorSnapshot;
        set => orig.actorSnapshot = value;
    }

    public AudioMixerSnapshot musicSnapshot
    {
        get => orig.musicSnapshot;
        set => orig.musicSnapshot = value;
    }

    public Color myGreen
    {
        get => GetField<Color>();
        set => SetField(value);
    }

    public bool customFade
    {
        get => orig.customFade;
        set => orig.customFade = value;
    }

    public bool forceWaitFetch
    {
        get => orig.forceWaitFetch;
        set => orig.forceWaitFetch = value;
    }

    public List<TransitionPoint> transitionPoints
    {
        get => GetFieldStatic<List<TransitionPoint>>();
        set => SetField(value);
    }

    public string lastEntered
    {
        get => TransitionPoint.lastEntered;
        set => TransitionPoint.lastEntered = value;
    }

    public List<TransitionPoint> TransitionPoints => TransitionPoint.TransitionPoints;


    public void Init()
    {
        CallMethodStatic();
    }

    public void Awake()
    {
        CallMethod();
    }

    public void OnDestroy()
    {
        CallMethod();
    }

    public void Start()
    {
        CallMethod();
    }

    public void OnTriggerEnter2D(Collider2D movingObj)
    {
        CallMethod(new object[] { movingObj });
    }

    public void OnTriggerStay2D(Collider2D movingObj)
    {
        CallMethod(new object[] { movingObj });
    }

    public void OnDrawGizmos()
    {
        CallMethod();
    }

    public GatePosition GetGatePosition()
    {
        return orig.GetGatePosition();
    }

    public void SetTargetScene(string newScene)
    {
        orig.SetTargetScene(newScene);
    }
}