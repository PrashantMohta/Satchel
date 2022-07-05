namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of AchievementRecordFloat allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class AchievementRecordFloatR : InstanceClassWrapper<AchievementRecordFloat>
{
    public AchievementRecordFloatR(AchievementRecordFloat _orig) : base(_orig)
    {
    }
}