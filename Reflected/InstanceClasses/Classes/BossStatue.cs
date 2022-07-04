namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of BossStatue allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class BossStatueR:InstanceClassWrapper<BossStatue>
{
public BossStatueR(BossStatue _orig) : base(_orig) {}
public BossScene bossScene
{
get => orig.bossScene;
set => orig.bossScene = value;
}

public BossScene dreamBossScene
{
get => orig.dreamBossScene;
set => orig.dreamBossScene = value;
}

public string statueStatePD
{
get => orig.statueStatePD;
set => orig.statueStatePD = value;
}

public string dreamStatueStatePD
{
get => orig.dreamStatueStatePD;
set => orig.dreamStatueStatePD = value;
}

public bool hasNoTiers
{
get => orig.hasNoTiers;
set => orig.hasNoTiers = value;
}

public bool dontCountCompletion
{
get => orig.dontCountCompletion;
set => orig.dontCountCompletion = value;
}

public bool isAlwaysUnlocked
{
get => orig.isAlwaysUnlocked;
set => orig.isAlwaysUnlocked = value;
}

public bool isAlwaysUnlockedDream
{
get => orig.isAlwaysUnlockedDream;
set => orig.isAlwaysUnlockedDream = value;
}

public float inspectCameraHeight
{
get => orig.inspectCameraHeight;
set => orig.inspectCameraHeight = value;
}

public bool isHidden
{
get => orig.isHidden;
set => orig.isHidden = value;
}

public PlayMakerFSM bossUIControlFSM
{
get => orig.bossUIControlFSM;
set => orig.bossUIControlFSM = value;
}

public UnityEngine.GameObject[] disableIfLocked
{
get => orig.disableIfLocked;
set => orig.disableIfLocked = value;
}

public UnityEngine.GameObject[] enableIfLocked
{
get => orig.enableIfLocked;
set => orig.enableIfLocked = value;
}

public BossStatueTrophyPlaque regularPlaque
{
get => orig.regularPlaque;
set => orig.regularPlaque = value;
}

public BossStatueTrophyPlaque altPlaqueL
{
get => orig.altPlaqueL;
set => orig.altPlaqueL = value;
}

public BossStatueTrophyPlaque altPlaqueR
{
get => orig.altPlaqueR;
set => orig.altPlaqueR = value;
}

public UnityEngine.SpriteRenderer lockedPlaque
{
get => orig.lockedPlaque;
set => orig.lockedPlaque = value;
}

public UnityEngine.GameObject dreamReturnGate
{
get => orig.dreamReturnGate;
set => orig.dreamReturnGate = value;
}

public TriggerEnterEvent lightTrigger
{
get => orig.lightTrigger;
set => orig.lightTrigger = value;
}

public CameraLockArea cameraLock
{
get => orig.cameraLock;
set => orig.cameraLock = value;
}

public UnityEngine.GameObject statueDisplay
{
get => orig.statueDisplay;
set => orig.statueDisplay = value;
}

public UnityEngine.GameObject statueDisplayAlt
{
get => orig.statueDisplayAlt;
set => orig.statueDisplayAlt = value;
}

public UnityEngine.ParticleSystem statueShakeParticles
{
get => orig.statueShakeParticles;
set => orig.statueShakeParticles = value;
}

public UnityEngine.ParticleSystem statueUpParticles
{
get => orig.statueUpParticles;
set => orig.statueUpParticles = value;
}

public UnityEngine.AudioSource statueShakeLoop
{
get => orig.statueShakeLoop;
set => orig.statueShakeLoop = value;
}

public UnityEngine.AudioSource audioSourcePrefab
{
get => orig.audioSourcePrefab;
set => orig.audioSourcePrefab = value;
}

public AudioEvent statueDownSound
{
get => orig.statueDownSound;
set => orig.statueDownSound = value;
}

public float statueDownSoundDelay
{
get => orig.statueDownSoundDelay;
set => orig.statueDownSoundDelay = value;
}

public AudioEvent statueUpSound
{
get => orig.statueUpSound;
set => orig.statueUpSound = value;
}

public float statueUpSoundDelay
{
get => orig.statueUpSoundDelay;
set => orig.statueUpSoundDelay = value;
}

public float swapWaitTime
{
get => orig.swapWaitTime;
set => orig.swapWaitTime = value;
}

public float shakeTime
{
get => orig.shakeTime;
set => orig.shakeTime = value;
}

public float holdTime
{
get => orig.holdTime;
set => orig.holdTime = value;
}

public float upParticleDelay
{
get => orig.upParticleDelay;
set => orig.upParticleDelay = value;
}

public IBossStatueToggle dreamToggle
{
get => GetField<IBossStatueToggle>();
set => SetField(value);
}

public bool wasUsingDreamVersion
{
get => GetField<bool>();
set => SetField(value);
}

public bool UsingDreamVersion
{
get => orig.UsingDreamVersion;
set => SetProperty(value);
}

public bool HasRegularVersion
{
get => orig.HasRegularVersion;
}

public bool HasDreamVersion
{
get => orig.HasDreamVersion;
}



public void Awake () =>
CallMethod();

public void Start () =>
CallMethod();

public void SetPlaquesVisible (bool isEnabled) =>
orig.SetPlaquesVisible(isEnabled);

public void SetPlaqueState (BossStatue.Completion statueState, BossStatueTrophyPlaque plaque, string playerDataKey) =>
orig.SetPlaqueState(statueState, plaque, playerDataKey);

public void SetDreamVersion (bool value, bool useAltStatue = false, bool doAnim = true) =>
orig.SetDreamVersion(value, useAltStatue, doAnim);

public void UpdateDetails () =>
CallMethod();

public System.Collections.IEnumerator SwapStatues (bool doAnim) =>
CallMethod<System.Collections.IEnumerator>(new object[] {doAnim});

public System.Collections.IEnumerator Jitter (float duration, float magnitude, UnityEngine.GameObject obj) =>
CallMethod<System.Collections.IEnumerator>(new object[] {duration, magnitude, obj});

public System.Collections.IEnumerator PlayAnimWait (UnityEngine.Animator animator, string stateName, float normalizedTime) =>
CallMethod<System.Collections.IEnumerator>(new object[] {animator, stateName, normalizedTime});

public System.Collections.IEnumerator PlayParticlesDelay (UnityEngine.ParticleSystem system, float delay) =>
CallMethod<System.Collections.IEnumerator>(new object[] {system, delay});

public System.Collections.IEnumerator PlayAudioEventDelayed (AudioEvent audioEvent, float delay) =>
CallMethod<System.Collections.IEnumerator>(new object[] {audioEvent, delay});

public void OnDrawGizmosSelected () =>
CallMethod();

}
}
