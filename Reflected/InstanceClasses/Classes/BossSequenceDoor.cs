namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of BossSequenceDoor allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class BossSequenceDoorR : InstanceClassWrapper<BossSequenceDoor>
{
    public BossSequenceDoorR(BossSequenceDoor _orig) : base(_orig)
    {
    }

    public string playerDataString
    {
        get => orig.playerDataString;
        set => orig.playerDataString = value;
    }

    public BossSequence bossSequence
    {
        get => orig.bossSequence;
        set => orig.bossSequence = value;
    }

    public string titleSuperKey
    {
        get => orig.titleSuperKey;
        set => orig.titleSuperKey = value;
    }

    public string titleSuperSheet
    {
        get => orig.titleSuperSheet;
        set => orig.titleSuperSheet = value;
    }

    public string titleMainKey
    {
        get => orig.titleMainKey;
        set => orig.titleMainKey = value;
    }

    public string titleMainSheet
    {
        get => orig.titleMainSheet;
        set => orig.titleMainSheet = value;
    }

    public string descriptionKey
    {
        get => orig.descriptionKey;
        set => orig.descriptionKey = value;
    }

    public string descriptionSheet
    {
        get => orig.descriptionSheet;
        set => orig.descriptionSheet = value;
    }

    public BossSequenceDoor[] requiredComplete
    {
        get => orig.requiredComplete;
        set => orig.requiredComplete = value;
    }

    public GameObject completedDisplay
    {
        get => orig.completedDisplay;
        set => orig.completedDisplay = value;
    }

    public GameObject completedAllDisplay
    {
        get => orig.completedAllDisplay;
        set => orig.completedAllDisplay = value;
    }

    public GameObject completedNoHitsDisplay
    {
        get => orig.completedNoHitsDisplay;
        set => orig.completedNoHitsDisplay = value;
    }

    public GameObject boundNailDisplay
    {
        get => orig.boundNailDisplay;
        set => orig.boundNailDisplay = value;
    }

    public GameObject boundHeartDisplay
    {
        get => orig.boundHeartDisplay;
        set => orig.boundHeartDisplay = value;
    }

    public GameObject boundCharmsDisplay
    {
        get => orig.boundCharmsDisplay;
        set => orig.boundCharmsDisplay = value;
    }

    public GameObject boundSoulDisplay
    {
        get => orig.boundSoulDisplay;
        set => orig.boundSoulDisplay = value;
    }

    public GameObject boundAllDisplay
    {
        get => orig.boundAllDisplay;
        set => orig.boundAllDisplay = value;
    }

    public GameObject boundAllBackboard
    {
        get => orig.boundAllBackboard;
        set => orig.boundAllBackboard = value;
    }

    public GameObject lockSet
    {
        get => orig.lockSet;
        set => orig.lockSet = value;
    }

    public GameObject lockInteractPrompt
    {
        get => orig.lockInteractPrompt;
        set => orig.lockInteractPrompt = value;
    }

    public GameObject cameraLock
    {
        get => orig.cameraLock;
        set => orig.cameraLock = value;
    }

    public GameObject unlockedSet
    {
        get => orig.unlockedSet;
        set => orig.unlockedSet = value;
    }

    public PlayMakerFSM challengeFSM
    {
        get => orig.challengeFSM;
        set => orig.challengeFSM = value;
    }

    public GameObject dreamReturnGate
    {
        get => orig.dreamReturnGate;
        set => orig.dreamReturnGate = value;
    }

    public bool doLockBreakSequence
    {
        get => orig.doLockBreakSequence;
        set => orig.doLockBreakSequence = value;
    }

    public GameObject lockBreakAnticEffects
    {
        get => orig.lockBreakAnticEffects;
        set => orig.lockBreakAnticEffects = value;
    }

    public GameObject lockBreakRumbleSound
    {
        get => orig.lockBreakRumbleSound;
        set => orig.lockBreakRumbleSound = value;
    }

    public SpriteRenderer[] glowSprites
    {
        get => orig.glowSprites;
        set => orig.glowSprites = value;
    }

    public Material spriteFlashMaterial
    {
        get => orig.spriteFlashMaterial;
        set => orig.spriteFlashMaterial = value;
    }

    public SpriteRenderer[] fadeSprites
    {
        get => orig.fadeSprites;
        set => orig.fadeSprites = value;
    }

    public AnimationCurve glowCurve
    {
        get => orig.glowCurve;
        set => orig.glowCurve = value;
    }

    public ParticleSystem glowParticles
    {
        get => orig.glowParticles;
        set => orig.glowParticles = value;
    }

    public float lockBreakAnticTime
    {
        get => orig.lockBreakAnticTime;
        set => orig.lockBreakAnticTime = value;
    }

    public GameObject lockBreakEffects
    {
        get => orig.lockBreakEffects;
        set => orig.lockBreakEffects = value;
    }

    public bool doUnlockSequence
    {
        get => GetField<bool>();
        set => SetField(value);
    }

    public GameObject lockedUIPrefab
    {
        get => orig.lockedUIPrefab;
        set => orig.lockedUIPrefab = value;
    }

    public BossDoorLockUI lockedUI
    {
        get => GetFieldStatic<BossDoorLockUI>();
        set => SetField(value);
    }


    public void Start()
    {
        CallMethod();
    }

    public void SaveState()
    {
        CallMethod();
    }

    public bool IsUnlocked()
    {
        return CallMethod<bool>();
    }

    public void SetDisplayState(BossSequenceDoor.Completion completion)
    {
        CallMethod(new object[] { completion });
    }

    public void ShowLockUI(bool value)
    {
        orig.ShowLockUI(value);
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        CallMethod(new object[] { collision });
    }

    public void StartShake()
    {
        CallMethod();
    }

    public void StopShake()
    {
        CallMethod();
    }

    public IEnumerator DoorUnlockSequence()
    {
        return CallMethod<IEnumerator>();
    }
}