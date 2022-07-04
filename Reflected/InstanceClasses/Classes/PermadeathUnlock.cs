namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of PermadeathUnlock allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class PermadeathUnlockR : InstanceClassWrapper<PermadeathUnlock>
{
    public PermadeathUnlockR(PermadeathUnlock _orig) : base(_orig)
    {
    }


    public void Start()
    {
        CallMethod();
    }
}