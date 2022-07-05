using System.Reflection;
using Modding.Delegates;

namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of SetVariableProxy allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class SetVariableProxyR : InstanceClassWrapper<SetVariableProxy>
{
    public SetVariableProxyR(SetVariableProxy _orig) : base(_orig)
    {
    }

    public bool HasSingleTarget => GetProperty<bool>();

    public MethodInfo Method => orig.Method;

    public object Target => orig.Target;

    public object Invoke(Type type, string name, object value)
    {
        return orig.Invoke(type, name, value);
    }

    public object EndInvoke(IAsyncResult result)
    {
        return orig.EndInvoke(result);
    }
}