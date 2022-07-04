namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of MenuButtonNativeInputListCondition allowing
///     you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class MenuButtonNativeInputListConditionR : InstanceClassWrapper<MenuButtonNativeInputListCondition>
{
    public MenuButtonNativeInputListConditionR(MenuButtonNativeInputListCondition _orig) : base(_orig)
    {
    }


    public bool IsFulfilled()
    {
        return orig.IsFulfilled();
    }
}