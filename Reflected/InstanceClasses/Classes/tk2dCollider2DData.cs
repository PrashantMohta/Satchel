namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of tk2dCollider2DData allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class tk2dCollider2DDataR : InstanceClassWrapper<tk2dCollider2DData>
{
    public tk2dCollider2DDataR(tk2dCollider2DData _orig) : base(_orig)
    {
    }

    public Vector2[] points
    {
        get => orig.points;
        set => orig.points = value;
    }
}