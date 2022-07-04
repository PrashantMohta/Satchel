using TeamCherry;

namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of References allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class ReferencesR : InstanceClassWrapper<References>
{
    public ReferencesR(References _orig) : base(_orig)
    {
    }

    public SceneDefaultSettings sceneDefaultSettings
    {
        get => orig.sceneDefaultSettings;
        set => orig.sceneDefaultSettings = value;
    }

    public CleanScenePrefabs cleanScenePrefabs
    {
        get => orig.cleanScenePrefabs;
        set => orig.cleanScenePrefabs = value;
    }

    public GameConfig gameConfig
    {
        get => orig.gameConfig;
        set => orig.gameConfig = value;
    }

    public SaveConfig saveConfig
    {
        get => orig.saveConfig;
        set => orig.saveConfig = value;
    }

    public GameVersionData gameVersionData
    {
        get => orig.gameVersionData;
        set => orig.gameVersionData = value;
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
}