namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of SaveStats allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class SaveStatsR : InstanceClassWrapper<SaveStats>
{
    public SaveStatsR(SaveStats _orig) : base(_orig)
    {
    }

    public PlayTime playTimeStruct
    {
        get => GetField<PlayTime>();
        set => SetField(value);
    }

    public int maxHealth
    {
        get => orig.maxHealth;
        set => SetProperty(value);
    }

    public int geo
    {
        get => orig.geo;
        set => SetProperty(value);
    }

    public MapZone mapZone
    {
        get => orig.mapZone;
        set => SetProperty(value);
    }

    public float playTime
    {
        get => orig.playTime;
        set => SetProperty(value);
    }

    public int maxMPReserve
    {
        get => orig.maxMPReserve;
        set => SetProperty(value);
    }

    public int permadeathMode
    {
        get => orig.permadeathMode;
        set => SetProperty(value);
    }

    public bool bossRushMode
    {
        get => orig.bossRushMode;
        set => SetProperty(value);
    }

    public float completionPercentage
    {
        get => orig.completionPercentage;
        set => SetProperty(value);
    }

    public bool unlockedCompletionRate
    {
        get => orig.unlockedCompletionRate;
        set => SetProperty(value);
    }

    public Dictionary<string, string> LoadedMods
    {
        get => orig.LoadedMods;
        set => orig.LoadedMods = value;
    }

    public string Name
    {
        get => orig.Name;
        set => orig.Name = value;
    }

    public string GetPlaytimeHHMM()
    {
        return orig.GetPlaytimeHHMM();
    }

    public string GetPlaytimeHHMMSS()
    {
        return orig.GetPlaytimeHHMMSS();
    }

    public string GetCompletionPercentage()
    {
        return orig.GetCompletionPercentage();
    }

    public int GetMPSlotsVisible()
    {
        return orig.GetMPSlotsVisible();
    }
}