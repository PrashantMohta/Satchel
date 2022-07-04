namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of MenuButtonAchievementListCondition allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class MenuButtonAchievementListConditionR:InstanceClassWrapper<MenuButtonAchievementListCondition>
{
public MenuButtonAchievementListConditionR(MenuButtonAchievementListCondition _orig) : base(_orig) {}


public bool IsFulfilled () =>
orig.IsFulfilled();

}
}
