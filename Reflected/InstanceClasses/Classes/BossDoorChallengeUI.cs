using UnityEngine.UI;

namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of BossDoorChallengeUI allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class BossDoorChallengeUIR : InstanceClassWrapper<BossDoorChallengeUI>
{
    public BossDoorChallengeUIR(BossDoorChallengeUI _orig) : base(_orig)
    {
    }

    public Text titleTextSuper
    {
        get => orig.titleTextSuper;
        set => orig.titleTextSuper = value;
    }

    public Text titleTextMain
    {
        get => orig.titleTextMain;
        set => orig.titleTextMain = value;
    }

    public Text descriptionText
    {
        get => orig.descriptionText;
        set => orig.descriptionText = value;
    }

    public BossDoorChallengeUIBindingButton boundNailButton
    {
        get => orig.boundNailButton;
        set => orig.boundNailButton = value;
    }

    public BossDoorChallengeUIBindingButton boundHeartButton
    {
        get => orig.boundHeartButton;
        set => orig.boundHeartButton = value;
    }

    public BossDoorChallengeUIBindingButton boundCharmsButton
    {
        get => orig.boundCharmsButton;
        set => orig.boundCharmsButton = value;
    }

    public BossDoorChallengeUIBindingButton boundSoulButton
    {
        get => orig.boundSoulButton;
        set => orig.boundSoulButton = value;
    }

    public BossDoorChallengeUIBindingButton[] buttons
    {
        get => GetField<BossDoorChallengeUIBindingButton[]>();
        set => SetField(value);
    }

    public bool allPreviouslySelected
    {
        get => GetField<bool>();
        set => SetField(value);
    }

    public AudioSource audioPlayerPrefab
    {
        get => orig.audioPlayerPrefab;
        set => orig.audioPlayerPrefab = value;
    }

    public AudioEvent allSelectedSound
    {
        get => orig.allSelectedSound;
        set => orig.allSelectedSound = value;
    }

    public GameObject allSelectedEffect
    {
        get => orig.allSelectedEffect;
        set => orig.allSelectedEffect = value;
    }

    public BossSequenceDoor door
    {
        get => GetField<BossSequenceDoor>();
        set => SetField(value);
    }

    public Animator animator
    {
        get => GetField<Animator>();
        set => SetField(value);
    }

    public Canvas canvas
    {
        get => GetField<Canvas>();
        set => SetField(value);
    }

    public CanvasGroup group
    {
        get => GetField<CanvasGroup>();
        set => SetField(value);
    }


    public void Awake()
    {
        CallMethod();
    }

    public void Start()
    {
        CallMethod();
    }

    public void OnEnable()
    {
        CallMethod();
    }

    public void Setup(BossSequenceDoor door)
    {
        orig.Setup(door);
    }

    public void UpdateAllButtons()
    {
        CallMethod();
    }

    public void Show()
    {
        orig.Show();
    }

    public IEnumerator ShowSequence()
    {
        return CallMethod<IEnumerator>();
    }

    public void Hide()
    {
        orig.Hide();
    }

    public IEnumerator HideSequence(bool sendEvent)
    {
        return CallMethod<IEnumerator>(new object[] { sendEvent });
    }

    public void Begin()
    {
        orig.Begin();
    }
}