using System.Reflection;
using Modding.Delegates;

namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of CharmUpdateHandler allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class CharmUpdateHandlerR : InstanceClassWrapper<CharmUpdateHandler>
{
    public CharmUpdateHandlerR(CharmUpdateHandler _orig) : base(_orig)
    {
    }

    public bool HasSingleTarget => GetProperty<bool>();

    public MethodInfo Method => orig.Method;

    public object Target => orig.Target;

    public void Invoke(PlayerData data, HeroController controller)
    {
        orig.Invoke(data, controller);
    }

    public void EndInvoke(IAsyncResult result)
    {
        orig.EndInvoke(result);
    }
}