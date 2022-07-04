namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of RestBench allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class RestBenchR : InstanceClassWrapper<RestBench>
{
    public RestBenchR(RestBench _orig) : base(_orig)
    {
    }

    public HeroController heroCtrl
    {
        get => GetField<HeroController>();
        set => SetField(value);
    }


    public void Start()
    {
        CallMethod();
    }

    public void OnTriggerEnter2D(Collider2D otherObject)
    {
        CallMethod(new object[] { otherObject });
    }

    public void OnTriggerExit2D(Collider2D otherObject)
    {
        CallMethod(new object[] { otherObject });
    }
}