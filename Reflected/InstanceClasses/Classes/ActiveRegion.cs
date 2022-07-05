namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of ActiveRegion allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class ActiveRegionR : InstanceClassWrapper<ActiveRegion>
{
    public ActiveRegionR(ActiveRegion _orig) : base(_orig)
    {
    }

    public bool verboseMode
    {
        get => GetField<bool>();
        set => SetField(value);
    }

    public bool staggeredActivation
    {
        get => orig.staggeredActivation;
        set => orig.staggeredActivation = value;
    }

    public BoxCollider2D activeRegion
    {
        get => GetField<BoxCollider2D>();
        set => SetField(value);
    }


    public void OnTriggerEnter2D(Collider2D col)
    {
        CallMethod(new object[] { col });
    }
}