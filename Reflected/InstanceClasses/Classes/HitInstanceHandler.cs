using System.Reflection;
using Modding.Delegates;

namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of HitInstanceHandler allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class HitInstanceHandlerR : InstanceClassWrapper<HitInstanceHandler>
{
    public HitInstanceHandlerR(HitInstanceHandler _orig) : base(_orig)
    {
    }

    public bool HasSingleTarget => GetProperty<bool>();

    public MethodInfo Method => orig.Method;

    public object Target => orig.Target;

    public HitInstance Invoke(Fsm owner, HitInstance hit)
    {
        return orig.Invoke(owner, hit);
    }

    public HitInstance EndInvoke(IAsyncResult result)
    {
        return orig.EndInvoke(result);
    }
}