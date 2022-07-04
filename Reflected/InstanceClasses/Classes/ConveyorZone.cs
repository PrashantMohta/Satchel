namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of ConveyorZone allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class ConveyorZoneR : InstanceClassWrapper<ConveyorZone>
{
    public ConveyorZoneR(ConveyorZone _orig) : base(_orig)
    {
    }

    public float speed
    {
        get => orig.speed;
        set => orig.speed = value;
    }

    public bool vertical
    {
        get => orig.vertical;
        set => orig.vertical = value;
    }

    public bool activated
    {
        get => GetField<bool>();
        set => SetField(value);
    }


    public void Start()
    {
        CallMethod();
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        CallMethod(new object[] { collision });
    }

    public void OnTriggerExit2D(Collider2D collision)
    {
        CallMethod(new object[] { collision });
    }
}