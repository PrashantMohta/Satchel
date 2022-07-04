namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of BossStatue allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class BossStatueR : InstanceClassWrapper<BossStatue>
{
    public BossStatueR(BossStatue _orig) : base(_orig)
    {
    }

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

    public GameObject[] disableIfLocked
    {
        get => orig.disableIfLocked;
        set => orig.disableIfLocked = value;
    }

    public GameObject[] enableIfLocked
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

    public SpriteRenderer lockedPlaque
    {
        get => orig.lockedPlaque;
        set => orig.lockedPlaque = value;
    }

    public GameObject dreamReturnGate
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

    public GameObject statueDisplay
    {
        get => orig.statueDisplay;
        set => orig.statueDisplay = value;
    }

    public GameObject statueDisplayAlt
    {
        get => orig.statueDisplayAlt;
        set => orig.statueDisplayAlt = value;
    }

    public ParticleSystem statueShakeParticles
    {
        get => orig.statueShakeParticles;
        set => orig.statueShakeParticles = value;
    }

    public ParticleSystem statueUpParticles
    {
        get => orig.statueUpParticles;
        set => orig.statueUpParticles = value;
    }

    public AudioSource statueShakeLoop
    {
        get => orig.statueShakeLoop;
        set => orig.statueShakeLoop = value;
    }

    public AudioSource audioSourcePrefab
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

    public bool HasRegularVersion => orig.HasRegularVersion;

    public bool HasDreamVersion => orig.HasDreamVersion;


    public void Awake()
    {
        CallMethod();
    }

    public void Start()
    {
        CallMethod();
    }

    public void SetPlaquesVisible(bool isEnabled)
    {
        orig.SetPlaquesVisible(isEnabled);
    }

    public void SetPlaqueState(BossStatue.Completion statueState, BossStatueTrophyPlaque plaque, string playerDataKey)
    {
        orig.SetPlaqueState(statueState, plaque, playerDataKey);
    }

    public void SetDreamVersion(bool value, bool useAltStatue = false, bool doAnim = true)
    {
        orig.SetDreamVersion(value, useAltStatue, doAnim);
    }

    public void UpdateDetails()
    {
        CallMethod();
    }

    public IEnumerator SwapStatues(bool doAnim)
    {
        return CallMethod<IEnumerator>(new object[] { doAnim });
    }

    public IEnumerator Jitter(float duration, float magnitude, GameObject obj)
    {
        return CallMethod<IEnumerator>(new object[] { duration, magnitude, obj });
    }

    public IEnumerator PlayAnimWait(Animator animator, string stateName, float normalizedTime)
    {
        return CallMethod<IEnumerator>(new object[] { animator, stateName, normalizedTime });
    }

    public IEnumerator PlayParticlesDelay(ParticleSystem system, float delay)
    {
        return CallMethod<IEnumerator>(new object[] { system, delay });
    }

    public IEnumerator PlayAudioEventDelayed(AudioEvent audioEvent, float delay)
    {
        return CallMethod<IEnumerator>(new object[] { audioEvent, delay });
    }

    public void OnDrawGizmosSelected()
    {
        CallMethod();
    }
}