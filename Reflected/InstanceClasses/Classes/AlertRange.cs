namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of AlertRange allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class AlertRangeR:InstanceClassWrapper<AlertRange>
{
public AlertRangeR(AlertRange _orig) : base(_orig) {}
public bool isHeroInRange
{
get => GetField<bool>();
set => SetField(value);
}

public UnityEngine.Collider2D[] colliders
{
get => GetField<UnityEngine.Collider2D[]>();
set => SetField(value);
}

public bool IsHeroInRange
{
get => orig.IsHeroInRange;
}



public void Awake () =>
CallMethod();

public void OnTriggerEnter2D (UnityEngine.Collider2D other) =>
CallMethod(new object[] {other});

public void OnTriggerExit2D (UnityEngine.Collider2D other) =>
CallMethod(new object[] {other});

public bool StillInColliders () =>
CallMethod<bool>();

public AlertRange Find (UnityEngine.GameObject root, string childName) =>
AlertRange.Find(root, childName);

}
}
