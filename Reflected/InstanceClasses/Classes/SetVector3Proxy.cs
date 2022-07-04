namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of SetVector3Proxy allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class SetVector3ProxyR:InstanceClassWrapper<Modding.Delegates.SetVector3Proxy>
{
public SetVector3ProxyR(Modding.Delegates.SetVector3Proxy _orig) : base(_orig) {}
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
