namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of BreakablePoleTopLand allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class BreakablePoleTopLandR : InstanceClassWrapper<BreakablePoleTopLand>
{
    public BreakablePoleTopLandR(BreakablePoleTopLand _orig) : base(_orig)
    {
    }

    public float angleMin
    {
        get => orig.angleMin;
        set => orig.angleMin = value;
    }

    public float angleMax
    {
        get => orig.angleMax;
        set => orig.angleMax = value;
    }

    public GameObject[] effects
    {
        get => orig.effects;
        set => orig.effects = value;
    }


    public void OnCollisionEnter2D(Collision2D collision)
    {
        CallMethod(new object[] { collision });
    }
}