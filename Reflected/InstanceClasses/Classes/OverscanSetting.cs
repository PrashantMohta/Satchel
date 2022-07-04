namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of OverscanSetting allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class OverscanSettingR:InstanceClassWrapper<OverscanSetting>
{
public OverscanSettingR(OverscanSetting _orig) : base(_orig) {}
public GameSettings gs
{
get => GetField<GameSettings>();
set => SetField(value);
}

public UnityEngine.UI.Slider slider
{
get => orig.slider;
set => orig.slider = value;
}

public UnityEngine.UI.MenuButton doneButton
{
get => orig.doneButton;
set => orig.doneButton = value;
}

public UnityEngine.UI.MenuButton backButton
{
get => orig.backButton;
set => orig.backButton = value;
}

public UnityEngine.UI.Text textUI
{
get => orig.textUI;
set => orig.textUI = value;
}

public float value
{
get => orig.value;
set => orig.value = value;
}



public void Start () =>
CallMethod();

public void UpdateValue () =>
orig.UpdateValue();

public void UpdateTextValue (float value) =>
orig.UpdateTextValue(value);

public void SetOverscan (float value) =>
orig.SetOverscan(value);

public void RefreshValueFromSettings () =>
orig.RefreshValueFromSettings();

public void DoneMode () =>
orig.DoneMode();

public void NormalMode () =>
orig.NormalMode();

}
}
