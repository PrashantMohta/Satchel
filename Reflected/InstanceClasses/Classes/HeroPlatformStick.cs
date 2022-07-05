namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of HeroPlatformStick allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class HeroPlatformStickR : InstanceClassWrapper<HeroPlatformStick>
{
    public HeroPlatformStickR(HeroPlatformStick _orig) : base(_orig)
    {
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