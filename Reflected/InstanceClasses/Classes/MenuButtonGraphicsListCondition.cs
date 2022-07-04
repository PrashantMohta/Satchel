namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of MenuButtonGraphicsListCondition allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class MenuButtonGraphicsListConditionR:InstanceClassWrapper<MenuButtonGraphicsListCondition>
{
public MenuButtonGraphicsListConditionR(MenuButtonGraphicsListCondition _orig) : base(_orig) {}


public bool IsFulfilled () =>
orig.IsFulfilled();

}
}
