namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of GetVector3Proxy allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class GetVector3ProxyR:InstanceClassWrapper<Modding.Delegates.GetVector3Proxy>
{
public GetVector3ProxyR(Modding.Delegates.GetVector3Proxy _orig) : base(_orig) {}
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

public UnityEngine.Vector3 EndInvoke (System.IAsyncResult result) =>
orig.EndInvoke(result);

}
}
