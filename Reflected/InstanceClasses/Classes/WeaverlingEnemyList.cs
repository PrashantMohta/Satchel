namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of WeaverlingEnemyList allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class WeaverlingEnemyListR : InstanceClassWrapper<WeaverlingEnemyList>
{
    public WeaverlingEnemyListR(WeaverlingEnemyList _orig) : base(_orig)
    {
    }

    public List<GameObject> enemyList
    {
        get => orig.enemyList;
        set => orig.enemyList = value;
    }


    public void OnEnable()
    {
        CallMethod();
    }

    public void OnTriggerEnter2D(Collider2D otherCollider)
    {
        CallMethod(new object[] { otherCollider });
    }

    public void OnTriggerExit2D(Collider2D otherCollider)
    {
        CallMethod(new object[] { otherCollider });
    }

    public GameObject GetTarget()
    {
        return orig.GetTarget();
    }
}