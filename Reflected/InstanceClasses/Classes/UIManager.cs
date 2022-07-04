using InControl;
using UnityEngine.Audio;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of UIManager allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class UIManagerRR : InstanceClassWrapper<UIManager>
{
    public UIManagerRR(UIManager _orig) : base(_orig)
    {
    }

    public GameManager gm
    {
        get => GetField<GameManager>();
        set => SetField(value);
    }

    public GameSettings gs
    {
        get => GetField<GameSettings>();
        set => SetField(value);
    }

    public HeroController hero_ctrl
    {
        get => GetField<HeroController>();
        set => SetField(value);
    }

    public PlayerData playerData
    {
        get => GetField<PlayerData>();
        set => SetField(value);
    }

    public InputHandler ih
    {
        get => GetField<InputHandler>();
        set => SetField(value);
    }

    public MenuAudioController uiAudioPlayer
    {
        get => orig.uiAudioPlayer;
        set => orig.uiAudioPlayer = value;
    }

    public HollowKnightInputModule inputModule
    {
        get => orig.inputModule;
        set => orig.inputModule = value;
    }

    public float MENU_FADE_SPEED
    {
        get => orig.MENU_FADE_SPEED;
        set => orig.MENU_FADE_SPEED = value;
    }

    public float MENU_FADE_DELAY
    {
        get => GetFieldStatic<float>();
        set => SetField(value);
    }

    public float MENU_MODAL_DIMMER_ALPHA
    {
        get => GetFieldStatic<float>();
        set => SetField(value);
    }

    public float MENU_FADE_ALPHA_TOLERANCE
    {
        get => GetFieldStatic<float>();
        set => SetField(value);
    }

    public float MENU_FADE_FAILSAFE
    {
        get => GetFieldStatic<float>();
        set => SetField(value);
    }

    public UIState uiState
    {
        get => orig.uiState;
        set => orig.uiState = value;
    }

    public MainMenuState menuState
    {
        get => orig.menuState;
        set => orig.menuState = value;
    }

    public EventSystem eventSystem
    {
        get => orig.eventSystem;
        set => orig.eventSystem = value;
    }

    public Canvas UICanvas
    {
        get => orig.UICanvas;
        set => orig.UICanvas = value;
    }

    public CanvasGroup modalDimmer
    {
        get => orig.modalDimmer;
        set => orig.modalDimmer = value;
    }

    public CanvasScaler canvasScaler
    {
        get => orig.canvasScaler;
        set => orig.canvasScaler = value;
    }

    public AudioMixerSnapshot gameplaySnapshot
    {
        get => orig.gameplaySnapshot;
        set => orig.gameplaySnapshot = value;
    }

    public AudioMixerSnapshot menuSilenceSnapshot
    {
        get => orig.menuSilenceSnapshot;
        set => orig.menuSilenceSnapshot = value;
    }

    public AudioMixerSnapshot menuPauseSnapshot
    {
        get => orig.menuPauseSnapshot;
        set => orig.menuPauseSnapshot = value;
    }

    public CanvasGroup mainMenuScreen
    {
        get => orig.mainMenuScreen;
        set => orig.mainMenuScreen = value;
    }

    public MainMenuOptions mainMenuButtons
    {
        get => orig.mainMenuButtons;
        set => orig.mainMenuButtons = value;
    }

    public SpriteRenderer gameTitle
    {
        get => orig.gameTitle;
        set => orig.gameTitle = value;
    }

    public PlayMakerFSM subtitleFSM
    {
        get => orig.subtitleFSM;
        set => orig.subtitleFSM = value;
    }

    public CanvasGroup saveProfileScreen
    {
        get => orig.saveProfileScreen;
        set => orig.saveProfileScreen = value;
    }

    public CanvasGroup saveProfileTitle
    {
        get => orig.saveProfileTitle;
        set => orig.saveProfileTitle = value;
    }

    public CanvasGroup saveProfileControls
    {
        get => orig.saveProfileControls;
        set => orig.saveProfileControls = value;
    }

    public Animator saveProfileTopFleur
    {
        get => orig.saveProfileTopFleur;
        set => orig.saveProfileTopFleur = value;
    }

    public PreselectOption saveSlots
    {
        get => orig.saveSlots;
        set => orig.saveSlots = value;
    }

    public SaveSlotButton slotOne
    {
        get => orig.slotOne;
        set => orig.slotOne = value;
    }

    public SaveSlotButton slotTwo
    {
        get => orig.slotTwo;
        set => orig.slotTwo = value;
    }

    public SaveSlotButton slotThree
    {
        get => orig.slotThree;
        set => orig.slotThree = value;
    }

    public SaveSlotButton slotFour
    {
        get => orig.slotFour;
        set => orig.slotFour = value;
    }

    public CheckpointSprite checkpointSprite
    {
        get => orig.checkpointSprite;
        set => orig.checkpointSprite = value;
    }

    public MenuScreen optionsMenuScreen
    {
        get => orig.optionsMenuScreen;
        set => orig.optionsMenuScreen = value;
    }

    public MenuScreen gameOptionsMenuScreen
    {
        get => orig.gameOptionsMenuScreen;
        set => orig.gameOptionsMenuScreen = value;
    }

    public GameMenuOptions gameMenuOptions
    {
        get => orig.gameMenuOptions;
        set => orig.gameMenuOptions = value;
    }

    public MenuLanguageSetting languageSetting
    {
        get => orig.languageSetting;
        set => orig.languageSetting = value;
    }

    public MenuSetting backerCreditsSetting
    {
        get => orig.backerCreditsSetting;
        set => orig.backerCreditsSetting = value;
    }

    public MenuSetting nativeAchievementsSetting
    {
        get => orig.nativeAchievementsSetting;
        set => orig.nativeAchievementsSetting = value;
    }

    public MenuSetting controllerRumbleSetting
    {
        get => orig.controllerRumbleSetting;
        set => orig.controllerRumbleSetting = value;
    }

    public MenuSetting nativeInputSetting
    {
        get => orig.nativeInputSetting;
        set => orig.nativeInputSetting = value;
    }

    public MenuScreen audioMenuScreen
    {
        get => orig.audioMenuScreen;
        set => orig.audioMenuScreen = value;
    }

    public MenuAudioSlider masterSlider
    {
        get => orig.masterSlider;
        set => orig.masterSlider = value;
    }

    public MenuAudioSlider musicSlider
    {
        get => orig.musicSlider;
        set => orig.musicSlider = value;
    }

    public MenuAudioSlider soundSlider
    {
        get => orig.soundSlider;
        set => orig.soundSlider = value;
    }

    public MenuScreen videoMenuScreen
    {
        get => orig.videoMenuScreen;
        set => orig.videoMenuScreen = value;
    }

    public VideoMenuOptions videoMenuOptions
    {
        get => orig.videoMenuOptions;
        set => orig.videoMenuOptions = value;
    }

    public MenuResolutionSetting resolutionOption
    {
        get => orig.resolutionOption;
        set => orig.resolutionOption = value;
    }

    public ResolutionCountdownTimer countdownTimer
    {
        get => orig.countdownTimer;
        set => orig.countdownTimer = value;
    }

    public MenuSetting fullscreenOption
    {
        get => orig.fullscreenOption;
        set => orig.fullscreenOption = value;
    }

    public MenuSetting vsyncOption
    {
        get => orig.vsyncOption;
        set => orig.vsyncOption = value;
    }

    public MenuSetting particlesOption
    {
        get => orig.particlesOption;
        set => orig.particlesOption = value;
    }

    public MenuSetting shadersOption
    {
        get => orig.shadersOption;
        set => orig.shadersOption = value;
    }

    public MenuDisplaySetting displayOption
    {
        get => orig.displayOption;
        set => orig.displayOption = value;
    }

    public MenuSetting frameCapOption
    {
        get => orig.frameCapOption;
        set => orig.frameCapOption = value;
    }

    public MenuScreen gamepadMenuScreen
    {
        get => orig.gamepadMenuScreen;
        set => orig.gamepadMenuScreen = value;
    }

    public ControllerDetect controllerDetect
    {
        get => orig.controllerDetect;
        set => orig.controllerDetect = value;
    }

    public MenuScreen remapGamepadMenuScreen
    {
        get => orig.remapGamepadMenuScreen;
        set => orig.remapGamepadMenuScreen = value;
    }

    public MenuScreen keyboardMenuScreen
    {
        get => orig.keyboardMenuScreen;
        set => orig.keyboardMenuScreen = value;
    }

    public MenuScreen overscanMenuScreen
    {
        get => orig.overscanMenuScreen;
        set => orig.overscanMenuScreen = value;
    }

    public OverscanSetting overscanSetting
    {
        get => orig.overscanSetting;
        set => orig.overscanSetting = value;
    }

    public MenuScreen brightnessMenuScreen
    {
        get => orig.brightnessMenuScreen;
        set => orig.brightnessMenuScreen = value;
    }

    public BrightnessSetting brightnessSetting
    {
        get => orig.brightnessSetting;
        set => orig.brightnessSetting = value;
    }

    public MenuScreen achievementsMenuScreen
    {
        get => orig.achievementsMenuScreen;
        set => orig.achievementsMenuScreen = value;
    }

    public RectTransform achievementListRect
    {
        get => orig.achievementListRect;
        set => orig.achievementListRect = value;
    }

    public MenuAchievementsList menuAchievementsList
    {
        get => orig.menuAchievementsList;
        set => orig.menuAchievementsList = value;
    }

    public Sprite hiddenIcon
    {
        get => orig.hiddenIcon;
        set => orig.hiddenIcon = value;
    }

    public GameObject achievementsPopupPanel
    {
        get => orig.achievementsPopupPanel;
        set => orig.achievementsPopupPanel = value;
    }

    public MenuScreen extrasMenuScreen
    {
        get => orig.extrasMenuScreen;
        set => orig.extrasMenuScreen = value;
    }

    public MenuScreen extrasContentMenuScreen
    {
        get => orig.extrasContentMenuScreen;
        set => orig.extrasContentMenuScreen = value;
    }

    public MenuScreen playModeMenuScreen
    {
        get => orig.playModeMenuScreen;
        set => orig.playModeMenuScreen = value;
    }

    public Animator pauseMenuAnimator
    {
        get => orig.pauseMenuAnimator;
        set => orig.pauseMenuAnimator = value;
    }

    public MenuScreen pauseMenuScreen
    {
        get => orig.pauseMenuScreen;
        set => orig.pauseMenuScreen = value;
    }

    public MenuScreen engageMenuScreen
    {
        get => orig.engageMenuScreen;
        set => orig.engageMenuScreen = value;
    }

    public bool didLeaveEngageMenu
    {
        get => orig.didLeaveEngageMenu;
        set => orig.didLeaveEngageMenu = value;
    }

    public MenuScreen noSaveMenuScreen
    {
        get => orig.noSaveMenuScreen;
        set => orig.noSaveMenuScreen = value;
    }

    public MenuScreen quitGamePrompt
    {
        get => orig.quitGamePrompt;
        set => orig.quitGamePrompt = value;
    }

    public MenuScreen returnMainMenuPrompt
    {
        get => orig.returnMainMenuPrompt;
        set => orig.returnMainMenuPrompt = value;
    }

    public MenuScreen resolutionPrompt
    {
        get => orig.resolutionPrompt;
        set => orig.resolutionPrompt = value;
    }

    public CinematicSkipPopup cinematicSkipPopup
    {
        get => GetField<CinematicSkipPopup>();
        set => SetField(value);
    }

    public UIButtonSkins uiButtonSkins
    {
        get => orig.uiButtonSkins;
        set => orig.uiButtonSkins = value;
    }

    public bool clearSaveFile
    {
        get => GetField<bool>();
        set => SetField(value);
    }

    public Selectable lastSelected
    {
        get => GetField<Selectable>();
        set => SetField(value);
    }

    public bool lastSubmitWasMouse
    {
        get => GetField<bool>();
        set => SetField(value);
    }

    public MenuScreen activePrompt
    {
        get => GetField<MenuScreen>();
        set => SetField(value);
    }

    public bool ignoreUnpause
    {
        get => GetField<bool>();
        set => SetField(value);
    }

    public bool isFadingMenu
    {
        get => GetField<bool>();
        set => SetField(value);
    }

    public float startMenuTime
    {
        get => GetField<float>();
        set => SetField(value);
    }

    public float startMenuDelay
    {
        get => GetFieldStatic<float>();
        set => SetField(value);
    }

    public Coroutine togglePauseCo
    {
        get => GetField<Coroutine>();
        set => SetField(value);
    }

    public Coroutine goToPauseMenuCo
    {
        get => GetField<Coroutine>();
        set => SetField(value);
    }

    public Coroutine leavePauseMenuCo
    {
        get => GetField<Coroutine>();
        set => SetField(value);
    }

    public GraphicRaycaster graphicRaycaster
    {
        get => GetField<GraphicRaycaster>();
        set => SetField(value);
    }

    public int menuAnimationCounter
    {
        get => GetField<int>();
        set => SetField(value);
    }

    public UIManager _instance
    {
        get => GetFieldStatic<UIManager>();
        set => SetField(value);
    }

    public bool permaDeath
    {
        get => GetField<bool>();
        set => SetField(value);
    }

    public bool bossRush
    {
        get => GetField<bool>();
        set => SetField(value);
    }

    public Action _editMenus
    {
        get => GetFieldStatic<Action>();
        set => SetField(value);
    }

    public bool hasCalledEditMenus
    {
        get => GetField<bool>();
        set => SetField(value);
    }

    public Action BeforeHideDynamicMenu
    {
        get => GetFieldStatic<Action>();
        set => SetField(value);
    }

    public bool IsFadingMenu => orig.IsFadingMenu;

    public bool IsAnimatingMenus => orig.IsAnimatingMenus;

    public UIManager instance => UIManager.instance;

    public MenuScreen currentDynamicMenu
    {
        get => orig.currentDynamicMenu;
        set => orig.currentDynamicMenu = value;
    }


    public void Awake()
    {
        CallMethod();
    }

    public void SceneInit()
    {
        orig.SceneInit();
    }

    public void Start()
    {
        CallMethod();
    }

    public void SetState(UIState newState)
    {
        orig.SetState(newState);
    }

    public void SetMenuState(MainMenuState newState)
    {
        CallMethod(new object[] { newState });
    }

    public void SetupRefs()
    {
        CallMethod();
    }

    public void SetUIStartState(GameState gameState)
    {
        orig.SetUIStartState(gameState);
    }

    public IEnumerator ShowMainMenuHome()
    {
        return orig.ShowMainMenuHome();
    }

    public Coroutine StartMenuAnimationCoroutine(IEnumerator routine)
    {
        return CallMethod<Coroutine>(new object[] { routine });
    }

    public IEnumerator StartMenuAnimationCoroutineWorker(IEnumerator routine)
    {
        return CallMethod<IEnumerator>(new object[] { routine });
    }

    public void UIGoToOptionsMenu()
    {
        orig.UIGoToOptionsMenu();
    }

    public void UILeaveOptionsMenu()
    {
        orig.UILeaveOptionsMenu();
    }

    public void UIExplicitSwitchUser()
    {
        orig.UIExplicitSwitchUser();
    }

    public void UIGoToEngageMenu()
    {
        orig.UIGoToEngageMenu();
    }

    public void UIGoToNoSaveMenu()
    {
        orig.UIGoToNoSaveMenu();
    }

    public void UIGoToMainMenu()
    {
        orig.UIGoToMainMenu();
    }

    public void UIGoToProfileMenu()
    {
        orig.UIGoToProfileMenu();
    }

    public void UIReturnToProfileMenu()
    {
        orig.UIReturnToProfileMenu();
    }

    public void UIMainStartGame()
    {
        orig.UIMainStartGame();
    }

    public void UIGoToControllerMenu()
    {
        orig.UIGoToControllerMenu();
    }

    public void UIGoToRemapControllerMenu()
    {
        orig.UIGoToRemapControllerMenu();
    }

    public void UIGoToKeyboardMenu()
    {
        orig.UIGoToKeyboardMenu();
    }

    public void UIGoToAudioMenu()
    {
        orig.UIGoToAudioMenu();
    }

    public void UIGoToVideoMenu(bool rollbackRes = false)
    {
        orig.UIGoToVideoMenu(rollbackRes);
    }

    public void UIGoToPauseMenu()
    {
        orig.UIGoToPauseMenu();
    }

    public void UIClosePauseMenu()
    {
        orig.UIClosePauseMenu();
    }

    public void UIClearPauseMenu()
    {
        orig.UIClearPauseMenu();
    }

    public void UnClearPauseMenu()
    {
        orig.UnClearPauseMenu();
    }

    public void UIGoToOverscanMenu()
    {
        orig.UIGoToOverscanMenu();
    }

    public void UIGoToBrightnessMenu()
    {
        orig.UIGoToBrightnessMenu();
    }

    public void UIGoToGameOptionsMenu()
    {
        orig.UIGoToGameOptionsMenu();
    }

    public void UIGoToAchievementsMenu()
    {
        orig.UIGoToAchievementsMenu();
    }

    public void UIGoToExtrasMenu()
    {
        orig.UIGoToExtrasMenu();
    }

    public void UIGoToExtrasContentMenu()
    {
        orig.UIGoToExtrasContentMenu();
    }

    public void UIShowQuitGamePrompt()
    {
        orig.UIShowQuitGamePrompt();
    }

    public void UIShowReturnMenuPrompt()
    {
        orig.UIShowReturnMenuPrompt();
    }

    public void UIShowResolutionPrompt(bool startTimer = false)
    {
        orig.UIShowResolutionPrompt(startTimer);
    }

    public void UILeaveExitToMenuPrompt()
    {
        orig.UILeaveExitToMenuPrompt();
    }

    public void UIGoToPlayModeMenu()
    {
        orig.UIGoToPlayModeMenu();
    }

    public void UIReturnToMainMenu()
    {
        orig.UIReturnToMainMenu();
    }

    public void UIGoToMenuCredits()
    {
        orig.UIGoToMenuCredits();
    }

    public void UIStartNewGame()
    {
        orig.UIStartNewGame();
    }

    public void UIStartNewGameContinue()
    {
        orig.UIStartNewGameContinue();
    }

    public void StartNewGame(bool permaDeath = false, bool bossRush = false)
    {
        orig.StartNewGame(permaDeath, bossRush);
    }

    public void ContinueGame()
    {
        orig.ContinueGame();
    }

    public IEnumerator GoToEngageMenu()
    {
        return orig.GoToEngageMenu();
    }

    public IEnumerator GoToNoSaveMenu()
    {
        return orig.GoToNoSaveMenu();
    }

    public IEnumerator GoToMainMenu()
    {
        return orig.GoToMainMenu();
    }

    public IEnumerator GoToProfileMenu()
    {
        return orig.GoToProfileMenu();
    }

    public IEnumerator PrepareSaveFilesInOrder()
    {
        return CallMethod<IEnumerator>();
    }

    public IEnumerator GoToOptionsMenu()
    {
        return orig.GoToOptionsMenu();
    }

    public IEnumerator GoToControllerMenu()
    {
        return orig.GoToControllerMenu();
    }

    public IEnumerator GoToRemapControllerMenu()
    {
        return orig.GoToRemapControllerMenu();
    }

    public IEnumerator GoToKeyboardMenu()
    {
        return orig.GoToKeyboardMenu();
    }

    public IEnumerator GoToAudioMenu()
    {
        return orig.GoToAudioMenu();
    }

    public IEnumerator GoToVideoMenu(bool rollbackRes = false)
    {
        return orig.GoToVideoMenu(rollbackRes);
    }

    public IEnumerator GoToOverscanMenu()
    {
        return orig.GoToOverscanMenu();
    }

    public IEnumerator GoToBrightnessMenu()
    {
        return orig.GoToBrightnessMenu();
    }

    public IEnumerator GoToGameOptionsMenu()
    {
        return orig.GoToGameOptionsMenu();
    }

    public IEnumerator GoToAchievementsMenu()
    {
        return orig.GoToAchievementsMenu();
    }

    public IEnumerator GoToExtrasMenu()
    {
        return orig.GoToExtrasMenu();
    }

    public IEnumerator GoToExtrasContentMenu()
    {
        return orig.GoToExtrasContentMenu();
    }

    public IEnumerator GoToQuitGamePrompt()
    {
        return orig.GoToQuitGamePrompt();
    }

    public IEnumerator GoToReturnMenuPrompt()
    {
        return orig.GoToReturnMenuPrompt();
    }

    public IEnumerator GoToResolutionPrompt(bool startTimer = false)
    {
        return orig.GoToResolutionPrompt(startTimer);
    }

    public IEnumerator LeaveOptionsMenu()
    {
        return orig.LeaveOptionsMenu();
    }

    public IEnumerator LeaveExitToMenuPrompt()
    {
        return orig.LeaveExitToMenuPrompt();
    }

    public IEnumerator GoToPlayModeMenu()
    {
        return orig.GoToPlayModeMenu();
    }

    public IEnumerator ReturnToMainMenu()
    {
        return orig.ReturnToMainMenu();
    }

    public IEnumerator GoToPauseMenu()
    {
        return orig.GoToPauseMenu();
    }

    public IEnumerator GoToMenuCredits()
    {
        return orig.GoToMenuCredits();
    }

    public void ShowCutscenePrompt(CinematicSkipPopup.Texts text)
    {
        orig.ShowCutscenePrompt(text);
    }

    public void HideCutscenePrompt()
    {
        orig.HideCutscenePrompt();
    }

    public void ApplyAudioMenuSettings()
    {
        orig.ApplyAudioMenuSettings();
    }

    public void ApplyVideoMenuSettings()
    {
        orig.ApplyVideoMenuSettings();
    }

    public void ApplyControllerMenuSettings()
    {
        orig.ApplyControllerMenuSettings();
    }

    public void ApplyRemapGamepadMenuSettings()
    {
        orig.ApplyRemapGamepadMenuSettings();
    }

    public void ApplyKeyboardMenuSettings()
    {
        orig.ApplyKeyboardMenuSettings();
    }

    public void ApplyOverscanSettings(bool goToBrightness = false)
    {
        orig.ApplyOverscanSettings(goToBrightness);
    }

    public void ApplyBrightnessSettings()
    {
        orig.ApplyBrightnessSettings();
    }

    public void ApplyGameMenuSettings()
    {
        orig.ApplyGameMenuSettings();
    }

    public void SaveOverscanSettings()
    {
        orig.SaveOverscanSettings();
    }

    public void SaveBrightnessSettings()
    {
        orig.SaveBrightnessSettings();
    }

    public void DefaultAudioMenuSettings()
    {
        orig.DefaultAudioMenuSettings();
    }

    public void DefaultVideoMenuSettings()
    {
        orig.DefaultVideoMenuSettings();
    }

    public void DefaultGamepadMenuSettings()
    {
        orig.DefaultGamepadMenuSettings();
    }

    public void DefaultKeyboardMenuSettings()
    {
        orig.DefaultKeyboardMenuSettings();
    }

    public void DefaultGameMenuSettings()
    {
        orig.DefaultGameMenuSettings();
    }

    public void LoadStoredSettings()
    {
        orig.LoadStoredSettings();
    }

    public void LoadAudioSettings()
    {
        CallMethod();
    }

    public void LoadVideoSettings()
    {
        CallMethod();
    }

    public void LoadGameOptionsSettings()
    {
        CallMethod();
    }

    public void LoadControllerSettings()
    {
        CallMethod();
    }

    public void RefreshAudioControls()
    {
        CallMethod();
    }

    public void RefreshVideoControls()
    {
        CallMethod();
    }

    public void DisableFrameCapSetting()
    {
        orig.DisableFrameCapSetting();
    }

    public void DisableVsyncSetting()
    {
        orig.DisableVsyncSetting();
    }

    public void RefreshKeyboardControls()
    {
        CallMethod();
    }

    public void RefreshGameOptionsControls()
    {
        CallMethod();
    }

    public void RefreshAchievementsList()
    {
        orig.RefreshAchievementsList();
    }

    public void UpdateMenuAchievementStatus(Achievement ach, MenuAchievement menuAch)
    {
        CallMethod(new object[] { ach, menuAch });
    }

    public void TogglePauseGame()
    {
        orig.TogglePauseGame();
    }

    public void QuitGame()
    {
        orig.QuitGame();
    }

    public void FadeOutMenuAudio(float duration)
    {
        orig.FadeOutMenuAudio(duration);
    }

    public void AudioGoToPauseMenu(float duration)
    {
        orig.AudioGoToPauseMenu(duration);
    }

    public void AudioGoToGameplay(float duration)
    {
        orig.AudioGoToGameplay(duration);
    }

    public void ConfigureMenu()
    {
        orig.ConfigureMenu();
    }

    public IEnumerator HideCurrentMenu()
    {
        return orig.HideCurrentMenu();
    }

    public IEnumerator ShowMenu(MenuScreen menu)
    {
        return orig.ShowMenu(menu);
    }

    public IEnumerator HideMenu(MenuScreen menu)
    {
        return orig.HideMenu(menu);
    }

    public void HideMenuInstant(MenuScreen menu)
    {
        orig.HideMenuInstant(menu);
    }

    public IEnumerator HideSaveProfileMenu()
    {
        return orig.HideSaveProfileMenu();
    }

    public void DisableScreens()
    {
        CallMethod();
    }

    public void ShowCanvas(Canvas canvas)
    {
        CallMethod(new object[] { canvas });
    }

    public void HideCanvas(Canvas canvas)
    {
        CallMethod(new object[] { canvas });
    }

    public void ShowCanvasGroup(CanvasGroup cg)
    {
        orig.ShowCanvasGroup(cg);
    }

    public void HideCanvasGroup(CanvasGroup cg)
    {
        orig.HideCanvasGroup(cg);
    }

    public IEnumerator FadeInCanvasGroup(CanvasGroup cg)
    {
        return orig.FadeInCanvasGroup(cg);
    }

    public IEnumerator FadeInCanvasGroupAlpha(CanvasGroup cg, float endAlpha)
    {
        return orig.FadeInCanvasGroupAlpha(cg, endAlpha);
    }

    public IEnumerator FadeOutCanvasGroup(CanvasGroup cg)
    {
        return orig.FadeOutCanvasGroup(cg);
    }

    public IEnumerator FadeInSprite(SpriteRenderer sprite)
    {
        return CallMethod<IEnumerator>(new object[] { sprite });
    }

    public IEnumerator FadeOutSprite(SpriteRenderer sprite)
    {
        return CallMethod<IEnumerator>(new object[] { sprite });
    }

    public void EnableChildren(RectTransform parent)
    {
        CallMethod(new object[] { parent });
    }

    public void EnableChildren(Canvas parent)
    {
        CallMethod(new object[] { parent });
    }

    public void DisableChildren(Canvas parent)
    {
        CallMethod(new object[] { parent });
    }

    public float GetAnimationClipLength(Animator animator, string clipName)
    {
        return CallMethod<float>(new object[] { animator, clipName });
    }

    public void MakeMenuLean()
    {
        orig.MakeMenuLean();
    }

    public UIManager orig_get_instance()
    {
        return UIManager.orig_get_instance();
    }

    public Sprite LoadImage()
    {
        return CallMethod<Sprite>();
    }

    public void orig_Awake()
    {
        CallMethod();
    }

    public void orig_Start()
    {
        CallMethod();
    }

    public IEnumerator orig_HideCurrentMenu()
    {
        return orig.orig_HideCurrentMenu();
    }

    public void UIGoToDynamicMenu(MenuScreen menu)
    {
        orig.UIGoToDynamicMenu(menu);
    }

    public IEnumerator GoToDynamicMenu(MenuScreen menu)
    {
        return orig.GoToDynamicMenu(menu);
    }

    public void UILeaveDynamicMenu(MenuScreen to, MainMenuState state)
    {
        orig.UILeaveDynamicMenu(to, state);
    }

    public IEnumerator LeaveDynamicMenu(MenuScreen to, MainMenuState state)
    {
        return orig.LeaveDynamicMenu(to, state);
    }

    public void UIPauseToDynamicMenu(MenuScreen to)
    {
        orig.UIPauseToDynamicMenu(to);
    }

    public IEnumerator PauseToDynamicMenu(MenuScreen to)
    {
        return orig.PauseToDynamicMenu(to);
    }
}