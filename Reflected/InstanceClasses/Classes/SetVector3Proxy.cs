using System.Reflection;
using Modding.Delegates;

namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of SetVector3Proxy allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class SetVector3ProxyR : InstanceClassWrapper<SetVector3Proxy>
{
    public SetVector3ProxyR(SetVector3Proxy _orig) : base(_orig)
    {
    }

    public bool HasSingleTarget => GetProperty<bool>();

    public MethodInfo Method => orig.Method;

    public object Target => orig.Target;

    public Vector3 EndInvoke(IAsyncResult result)
    {
        return orig.EndInvoke(result);
    }
}