namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of ActiveRecycler allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class ActiveRecyclerR : InstanceClassWrapper<ActiveRecycler>
{
    public ActiveRecyclerR(ActiveRecycler _orig) : base(_orig)
    {
    }
}