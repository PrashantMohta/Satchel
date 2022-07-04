namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of DisableIfZPos allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class DisableIfZPosR : InstanceClassWrapper<DisableIfZPos>
{
    public DisableIfZPosR(DisableIfZPos _orig) : base(_orig)
    {
    }

    public float limitZ
    {
        get => orig.limitZ;
        set => orig.limitZ = value;
    }


    public void Start()
    {
        CallMethod();
    }
}