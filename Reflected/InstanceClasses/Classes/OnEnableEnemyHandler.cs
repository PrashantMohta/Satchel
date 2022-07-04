using System.Reflection;
using Modding.Delegates;

namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of OnEnableEnemyHandler allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class OnEnableEnemyHandlerR : InstanceClassWrapper<OnEnableEnemyHandler>
{
    public OnEnableEnemyHandlerR(OnEnableEnemyHandler _orig) : base(_orig)
    {
    }

    public bool HasSingleTarget => GetProperty<bool>();

    public MethodInfo Method => orig.Method;

    public object Target => orig.Target;

    public bool Invoke(GameObject enemy, bool isAlreadyDead)
    {
        return orig.Invoke(enemy, isAlreadyDead);
    }

    public bool EndInvoke(IAsyncResult result)
    {
        return orig.EndInvoke(result);
    }
}