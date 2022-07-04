namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of GameCoreOnlineSubsystem allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class GameCoreOnlineSubsystemR:InstanceClassWrapper<GameCoreOnlineSubsystem>
{
public GameCoreOnlineSubsystemR(GameCoreOnlineSubsystem _orig) : base(_orig) {}
public string SCID
{
get => GetFieldStatic<string>();
set => SetField(value);
}

public AchievementIDMap achievementIdMap
{
get => GetField<AchievementIDMap>();
set => SetField(value);
}

public System.Collections.Generic.List<System.Int32> awardedAchievements
{
get => GetField<System.Collections.Generic.List<System.Int32>>();
set => SetField(value);
}

public string userDisplayName
{
get => GetField<string>();
set => SetField(value);
}

public UnityEngine.Texture2D userDisplayImage
{
get => GetField<UnityEngine.Texture2D>();
set => SetField(value);
}

public DesktopPlatform platform
{
get => GetField<DesktopPlatform>();
set => SetField(value);
}

public string EngagedDisplayName
{
get => orig.EngagedDisplayName;
}

public UnityEngine.Texture2D EngagedDisplayImage
{
get => orig.EngagedDisplayImage;
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

public bool IsPackaged (DesktopPlatform desktopPlatform) =>
GameCoreOnlineSubsystem.IsPackaged(desktopPlatform);

public void Update () =>
orig.Update();

public void PushAchievementUnlock (string achievementId) =>
orig.PushAchievementUnlock(achievementId);

public System.Boolean? IsAchievementUnlocked (string achievementId) =>
orig.IsAchievementUnlocked(achievementId);

public void ResetAchievements () =>
orig.ResetAchievements();

public string GetSaveContainerName (int slotIndex) =>
CallMethod<string>(new object[] {slotIndex});

public string GetSaveFileName (int slotIndex) =>
CallMethod<string>(new object[] {slotIndex});

public void IsSaveSlotInUse (int slotIndex, System.Action<System.Boolean> callback) =>
orig.IsSaveSlotInUse(slotIndex, callback);

public void ReadSaveSlot (int slotIndex, System.Action<System.Byte[]> callback) =>
orig.ReadSaveSlot(slotIndex, callback);

public void WriteSaveSlot (int slotIndex, System.Byte[] bytes, System.Action<System.Boolean> callback) =>
orig.WriteSaveSlot(slotIndex, bytes, callback);

public void ClearSaveSlot (int slotIndex, System.Action<System.Boolean> callback) =>
orig.ClearSaveSlot(slotIndex, callback);

public bool Succeeded (int hresult, string operationFriendlyName) =>
CallMethodStatic<bool>(new object[] {hresult, operationFriendlyName});

public void CompletePostSignInInitialization () =>
CallMethod();

public void MigrateLocalSaves () =>
CallMethod();

}
}
