namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of GrimmEnemyRange allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class GrimmEnemyRangeR : InstanceClassWrapper<GrimmEnemyRange>
{
    public GrimmEnemyRangeR(GrimmEnemyRange _orig) : base(_orig)
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

    public bool IsEnemyInRange()
    {
        return orig.IsEnemyInRange();
    }

    public GameObject GetTarget()
    {
        return orig.GetTarget();
    }

    public void OnTriggerEnter2D(Collider2D otherCollider)
    {
        CallMethod(new object[] { otherCollider });
    }

    public void OnTriggerExit2D(Collider2D otherCollider)
    {
        CallMethod(new object[] { otherCollider });
    }

    public void ClearEnemyList()
    {
        orig.ClearEnemyList();
    }
}