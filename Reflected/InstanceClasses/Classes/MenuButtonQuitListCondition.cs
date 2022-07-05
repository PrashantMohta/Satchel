namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of MenuButtonQuitListCondition allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class MenuButtonQuitListConditionR : InstanceClassWrapper<MenuButtonQuitListCondition>
{
    public MenuButtonQuitListConditionR(MenuButtonQuitListCondition _orig) : base(_orig)
    {
    }


    public bool IsFulfilled()
    {
        return orig.IsFulfilled();
    }
}