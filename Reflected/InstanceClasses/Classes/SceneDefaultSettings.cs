namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of SceneDefaultSettings allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class SceneDefaultSettingsR:InstanceClassWrapper<TeamCherry.SceneDefaultSettings>
{
public SceneDefaultSettingsR(TeamCherry.SceneDefaultSettings _orig) : base(_orig) {}
public int selection
{
get => orig.selection;
set => orig.selection = value;
}

public System.Collections.Generic.List<SceneManagerSettings> settingsList
{
get => orig.settingsList;
set => orig.settingsList = value;
}

public string name
{
get => orig.name;
set => orig.name = value;
}

public UnityEngine.HideFlags hideFlags
{
get => orig.hideFlags;
set => orig.hideFlags = value;
}

public void OnEnable () =>
orig.OnEnable();

public SceneManagerSettings GetMapZoneSettings (GlobalEnums.MapZone mapZone) =>
orig.GetMapZoneSettings(mapZone);

public SceneManagerSettings GetCurrentMapZoneSettings () =>
orig.GetCurrentMapZoneSettings();

public void SaveSettings (SceneManagerSettings sms) =>
orig.SaveSettings(sms);

public GlobalEnums.MapZone GetCurrentSelection () =>
orig.GetCurrentSelection();

}
}
