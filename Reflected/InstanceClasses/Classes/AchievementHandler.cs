namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of AchievementHandler allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class AchievementHandlerR : InstanceClassWrapper<AchievementHandler>
{
    public AchievementHandlerR(AchievementHandler _orig) : base(_orig)
    {
    }

    public GameManager gm
    {
        get => GetField<GameManager>();
        set => SetField(value);
    }

    public AchievementsList achievementsListPrefab
    {
        get => orig.achievementsListPrefab;
        set => orig.achievementsListPrefab = value;
    }

    public Sprite hiddenAchievementIcon
    {
        get => orig.hiddenAchievementIcon;
        set => orig.hiddenAchievementIcon = value;
    }

    public List<string> queuedAchievements
    {
        get => GetField<List<string>>();
        set => SetField(value);
    }

    public Dictionary<string, List<string>> achievementWhiteLists
    {
        get => GetField<Dictionary<string, List<string>>>();
        set => SetField(value);
    }

    public AchievementsList achievementsList
    {
        get => orig.achievementsList;
        set => SetProperty(value);
    }


    public void Awake()
    {
        CallMethod();
    }

    public void Start()
    {
        CallMethod();
    }

    public void AwardAchievementToPlayer(string key)
    {
        orig.AwardAchievementToPlayer(key);
    }

    public bool AchievementWasAwarded(string key)
    {
        return orig.AchievementWasAwarded(key);
    }

    public void ResetAllAchievements()
    {
        orig.ResetAllAchievements();
    }

    public void FlushRecordsToDisk()
    {
        orig.FlushRecordsToDisk();
    }

    public void QueueAchievement(string key)
    {
        orig.QueueAchievement(key);
    }

    public void AwardQueuedAchievements()
    {
        orig.AwardQueuedAchievements();
    }

    public void AwardAllAchievements()
    {
        orig.AwardAllAchievements();
    }

    public bool CanAwardAchievement(string key)
    {
        return CallMethod<bool>(new object[] { key });
    }
}