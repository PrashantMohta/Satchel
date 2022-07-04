namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of DamageHero allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class DamageHeroR : InstanceClassWrapper<DamageHero>
{
    public DamageHeroR(DamageHero _orig) : base(_orig)
    {
    }

    public int damageDealt
    {
        get => orig.damageDealt;
        set => orig.damageDealt = value;
    }

    public int hazardType
    {
        get => orig.hazardType;
        set => orig.hazardType = value;
    }

    public bool shadowDashHazard
    {
        get => orig.shadowDashHazard;
        set => orig.shadowDashHazard = value;
    }

    public bool resetOnEnable
    {
        get => orig.resetOnEnable;
        set => orig.resetOnEnable = value;
    }

    public int? initialValue
    {
        get => GetField<int?>();
        set => SetField(value);
    }


    public void OnEnable()
    {
        CallMethod();
    }
}