namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of TakeHealthProxy allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class TakeHealthProxyR:InstanceClassWrapper<Modding.Delegates.TakeHealthProxy>
{
public TakeHealthProxyR(Modding.Delegates.TakeHealthProxy _orig) : base(_orig) {}
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

public int Invoke (int damage) =>
orig.Invoke(damage);

public int EndInvoke (System.IAsyncResult result) =>
orig.EndInvoke(result);

}
}
