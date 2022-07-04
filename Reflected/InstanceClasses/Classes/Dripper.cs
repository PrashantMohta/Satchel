namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of Dripper allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class DripperR:InstanceClassWrapper<Dripper>
{
public DripperR(Dripper _orig) : base(_orig) {}
public UnityEngine.GameObject spatterPrefab
{
get => orig.spatterPrefab;
set => orig.spatterPrefab = value;
}

public UnityEngine.Coroutine routine
{
get => GetField<UnityEngine.Coroutine>();
set => SetField(value);
}



public void OnEnable () =>
CallMethod();

public void OnDisable () =>
CallMethod();

public System.Collections.IEnumerator Behaviour () =>
CallMethod<System.Collections.IEnumerator>();

}
}
