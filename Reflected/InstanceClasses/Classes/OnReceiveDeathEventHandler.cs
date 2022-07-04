namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of OnReceiveDeathEventHandler allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class OnReceiveDeathEventHandlerR:InstanceClassWrapper<Modding.Delegates.OnReceiveDeathEventHandler>
{
public OnReceiveDeathEventHandlerR(Modding.Delegates.OnReceiveDeathEventHandler _orig) : base(_orig) {}
public bool HasSingleTarget
{
get => GetProperty<bool>();
}

public System.Reflection.MethodInfo Method
{
get => orig.Method;
}

public System.Object Target
{
get => orig.Target;
}

public void Invoke (EnemyDeathEffects enemyDeathEffects, ref bool eventAlreadyReceived, ref System.Single? attackDirection, ref bool resetDeathEvent, ref bool spellBurn, ref bool isWatery) =>
orig.Invoke(enemyDeathEffects, eventAlreadyReceived, ref attackDirection, ref resetDeathEvent, ref spellBurn, ref isWatery);

public void EndInvoke (ref System.Single? attackDirection, ref bool resetDeathEvent, ref bool spellBurn, ref bool isWatery, System.IAsyncResult result) =>
orig.EndInvoke(ref attackDirection, ref resetDeathEvent, ref spellBurn, ref isWatery, result);

}
}
