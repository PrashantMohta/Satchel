namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of GOGGalaxyOnlineSubsystem allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class GOGGalaxyOnlineSubsystemR:InstanceClassWrapper<GOGGalaxyOnlineSubsystem>
{
public GOGGalaxyOnlineSubsystemR(GOGGalaxyOnlineSubsystem _orig) : base(_orig) {}
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

public bool DidInitialize
{
get => orig.DidInitialize;
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
GOGGalaxyOnlineSubsystem.IsPackaged(desktopPlatform);

public void Dispose () =>
orig.Dispose();

public void Update () =>
orig.Update();

public void OnAuthorized () =>
CallMethod();

public void OnStatisticsReceived () =>
CallMethod();

public System.Boolean? IsAchievementUnlocked (string achievementId) =>
orig.IsAchievementUnlocked(achievementId);

public void PushAchievementUnlock (string achievementId) =>
orig.PushAchievementUnlock(achievementId);

public void ResetAchievements () =>
orig.ResetAchievements();

}
}
