namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of AchievementsList allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class AchievementsListR : InstanceClassWrapper<AchievementsList>
{
    public AchievementsListR(AchievementsList _orig) : base(_orig)
    {
    }

    public List<Achievement> achievements
    {
        get => orig.achievements;
        set => orig.achievements = value;
    }


    public Achievement FindAchievement(string key)
    {
        return orig.FindAchievement(key);
    }

    public bool AchievementExists(string key)
    {
        return orig.AchievementExists(key);
    }
}