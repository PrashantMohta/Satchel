namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of LimitSendEvents allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class LimitSendEventsR:InstanceClassWrapper<LimitSendEvents>
{
public LimitSendEventsR(LimitSendEvents _orig) : base(_orig) {}
public UnityEngine.Collider2D monitorCollider
{
get => orig.monitorCollider;
set => orig.monitorCollider = value;
}

public System.Boolean? previousColliderState
{
get => GetField<System.Boolean?>();
set => SetField(value);
}

public System.Collections.Generic.List<UnityEngine.GameObject> sentList
{
get => GetField<System.Collections.Generic.List<UnityEngine.GameObject>>();
set => SetField(value);
}



public void OnEnable () =>
CallMethod();

public void Update () =>
CallMethod();

public bool Add (UnityEngine.GameObject obj) =>
orig.Add(obj);

}
}
