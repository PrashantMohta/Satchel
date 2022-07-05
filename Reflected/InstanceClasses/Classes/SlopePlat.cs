namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of SlopePlat allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class SlopePlatR : InstanceClassWrapper<SlopePlat>
{
    public SlopePlatR(SlopePlat _orig) : base(_orig)
    {
    }

    public float heroXLeft
    {
        get => orig.heroXLeft;
        set => orig.heroXLeft = value;
    }

    public float heroXRight
    {
        get => orig.heroXRight;
        set => orig.heroXRight = value;
    }

    public float platYLeft
    {
        get => orig.platYLeft;
        set => orig.platYLeft = value;
    }

    public float platYRight
    {
        get => orig.platYRight;
        set => orig.platYRight = value;
    }

    public GameObject hero
    {
        get => GetField<GameObject>();
        set => SetField(value);
    }


    public void Start()
    {
        CallMethod();
    }

    public void Update()
    {
        CallMethod();
    }
}