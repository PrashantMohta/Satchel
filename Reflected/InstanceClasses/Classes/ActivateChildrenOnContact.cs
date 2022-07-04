namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of ActivateChildrenOnContact allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class ActivateChildrenOnContactR:InstanceClassWrapper<ActivateChildrenOnContact>
{
public ActivateChildrenOnContactR(ActivateChildrenOnContact _orig) : base(_orig) {}
public UnityEngine.CircleCollider2D circleCollider
{
get => orig.circleCollider;
set => orig.circleCollider = value;
}

public UnityEngine.BoxCollider2D boxCollider
{
get => orig.boxCollider;
set => orig.boxCollider = value;
}



public void OnTriggerEnter2D (UnityEngine.Collider2D collision) =>
CallMethod(new object[] {collision});

}
}
