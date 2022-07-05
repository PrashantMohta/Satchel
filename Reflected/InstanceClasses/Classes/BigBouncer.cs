namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of BigBouncer allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class BigBouncerR : InstanceClassWrapper<BigBouncer>
{
    public BigBouncerR(BigBouncer _orig) : base(_orig)
    {
    }
}