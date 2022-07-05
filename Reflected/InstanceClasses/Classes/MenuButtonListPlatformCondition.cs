namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of MenuButtonListPlatformCondition allowing you
///     to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class MenuButtonListPlatformConditionR : InstanceClassWrapper<MenuButtonListPlatformCondition>
{
    public MenuButtonListPlatformConditionR(MenuButtonListPlatformCondition _orig) : base(_orig)
    {
    }

    public MenuButtonListPlatformCondition.PlatformBoolPair[] platforms
    {
        get => orig.platforms;
        set => orig.platforms = value;
    }

    public bool defaultActivation
    {
        get => orig.defaultActivation;
        set => orig.defaultActivation = value;
    }


    public bool IsFulfilled()
    {
        return orig.IsFulfilled();
    }
}