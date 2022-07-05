using System.Reflection;
using Modding.Delegates;

namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of SlashHitHandler allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class SlashHitHandlerR : InstanceClassWrapper<SlashHitHandler>
{
    public SlashHitHandlerR(SlashHitHandler _orig) : base(_orig)
    {
    }

    public bool HasSingleTarget => GetProperty<bool>();

    public MethodInfo Method => orig.Method;

    public object Target => orig.Target;

    public void Invoke(Collider2D otherCollider, GameObject slash)
    {
        orig.Invoke(otherCollider, slash);
    }

    public void EndInvoke(IAsyncResult result)
    {
        orig.EndInvoke(result);
    }
}