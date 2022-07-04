namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of SaveSlotButton allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class SaveSlotButtonR:InstanceClassWrapper<UnityEngine.UI.SaveSlotButton>
{
public SaveSlotButtonR(UnityEngine.UI.SaveSlotButton _orig) : base(_orig) {}
public bool verboseMode
{
get => GetField<bool>();
set => SetField(value);
}

public UnityEngine.Animator topFleur
{
get => orig.topFleur;
set => orig.topFleur = value;
}

public UnityEngine.Animator highlight
{
get => orig.highlight;
set => orig.highlight = value;
}

public UnityEngine.CanvasGroup newGameText
{
get => orig.newGameText;
set => orig.newGameText = value;
}

public UnityEngine.CanvasGroup saveCorruptedText
{
get => orig.saveCorruptedText;
set => orig.saveCorruptedText = value;
}

public UnityEngine.CanvasGroup loadingText
{
get => orig.loadingText;
set => orig.loadingText = value;
}

public UnityEngine.CanvasGroup activeSaveSlot
{
get => orig.activeSaveSlot;
set => orig.activeSaveSlot = value;
}

public UnityEngine.CanvasGroup clearSaveButton
{
get => orig.clearSaveButton;
set => orig.clearSaveButton = value;
}

public UnityEngine.CanvasGroup clearSavePrompt
{
get => orig.clearSavePrompt;
set => orig.clearSavePrompt = value;
}

public UnityEngine.CanvasGroup backgroundCg
{
get => orig.backgroundCg;
set => orig.backgroundCg = value;
}

public UnityEngine.CanvasGroup slotNumberText
{
get => orig.slotNumberText;
set => orig.slotNumberText = value;
}

public UnityEngine.CanvasGroup myCanvasGroup
{
get => orig.myCanvasGroup;
set => orig.myCanvasGroup = value;
}

public UnityEngine.CanvasGroup defeatedText
{
get => orig.defeatedText;
set => orig.defeatedText = value;
}

public UnityEngine.CanvasGroup defeatedBackground
{
get => orig.defeatedBackground;
set => orig.defeatedBackground = value;
}

public UnityEngine.CanvasGroup brokenSteelOrb
{
get => orig.brokenSteelOrb;
set => orig.brokenSteelOrb = value;
}

public UnityEngine.UI.Text geoText
{
get => orig.geoText;
set => orig.geoText = value;
}

public UnityEngine.UI.Text locationText
{
get => orig.locationText;
set => orig.locationText = value;
}

public UnityEngine.UI.Text playTimeText
{
get => orig.playTimeText;
set => orig.playTimeText = value;
}

public UnityEngine.UI.Text completionText
{
get => orig.completionText;
set => orig.completionText = value;
}

public UnityEngine.CanvasGroup normalSoulOrbCg
{
get => orig.normalSoulOrbCg;
set => orig.normalSoulOrbCg = value;
}

public UnityEngine.CanvasGroup hardcoreSoulOrbCg
{
get => orig.hardcoreSoulOrbCg;
set => orig.hardcoreSoulOrbCg = value;
}

public UnityEngine.CanvasGroup ggSoulOrbCg
{
get => orig.ggSoulOrbCg;
set => orig.ggSoulOrbCg = value;
}

public UnityEngine.UI.Image background
{
get => orig.background;
set => orig.background = value;
}

public UnityEngine.UI.Image soulOrbIcon
{
get => orig.soulOrbIcon;
set => orig.soulOrbIcon = value;
}

public SaveProfileHealthBar healthSlots
{
get => orig.healthSlots;
set => orig.healthSlots = value;
}

public UnityEngine.UI.Image geoIcon
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

public UnityEngine.GameObject clearSaveBlocker
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

public UnityEngine.UI.Navigation noNav
{
get => GetField<UnityEngine.UI.Navigation>();
set => SetField(value);
}

public UnityEngine.UI.Navigation fullSlotNav
{
get => GetField<UnityEngine.UI.Navigation>();
set => SetField(value);
}

public UnityEngine.UI.Navigation emptySlotNav
{
get => GetField<UnityEngine.UI.Navigation>();
set => SetField(value);
}

public System.Collections.IEnumerator currentLoadingTextFadeIn
{
get => GetField<System.Collections.IEnumerator>();
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

public UnityEngine.Animator flashEffect
{
get => orig.flashEffect;
set => orig.flashEffect = value;
}

public GlobalEnums.CancelAction cancelAction
{
get => orig.cancelAction;
set => orig.cancelAction = value;
}

public UnityEngine.Animator leftCursor
{
get => orig.leftCursor;
set => orig.leftCursor = value;
}

public UnityEngine.Animator rightCursor
{
get => orig.rightCursor;
set => orig.rightCursor = value;
}

public UnityEngine.Animator selectHighlight
{
get => orig.selectHighlight;
set => orig.selectHighlight = value;
}

public bool playSubmitSound
{
get => orig.playSubmitSound;
set => orig.playSubmitSound = value;
}

public UnityEngine.Animator descriptionText
{
get => orig.descriptionText;
set => orig.descriptionText = value;
}

public MenuAudioController uiAudioPlayer
{
get => GetField<MenuAudioController>();
set => SetField(value);
}

public UnityEngine.GameObject prevSelectedObject
{
get => GetField<UnityEngine.GameObject>();
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

public int SaveSlotIndex
{
get => GetProperty<int>();
}

public System.Action<UnityEngine.UI.MenuButton> submitAction
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

public System.Action<UnityEngine.UI.MenuSelectable> customCancelAction
{
get => orig.customCancelAction;
set => orig.customCancelAction = value;
}

public UnityEngine.UI.Navigation navigation
{
get => orig.navigation;
set => orig.navigation = value;
}

public UnityEngine.UI.ColorBlock colors
{
get => orig.colors;
set => orig.colors = value;
}

public UnityEngine.UI.SpriteState spriteState
{
get => orig.spriteState;
set => orig.spriteState = value;
}

public UnityEngine.UI.AnimationTriggers animationTriggers
{
get => orig.animationTriggers;
set => orig.animationTriggers = value;
}

public UnityEngine.UI.Graphic targetGraphic
{
get => orig.targetGraphic;
set => orig.targetGraphic = value;
}

public bool interactable
{
get => orig.interactable;
set => orig.interactable = value;
}

public UnityEngine.UI.Image image
{
get => orig.image;
set => orig.image = value;
}

public UnityEngine.Animator animator
{
get => orig.animator;
}



public void Awake () =>
CallMethod();

public void OnEnable () =>
CallMethod();

public void Start () =>
CallMethod();

public void Prepare (GameManager gameManager, bool isReload = false) =>
orig.Prepare(gameManager, isReload);

public void ClearCache () =>
orig.ClearCache();

public void ChangeSaveFileState (UnityEngine.UI.SaveSlotButton.SaveFileStates nextSaveFileState) =>
CallMethod(new object[] {nextSaveFileState});

public void OnSubmit (UnityEngine.EventSystems.BaseEventData eventData) =>
orig.OnSubmit(eventData);

public System.Collections.IEnumerator ReloadCorrupted () =>
CallMethod<System.Collections.IEnumerator>();

public void OnPointerClick (UnityEngine.EventSystems.PointerEventData eventData) =>
orig.OnPointerClick(eventData);

public void OnSelect (UnityEngine.EventSystems.BaseEventData eventData) =>
orig.OnSelect(eventData);

public void OnDeselect (UnityEngine.EventSystems.BaseEventData eventData) =>
orig.OnDeselect(eventData);

public void ShowRelevantModeForSaveFileState () =>
orig.ShowRelevantModeForSaveFileState();

public void HideSaveSlot () =>
orig.HideSaveSlot();

public void ClearSavePrompt () =>
orig.ClearSavePrompt();

public void CancelClearSave () =>
orig.CancelClearSave();

public void ClearSaveFile () =>
orig.ClearSaveFile();

public System.Collections.IEnumerator FadeInCanvasGroupAfterDelay (float delay, UnityEngine.CanvasGroup cg) =>
CallMethod<System.Collections.IEnumerator>(new object[] {delay, cg});

public System.Collections.IEnumerator AnimateToSlotState (UnityEngine.UI.SaveSlotButton.SlotState nextState) =>
CallMethod<System.Collections.IEnumerator>(new object[] {nextState});

public void PresentSaveSlot (SaveStats saveStats) =>
CallMethod(new object[] {saveStats});

public void SetupNavs () =>
CallMethod();

public System.Collections.IEnumerator ValidateDeselect () =>
CallMethod<System.Collections.IEnumerator>();

}
}
