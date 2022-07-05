using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of SaveSlotButton allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class SaveSlotButtonR : InstanceClassWrapper<SaveSlotButton>
{
    public SaveSlotButtonR(SaveSlotButton _orig) : base(_orig)
    {
    }

    public bool verboseMode
    {
        get => GetField<bool>();
        set => SetField(value);
    }

    public Animator topFleur
    {
        get => orig.topFleur;
        set => orig.topFleur = value;
    }

    public Animator highlight
    {
        get => orig.highlight;
        set => orig.highlight = value;
    }

    public CanvasGroup newGameText
    {
        get => orig.newGameText;
        set => orig.newGameText = value;
    }

    public CanvasGroup saveCorruptedText
    {
        get => orig.saveCorruptedText;
        set => orig.saveCorruptedText = value;
    }

    public CanvasGroup loadingText
    {
        get => orig.loadingText;
        set => orig.loadingText = value;
    }

    public CanvasGroup activeSaveSlot
    {
        get => orig.activeSaveSlot;
        set => orig.activeSaveSlot = value;
    }

    public CanvasGroup clearSaveButton
    {
        get => orig.clearSaveButton;
        set => orig.clearSaveButton = value;
    }

    public CanvasGroup clearSavePrompt
    {
        get => orig.clearSavePrompt;
        set => orig.clearSavePrompt = value;
    }

    public CanvasGroup backgroundCg
    {
        get => orig.backgroundCg;
        set => orig.backgroundCg = value;
    }

    public CanvasGroup slotNumberText
    {
        get => orig.slotNumberText;
        set => orig.slotNumberText = value;
    }

    public CanvasGroup myCanvasGroup
    {
        get => orig.myCanvasGroup;
        set => orig.myCanvasGroup = value;
    }

    public CanvasGroup defeatedText
    {
        get => orig.defeatedText;
        set => orig.defeatedText = value;
    }

    public CanvasGroup defeatedBackground
    {
        get => orig.defeatedBackground;
        set => orig.defeatedBackground = value;
    }

    public CanvasGroup brokenSteelOrb
    {
        get => orig.brokenSteelOrb;
        set => orig.brokenSteelOrb = value;
    }

    public Text geoText
    {
        get => orig.geoText;
        set => orig.geoText = value;
    }

    public Text locationText
    {
        get => orig.locationText;
        set => orig.locationText = value;
    }

    public Text playTimeText
    {
        get => orig.playTimeText;
        set => orig.playTimeText = value;
    }

    public Text completionText
    {
        get => orig.completionText;
        set => orig.completionText = value;
    }

    public CanvasGroup normalSoulOrbCg
    {
        get => orig.normalSoulOrbCg;
        set => orig.normalSoulOrbCg = value;
    }

    public CanvasGroup hardcoreSoulOrbCg
    {
        get => orig.hardcoreSoulOrbCg;
        set => orig.hardcoreSoulOrbCg = value;
    }

    public CanvasGroup ggSoulOrbCg
    {
        get => orig.ggSoulOrbCg;
        set => orig.ggSoulOrbCg = value;
    }

    public Image background
    {
        get => orig.background;
        set => orig.background = value;
    }

    public Image soulOrbIcon
    {
        get => orig.soulOrbIcon;
        set => orig.soulOrbIcon = value;
    }

    public SaveProfileHealthBar healthSlots
    {
        get => orig.healthSlots;
        set => orig.healthSlots = value;
    }

    public Image geoIcon
    {
        get => orig.geoIcon;
        set => orig.geoIcon = value;
    }

    public SaveProfileMPSlots mpSlots
    {
        get => orig.mpSlots;
        set => orig.mpSlots = value;
    }

    public SaveSlotBackgrounds saveSlots
    {
        get => orig.saveSlots;
        set => orig.saveSlots = value;
    }

    public GameObject clearSaveBlocker
    {
        get => orig.clearSaveBlocker;
        set => orig.clearSaveBlocker = value;
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

    public InputHandler ih
    {
        get => GetField<InputHandler>();
        set => SetField(value);
    }

    public PreselectOption clearSavePromptHighlight
    {
        get => GetField<PreselectOption>();
        set => SetField(value);
    }

    public SaveStats saveStats
    {
        get => GetField<SaveStats>();
        set => SetField(value);
    }

    public Navigation noNav
    {
        get => GetField<Navigation>();
        set => SetField(value);
    }

    public Navigation fullSlotNav
    {
        get => GetField<Navigation>();
        set => SetField(value);
    }

    public Navigation emptySlotNav
    {
        get => GetField<Navigation>();
        set => SetField(value);
    }

    public IEnumerator currentLoadingTextFadeIn
    {
        get => GetField<IEnumerator>();
        set => SetField(value);
    }

    public bool didLoadSaveStats
    {
        get => GetField<bool>();
        set => SetField(value);
    }

    public CoroutineQueue coroutineQueue
    {
        get => GetField<CoroutineQueue>();
        set => SetField(value);
    }

    public Animator flashEffect
    {
        get => orig.flashEffect;
        set => orig.flashEffect = value;
    }

    public CancelAction cancelAction
    {
        get => orig.cancelAction;
        set => orig.cancelAction = value;
    }

    public Animator leftCursor
    {
        get => orig.leftCursor;
        set => orig.leftCursor = value;
    }

    public Animator rightCursor
    {
        get => orig.rightCursor;
        set => orig.rightCursor = value;
    }

    public Animator selectHighlight
    {
        get => orig.selectHighlight;
        set => orig.selectHighlight = value;
    }

    public bool playSubmitSound
    {
        get => orig.playSubmitSound;
        set => orig.playSubmitSound = value;
    }

    public Animator descriptionText
    {
        get => orig.descriptionText;
        set => orig.descriptionText = value;
    }

    public MenuAudioController uiAudioPlayer
    {
        get => GetField<MenuAudioController>();
        set => SetField(value);
    }

    public GameObject prevSelectedObject
    {
        get => GetField<GameObject>();
        set => SetField(value);
    }

    public bool dontPlaySelectSound
    {
        get => GetField<bool>();
        set => SetField(value);
    }

    public bool deselectWasForced
    {
        get => GetField<bool>();
        set => SetField(value);
    }

    public int m_CurrentIndex
    {
        get => GetField<int>();
        set => SetField(value);
    }

    public int SaveSlotIndex => GetProperty<int>();

    public Action<MenuButton> submitAction
    {
        get => orig.submitAction;
        set => orig.submitAction = value;
    }

    public bool proceed
    {
        get => orig.proceed;
        set => orig.proceed = value;
    }

    public bool DontPlaySelectSound
    {
        get => orig.DontPlaySelectSound;
        set => orig.DontPlaySelectSound = value;
    }

    public Action<MenuSelectable> customCancelAction
    {
        get => orig.customCancelAction;
        set => orig.customCancelAction = value;
    }

    public Navigation navigation
    {
        get => orig.navigation;
        set => orig.navigation = value;
    }

    public ColorBlock colors
    {
        get => orig.colors;
        set => orig.colors = value;
    }

    public SpriteState spriteState
    {
        get => orig.spriteState;
        set => orig.spriteState = value;
    }

    public AnimationTriggers animationTriggers
    {
        get => orig.animationTriggers;
        set => orig.animationTriggers = value;
    }

    public Graphic targetGraphic
    {
        get => orig.targetGraphic;
        set => orig.targetGraphic = value;
    }

    public bool interactable
    {
        get => orig.interactable;
        set => orig.interactable = value;
    }

    public Image image
    {
        get => orig.image;
        set => orig.image = value;
    }

    public Animator animator => orig.animator;


    public void Awake()
    {
        CallMethod();
    }

    public void OnEnable()
    {
        CallMethod();
    }

    public void Start()
    {
        CallMethod();
    }

    public void Prepare(GameManager gameManager, bool isReload = false)
    {
        orig.Prepare(gameManager, isReload);
    }

    public void ClearCache()
    {
        orig.ClearCache();
    }

    public void ChangeSaveFileState(SaveSlotButton.SaveFileStates nextSaveFileState)
    {
        CallMethod(new object[] { nextSaveFileState });
    }

    public void OnSubmit(BaseEventData eventData)
    {
        orig.OnSubmit(eventData);
    }

    public IEnumerator ReloadCorrupted()
    {
        return CallMethod<IEnumerator>();
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        orig.OnPointerClick(eventData);
    }

    public void OnSelect(BaseEventData eventData)
    {
        orig.OnSelect(eventData);
    }

    public void OnDeselect(BaseEventData eventData)
    {
        orig.OnDeselect(eventData);
    }

    public void ShowRelevantModeForSaveFileState()
    {
        orig.ShowRelevantModeForSaveFileState();
    }

    public void HideSaveSlot()
    {
        orig.HideSaveSlot();
    }

    public void ClearSavePrompt()
    {
        orig.ClearSavePrompt();
    }

    public void CancelClearSave()
    {
        orig.CancelClearSave();
    }

    public void ClearSaveFile()
    {
        orig.ClearSaveFile();
    }

    public IEnumerator FadeInCanvasGroupAfterDelay(float delay, CanvasGroup cg)
    {
        return CallMethod<IEnumerator>(new object[] { delay, cg });
    }

    public IEnumerator AnimateToSlotState(SaveSlotButton.SlotState nextState)
    {
        return CallMethod<IEnumerator>(new object[] { nextState });
    }

    public void PresentSaveSlot(SaveStats saveStats)
    {
        CallMethod(new object[] { saveStats });
    }

    public void SetupNavs()
    {
        CallMethod();
    }

    public IEnumerator ValidateDeselect()
    {
        return CallMethod<IEnumerator>();
    }
}