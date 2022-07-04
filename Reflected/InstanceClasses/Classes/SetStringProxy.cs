using System.Reflection;
using Modding.Delegates;

namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of SetStringProxy allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class SetStringProxyR : InstanceClassWrapper<SetStringProxy>
{
    public SetStringProxyR(SetStringProxy _orig) : base(_orig)
    {
    }

    public bool HasSingleTarget => GetProperty<bool>();

    public MethodInfo Method => orig.Method;

    public object Target => orig.Target;

    public string Invoke(string name, string res)
    {
        return orig.Invoke(name, res);
    }

    public string EndInvoke(IAsyncResult result)
    {
        return orig.EndInvoke(result);
    }
}