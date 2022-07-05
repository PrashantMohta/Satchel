namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of PlayerAchievements allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class PlayerAchievementsR : InstanceClassWrapper<PlayerAchievements>
{
    public PlayerAchievementsR(PlayerAchievements _orig) : base(_orig)
    {
    }
}