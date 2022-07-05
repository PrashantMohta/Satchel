using System.Reflection;
using Modding.Delegates;

namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of TakeDamageProxy allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class TakeDamageProxyR : InstanceClassWrapper<TakeDamageProxy>
{
    public TakeDamageProxyR(TakeDamageProxy _orig) : base(_orig)
    {
    }

    public bool HasSingleTarget => GetProperty<bool>();

    public MethodInfo Method => orig.Method;

    public object Target => orig.Target;

    public int Invoke(ref int hazardType, int damage)
    {
        return orig.Invoke(ref hazardType, damage);
    }

    public int EndInvoke(ref int hazardType, IAsyncResult result)
    {
        return orig.EndInvoke(ref hazardType, result);
    }
}