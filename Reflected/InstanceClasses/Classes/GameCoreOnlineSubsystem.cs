namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of GameCoreOnlineSubsystem allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class GameCoreOnlineSubsystemR : InstanceClassWrapper<GameCoreOnlineSubsystem>
{
    public GameCoreOnlineSubsystemR(GameCoreOnlineSubsystem _orig) : base(_orig)
    {
    }

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

    public List<int> awardedAchievements
    {
        get => GetField<List<int>>();
        set => SetField(value);
    }

    public string userDisplayName
    {
        get => GetField<string>();
        set => SetField(value);
    }

    public Texture2D userDisplayImage
    {
        get => GetField<Texture2D>();
        set => SetField(value);
    }

    public DesktopPlatform platform
    {
        get => GetField<DesktopPlatform>();
        set => SetField(value);
    }

    public string EngagedDisplayName => orig.EngagedDisplayName;

    public Texture2D EngagedDisplayImage => orig.EngagedDisplayImage;

    public bool AreAchievementsFetched => orig.AreAchievementsFetched;

    public bool HasNativeAchievementsDialog => orig.HasNativeAchievementsDialog;

    public bool HandlesGameSaves => orig.HandlesGameSaves;

    public bool WillPreloadSaveFiles => orig.WillPreloadSaveFiles;

    public bool IsPackaged(DesktopPlatform desktopPlatform)
    {
        return GameCoreOnlineSubsystem.IsPackaged(desktopPlatform);
    }

    public void Update()
    {
        orig.Update();
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

    public string GetSaveContainerName(int slotIndex)
    {
        return CallMethod<string>(new object[] { slotIndex });
    }

    public string GetSaveFileName(int slotIndex)
    {
        return CallMethod<string>(new object[] { slotIndex });
    }

    public void IsSaveSlotInUse(int slotIndex, Action<bool> callback)
    {
        orig.IsSaveSlotInUse(slotIndex, callback);
    }

    public void ReadSaveSlot(int slotIndex, Action<byte[]> callback)
    {
        orig.ReadSaveSlot(slotIndex, callback);
    }

    public void WriteSaveSlot(int slotIndex, byte[] bytes, Action<bool> callback)
    {
        orig.WriteSaveSlot(slotIndex, bytes, callback);
    }

    public void ClearSaveSlot(int slotIndex, Action<bool> callback)
    {
        orig.ClearSaveSlot(slotIndex, callback);
    }

    public bool Succeeded(int hresult, string operationFriendlyName)
    {
        return CallMethodStatic<bool>(new object[] { hresult, operationFriendlyName });
    }

    public void CompletePostSignInInitialization()
    {
        CallMethod();
    }

    public void MigrateLocalSaves()
    {
        CallMethod();
    }
}