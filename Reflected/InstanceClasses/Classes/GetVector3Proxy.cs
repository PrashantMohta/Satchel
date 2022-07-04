using System.Reflection;
using Modding.Delegates;

namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of GetVector3Proxy allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class GetVector3ProxyR : InstanceClassWrapper<GetVector3Proxy>
{
    public GetVector3ProxyR(GetVector3Proxy _orig) : base(_orig)
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