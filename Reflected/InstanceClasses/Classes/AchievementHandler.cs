namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of AchievementHandler allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class AchievementHandlerR:InstanceClassWrapper<AchievementHandler>
{
public AchievementHandlerR(AchievementHandler _orig) : base(_orig) {}
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

public UnityEngine.Sprite hiddenAchievementIcon
{
get => orig.hiddenAchievementIcon;
set => orig.hiddenAchievementIcon = value;
}

public System.Collections.Generic.List<System.String> queuedAchievements
{
get => GetField<System.Collections.Generic.List<System.String>>();
set => SetField(value);
}

public System.Collections.Generic.Dictionary<System.String,System.Collections.Generic.List<System.String>> achievementWhiteLists
{
get => GetField<System.Collections.Generic.Dictionary<System.String,System.Collections.Generic.List<System.String>>>();
set => SetField(value);
}

public AchievementsList achievementsList
{
get => orig.achievementsList;
set => SetProperty(value);
}



public void Awake () =>
CallMethod();

public void Start () =>
CallMethod();

public void AwardAchievementToPlayer (string key) =>
orig.AwardAchievementToPlayer(key);

public bool AchievementWasAwarded (string key) =>
orig.AchievementWasAwarded(key);

public void ResetAllAchievements () =>
orig.ResetAllAchievements();

public void FlushRecordsToDisk () =>
orig.FlushRecordsToDisk();

public void QueueAchievement (string key) =>
orig.QueueAchievement(key);

public void AwardQueuedAchievements () =>
orig.AwardQueuedAchievements();

public void AwardAllAchievements () =>
orig.AwardAllAchievements();

public bool CanAwardAchievement (string key) =>
CallMethod<bool>(new object[] {key});

}
}
