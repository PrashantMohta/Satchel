namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of SetVariableProxy allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class SetVariableProxyR:InstanceClassWrapper<Modding.Delegates.SetVariableProxy>
{
public SetVariableProxyR(Modding.Delegates.SetVariableProxy _orig) : base(_orig) {}
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

public System.Object Invoke (System.Type type, string name, System.Object value) =>
orig.Invoke(type, name, value);

public System.Object EndInvoke (System.IAsyncResult result) =>
orig.EndInvoke(result);

}
}
