namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of GetFloatProxy allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class GetFloatProxyR:InstanceClassWrapper<Modding.Delegates.GetFloatProxy>
{
public GetFloatProxyR(Modding.Delegates.GetFloatProxy _orig) : base(_orig) {}
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

public float EndInvoke (System.IAsyncResult result) =>
orig.EndInvoke(result);

}
}
