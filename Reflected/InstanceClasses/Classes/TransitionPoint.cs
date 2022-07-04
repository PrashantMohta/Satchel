namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of TransitionPoint allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class TransitionPointR:InstanceClassWrapper<TransitionPoint>
{
public TransitionPointR(TransitionPoint _orig) : base(_orig) {}
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

public UnityEngine.Vector2 entryOffset
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

public UnityEngine.Audio.AudioMixerSnapshot atmosSnapshot
{
get => orig.atmosSnapshot;
set => orig.atmosSnapshot = value;
}

public UnityEngine.Audio.AudioMixerSnapshot enviroSnapshot
{
get => orig.enviroSnapshot;
set => orig.enviroSnapshot = value;
}

public UnityEngine.Audio.AudioMixerSnapshot actorSnapshot
{
get => orig.actorSnapshot;
set => orig.actorSnapshot = value;
}

public UnityEngine.Audio.AudioMixerSnapshot musicSnapshot
{
get => orig.musicSnapshot;
set => orig.musicSnapshot = value;
}

public UnityEngine.Color myGreen
{
get => GetField<UnityEngine.Color>();
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

public System.Collections.Generic.List<TransitionPoint> transitionPoints
{
get => GetFieldStatic<System.Collections.Generic.List<TransitionPoint>>();
set => SetField(value);
}

public string lastEntered
{
get => TransitionPoint.lastEntered;
set => TransitionPoint.lastEntered = value;
}

public System.Collections.Generic.List<TransitionPoint> TransitionPoints
{
get => TransitionPoint.TransitionPoints;
}



public void Init () =>
CallMethodStatic();

public void Awake () =>
CallMethod();

public void OnDestroy () =>
CallMethod();

public void Start () =>
CallMethod();

public void OnTriggerEnter2D (UnityEngine.Collider2D movingObj) =>
CallMethod(new object[] {movingObj});

public void OnTriggerStay2D (UnityEngine.Collider2D movingObj) =>
CallMethod(new object[] {movingObj});

public void OnDrawGizmos () =>
CallMethod();

public GlobalEnums.GatePosition GetGatePosition () =>
orig.GetGatePosition();

public void SetTargetScene (string newScene) =>
orig.SetTargetScene(newScene);

}
}
