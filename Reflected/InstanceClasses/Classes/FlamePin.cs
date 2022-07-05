namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of FlamePin allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class FlamePinR : InstanceClassWrapper<FlamePin>
{
    public FlamePinR(FlamePin _orig) : base(_orig)
    {
    }

    public PlayerData pd
    {
        get => GetField<PlayerData>();
        set => SetField(value);
    }

    public float level
    {
        get => orig.level;
        set => orig.level = value;
    }


    public void Start()
    {
        CallMethod();
    }

    public void OnEnable()
    {
        CallMethod();
    }
}