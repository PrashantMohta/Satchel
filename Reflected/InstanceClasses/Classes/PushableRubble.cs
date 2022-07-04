namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of PushableRubble allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class PushableRubbleR:InstanceClassWrapper<PushableRubble>
{
public PushableRubbleR(PushableRubble _orig) : base(_orig) {}
public UnityEngine.Rigidbody2D body
{
get => GetField<UnityEngine.Rigidbody2D>();
set => SetField(value);
}



public void Awake () =>
CallMethod();

public void OnTriggerEnter2D (UnityEngine.Collider2D collider) =>
CallMethod(new object[] {collider});

public void Push () =>
CallMethod();

public void EndRubble () =>
orig.EndRubble();

public void EndRubbleContinuation () =>
CallMethod();

}
}
