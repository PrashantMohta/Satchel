using TeamCherry;

namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of SceneDefaultSettings allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class SceneDefaultSettingsR : InstanceClassWrapper<SceneDefaultSettings>
{
    public SceneDefaultSettingsR(SceneDefaultSettings _orig) : base(_orig)
    {
    }

    public int selection
    {
        get => orig.selection;
        set => orig.selection = value;
    }

    public List<SceneManagerSettings> settingsList
    {
        get => orig.settingsList;
        set => orig.settingsList = value;
    }

    public string name
    {
        get => orig.name;
        set => orig.name = value;
    }

    public HideFlags hideFlags
    {
        get => orig.hideFlags;
        set => orig.hideFlags = value;
    }

    public void OnEnable()
    {
        orig.OnEnable();
    }

    public SceneManagerSettings GetMapZoneSettings(MapZone mapZone)
    {
        return orig.GetMapZoneSettings(mapZone);
    }

    public SceneManagerSettings GetCurrentMapZoneSettings()
    {
        return orig.GetCurrentMapZoneSettings();
    }

    public void SaveSettings(SceneManagerSettings sms)
    {
        orig.SaveSettings(sms);
    }

    public MapZone GetCurrentSelection()
    {
        return orig.GetCurrentSelection();
    }
}