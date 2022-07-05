using System.Reflection;
using Modding.Delegates;

namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of OnReceiveDeathEventHandler allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class OnReceiveDeathEventHandlerR : InstanceClassWrapper<OnReceiveDeathEventHandler>
{
    public OnReceiveDeathEventHandlerR(OnReceiveDeathEventHandler _orig) : base(_orig)
    {
    }

    public bool HasSingleTarget => GetProperty<bool>();

    public MethodInfo Method => orig.Method;

    public object Target => orig.Target;

    public void Invoke(EnemyDeathEffects enemyDeathEffects, ref bool eventAlreadyReceived, ref float? attackDirection,
        ref bool resetDeathEvent, ref bool spellBurn, ref bool isWatery)
    {
        orig.Invoke(enemyDeathEffects, eventAlreadyReceived, ref attackDirection, ref resetDeathEvent, ref spellBurn,
            ref isWatery);
    }

    public void EndInvoke(ref float? attackDirection, ref bool resetDeathEvent, ref bool spellBurn, ref bool isWatery,
        IAsyncResult result)
    {
        orig.EndInvoke(ref attackDirection, ref resetDeathEvent, ref spellBurn, ref isWatery, result);
    }
}