namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of TakeDamageProxy allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class TakeDamageProxyR:InstanceClassWrapper<Modding.Delegates.TakeDamageProxy>
{
public TakeDamageProxyR(Modding.Delegates.TakeDamageProxy _orig) : base(_orig) {}
public bool HasSingleTarget
{
get => GetProperty<bool>();
}

public System.Reflection.MethodInfo Method
{
get => orig.Method;
}

public System.Object Target
{
get => orig.Target;
}

public int Invoke (ref int hazardType, int damage) =>
orig.Invoke(ref hazardType, damage);

public int EndInvoke (ref int hazardType, System.IAsyncResult result) =>
orig.EndInvoke(ref hazardType, result);

}
}
