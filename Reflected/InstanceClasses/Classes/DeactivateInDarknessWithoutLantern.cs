namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of DeactivateInDarknessWithoutLantern allowing
///     you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class DeactivateInDarknessWithoutLanternR : InstanceClassWrapper<DeactivateInDarknessWithoutLantern>
{
    public DeactivateInDarknessWithoutLanternR(DeactivateInDarknessWithoutLantern _orig) : base(_orig)
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

    public SceneManager sm
    {
        get => GetField<SceneManager>();
        set => SetField(value);
    }


    public void Start()
    {
        CallMethod();
    }
}