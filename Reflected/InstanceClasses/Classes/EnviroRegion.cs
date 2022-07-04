namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of EnviroRegion allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class EnviroRegionR : InstanceClassWrapper<EnviroRegion>
{
    public EnviroRegionR(EnviroRegion _orig) : base(_orig)
    {
    }

    public int environmentType
    {
        get => orig.environmentType;
        set => orig.environmentType = value;
    }

    public GameManager gm
    {
        get => GetField<GameManager>();
        set => SetField(value);
    }

    public PlayerData pd
    {
        get => GetField<PlayerData>();
        set => SetField(value);
    }

    public HeroController heroCtrl
    {
        get => GetField<HeroController>();
        set => SetField(value);
    }


    public void Start()
    {
        CallMethod();
    }

    public void OnTriggerEnter2D()
    {
        CallMethod();
    }

    public void OnTriggerExit2D()
    {
        CallMethod();
    }
}