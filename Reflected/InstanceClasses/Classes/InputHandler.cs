using InControl;

namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of InputHandler allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class InputHandlerR : InstanceClassWrapper<InputHandler>
{
    public InputHandlerR(InputHandler _orig) : base(_orig)
    {
    }

    public InputHandler Instance
    {
        get => InputHandler.Instance;
        set => InputHandler.Instance = value;
    }

    public bool verboseMode
    {
        get => GetField<bool>();
        set => SetField(value);
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

    public GameConfig gc
    {
        get => GetField<GameConfig>();
        set => SetField(value);
    }

    public InputDevice gameController
    {
        get => orig.gameController;
        set => orig.gameController = value;
    }

    public HeroActions inputActions
    {
        get => orig.inputActions;
        set => orig.inputActions = value;
    }

    public BindingSourceType lastActiveController
    {
        get => orig.lastActiveController;
        set => orig.lastActiveController = value;
    }

    public InputDeviceStyle lastInputDeviceStyle
    {
        get => orig.lastInputDeviceStyle;
        set => orig.lastInputDeviceStyle = value;
    }

    public GamepadType activeGamepadType
    {
        get => orig.activeGamepadType;
        set => orig.activeGamepadType = value;
    }

    public GamepadState gamepadState
    {
        get => orig.gamepadState;
        set => orig.gamepadState = value;
    }

    public HeroController heroCtrl
    {
        get => GetField<HeroController>();
        set => SetField(value);
    }

    public HeroControllerStates cState
    {
        get => GetField<HeroControllerStates>();
        set => SetField(value);
    }

    public PlayerData playerData
    {
        get => GetField<PlayerData>();
        set => SetField(value);
    }

    public OnScreenDebugInfo debugInfo
    {
        get => GetField<OnScreenDebugInfo>();
        set => SetField(value);
    }

    public List<PlayerAction> nonMappableControllerActions
    {
        get => GetField<List<PlayerAction>>();
        set => SetField(value);
    }

    public float inputX
    {
        get => orig.inputX;
        set => orig.inputX = value;
    }

    public float inputY
    {
        get => orig.inputY;
        set => orig.inputY = value;
    }

    public bool acceptingInput
    {
        get => orig.acceptingInput;
        set => orig.acceptingInput = value;
    }

    public bool skippingCutscene
    {
        get => orig.skippingCutscene;
        set => orig.skippingCutscene = value;
    }

    public bool readyToSkipCutscene
    {
        get => GetField<bool>();
        set => SetField(value);
    }

    public bool controllerDetected
    {
        get => GetField<bool>();
        set => SetField(value);
    }

    public ControllerProfile currentControllerProfile
    {
        get => GetField<ControllerProfile>();
        set => SetField(value);
    }

    public bool isGameplayScene
    {
        get => GetField<bool>();
        set => SetField(value);
    }

    public bool isTitleScreenScene
    {
        get => GetField<bool>();
        set => SetField(value);
    }

    public bool isMenuScene
    {
        get => GetField<bool>();
        set => SetField(value);
    }

    public bool isStagTravelScene
    {
        get => GetField<bool>();
        set => SetField(value);
    }

    public float stagLockoutDuration
    {
        get => GetField<float>();
        set => SetField(value);
    }

    public bool stagLockoutActive
    {
        get => GetField<bool>();
        set => SetField(value);
    }

    public float skipCooldownTime
    {
        get => GetField<float>();
        set => SetField(value);
    }

    public bool controllerPressed
    {
        get => GetField<bool>();
        set => SetField(value);
    }

    public List<PlayerAction> mappableControllerActions
    {
        get => orig.mappableControllerActions;
        set => SetProperty(value);
    }

    public List<PlayerAction> unmappedActions
    {
        get => orig.unmappedActions;
        set => SetProperty(value);
    }

    public bool pauseAllowed
    {
        get => orig.pauseAllowed;
        set => SetProperty(value);
    }

    public SkipPromptMode skipMode
    {
        get => orig.skipMode;
        set => SetProperty(value);
    }


    public void Awake()
    {
        orig.Awake();
    }

    public void Start()
    {
        orig.Start();
    }

    public void OnDestroy()
    {
        CallMethod();
    }

    public void SceneInit()
    {
        orig.SceneInit();
    }

    public void OnGUI()
    {
        CallMethod();
    }

    public void SetCursorVisible(bool value)
    {
        CallMethod(new object[] { value });
    }

    public void SetCursorEnabled(bool isEnabled)
    {
        CallMethodStatic(new object[] { isEnabled });
    }

    public void Update()
    {
        CallMethod();
    }

    public void ControllerAttached(InputDevice inputDevice)
    {
        CallMethod(new object[] { inputDevice });
    }

    public void ControllerActivated(InputDevice inputDevice)
    {
        CallMethod(new object[] { inputDevice });
    }

    public void ControllerDetached(InputDevice inputDevice)
    {
        CallMethod(new object[] { inputDevice });
    }

    public void PlayingInput()
    {
        CallMethod();
    }

    public void CutsceneInput()
    {
        CallMethod();
    }

    public void StagCutsceneInput()
    {
        CallMethod();
    }

    public void BetaEndInput()
    {
        CallMethod();
    }

    public void AttachHeroController(HeroController heroController)
    {
        orig.AttachHeroController(heroController);
    }

    public void StopAcceptingInput()
    {
        orig.StopAcceptingInput();
    }

    public void StartAcceptingInput()
    {
        orig.StartAcceptingInput();
    }

    public void PreventPause()
    {
        orig.PreventPause();
    }

    public void AllowPause()
    {
        orig.AllowPause();
    }

    public void UpdateActiveController()
    {
        orig.UpdateActiveController();
    }

    public void StopUIInput()
    {
        orig.StopUIInput();
    }

    public void StartUIInput()
    {
        orig.StartUIInput();
    }

    public void StopMouseInput()
    {
        orig.StopMouseInput();
    }

    public void EnableMouseInput()
    {
        orig.EnableMouseInput();
    }

    public void SetSkipMode(SkipPromptMode newMode)
    {
        orig.SetSkipMode(newMode);
    }

    public void RefreshPlayerData()
    {
        orig.RefreshPlayerData();
    }

    public void ResetDefaultKeyBindings()
    {
        orig.ResetDefaultKeyBindings();
    }

    public void ResetDefaultControllerButtonBindings()
    {
        orig.ResetDefaultControllerButtonBindings();
    }

    public void ResetAllControllerButtonBindings()
    {
        orig.ResetAllControllerButtonBindings();
    }

    public void SendKeyBindingsToGameSettings()
    {
        orig.SendKeyBindingsToGameSettings();
    }

    public void SendButtonBindingsToGameSettings()
    {
        orig.SendButtonBindingsToGameSettings();
    }

    public void MapControllerButtons(GamepadType gamePadType)
    {
        orig.MapControllerButtons(gamePadType);
    }

    public void RemapUIButtons()
    {
        orig.RemapUIButtons();
    }

    public PlayerAction ActionButtonToPlayerAction(HeroActionButton actionButtonType)
    {
        return orig.ActionButtonToPlayerAction(actionButtonType);
    }

    public InputControlType GetButtonBindingForAction(PlayerAction action)
    {
        return orig.GetButtonBindingForAction(action);
    }

    public PlayerAction GetActionForMappableControllerButton(InputControlType button)
    {
        return orig.GetActionForMappableControllerButton(button);
    }

    public PlayerAction GetActionForDefaultControllerButton(InputControlType button)
    {
        return orig.GetActionForDefaultControllerButton(button);
    }

    public void PrintMappings(PlayerAction action)
    {
        orig.PrintMappings(action);
    }

    public string ActionButtonLocalizedKey(PlayerAction action)
    {
        return orig.ActionButtonLocalizedKey(action);
    }

    public string ActionButtonLocalizedKey(string actionName)
    {
        return orig.ActionButtonLocalizedKey(actionName);
    }

    public void StopCutsceneInput()
    {
        CallMethod();
    }

    public void UnlockStagInput()
    {
        CallMethod();
    }

    public IEnumerator SetupGamepadUIInputActions()
    {
        return CallMethod<IEnumerator>();
    }

    public void RemoveGamepadUIInputActions()
    {
        CallMethod();
    }

    public void DestroyCurrentActionSet()
    {
        CallMethod();
    }

    public void SetActiveGamepadType(InputDevice inputDevice)
    {
        orig.SetActiveGamepadType(inputDevice);
    }

    public void MapDefaultKeyboardLayout()
    {
        CallMethod();
    }

    public void MapKeyboardLayoutFromGameSettings()
    {
        CallMethod();
    }

    public void AddKeyBinding(PlayerAction action, string savedBinding)
    {
        CallMethodStatic(new object[] { action, savedBinding });
    }

    public void SetupNonMappableBindings()
    {
        CallMethod();
    }

    public void SetupMappableControllerBindingsList()
    {
        CallMethod();
    }
}