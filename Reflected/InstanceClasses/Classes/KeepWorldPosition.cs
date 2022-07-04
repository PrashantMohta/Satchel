namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of KeepWorldPosition allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class KeepWorldPositionR : InstanceClassWrapper<KeepWorldPosition>
{
    public KeepWorldPositionR(KeepWorldPosition _orig) : base(_orig)
    {
    }

    public bool keepX
    {
        get => orig.keepX;
        set => orig.keepX = value;
    }

    public float xPosition
    {
        get => orig.xPosition;
        set => orig.xPosition = value;
    }

    public bool keepY
    {
        get => orig.keepY;
        set => orig.keepY = value;
    }

    public float yPosition
    {
        get => orig.yPosition;
        set => orig.yPosition = value;
    }


    public void Update()
    {
        CallMethod();
    }
}