namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of KeepWorldScalePositive allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class KeepWorldScalePositiveR : InstanceClassWrapper<KeepWorldScalePositive>
{
    public KeepWorldScalePositiveR(KeepWorldScalePositive _orig) : base(_orig)
    {
    }

    public bool x
    {
        get => orig.x;
        set => orig.x = value;
    }

    public bool y
    {
        get => orig.y;
        set => orig.y = value;
    }


    public void Update()
    {
        CallMethod();
    }
}