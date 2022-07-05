using System.Reflection;
using Modding.Delegates;

namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of TakeHealthProxy allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class TakeHealthProxyR : InstanceClassWrapper<TakeHealthProxy>
{
    public TakeHealthProxyR(TakeHealthProxy _orig) : base(_orig)
    {
    }

    public bool HasSingleTarget => GetProperty<bool>();

    public MethodInfo Method => orig.Method;

    public object Target => orig.Target;

    public int Invoke(int damage)
    {
        return orig.Invoke(damage);
    }

    public int EndInvoke(IAsyncResult result)
    {
        return orig.EndInvoke(result);
    }
}