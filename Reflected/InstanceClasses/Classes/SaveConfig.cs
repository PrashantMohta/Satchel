namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of SaveConfig allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class SaveConfigR : InstanceClassWrapper<SaveConfig>
{
    public SaveConfigR(SaveConfig _orig) : base(_orig)
    {
    }

    public PlayerData defaultPlayerData
    {
        get => orig.defaultPlayerData;
        set => orig.defaultPlayerData = value;
    }

    public PlayerData testPlayerData
    {
        get => orig.testPlayerData;
        set => orig.testPlayerData = value;
    }

    public PlayerData fullPlayerData
    {
        get => orig.fullPlayerData;
        set => orig.fullPlayerData = value;
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