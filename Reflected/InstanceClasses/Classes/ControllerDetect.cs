namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of ControllerDetect allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class ControllerDetectR:InstanceClassWrapper<ControllerDetect>
{
public ControllerDetectR(ControllerDetect _orig) : base(_orig) {}
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

public UnityEngine.UI.Image controllerImage
{
get => GetField<UnityEngine.UI.Image>();
set => SetField(value);
}

public UnityEngine.CanvasGroup controllerPrompt
{
get => orig.controllerPrompt;
set => orig.controllerPrompt = value;
}

public UnityEngine.CanvasGroup remapDialog
{
get => orig.remapDialog;
set => orig.remapDialog = value;
}

public UnityEngine.CanvasGroup menuControls
{
get => orig.menuControls;
set => orig.menuControls = value;
}

public UnityEngine.CanvasGroup remapControls
{
get => orig.remapControls;
set => orig.remapControls = value;
}

public UnityEngine.UI.Selectable controllerMenuPreselect
{
get => orig.controllerMenuPreselect;
set => orig.controllerMenuPreselect = value;
}

public UnityEngine.UI.Selectable remapMenuPreselect
{
get => orig.remapMenuPreselect;
set => orig.remapMenuPreselect = value;
}

public UnityEngine.UI.MenuSelectable remapApplyButton
{
get => orig.remapApplyButton;
set => orig.remapApplyButton = value;
}

public UnityEngine.UI.MenuSelectable defaultsButton
{
get => orig.defaultsButton;
set => orig.defaultsButton = value;
}

public UnityEngine.UI.MenuButton applyButton
{
get => orig.applyButton;
set => orig.applyButton = value;
}

public UnityEngine.UI.MenuButton remapButton
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



public void Awake () =>
CallMethod();

public void OnEnable () =>
CallMethod();

public void OnDisable () =>
CallMethod();

public void ControllerActivated (InControl.InputDevice inputDevice) =>
CallMethod(new object[] {inputDevice});

public void ControllerAttached (InControl.InputDevice inputDevice) =>
CallMethod(new object[] {inputDevice});

public void ControllerDetached (InControl.InputDevice inputDevice) =>
CallMethod(new object[] {inputDevice});

public void ShowController (GlobalEnums.GamepadType gamepadType) =>
CallMethod(new object[] {gamepadType});

public void HideButtonLabels () =>
CallMethod();

public void LookForActiveController () =>
CallMethod();

}
}
