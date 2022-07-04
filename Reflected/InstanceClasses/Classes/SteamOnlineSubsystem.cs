using System.Text;

namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of SteamOnlineSubsystem allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class SteamOnlineSubsystemR : InstanceClassWrapper<SteamOnlineSubsystem>
{
    public SteamOnlineSubsystemR(SteamOnlineSubsystem _orig) : base(_orig)
    {
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

    public bool statsReceived
    {
        get => GetField<bool>();
        set => SetField(value);
    }


    public bool AreAchievementsFetched => orig.AreAchievementsFetched;

    public bool HasNativeAchievementsDialog => orig.HasNativeAchievementsDialog;

    public bool HandlesGameSaves => orig.HandlesGameSaves;

    public bool WillPreloadSaveFiles => orig.WillPreloadSaveFiles;

    public string EngagedDisplayName => orig.EngagedDisplayName;

    public Texture2D EngagedDisplayImage => orig.EngagedDisplayImage;

    public bool IsPackaged(DesktopPlatform desktopPlatform)
    {
        return SteamOnlineSubsystem.IsPackaged(desktopPlatform);
    }

    public void Dispose()
    {
        orig.Dispose();
    }

    public void Update()
    {
        orig.Update();
    }

    public void OnSteamLogMessage(int severity, StringBuilder content)
    {
        CallMethod(new object[] { severity, content });
    }

    public void PushAchievementUnlock(string achievementId)
    {
        orig.PushAchievementUnlock(achievementId);
    }

    public bool? IsAchievementUnlocked(string achievementId)
    {
        return orig.IsAchievementUnlocked(achievementId);
    }

    public void ResetAchievements()
    {
        orig.ResetAchievements();
    }
}