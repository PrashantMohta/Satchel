namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of CinematicPlayer allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class CinematicPlayerR:InstanceClassWrapper<CinematicPlayer>
{
public CinematicPlayerR(CinematicPlayer _orig) : base(_orig) {}
public CinematicVideoReference videoClip
{
get => GetField<CinematicVideoReference>();
set => SetField(value);
}

public CinematicVideoPlayer cinematicVideoPlayer
{
get => GetField<CinematicVideoPlayer>();
set => SetField(value);
}

public UnityEngine.AudioSource additionalAudio
{
get => GetField<UnityEngine.AudioSource>();
set => SetField(value);
}

public bool additionalAudioContinuesPastVideo
{
get => GetField<bool>();
set => SetField(value);
}

public UnityEngine.MeshRenderer selfBlanker
{
get => GetField<UnityEngine.MeshRenderer>();
set => SetField(value);
}

public float delayBeforeFadeIn
{
get => orig.delayBeforeFadeIn;
set => orig.delayBeforeFadeIn = value;
}

public GlobalEnums.SkipPromptMode skipMode
{
get => orig.skipMode;
set => orig.skipMode = value;
}

public bool startSkipLocked
{
get => orig.startSkipLocked;
set => orig.startSkipLocked = value;
}

public bool loopVideo
{
get => orig.loopVideo;
set => orig.loopVideo = value;
}

public CinematicVideoFaderStyles faderStyle
{
get => orig.faderStyle;
set => orig.faderStyle = value;
}

public UnityEngine.AudioSource audioSource
{
get => GetField<UnityEngine.AudioSource>();
set => SetField(value);
}

public UnityEngine.MeshRenderer myRenderer
{
get => GetField<UnityEngine.MeshRenderer>();
set => SetField(value);
}

public GameManager gm
{
get => GetField<GameManager>();
set => SetField(value);
}

public UIManager ui
{
get => GetField<UIManager>();
set => SetField(value);
}

public PlayerData pd
{
get => GetField<PlayerData>();
set => SetField(value);
}

public PlayMakerFSM cameraFSM
{
get => GetField<PlayMakerFSM>();
set => SetField(value);
}

public bool videoTriggered
{
get => GetField<bool>();
set => SetField(value);
}

public bool loadingLevel
{
get => GetField<bool>();
set => SetField(value);
}

public UnityEngine.Audio.AudioMixerSnapshot masterOff
{
get => GetField<UnityEngine.Audio.AudioMixerSnapshot>();
set => SetField(value);
}

public UnityEngine.Audio.AudioMixerSnapshot masterResume
{
get => GetField<UnityEngine.Audio.AudioMixerSnapshot>();
set => SetField(value);
}



public void Awake () =>
CallMethod();

public void OnDestroy () =>
CallMethod();

public void Start () =>
CallMethod();

public void Update () =>
CallMethod();

public void Update10 () =>
CallMethod();

public System.Collections.IEnumerator SkipVideo () =>
orig.SkipVideo();

public void TriggerStartVideo () =>
orig.TriggerStartVideo();

public void TriggerStopVideo () =>
orig.TriggerStopVideo();

public void UnlockSkip () =>
orig.UnlockSkip();

public System.Collections.IEnumerator StartVideo () =>
CallMethod<System.Collections.IEnumerator>();

public void FinishVideo () =>
CallMethod();

public void FinishInGameVideo () =>
CallMethod();

public System.Collections.IEnumerator WaitForStagFadeOut () =>
CallMethod<System.Collections.IEnumerator>();

}
}
