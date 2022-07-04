namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of UnboldIfCJK allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class UnboldIfCJKR : InstanceClassWrapper<UnboldIfCJK>
{
    public UnboldIfCJKR(UnboldIfCJK _orig) : base(_orig)
    {
    }

    public GameManager gm
    {
        get => GetField<GameManager>();
        set => SetField(value);
    }


    public void OnEnable()
    {
        CallMethod();
    }
}