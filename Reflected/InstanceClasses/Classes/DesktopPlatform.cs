namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of DesktopPlatform allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class DesktopPlatformR : InstanceClassWrapper<DesktopPlatform>
{
    public DesktopPlatformR(DesktopPlatform _orig) : base(_orig)
    {
    }

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

    public string DisplayName => orig.DisplayName;

    public bool AreAchievementsFetched => orig.AreAchievementsFetched;

    public bool HasNativeAchievementsDialog => orig.HasNativeAchievementsDialog;

    public bool ShowLanguageSelect => orig.ShowLanguageSelect;

    public bool IsControllerImplicit => orig.IsControllerImplicit;

    public bool WillPreloadSaveFiles => orig.WillPreloadSaveFiles;

    public string EngagedDisplayName => orig.EngagedDisplayName;

    public Texture2D EngagedDisplayImage => orig.EngagedDisplayImage;

    public bool IsFileSystemProtected => orig.IsFileSystemProtected;

    public bool IsSaveStoreMounted => orig.IsSaveStoreMounted;

    public bool IsFiringAchievementsFromSavesAllowed => orig.IsFiringAchievementsFromSavesAllowed;

    public bool WillManageResolution => orig.WillManageResolution;

    public bool WillDisplayGraphicsSettings => orig.WillDisplayGraphicsSettings;

    public bool IsSpriteScalingApplied => orig.IsSpriteScalingApplied;

    public float SpriteScalingFactor => orig.SpriteScalingFactor;

    public bool WillDisplayControllerSettings => orig.WillDisplayControllerSettings;

    public bool WillDisplayKeyboardSettings => orig.WillDisplayKeyboardSettings;

    public bool WillDisplayQuitButton => orig.WillDisplayQuitButton;

    public bool IsMouseSupported => orig.IsMouseSupported;

    public bool WillEverPauseOnControllerDisconnected => orig.WillEverPauseOnControllerDisconnected;

    public bool IsPausingOnControllerDisconnected => orig.IsPausingOnControllerDisconnected;

    public bool FetchScenesBeforeFade => orig.FetchScenesBeforeFade;

    public float MaximumLoadDurationForNonCriticalGarbageCollection =>
        orig.MaximumLoadDurationForNonCriticalGarbageCollection;

    public int MaximumSceneTransitionsWithoutNonCriticalGarbageCollection =>
        orig.MaximumSceneTransitionsWithoutNonCriticalGarbageCollection;

    public bool IsSavingAllowedByEngagement => orig.IsSavingAllowedByEngagement;

    public bool CanReEngage => orig.CanReEngage;

    public bool IsPlayerPrefsLoaded => orig.IsPlayerPrefsLoaded;

    public bool RequiresPreferencesSyncOnEngage => orig.RequiresPreferencesSyncOnEngage;


    public void Awake()
    {
        CallMethod();
    }

    public void CreateOnlineSubsystem()
    {
        CallMethod();
    }

    public void OnDestroy()
    {
        CallMethod();
    }

    public void Update()
    {
        CallMethod();
    }

    public void IsSaveSlotInUse(int slotIndex, Action<bool> callback)
    {
        orig.IsSaveSlotInUse(slotIndex, callback);
    }

    public void LocalIsSaveSlotInUse(int slotIndex, Action<bool> callback)
    {
        orig.LocalIsSaveSlotInUse(slotIndex, callback);
    }

    public void ReadSaveSlot(int slotIndex, Action<byte[]> callback)
    {
        orig.ReadSaveSlot(slotIndex, callback);
    }

    public void LocalReadSaveSlot(int slotIndex, Action<byte[]> callback)
    {
        orig.LocalReadSaveSlot(slotIndex, callback);
    }

    public void EnsureSaveSlotSpace(int slotIndex, Action<bool> callback)
    {
        orig.EnsureSaveSlotSpace(slotIndex, callback);
    }

    public void WriteSaveSlot(int slotIndex, byte[] bytes, Action<bool> callback)
    {
        orig.WriteSaveSlot(slotIndex, bytes, callback);
    }

    public int GetBackupNumber(string backupPath)
    {
        return CallMethod<int>(new object[] { backupPath });
    }

    public void ClearSaveSlot(int slotIndex, Action<bool> callback)
    {
        orig.ClearSaveSlot(slotIndex, callback);
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

    public bool IncludesPlugin(string pluginName)
    {
        return orig.IncludesPlugin(pluginName);
    }

    public void OnOnlineSubsystemAchievementsFetched()
    {
        orig.OnOnlineSubsystemAchievementsFetched();
    }

    public VibrationMixer GetVibrationMixer()
    {
        return orig.GetVibrationMixer();
    }
}