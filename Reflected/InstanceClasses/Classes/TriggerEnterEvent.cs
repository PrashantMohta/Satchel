namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of TriggerEnterEvent allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class TriggerEnterEventR : InstanceClassWrapper<TriggerEnterEvent>
{
    public TriggerEnterEventR(TriggerEnterEvent _orig) : base(_orig)
    {
    }

    public bool waitForHeroInPosition
    {
        get => orig.waitForHeroInPosition;
        set => orig.waitForHeroInPosition = value;
    }

    public bool active
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

    public void OnTriggerStay2D(Collider2D collision)
    {
        CallMethod(new object[] { collision });
    }
}