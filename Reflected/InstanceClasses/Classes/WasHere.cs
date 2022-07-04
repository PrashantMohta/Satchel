using MonoMod;

namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of WasHere allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class WasHereR : InstanceClassWrapper<WasHere>
{
    public WasHereR(WasHere _orig) : base(_orig)
    {
    }
}