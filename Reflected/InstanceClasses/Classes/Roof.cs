namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of Roof allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class RoofR : InstanceClassWrapper<Roof>
{
    public RoofR(Roof _orig) : base(_orig)
    {
    }

    public string PlayerTag
    {
        get => GetFieldStatic<string>();
        set => SetField(value);
    }

    public string CancelSuperDashMethod
    {
        get => GetFieldStatic<string>();
        set => SetField(value);
    }

    public string CancelHeroJumpMethod
    {
        get => GetFieldStatic<string>();
        set => SetField(value);
    }


    public void OnCollisionEnter2D(Collision2D collision)
    {
        CallMethod(new object[] { collision });
    }
}