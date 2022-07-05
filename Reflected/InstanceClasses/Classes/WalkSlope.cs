namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of WalkSlope allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class WalkSlopeR : InstanceClassWrapper<WalkSlope>
{
    public WalkSlopeR(WalkSlope _orig) : base(_orig)
    {
    }


    public void Start()
    {
        CallMethod();
    }
}