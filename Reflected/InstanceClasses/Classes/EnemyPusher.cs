namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of EnemyPusher allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class EnemyPusherR : InstanceClassWrapper<EnemyPusher>
{
    public EnemyPusherR(EnemyPusher _orig) : base(_orig)
    {
    }


    public void OnCollisionEnter2D(Collision2D collision)
    {
        CallMethod(new object[] { collision });
    }
}