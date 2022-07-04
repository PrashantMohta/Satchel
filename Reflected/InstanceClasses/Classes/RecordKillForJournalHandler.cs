namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of RecordKillForJournalHandler allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class RecordKillForJournalHandlerR:InstanceClassWrapper<Modding.Delegates.RecordKillForJournalHandler>
{
public RecordKillForJournalHandlerR(Modding.Delegates.RecordKillForJournalHandler _orig) : base(_orig) {}
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

public void Invoke (EnemyDeathEffects enemyDeathEffects, string playerDataName, string killedBoolPlayerDataLookupKey, string killCountIntPlayerDataLookupKey, string newDataBoolPlayerDataLookupKey) =>
orig.Invoke(enemyDeathEffects, playerDataName, killedBoolPlayerDataLookupKey, killCountIntPlayerDataLookupKey, newDataBoolPlayerDataLookupKey);

public void EndInvoke (System.IAsyncResult result) =>
orig.EndInvoke(result);

}
}
