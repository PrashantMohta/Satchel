namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of GetBoolProxy allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class GetBoolProxyR:InstanceClassWrapper<Modding.Delegates.GetBoolProxy>
{
public GetBoolProxyR(Modding.Delegates.GetBoolProxy _orig) : base(_orig) {}
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

public bool EndInvoke (System.IAsyncResult result) =>
orig.EndInvoke(result);

}
}
