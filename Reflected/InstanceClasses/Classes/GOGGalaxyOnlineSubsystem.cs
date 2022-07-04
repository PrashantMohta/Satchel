namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of GOGGalaxyOnlineSubsystem allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class GOGGalaxyOnlineSubsystemR : InstanceClassWrapper<GOGGalaxyOnlineSubsystem>
{
    public GOGGalaxyOnlineSubsystemR(GOGGalaxyOnlineSubsystem _orig) : base(_orig)
    {
    }

    public string ClientId
    {
        get => GetFieldStatic<string>();
        set => SetField(value);
    }

    public string ClientSecret
    {
        get => GetFieldStatic<string>();
        set => SetField(value);
    }

    public DesktopPlatform platform
    {
        get => GetField<DesktopPlatform>();
        set => SetField(value);
    }

    public bool didInitialize
    {
        get => GetField<bool>();
        set => SetField(value);
    }

    public bool DidInitialize => orig.DidInitialize;

    public bool AreAchievementsFetched => orig.AreAchievementsFetched;

    public bool HasNativeAchievementsDialog => orig.HasNativeAchievementsDialog;

    public bool HandlesGameSaves => orig.HandlesGameSaves;

    public bool WillPreloadSaveFiles => orig.WillPreloadSaveFiles;

    public string EngagedDisplayName => orig.EngagedDisplayName;

    public Texture2D EngagedDisplayImage => orig.EngagedDisplayImage;

    public bool IsPackaged(DesktopPlatform desktopPlatform)
    {
        return GOGGalaxyOnlineSubsystem.IsPackaged(desktopPlatform);
    }

    public void Dispose()
    {
        orig.Dispose();
    }

    public void Update()
    {
        orig.Update();
    }

    public void OnAuthorized()
    {
        CallMethod();
    }

    public void OnStatisticsReceived()
    {
        CallMethod();
    }

    public bool? IsAchievementUnlocked(string achievementId)
    {
        return orig.IsAchievementUnlocked(achievementId);
    }

    public void PushAchievementUnlock(string achievementId)
    {
        orig.PushAchievementUnlock(achievementId);
    }

    public void ResetAchievements()
    {
        orig.ResetAchievements();
    }
}