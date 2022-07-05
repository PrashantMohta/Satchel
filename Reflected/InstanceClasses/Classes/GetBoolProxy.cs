using System.Reflection;
using Modding.Delegates;

namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of GetBoolProxy allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class GetBoolProxyR : InstanceClassWrapper<GetBoolProxy>
{
    public GetBoolProxyR(GetBoolProxy _orig) : base(_orig)
    {
    }

    public bool HasSingleTarget => GetProperty<bool>();

    public MethodInfo Method => orig.Method;

    public object Target => orig.Target;

    public bool EndInvoke(IAsyncResult result)
    {
        return orig.EndInvoke(result);
    }
}