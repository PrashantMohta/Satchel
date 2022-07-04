using InControl;
using UnityEngine.UI;

namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of ControllerDetect allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class ControllerDetectR : InstanceClassWrapper<ControllerDetect>
{
    public ControllerDetectR(ControllerDetect _orig) : base(_orig)
    {
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

    public Image controllerImage
    {
        get => GetField<Image>();
        set => SetField(value);
    }

    public CanvasGroup controllerPrompt
    {
        get => orig.controllerPrompt;
        set => orig.controllerPrompt = value;
    }

    public CanvasGroup remapDialog
    {
        get => orig.remapDialog;
        set => orig.remapDialog = value;
    }

    public CanvasGroup menuControls
    {
        get => orig.menuControls;
        set => orig.menuControls = value;
    }

    public CanvasGroup remapControls
    {
        get => orig.remapControls;
        set => orig.remapControls = value;
    }

    public Selectable controllerMenuPreselect
    {
        get => orig.controllerMenuPreselect;
        set => orig.controllerMenuPreselect = value;
    }

    public Selectable remapMenuPreselect
    {
        get => orig.remapMenuPreselect;
        set => orig.remapMenuPreselect = value;
    }

    public MenuSelectable remapApplyButton
    {
        get => orig.remapApplyButton;
        set => orig.remapApplyButton = value;
    }

    public MenuSelectable defaultsButton
    {
        get => orig.defaultsButton;
        set => orig.defaultsButton = value;
    }

    public MenuButton applyButton
    {
        get => orig.applyButton;
        set => orig.applyButton = value;
    }

    public MenuButton remapButton
    {
        get => orig.remapButton;
        set => orig.remapButton = value;
    }

    public ControllerImage[] controllerImages
    {
        get => orig.controllerImages;
        set => orig.controllerImages = value;
    }

    public float profileYPos
    {
        get => GetField<float>();
        set => SetField(value);
    }


    public void Awake()
    {
        CallMethod();
    }

    public void OnEnable()
    {
        CallMethod();
    }

    public void OnDisable()
    {
        CallMethod();
    }

    public void ControllerActivated(InputDevice inputDevice)
    {
        CallMethod(new object[] { inputDevice });
    }

    public void ControllerAttached(InputDevice inputDevice)
    {
        CallMethod(new object[] { inputDevice });
    }

    public void ControllerDetached(InputDevice inputDevice)
    {
        CallMethod(new object[] { inputDevice });
    }

    public void ShowController(GamepadType gamepadType)
    {
        CallMethod(new object[] { gamepadType });
    }

    public void HideButtonLabels()
    {
        CallMethod();
    }

    public void LookForActiveController()
    {
        CallMethod();
    }
}