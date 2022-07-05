namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of MenuButtonChineseListCondition allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class MenuButtonChineseListConditionR : InstanceClassWrapper<MenuButtonChineseListCondition>
{
    public MenuButtonChineseListConditionR(MenuButtonChineseListCondition _orig) : base(_orig)
    {
    }

    public bool isChineseBuildDesired
    {
        get => GetField<bool>();
        set => SetField(value);
    }


    public bool IsFulfilled()
    {
        return orig.IsFulfilled();
    }
}