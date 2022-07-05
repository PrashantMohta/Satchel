using UnityEngine.UI;

namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of BossDoorChallengeCompleteUI allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class BossDoorChallengeCompleteUIR : InstanceClassWrapper<BossDoorChallengeCompleteUI>
{
    public BossDoorChallengeCompleteUIR(BossDoorChallengeCompleteUI _orig) : base(_orig)
    {
    }

    public float achievementShowDelay
    {
        get => orig.achievementShowDelay;
        set => orig.achievementShowDelay = value;
    }

    public Animator animator
    {
        get => orig.animator;
        set => orig.animator = value;
    }

    public float appearAnimDelay
    {
        get => orig.appearAnimDelay;
        set => orig.appearAnimDelay = value;
    }

    public float appearEndWaitTime
    {
        get => orig.appearEndWaitTime;
        set => orig.appearEndWaitTime = value;
    }

    public float bindingCapAnimDelay
    {
        get => orig.bindingCapAnimDelay;
        set => orig.bindingCapAnimDelay = value;
    }

    public float bindingCapAppearDelay
    {
        get => orig.bindingCapAppearDelay;
        set => orig.bindingCapAppearDelay = value;
    }

    public float completionCapAppearDelay
    {
        get => orig.completionCapAppearDelay;
        set => orig.completionCapAppearDelay = value;
    }

    public float endAnimDelay
    {
        get => orig.endAnimDelay;
        set => orig.endAnimDelay = value;
    }

    public AudioSource musicSource
    {
        get => orig.musicSource;
        set => orig.musicSource = value;
    }

    public float musicDelay
    {
        get => orig.musicDelay;
        set => orig.musicDelay = value;
    }

    public AudioSource audioSourcePrefab
    {
        get => orig.audioSourcePrefab;
        set => orig.audioSourcePrefab = value;
    }

    public AudioEvent screenAppearSound
    {
        get => orig.screenAppearSound;
        set => orig.screenAppearSound = value;
    }

    public AudioEvent bindingAppearSound
    {
        get => orig.bindingAppearSound;
        set => orig.bindingAppearSound = value;
    }

    public float bindingAppearPitchIncrease
    {
        get => orig.bindingAppearPitchIncrease;
        set => orig.bindingAppearPitchIncrease = value;
    }

    public AudioEvent bindingAllAppearSound
    {
        get => orig.bindingAllAppearSound;
        set => orig.bindingAllAppearSound = value;
    }

    public AudioEvent coreAppearSound
    {
        get => orig.coreAppearSound;
        set => orig.coreAppearSound = value;
    }

    public GameObject[] coreFlashEffects
    {
        get => orig.coreFlashEffects;
        set => orig.coreFlashEffects = value;
    }

    public GameObject completeCore
    {
        get => orig.completeCore;
        set => orig.completeCore = value;
    }

    public GameObject allBindingsCore
    {
        get => orig.allBindingsCore;
        set => orig.allBindingsCore = value;
    }

    public GameObject noHitsCore
    {
        get => orig.noHitsCore;
        set => orig.noHitsCore = value;
    }

    public GameObject allBindingsNoHitsCore
    {
        get => orig.allBindingsNoHitsCore;
        set => orig.allBindingsNoHitsCore = value;
    }

    public CanvasGroup timerGroup
    {
        get => orig.timerGroup;
        set => orig.timerGroup = value;
    }

    public float timerFadeDelay
    {
        get => orig.timerFadeDelay;
        set => orig.timerFadeDelay = value;
    }

    public float timerFadeTime
    {
        get => orig.timerFadeTime;
        set => orig.timerFadeTime = value;
    }

    public Text timerText
    {
        get => orig.timerText;
        set => orig.timerText = value;
    }

    public bool waitingForInput
    {
        get => GetField<bool>();
        set => SetField(value);
    }


    public void Start()
    {
        CallMethod();
    }

    public void Update()
    {
        CallMethod();
    }

    public IEnumerator ShowAchievements()
    {
        return CallMethod<IEnumerator>();
    }

    public IEnumerator Sequence()
    {
        return CallMethod<IEnumerator>();
    }
}