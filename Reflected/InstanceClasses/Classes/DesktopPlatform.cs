namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of DesktopPlatform allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class DesktopPlatformR:InstanceClassWrapper<DesktopPlatform>
{
public DesktopPlatformR(DesktopPlatform _orig) : base(_orig) {}
public string saveDirPath
{
get => GetField<string>();
set => SetField(value);
}

public PlayerPrefsSharedData sharedData
{
get => GetField<PlayerPrefsSharedData>();
set => SetField(value);
}

public PlayerPrefsSharedData encryptedSharedData
{
get => GetField<PlayerPrefsSharedData>();
set => SetField(value);
}

public DesktopOnlineSubsystem onlineSubsystem
{
get => GetField<DesktopOnlineSubsystem>();
set => SetField(value);
}

public PlatformVibrationHelper vibrationHelper
{
get => GetField<PlatformVibrationHelper>();
set => SetField(value);
}

public string DisplayName
{
get => orig.DisplayName;
}

public bool AreAchievementsFetched
{
get => orig.AreAchievementsFetched;
}

public bool HasNativeAchievementsDialog
{
get => orig.HasNativeAchievementsDialog;
}

public bool ShowLanguageSelect
{
get => orig.ShowLanguageSelect;
}

public bool IsControllerImplicit
{
get => orig.IsControllerImplicit;
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

public bool IsFileSystemProtected
{
get => orig.IsFileSystemProtected;
}

public bool IsSaveStoreMounted
{
get => orig.IsSaveStoreMounted;
}

public bool IsFiringAchievementsFromSavesAllowed
{
get => orig.IsFiringAchievementsFromSavesAllowed;
}

public bool WillManageResolution
{
get => orig.WillManageResolution;
}

public bool WillDisplayGraphicsSettings
{
get => orig.WillDisplayGraphicsSettings;
}

public bool IsSpriteScalingApplied
{
get => orig.IsSpriteScalingApplied;
}

public float SpriteScalingFactor
{
get => orig.SpriteScalingFactor;
}

public bool WillDisplayControllerSettings
{
get => orig.WillDisplayControllerSettings;
}

public bool WillDisplayKeyboardSettings
{
get => orig.WillDisplayKeyboardSettings;
}

public bool WillDisplayQuitButton
{
get => orig.WillDisplayQuitButton;
}

public bool IsMouseSupported
{
get => orig.IsMouseSupported;
}

public bool WillEverPauseOnControllerDisconnected
{
get => orig.WillEverPauseOnControllerDisconnected;
}

public bool IsPausingOnControllerDisconnected
{
get => orig.IsPausingOnControllerDisconnected;
}

public bool FetchScenesBeforeFade
{
get => orig.FetchScenesBeforeFade;
}

public float MaximumLoadDurationForNonCriticalGarbageCollection
{
get => orig.MaximumLoadDurationForNonCriticalGarbageCollection;
}

public int MaximumSceneTransitionsWithoutNonCriticalGarbageCollection
{
get => orig.MaximumSceneTransitionsWithoutNonCriticalGarbageCollection;
}

public bool IsSavingAllowedByEngagement
{
get => orig.IsSavingAllowedByEngagement;
}

public bool CanReEngage
{
get => orig.CanReEngage;
}

public bool IsPlayerPrefsLoaded
{
get => orig.IsPlayerPrefsLoaded;
}

public bool RequiresPreferencesSyncOnEngage
{
get => orig.RequiresPreferencesSyncOnEngage;
}



public void Awake () =>
CallMethod();

public void CreateOnlineSubsystem () =>
CallMethod();

public void OnDestroy () =>
CallMethod();

public void Update () =>
CallMethod();

public void IsSaveSlotInUse (int slotIndex, System.Action<System.Boolean> callback) =>
orig.IsSaveSlotInUse(slotIndex, callback);

public void LocalIsSaveSlotInUse (int slotIndex, System.Action<System.Boolean> callback) =>
orig.LocalIsSaveSlotInUse(slotIndex, callback);

public void ReadSaveSlot (int slotIndex, System.Action<System.Byte[]> callback) =>
orig.ReadSaveSlot(slotIndex, callback);

public void LocalReadSaveSlot (int slotIndex, System.Action<System.Byte[]> callback) =>
orig.LocalReadSaveSlot(slotIndex, callback);

public void EnsureSaveSlotSpace (int slotIndex, System.Action<System.Boolean> callback) =>
orig.EnsureSaveSlotSpace(slotIndex, callback);

public void WriteSaveSlot (int slotIndex, System.Byte[] bytes, System.Action<System.Boolean> callback) =>
orig.WriteSaveSlot(slotIndex, bytes, callback);

public int GetBackupNumber (string backupPath) =>
CallMethod<int>(new object[] {backupPath});

public void ClearSaveSlot (int slotIndex, System.Action<System.Boolean> callback) =>
orig.ClearSaveSlot(slotIndex, callback);

public System.Boolean? IsAchievementUnlocked (string achievementId) =>
orig.IsAchievementUnlocked(achievementId);

public void PushAchievementUnlock (string achievementId) =>
orig.PushAchievementUnlock(achievementId);

public void ResetAchievements () =>
orig.ResetAchievements();

public bool IncludesPlugin (string pluginName) =>
orig.IncludesPlugin(pluginName);

public void OnOnlineSubsystemAchievementsFetched () =>
orig.OnOnlineSubsystemAchievementsFetched();

public VibrationMixer GetVibrationMixer () =>
orig.GetVibrationMixer();

}
}
