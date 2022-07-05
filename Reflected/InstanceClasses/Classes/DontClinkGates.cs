namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of DontClinkGates allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class DontClinkGatesR : InstanceClassWrapper<DontClinkGates>
{
    public DontClinkGatesR(DontClinkGates _orig) : base(_orig)
    {
    }
}