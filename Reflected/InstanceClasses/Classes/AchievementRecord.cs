namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of AchievementRecord allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class AchievementRecordR:InstanceClassWrapper<AchievementRecord>
{
public AchievementRecordR(AchievementRecord _orig) : base(_orig) {}
}
}
