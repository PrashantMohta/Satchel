namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of TutorialEntryPauser allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class TutorialEntryPauserR : InstanceClassWrapper<TutorialEntryPauser>
{
    public TutorialEntryPauserR(TutorialEntryPauser _orig) : base(_orig)
    {
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

    public HeroController hc
    {
        get => GetField<HeroController>();
        set => SetField(value);
    }


    public void Start()
    {
        CallMethod();
    }

    public void EnableControl()
    {
        CallMethod();
    }
}