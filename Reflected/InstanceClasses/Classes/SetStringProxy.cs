namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of SetStringProxy allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class SetStringProxyR:InstanceClassWrapper<Modding.Delegates.SetStringProxy>
{
public SetStringProxyR(Modding.Delegates.SetStringProxy _orig) : base(_orig) {}
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
