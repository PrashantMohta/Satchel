using InControl;
using UnityEngine.Audio;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Satchel.Reflected;

public static class UIManagerR
{
    public static GameManager gm
    {
        get => ReflectionHelper.GetField<UIManager, GameManager>(UIManager.instance, "gm");
        set => ReflectionHelper.SetField(UIManager.instance, "gm", value);
    }

    public static GameSettings gs
    {
        get => ReflectionHelper.GetField<UIManager, GameSettings>(UIManager.instance, "gs");
        set => ReflectionHelper.SetField(UIManager.instance, "gs", value);
    }

    public static HeroController hero_ctrl
    {
        get => ReflectionHelper.GetField<UIManager, HeroController>(UIManager.instance, "hero_ctrl");
        set => ReflectionHelper.SetField(UIManager.instance, "hero_ctrl", value);
    }

    public static PlayerData playerData
    {
        get => ReflectionHelper.GetField<UIManager, PlayerData>(UIManager.instance, "playerData");
        set => ReflectionHelper.SetField(UIManager.instance, "playerData", value);
    }

    public static InputHandler ih
    {
        get => ReflectionHelper.GetField<UIManager, InputHandler>(UIManager.instance, "ih");
        set => ReflectionHelper.SetField(UIManager.instance, "ih", value);
    }

    public static MenuAudioController uiAudioPlayer
    {
        get => UIManager.instance.uiAudioPlayer;
        set => UIManager.instance.uiAudioPlayer = value;
    }

    public static HollowKnightInputModule inputModule
    {
        get => UIManager.instance.inputModule;
        set => UIManager.instance.inputModule = value;
    }

    public static float MENU_FADE_SPEED
    {
        get => UIManager.instance.MENU_FADE_SPEED;
        set => UIManager.instance.MENU_FADE_SPEED = value;
    }

    public static UIState uiState
    {
        get => UIManager.instance.uiState;
        set => UIManager.instance.uiState = value;
    }

    public static MainMenuState menuState
    {
        get => UIManager.instance.menuState;
        set => UIManager.instance.menuState = value;
    }

    public static EventSystem eventSystem
    {
        get => UIManager.instance.eventSystem;
        set => UIManager.instance.eventSystem = value;
    }

    public static Canvas UICanvas
    {
        get => UIManager.instance.UICanvas;
        set => UIManager.instance.UICanvas = value;
    }

    public static CanvasGroup modalDimmer
    {
        get => UIManager.instance.modalDimmer;
        set => UIManager.instance.modalDimmer = value;
    }

    public static CanvasScaler canvasScaler
    {
        get => UIManager.instance.canvasScaler;
        set => UIManager.instance.canvasScaler = value;
    }

    public static AudioMixerSnapshot gameplaySnapshot
    {
        get => UIManager.instance.gameplaySnapshot;
        set => UIManager.instance.gameplaySnapshot = value;
    }

    public static AudioMixerSnapshot menuSilenceSnapshot
    {
        get => UIManager.instance.menuSilenceSnapshot;
        set => UIManager.instance.menuSilenceSnapshot = value;
    }

    public static AudioMixerSnapshot menuPauseSnapshot
    {
        get => UIManager.instance.menuPauseSnapshot;
        set => UIManager.instance.menuPauseSnapshot = value;
    }

    public static CanvasGroup mainMenuScreen
    {
        get => UIManager.instance.mainMenuScreen;
        set => UIManager.instance.mainMenuScreen = value;
    }

    public static MainMenuOptions mainMenuButtons
    {
        get => UIManager.instance.mainMenuButtons;
        set => UIManager.instance.mainMenuButtons = value;
    }

    public static SpriteRenderer gameTitle
    {
        get => UIManager.instance.gameTitle;
        set => UIManager.instance.gameTitle = value;
    }

    public static PlayMakerFSM subtitleFSM
    {
        get => UIManager.instance.subtitleFSM;
        set => UIManager.instance.subtitleFSM = value;
    }

    public static CanvasGroup saveProfileScreen
    {
        get => UIManager.instance.saveProfileScreen;
        set => UIManager.instance.saveProfileScreen = value;
    }

    public static CanvasGroup saveProfileTitle
    {
        get => UIManager.instance.saveProfileTitle;
        set => UIManager.instance.saveProfileTitle = value;
    }

    public static CanvasGroup saveProfileControls
    {
        get => UIManager.instance.saveProfileControls;
        set => UIManager.instance.saveProfileControls = value;
    }

    public static Animator saveProfileTopFleur
    {
        get => UIManager.instance.saveProfileTopFleur;
        set => UIManager.instance.saveProfileTopFleur = value;
    }

    public static PreselectOption saveSlots
    {
        get => UIManager.instance.saveSlots;
        set => UIManager.instance.saveSlots = value;
    }

    public static SaveSlotButton slotOne
    {
        get => UIManager.instance.slotOne;
        set => UIManager.instance.slotOne = value;
    }

    public static SaveSlotButton slotTwo
    {
        get => UIManager.instance.slotTwo;
        set => UIManager.instance.slotTwo = value;
    }

    public static SaveSlotButton slotThree
    {
        get => UIManager.instance.slotThree;
        set => UIManager.instance.slotThree = value;
    }

    public static SaveSlotButton slotFour
    {
        get => UIManager.instance.slotFour;
        set => UIManager.instance.slotFour = value;
    }

    public static CheckpointSprite checkpointSprite
    {
        get => UIManager.instance.checkpointSprite;
        set => UIManager.instance.checkpointSprite = value;
    }

    public static MenuScreen optionsMenuScreen
    {
        get => UIManager.instance.optionsMenuScreen;
        set => UIManager.instance.optionsMenuScreen = value;
    }

    public static MenuScreen gameOptionsMenuScreen
    {
        get => UIManager.instance.gameOptionsMenuScreen;
        set => UIManager.instance.gameOptionsMenuScreen = value;
    }

    public static GameMenuOptions gameMenuOptions
    {
        get => UIManager.instance.gameMenuOptions;
        set => UIManager.instance.gameMenuOptions = value;
    }

    public static MenuLanguageSetting languageSetting
    {
        get => UIManager.instance.languageSetting;
        set => UIManager.instance.languageSetting = value;
    }

    public static MenuSetting backerCreditsSetting
    {
        get => UIManager.instance.backerCreditsSetting;
        set => UIManager.instance.backerCreditsSetting = value;
    }

    public static MenuSetting nativeAchievementsSetting
    {
        get => UIManager.instance.nativeAchievementsSetting;
        set => UIManager.instance.nativeAchievementsSetting = value;
    }

    public static MenuSetting controllerRumbleSetting
    {
        get => UIManager.instance.controllerRumbleSetting;
        set => UIManager.instance.controllerRumbleSetting = value;
    }

    public static MenuSetting nativeInputSetting
    {
        get => UIManager.instance.nativeInputSetting;
        set => UIManager.instance.nativeInputSetting = value;
    }

    public static MenuScreen audioMenuScreen
    {
        get => UIManager.instance.audioMenuScreen;
        set => UIManager.instance.audioMenuScreen = value;
    }

    public static MenuAudioSlider masterSlider
    {
        get => UIManager.instance.masterSlider;
        set => UIManager.instance.masterSlider = value;
    }

    public static MenuAudioSlider musicSlider
    {
        get => UIManager.instance.musicSlider;
        set => UIManager.instance.musicSlider = value;
    }

    public static MenuAudioSlider soundSlider
    {
        get => UIManager.instance.soundSlider;
        set => UIManager.instance.soundSlider = value;
    }

    public static MenuScreen videoMenuScreen
    {
        get => UIManager.instance.videoMenuScreen;
        set => UIManager.instance.videoMenuScreen = value;
    }

    public static VideoMenuOptions videoMenuOptions
    {
        get => UIManager.instance.videoMenuOptions;
        set => UIManager.instance.videoMenuOptions = value;
    }

    public static MenuResolutionSetting resolutionOption
    {
        get => UIManager.instance.resolutionOption;
        set => UIManager.instance.resolutionOption = value;
    }

    public static ResolutionCountdownTimer countdownTimer
    {
        get => UIManager.instance.countdownTimer;
        set => UIManager.instance.countdownTimer = value;
    }

    public static MenuSetting fullscreenOption
    {
        get => UIManager.instance.fullscreenOption;
        set => UIManager.instance.fullscreenOption = value;
    }

    public static MenuSetting vsyncOption
    {
        get => UIManager.instance.vsyncOption;
        set => UIManager.instance.vsyncOption = value;
    }

    public static MenuSetting particlesOption
    {
        get => UIManager.instance.particlesOption;
        set => UIManager.instance.particlesOption = value;
    }

    public static MenuSetting shadersOption
    {
        get => UIManager.instance.shadersOption;
        set => UIManager.instance.shadersOption = value;
    }

    public static MenuDisplaySetting displayOption
    {
        get => UIManager.instance.displayOption;
        set => UIManager.instance.displayOption = value;
    }

    public static MenuSetting frameCapOption
    {
        get => UIManager.instance.frameCapOption;
        set => UIManager.instance.frameCapOption = value;
    }

    public static MenuScreen gamepadMenuScreen
    {
        get => UIManager.instance.gamepadMenuScreen;
        set => UIManager.instance.gamepadMenuScreen = value;
    }

    public static ControllerDetect controllerDetect
    {
        get => UIManager.instance.controllerDetect;
        set => UIManager.instance.controllerDetect = value;
    }

    public static MenuScreen remapGamepadMenuScreen
    {
        get => UIManager.instance.remapGamepadMenuScreen;
        set => UIManager.instance.remapGamepadMenuScreen = value;
    }

    public static MenuScreen keyboardMenuScreen
    {
        get => UIManager.instance.keyboardMenuScreen;
        set => UIManager.instance.keyboardMenuScreen = value;
    }

    public static MenuScreen overscanMenuScreen
    {
        get => UIManager.instance.overscanMenuScreen;
        set => UIManager.instance.overscanMenuScreen = value;
    }

    public static OverscanSetting overscanSetting
    {
        get => UIManager.instance.overscanSetting;
        set => UIManager.instance.overscanSetting = value;
    }

    public static MenuScreen brightnessMenuScreen
    {
        get => UIManager.instance.brightnessMenuScreen;
        set => UIManager.instance.brightnessMenuScreen = value;
    }

    public static BrightnessSetting brightnessSetting
    {
        get => UIManager.instance.brightnessSetting;
        set => UIManager.instance.brightnessSetting = value;
    }

    public static MenuScreen achievementsMenuScreen
    {
        get => UIManager.instance.achievementsMenuScreen;
        set => UIManager.instance.achievementsMenuScreen = value;
    }

    public static RectTransform achievementListRect
    {
        get => UIManager.instance.achievementListRect;
        set => UIManager.instance.achievementListRect = value;
    }

    public static MenuAchievementsList menuAchievementsList
    {
        get => UIManager.instance.menuAchievementsList;
        set => UIManager.instance.menuAchievementsList = value;
    }

    public static Sprite hiddenIcon
    {
        get => UIManager.instance.hiddenIcon;
        set => UIManager.instance.hiddenIcon = value;
    }

    public static GameObject achievementsPopupPanel
    {
        get => UIManager.instance.achievementsPopupPanel;
        set => UIManager.instance.achievementsPopupPanel = value;
    }

    public static MenuScreen extrasMenuScreen
    {
        get => UIManager.instance.extrasMenuScreen;
        set => UIManager.instance.extrasMenuScreen = value;
    }

    public static MenuScreen extrasContentMenuScreen
    {
        get => UIManager.instance.extrasContentMenuScreen;
        set => UIManager.instance.extrasContentMenuScreen = value;
    }

    public static MenuScreen playModeMenuScreen
    {
        get => UIManager.instance.playModeMenuScreen;
        set => UIManager.instance.playModeMenuScreen = value;
    }

    public static Animator pauseMenuAnimator
    {
        get => UIManager.instance.pauseMenuAnimator;
        set => UIManager.instance.pauseMenuAnimator = value;
    }

    public static MenuScreen pauseMenuScreen
    {
        get => UIManager.instance.pauseMenuScreen;
        set => UIManager.instance.pauseMenuScreen = value;
    }

    public static MenuScreen engageMenuScreen
    {
        get => UIManager.instance.engageMenuScreen;
        set => UIManager.instance.engageMenuScreen = value;
    }

    public static bool didLeaveEngageMenu
    {
        get => UIManager.instance.didLeaveEngageMenu;
        set => UIManager.instance.didLeaveEngageMenu = value;
    }

    public static MenuScreen noSaveMenuScreen
    {
        get => UIManager.instance.noSaveMenuScreen;
        set => UIManager.instance.noSaveMenuScreen = value;
    }

    public static MenuScreen quitGamePrompt
    {
        get => UIManager.instance.quitGamePrompt;
        set => UIManager.instance.quitGamePrompt = value;
    }

    public static MenuScreen returnMainMenuPrompt
    {
        get => UIManager.instance.returnMainMenuPrompt;
        set => UIManager.instance.returnMainMenuPrompt = value;
    }

    public static MenuScreen resolutionPrompt
    {
        get => UIManager.instance.resolutionPrompt;
        set => UIManager.instance.resolutionPrompt = value;
    }

    public static CinematicSkipPopup cinematicSkipPopup
    {
        get => ReflectionHelper.GetField<UIManager, CinematicSkipPopup>(UIManager.instance, "cinematicSkipPopup");
        set => ReflectionHelper.SetField(UIManager.instance, "cinematicSkipPopup", value);
    }

    public static UIButtonSkins uiButtonSkins
    {
        get => UIManager.instance.uiButtonSkins;
        set => UIManager.instance.uiButtonSkins = value;
    }

    public static bool clearSaveFile
    {
        get => ReflectionHelper.GetField<UIManager, bool>(UIManager.instance, "clearSaveFile");
        set => ReflectionHelper.SetField(UIManager.instance, "clearSaveFile", value);
    }

    public static Selectable lastSelected
    {
        get => ReflectionHelper.GetField<UIManager, Selectable>(UIManager.instance, "lastSelected");
        set => ReflectionHelper.SetField(UIManager.instance, "lastSelected", value);
    }

    public static bool lastSubmitWasMouse
    {
        get => ReflectionHelper.GetField<UIManager, bool>(UIManager.instance, "lastSubmitWasMouse");
        set => ReflectionHelper.SetField(UIManager.instance, "lastSubmitWasMouse", value);
    }

    public static MenuScreen activePrompt
    {
        get => ReflectionHelper.GetField<UIManager, MenuScreen>(UIManager.instance, "activePrompt");
        set => ReflectionHelper.SetField(UIManager.instance, "activePrompt", value);
    }

    public static bool ignoreUnpause
    {
        get => ReflectionHelper.GetField<UIManager, bool>(UIManager.instance, "ignoreUnpause");
        set => ReflectionHelper.SetField(UIManager.instance, "ignoreUnpause", value);
    }

    public static bool isFadingMenu
    {
        get => ReflectionHelper.GetField<UIManager, bool>(UIManager.instance, "isFadingMenu");
        set => ReflectionHelper.SetField(UIManager.instance, "isFadingMenu", value);
    }

    public static float startMenuTime
    {
        get => ReflectionHelper.GetField<UIManager, float>(UIManager.instance, "startMenuTime");
        set => ReflectionHelper.SetField(UIManager.instance, "startMenuTime", value);
    }

    public static Coroutine togglePauseCo
    {
        get => ReflectionHelper.GetField<UIManager, Coroutine>(UIManager.instance, "togglePauseCo");
        set => ReflectionHelper.SetField(UIManager.instance, "togglePauseCo", value);
    }

    public static Coroutine goToPauseMenuCo
    {
        get => ReflectionHelper.GetField<UIManager, Coroutine>(UIManager.instance, "goToPauseMenuCo");
        set => ReflectionHelper.SetField(UIManager.instance, "goToPauseMenuCo", value);
    }

    public static Coroutine leavePauseMenuCo
    {
        get => ReflectionHelper.GetField<UIManager, Coroutine>(UIManager.instance, "leavePauseMenuCo");
        set => ReflectionHelper.SetField(UIManager.instance, "leavePauseMenuCo", value);
    }

    public static GraphicRaycaster graphicRaycaster
    {
        get => ReflectionHelper.GetField<UIManager, GraphicRaycaster>(UIManager.instance, "graphicRaycaster");
        set => ReflectionHelper.SetField(UIManager.instance, "graphicRaycaster", value);
    }

    public static int menuAnimationCounter
    {
        get => ReflectionHelper.GetField<UIManager, int>(UIManager.instance, "menuAnimationCounter");
        set => ReflectionHelper.SetField(UIManager.instance, "menuAnimationCounter", value);
    }

    public static bool permaDeath
    {
        get => ReflectionHelper.GetField<UIManager, bool>(UIManager.instance, "permaDeath");
        set => ReflectionHelper.SetField(UIManager.instance, "permaDeath", value);
    }

    public static bool bossRush
    {
        get => ReflectionHelper.GetField<UIManager, bool>(UIManager.instance, "bossRush");
        set => ReflectionHelper.SetField(UIManager.instance, "bossRush", value);
    }

    public static bool hasCalledEditMenus
    {
        get => ReflectionHelper.GetField<UIManager, bool>(UIManager.instance, "hasCalledEditMenus");
        set => ReflectionHelper.SetField(UIManager.instance, "hasCalledEditMenus", value);
    }

    public static bool IsFadingMenu => UIManager.instance.IsFadingMenu;

    public static bool IsAnimatingMenus => UIManager.instance.IsAnimatingMenus;

    public static MenuScreen currentDynamicMenu
    {
        get => UIManager.instance.currentDynamicMenu;
        set => UIManager.instance.currentDynamicMenu = value;
    }

    public static bool useGUILayout
    {
        get => UIManager.instance.useGUILayout;
        set => UIManager.instance.useGUILayout = value;
    }

    public static bool enabled
    {
        get => UIManager.instance.enabled;
        set => UIManager.instance.enabled = value;
    }

    public static bool isActiveAndEnabled => UIManager.instance.isActiveAndEnabled;

    public static Transform transform => UIManager.instance.transform;

    public static GameObject gameObject => UIManager.instance.gameObject;

    public static string tag
    {
        get => UIManager.instance.tag;
        set => UIManager.instance.tag = value;
    }

    public static string name
    {
        get => UIManager.instance.name;
        set => UIManager.instance.name = value;
    }

    public static HideFlags hideFlags
    {
        get => UIManager.instance.hideFlags;
        set => UIManager.instance.hideFlags = value;
    }

    public static void Awake()
    {
        ReflectionHelper.CallMethod(UIManager.instance, "Awake");
    }

    public static void SceneInit()
    {
        UIManager.instance.SceneInit();
    }

    public static void Start()
    {
        ReflectionHelper.CallMethod(UIManager.instance, "Start");
    }

    public static void SetState(UIState newState)
    {
        UIManager.instance.SetState(newState);
    }

    public static void SetMenuState(MainMenuState newState)
    {
        ReflectionHelper.CallMethod(UIManager.instance, "SetMenuState", newState);
    }

    public static void SetupRefs()
    {
        ReflectionHelper.CallMethod(UIManager.instance, "SetupRefs");
    }

    public static void SetUIStartState(GameState gameState)
    {
        UIManager.instance.SetUIStartState(gameState);
    }

    public static IEnumerator ShowMainMenuHome()
    {
        return UIManager.instance.ShowMainMenuHome();
    }

    public static Coroutine StartMenuAnimationCoroutine(IEnumerator routine)
    {
        return ReflectionHelper.CallMethod<UIManager, Coroutine>(UIManager.instance, "StartMenuAnimationCoroutine",
            routine);
    }

    public static IEnumerator StartMenuAnimationCoroutineWorker(IEnumerator routine)
    {
        return ReflectionHelper.CallMethod<UIManager, IEnumerator>(UIManager.instance,
            "StartMenuAnimationCoroutineWorker", routine);
    }

    public static void UIGoToOptionsMenu()
    {
        UIManager.instance.UIGoToOptionsMenu();
    }

    public static void UILeaveOptionsMenu()
    {
        UIManager.instance.UILeaveOptionsMenu();
    }

    public static void UIExplicitSwitchUser()
    {
        UIManager.instance.UIExplicitSwitchUser();
    }

    public static void UIGoToEngageMenu()
    {
        UIManager.instance.UIGoToEngageMenu();
    }

    public static void UIGoToNoSaveMenu()
    {
        UIManager.instance.UIGoToNoSaveMenu();
    }

    public static void UIGoToMainMenu()
    {
        UIManager.instance.UIGoToMainMenu();
    }

    public static void UIGoToProfileMenu()
    {
        UIManager.instance.UIGoToProfileMenu();
    }

    public static void UIReturnToProfileMenu()
    {
        UIManager.instance.UIReturnToProfileMenu();
    }

    public static void UIMainStartGame()
    {
        UIManager.instance.UIMainStartGame();
    }

    public static void UIGoToControllerMenu()
    {
        UIManager.instance.UIGoToControllerMenu();
    }

    public static void UIGoToRemapControllerMenu()
    {
        UIManager.instance.UIGoToRemapControllerMenu();
    }

    public static void UIGoToKeyboardMenu()
    {
        UIManager.instance.UIGoToKeyboardMenu();
    }

    public static void UIGoToAudioMenu()
    {
        UIManager.instance.UIGoToAudioMenu();
    }

    public static void UIGoToVideoMenu(bool rollbackRes = false)
    {
        UIManager.instance.UIGoToVideoMenu(rollbackRes);
    }

    public static void UIGoToPauseMenu()
    {
        UIManager.instance.UIGoToPauseMenu();
    }

    public static void UIClosePauseMenu()
    {
        UIManager.instance.UIClosePauseMenu();
    }

    public static void UIClearPauseMenu()
    {
        UIManager.instance.UIClearPauseMenu();
    }

    public static void UnClearPauseMenu()
    {
        UIManager.instance.UnClearPauseMenu();
    }

    public static void UIGoToOverscanMenu()
    {
        UIManager.instance.UIGoToOverscanMenu();
    }

    public static void UIGoToBrightnessMenu()
    {
        UIManager.instance.UIGoToBrightnessMenu();
    }

    public static void UIGoToGameOptionsMenu()
    {
        UIManager.instance.UIGoToGameOptionsMenu();
    }

    public static void UIGoToAchievementsMenu()
    {
        UIManager.instance.UIGoToAchievementsMenu();
    }

    public static void UIGoToExtrasMenu()
    {
        UIManager.instance.UIGoToExtrasMenu();
    }

    public static void UIGoToExtrasContentMenu()
    {
        UIManager.instance.UIGoToExtrasContentMenu();
    }

    public static void UIShowQuitGamePrompt()
    {
        UIManager.instance.UIShowQuitGamePrompt();
    }

    public static void UIShowReturnMenuPrompt()
    {
        UIManager.instance.UIShowReturnMenuPrompt();
    }

    public static void UIShowResolutionPrompt(bool startTimer = false)
    {
        UIManager.instance.UIShowResolutionPrompt(startTimer);
    }

    public static void UILeaveExitToMenuPrompt()
    {
        UIManager.instance.UILeaveExitToMenuPrompt();
    }

    public static void UIGoToPlayModeMenu()
    {
        UIManager.instance.UIGoToPlayModeMenu();
    }

    public static void UIReturnToMainMenu()
    {
        UIManager.instance.UIReturnToMainMenu();
    }

    public static void UIGoToMenuCredits()
    {
        UIManager.instance.UIGoToMenuCredits();
    }

    public static void UIStartNewGame()
    {
        UIManager.instance.UIStartNewGame();
    }

    public static void UIStartNewGameContinue()
    {
        UIManager.instance.UIStartNewGameContinue();
    }

    public static void StartNewGame(bool permaDeath = false, bool bossRush = false)
    {
        UIManager.instance.StartNewGame(permaDeath, bossRush);
    }

    public static void ContinueGame()
    {
        UIManager.instance.ContinueGame();
    }

    public static IEnumerator GoToEngageMenu()
    {
        return UIManager.instance.GoToEngageMenu();
    }

    public static IEnumerator GoToNoSaveMenu()
    {
        return UIManager.instance.GoToNoSaveMenu();
    }

    public static IEnumerator GoToMainMenu()
    {
        return UIManager.instance.GoToMainMenu();
    }

    public static IEnumerator GoToProfileMenu()
    {
        return UIManager.instance.GoToProfileMenu();
    }

    public static IEnumerator PrepareSaveFilesInOrder()
    {
        return ReflectionHelper.CallMethod<UIManager, IEnumerator>(UIManager.instance, "PrepareSaveFilesInOrder");
    }

    public static IEnumerator GoToOptionsMenu()
    {
        return UIManager.instance.GoToOptionsMenu();
    }

    public static IEnumerator GoToControllerMenu()
    {
        return UIManager.instance.GoToControllerMenu();
    }

    public static IEnumerator GoToRemapControllerMenu()
    {
        return UIManager.instance.GoToRemapControllerMenu();
    }

    public static IEnumerator GoToKeyboardMenu()
    {
        return UIManager.instance.GoToKeyboardMenu();
    }

    public static IEnumerator GoToAudioMenu()
    {
        return UIManager.instance.GoToAudioMenu();
    }

    public static IEnumerator GoToVideoMenu(bool rollbackRes = false)
    {
        return UIManager.instance.GoToVideoMenu(rollbackRes);
    }

    public static IEnumerator GoToOverscanMenu()
    {
        return UIManager.instance.GoToOverscanMenu();
    }

    public static IEnumerator GoToBrightnessMenu()
    {
        return UIManager.instance.GoToBrightnessMenu();
    }

    public static IEnumerator GoToGameOptionsMenu()
    {
        return UIManager.instance.GoToGameOptionsMenu();
    }

    public static IEnumerator GoToAchievementsMenu()
    {
        return UIManager.instance.GoToAchievementsMenu();
    }

    public static IEnumerator GoToExtrasMenu()
    {
        return UIManager.instance.GoToExtrasMenu();
    }

    public static IEnumerator GoToExtrasContentMenu()
    {
        return UIManager.instance.GoToExtrasContentMenu();
    }

    public static IEnumerator GoToQuitGamePrompt()
    {
        return UIManager.instance.GoToQuitGamePrompt();
    }

    public static IEnumerator GoToReturnMenuPrompt()
    {
        return UIManager.instance.GoToReturnMenuPrompt();
    }

    public static IEnumerator GoToResolutionPrompt(bool startTimer = false)
    {
        return UIManager.instance.GoToResolutionPrompt(startTimer);
    }

    public static IEnumerator LeaveOptionsMenu()
    {
        return UIManager.instance.LeaveOptionsMenu();
    }

    public static IEnumerator LeaveExitToMenuPrompt()
    {
        return UIManager.instance.LeaveExitToMenuPrompt();
    }

    public static IEnumerator GoToPlayModeMenu()
    {
        return UIManager.instance.GoToPlayModeMenu();
    }

    public static IEnumerator ReturnToMainMenu()
    {
        return UIManager.instance.ReturnToMainMenu();
    }

    public static IEnumerator GoToPauseMenu()
    {
        return UIManager.instance.GoToPauseMenu();
    }

    public static IEnumerator GoToMenuCredits()
    {
        return UIManager.instance.GoToMenuCredits();
    }

    public static void ShowCutscenePrompt(CinematicSkipPopup.Texts text)
    {
        UIManager.instance.ShowCutscenePrompt(text);
    }

    public static void HideCutscenePrompt()
    {
        UIManager.instance.HideCutscenePrompt();
    }

    public static void ApplyAudioMenuSettings()
    {
        UIManager.instance.ApplyAudioMenuSettings();
    }

    public static void ApplyVideoMenuSettings()
    {
        UIManager.instance.ApplyVideoMenuSettings();
    }

    public static void ApplyControllerMenuSettings()
    {
        UIManager.instance.ApplyControllerMenuSettings();
    }

    public static void ApplyRemapGamepadMenuSettings()
    {
        UIManager.instance.ApplyRemapGamepadMenuSettings();
    }

    public static void ApplyKeyboardMenuSettings()
    {
        UIManager.instance.ApplyKeyboardMenuSettings();
    }

    public static void ApplyOverscanSettings(bool goToBrightness = false)
    {
        UIManager.instance.ApplyOverscanSettings(goToBrightness);
    }

    public static void ApplyBrightnessSettings()
    {
        UIManager.instance.ApplyBrightnessSettings();
    }

    public static void ApplyGameMenuSettings()
    {
        UIManager.instance.ApplyGameMenuSettings();
    }

    public static void SaveOverscanSettings()
    {
        UIManager.instance.SaveOverscanSettings();
    }

    public static void SaveBrightnessSettings()
    {
        UIManager.instance.SaveBrightnessSettings();
    }

    public static void DefaultAudioMenuSettings()
    {
        UIManager.instance.DefaultAudioMenuSettings();
    }

    public static void DefaultVideoMenuSettings()
    {
        UIManager.instance.DefaultVideoMenuSettings();
    }

    public static void DefaultGamepadMenuSettings()
    {
        UIManager.instance.DefaultGamepadMenuSettings();
    }

    public static void DefaultKeyboardMenuSettings()
    {
        UIManager.instance.DefaultKeyboardMenuSettings();
    }

    public static void DefaultGameMenuSettings()
    {
        UIManager.instance.DefaultGameMenuSettings();
    }

    public static void LoadStoredSettings()
    {
        UIManager.instance.LoadStoredSettings();
    }

    public static void LoadAudioSettings()
    {
        ReflectionHelper.CallMethod(UIManager.instance, "LoadAudioSettings");
    }

    public static void LoadVideoSettings()
    {
        ReflectionHelper.CallMethod(UIManager.instance, "LoadVideoSettings");
    }

    public static void LoadGameOptionsSettings()
    {
        ReflectionHelper.CallMethod(UIManager.instance, "LoadGameOptionsSettings");
    }

    public static void LoadControllerSettings()
    {
        ReflectionHelper.CallMethod(UIManager.instance, "LoadControllerSettings");
    }

    public static void RefreshAudioControls()
    {
        ReflectionHelper.CallMethod(UIManager.instance, "RefreshAudioControls");
    }

    public static void RefreshVideoControls()
    {
        ReflectionHelper.CallMethod(UIManager.instance, "RefreshVideoControls");
    }

    public static void DisableFrameCapSetting()
    {
        UIManager.instance.DisableFrameCapSetting();
    }

    public static void DisableVsyncSetting()
    {
        UIManager.instance.DisableVsyncSetting();
    }

    public static void RefreshKeyboardControls()
    {
        ReflectionHelper.CallMethod(UIManager.instance, "RefreshKeyboardControls");
    }

    public static void RefreshGameOptionsControls()
    {
        ReflectionHelper.CallMethod(UIManager.instance, "RefreshGameOptionsControls");
    }

    public static void RefreshAchievementsList()
    {
        UIManager.instance.RefreshAchievementsList();
    }

    public static void UpdateMenuAchievementStatus(Achievement ach, MenuAchievement menuAch)
    {
        ReflectionHelper.CallMethod(UIManager.instance, "UpdateMenuAchievementStatus", ach, menuAch);
    }

    public static void TogglePauseGame()
    {
        UIManager.instance.TogglePauseGame();
    }

    public static void QuitGame()
    {
        UIManager.instance.QuitGame();
    }

    public static void FadeOutMenuAudio(float duration)
    {
        UIManager.instance.FadeOutMenuAudio(duration);
    }

    public static void AudioGoToPauseMenu(float duration)
    {
        UIManager.instance.AudioGoToPauseMenu(duration);
    }

    public static void AudioGoToGameplay(float duration)
    {
        UIManager.instance.AudioGoToGameplay(duration);
    }

    public static void ConfigureMenu()
    {
        UIManager.instance.ConfigureMenu();
    }

    public static IEnumerator HideCurrentMenu()
    {
        return UIManager.instance.HideCurrentMenu();
    }

    public static IEnumerator ShowMenu(MenuScreen menu)
    {
        return UIManager.instance.ShowMenu(menu);
    }

    public static IEnumerator HideMenu(MenuScreen menu)
    {
        return UIManager.instance.HideMenu(menu);
    }

    public static void HideMenuInstant(MenuScreen menu)
    {
        UIManager.instance.HideMenuInstant(menu);
    }

    public static IEnumerator HideSaveProfileMenu()
    {
        return UIManager.instance.HideSaveProfileMenu();
    }

    public static void DisableScreens()
    {
        ReflectionHelper.CallMethod(UIManager.instance, "DisableScreens");
    }

    public static void ShowCanvas(Canvas canvas)
    {
        ReflectionHelper.CallMethod(UIManager.instance, "ShowCanvas", canvas);
    }

    public static void HideCanvas(Canvas canvas)
    {
        ReflectionHelper.CallMethod(UIManager.instance, "HideCanvas", canvas);
    }

    public static void ShowCanvasGroup(CanvasGroup cg)
    {
        UIManager.instance.ShowCanvasGroup(cg);
    }

    public static void HideCanvasGroup(CanvasGroup cg)
    {
        UIManager.instance.HideCanvasGroup(cg);
    }

    public static IEnumerator FadeInCanvasGroup(CanvasGroup cg)
    {
        return UIManager.instance.FadeInCanvasGroup(cg);
    }

    public static IEnumerator FadeInCanvasGroupAlpha(CanvasGroup cg, float endAlpha)
    {
        return UIManager.instance.FadeInCanvasGroupAlpha(cg, endAlpha);
    }

    public static IEnumerator FadeOutCanvasGroup(CanvasGroup cg)
    {
        return UIManager.instance.FadeOutCanvasGroup(cg);
    }

    public static IEnumerator FadeInSprite(SpriteRenderer sprite)
    {
        return ReflectionHelper.CallMethod<UIManager, IEnumerator>(UIManager.instance, "FadeInSprite", sprite);
    }

    public static IEnumerator FadeOutSprite(SpriteRenderer sprite)
    {
        return ReflectionHelper.CallMethod<UIManager, IEnumerator>(UIManager.instance, "FadeOutSprite", sprite);
    }

    public static void EnableChildren(RectTransform parent)
    {
        ReflectionHelper.CallMethod(UIManager.instance, "EnableChildren", parent);
    }

    public static void EnableChildren(Canvas parent)
    {
        ReflectionHelper.CallMethod(UIManager.instance, "EnableChildren", parent);
    }

    public static void DisableChildren(Canvas parent)
    {
        ReflectionHelper.CallMethod(UIManager.instance, "DisableChildren", parent);
    }

    public static float GetAnimationClipLength(Animator animator, string clipName)
    {
        return ReflectionHelper.CallMethod<UIManager, float>(UIManager.instance, "GetAnimationClipLength", animator,
            clipName);
    }

    public static void MakeMenuLean()
    {
        UIManager.instance.MakeMenuLean();
    }

    public static Sprite LoadImage()
    {
        return ReflectionHelper.CallMethod<UIManager, Sprite>(UIManager.instance, "LoadImage");
    }

    public static void orig_Awake()
    {
        ReflectionHelper.CallMethod(UIManager.instance, "orig_Awake");
    }

    public static void orig_Start()
    {
        ReflectionHelper.CallMethod(UIManager.instance, "orig_Start");
    }

    public static IEnumerator orig_HideCurrentMenu()
    {
        return UIManager.instance.orig_HideCurrentMenu();
    }

    public static void UIGoToDynamicMenu(MenuScreen menu)
    {
        UIManager.instance.UIGoToDynamicMenu(menu);
    }

    public static IEnumerator GoToDynamicMenu(MenuScreen menu)
    {
        return UIManager.instance.GoToDynamicMenu(menu);
    }

    public static void UILeaveDynamicMenu(MenuScreen to, MainMenuState state)
    {
        UIManager.instance.UILeaveDynamicMenu(to, state);
    }

    public static IEnumerator LeaveDynamicMenu(MenuScreen to, MainMenuState state)
    {
        return UIManager.instance.LeaveDynamicMenu(to, state);
    }

    public static void UIPauseToDynamicMenu(MenuScreen to)
    {
        UIManager.instance.UIPauseToDynamicMenu(to);
    }

    public static IEnumerator PauseToDynamicMenu(MenuScreen to)
    {
        return UIManager.instance.PauseToDynamicMenu(to);
    }
}