namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of GrimmEnemyRange allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class GrimmEnemyRangeR:InstanceClassWrapper<GrimmEnemyRange>
{
public GrimmEnemyRangeR(GrimmEnemyRange _orig) : base(_orig) {}
public System.Collections.Generic.List<UnityEngine.GameObject> enemyList
{
get => orig.enemyList;
set => orig.enemyList = value;
}



public void OnEnable () =>
CallMethod();

public bool IsEnemyInRange () =>
orig.IsEnemyInRange();

public UnityEngine.GameObject GetTarget () =>
orig.GetTarget();

public void OnTriggerEnter2D (UnityEngine.Collider2D otherCollider) =>
CallMethod(new object[] {otherCollider});

public void OnTriggerExit2D (UnityEngine.Collider2D otherCollider) =>
CallMethod(new object[] {otherCollider});

public void ClearEnemyList () =>
orig.ClearEnemyList();

}
}
