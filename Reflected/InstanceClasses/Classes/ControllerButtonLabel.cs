namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of ControllerButtonLabel allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class ControllerButtonLabelR:InstanceClassWrapper<ControllerButtonLabel>
{
public ControllerButtonLabelR(ControllerButtonLabel _orig) : base(_orig) {}
public UnityEngine.UI.Text buttonText
{
get => GetField<UnityEngine.UI.Text>();
set => SetField(value);
}

public string overrideLabelKey
{
get => orig.overrideLabelKey;
set => orig.overrideLabelKey = value;
}

public InControl.InputControlType controllerButton
{
get => orig.controllerButton;
set => orig.controllerButton = value;
}

public InputHandler ih
{
get => GetField<InputHandler>();
set => SetField(value);
}

public UIManager ui
{
get => GetField<UIManager>();
set => SetField(value);
}



public void Awake () =>
CallMethod();

public void OnEnable () =>
CallMethod();

public void ShowCurrentBinding () =>
CallMethod();

}
}
