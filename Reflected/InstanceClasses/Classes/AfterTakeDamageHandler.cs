using System.Reflection;
using Modding.Delegates;

namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of AfterTakeDamageHandler allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class AfterTakeDamageHandlerR : InstanceClassWrapper<AfterTakeDamageHandler>
{
    public AfterTakeDamageHandlerR(AfterTakeDamageHandler _orig) : base(_orig)
    {
    }

    public bool HasSingleTarget => GetProperty<bool>();

    public MethodInfo Method => orig.Method;

    public object Target => orig.Target;

    public int Invoke(int hazardType, int damageAmount)
    {
        return orig.Invoke(hazardType, damageAmount);
    }

    public int EndInvoke(IAsyncResult result)
    {
        return orig.EndInvoke(result);
    }
}