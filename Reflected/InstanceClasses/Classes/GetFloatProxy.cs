using System.Reflection;
using Modding.Delegates;

namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of GetFloatProxy allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class GetFloatProxyR : InstanceClassWrapper<GetFloatProxy>
{
    public GetFloatProxyR(GetFloatProxy _orig) : base(_orig)
    {
    }

    public bool HasSingleTarget => GetProperty<bool>();

    public MethodInfo Method => orig.Method;

    public object Target => orig.Target;

    public float EndInvoke(IAsyncResult result)
    {
        return orig.EndInvoke(result);
    }
}