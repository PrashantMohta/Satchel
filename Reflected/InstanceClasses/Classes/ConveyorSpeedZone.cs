namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of ConveyorSpeedZone allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class ConveyorSpeedZoneR : InstanceClassWrapper<ConveyorSpeedZone>
{
    public ConveyorSpeedZoneR(ConveyorSpeedZone _orig) : base(_orig)
    {
    }

    public float speed
    {
        get => orig.speed;
        set => orig.speed = value;
    }


    public void OnTriggerEnter2D(Collider2D collision)
    {
        CallMethod(new object[] { collision });
    }
}