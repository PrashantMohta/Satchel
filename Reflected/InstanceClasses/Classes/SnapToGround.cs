namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of SnapToGround allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class SnapToGroundR : InstanceClassWrapper<SnapToGround>
{
    public SnapToGroundR(SnapToGround _orig) : base(_orig)
    {
    }

    public Collider2D col
    {
        get => GetField<Collider2D>();
        set => SetField(value);
    }


    public void Awake()
    {
        CallMethod();
    }

    public void OnEnable()
    {
        CallMethod();
    }
}