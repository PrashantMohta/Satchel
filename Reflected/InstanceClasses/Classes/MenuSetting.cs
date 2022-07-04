namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of MenuSetting allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class MenuSettingR:InstanceClassWrapper<MenuSetting>
{
public MenuSettingR(MenuSetting _orig) : base(_orig) {}
public UnityEngine.UI.MenuOptionHorizontal optionList
{
get => orig.optionList;
set => orig.optionList = value;
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

public bool verboseMode
{
get => GetField<bool>();
set => SetField(value);
}



public void Start () =>
CallMethod();

public void RefreshValueFromGameSettings (bool alsoApplySetting = false) =>
orig.RefreshValueFromGameSettings(alsoApplySetting);

public void UpdateSetting (int settingIndex) =>
orig.UpdateSetting(settingIndex);

public void orig_UpdateSetting (int settingIndex) =>
orig.orig_UpdateSetting(settingIndex);

public void orig_RefreshValueFromGameSettings (bool alsoApplySetting = false) =>
orig.orig_RefreshValueFromGameSettings(alsoApplySetting);

}
}
