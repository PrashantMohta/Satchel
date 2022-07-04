namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of GrassWind allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class GrassWindR:InstanceClassWrapper<GrassWind>
{
public GrassWindR(GrassWind _orig) : base(_orig) {}
public UnityEngine.Collider2D col
{
get => GetField<UnityEngine.Collider2D>();
set => SetField(value);
}



public void Awake () =>
CallMethod();

public void OnTriggerEnter2D (UnityEngine.Collider2D collision) =>
CallMethod(new object[] {collision});

public System.Collections.IEnumerator DelayReact (GrassBehaviour behaviour, UnityEngine.Collider2D collision) =>
CallMethod<System.Collections.IEnumerator>(new object[] {behaviour, collision});

}
}
