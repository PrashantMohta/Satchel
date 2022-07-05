namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of DestroyOutOfBounds allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class DestroyOutOfBoundsR : InstanceClassWrapper<DestroyOutOfBounds>
{
    public DestroyOutOfBoundsR(DestroyOutOfBounds _orig) : base(_orig)
    {
    }


    public void Update()
    {
        CallMethod();
    }
}