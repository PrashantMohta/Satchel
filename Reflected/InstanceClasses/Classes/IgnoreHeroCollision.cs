namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of IgnoreHeroCollision allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class IgnoreHeroCollisionR : InstanceClassWrapper<IgnoreHeroCollision>
{
    public IgnoreHeroCollisionR(IgnoreHeroCollision _orig) : base(_orig)
    {
    }


    public void Start()
    {
        CallMethod();
    }

    public void Ignore()
    {
        CallMethod();
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        CallMethod(new object[] { collision });
    }
}