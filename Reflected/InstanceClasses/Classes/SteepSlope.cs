namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of SteepSlope allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class SteepSlopeR : InstanceClassWrapper<SteepSlope>
{
    public SteepSlopeR(SteepSlope _orig) : base(_orig)
    {
    }

    public bool slideLeft
    {
        get => orig.slideLeft;
        set => orig.slideLeft = value;
    }

    public bool slideRight
    {
        get => orig.slideRight;
        set => orig.slideRight = value;
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

    public void OnCollisionStay2D(Collision2D collision)
    {
        CallMethod(new object[] { collision });
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        CallMethod(new object[] { collision });
    }

    public void OnCollisionExit2D(Collision2D collision)
    {
        CallMethod(new object[] { collision });
    }
}