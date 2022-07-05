namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of MenuButtonControllerListCondition allowing you
///     to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class MenuButtonControllerListConditionR : InstanceClassWrapper<MenuButtonControllerListCondition>
{
    public MenuButtonControllerListConditionR(MenuButtonControllerListCondition _orig) : base(_orig)
    {
    }


    public bool IsFulfilled()
    {
        return orig.IsFulfilled();
    }
}