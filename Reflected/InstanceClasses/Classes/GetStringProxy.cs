namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of GetStringProxy allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class GetStringProxyR:InstanceClassWrapper<Modding.Delegates.GetStringProxy>
{
public GetStringProxyR(Modding.Delegates.GetStringProxy _orig) : base(_orig) {}
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

public string Invoke (string name, string res) =>
orig.Invoke(name, res);

public string EndInvoke (System.IAsyncResult result) =>
orig.EndInvoke(result);

}
}
