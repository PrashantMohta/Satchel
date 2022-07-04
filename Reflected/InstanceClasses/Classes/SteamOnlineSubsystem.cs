namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of SteamOnlineSubsystem allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class SteamOnlineSubsystemR:InstanceClassWrapper<SteamOnlineSubsystem>
{
public SteamOnlineSubsystemR(SteamOnlineSubsystem _orig) : base(_orig) {}
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


public bool AreAchievementsFetched
{
get => orig.AreAchievementsFetched;
}

public bool HasNativeAchievementsDialog
{
get => orig.HasNativeAchievementsDialog;
}

public bool HandlesGameSaves
{
get => orig.HandlesGameSaves;
}

public bool WillPreloadSaveFiles
{
get => orig.WillPreloadSaveFiles;
}

public string EngagedDisplayName
{
get => orig.EngagedDisplayName;
}

public UnityEngine.Texture2D EngagedDisplayImage
{
get => orig.EngagedDisplayImage;
}

public bool IsPackaged (DesktopPlatform desktopPlatform) =>
SteamOnlineSubsystem.IsPackaged(desktopPlatform);

public void Dispose () =>
orig.Dispose();

public void Update () =>
orig.Update();

public void OnSteamLogMessage (int severity, System.Text.StringBuilder content) =>
CallMethod(new object[] {severity, content});

public void PushAchievementUnlock (string achievementId) =>
orig.PushAchievementUnlock(achievementId);

public System.Boolean? IsAchievementUnlocked (string achievementId) =>
orig.IsAchievementUnlocked(achievementId);

public void ResetAchievements () =>
orig.ResetAchievements();

}
}
