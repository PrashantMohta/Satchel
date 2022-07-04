namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of GateSnap allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class GateSnapR : InstanceClassWrapper<GateSnap>
{
    public GateSnapR(GateSnap _orig) : base(_orig)
    {
    }

    public float snapX
    {
        get => GetField<float>();
        set => SetField(value);
    }

    public float snapY
    {
        get => GetField<float>();
        set => SetField(value);
    }


    public void Update()
    {
        CallMethod();
    }
}