namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of HeroDetect allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class HeroDetectR : InstanceClassWrapper<HeroDetect>
{
    public HeroDetectR(HeroDetect _orig) : base(_orig)
    {
    }


    public void OnTriggerEnter2D(Collider2D collision)
    {
        CallMethod(new object[] { collision });
    }

    public void OnTriggerExit2D(Collider2D collision)
    {
        CallMethod(new object[] { collision });
    }
}