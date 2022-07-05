namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of ConveyorBelt allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class ConveyorBeltR : InstanceClassWrapper<ConveyorBelt>
{
    public ConveyorBeltR(ConveyorBelt _orig) : base(_orig)
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


    public void OnCollisionEnter2D(Collision2D collision)
    {
        CallMethod(new object[] { collision });
    }

    public void OnCollisionExit2D(Collision2D collision)
    {
        CallMethod(new object[] { collision });
    }
}