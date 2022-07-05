namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of ConstrainPosition allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class ConstrainPositionR : InstanceClassWrapper<ConstrainPosition>
{
    public ConstrainPositionR(ConstrainPosition _orig) : base(_orig)
    {
    }

    public bool constrainX
    {
        get => orig.constrainX;
        set => orig.constrainX = value;
    }

    public float xMin
    {
        get => orig.xMin;
        set => orig.xMin = value;
    }

    public float xMax
    {
        get => orig.xMax;
        set => orig.xMax = value;
    }

    public bool constrainY
    {
        get => orig.constrainY;
        set => orig.constrainY = value;
    }

    public float yMin
    {
        get => orig.yMin;
        set => orig.yMin = value;
    }

    public float yMax
    {
        get => orig.yMax;
        set => orig.yMax = value;
    }


    public void Update()
    {
        CallMethod();
    }
}