namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of OnEnableEnemyHandler allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class OnEnableEnemyHandlerR:InstanceClassWrapper<Modding.Delegates.OnEnableEnemyHandler>
{
public OnEnableEnemyHandlerR(Modding.Delegates.OnEnableEnemyHandler _orig) : base(_orig) {}
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

public bool Invoke (UnityEngine.GameObject enemy, bool isAlreadyDead) =>
orig.Invoke(enemy, isAlreadyDead);

public bool EndInvoke (System.IAsyncResult result) =>
orig.EndInvoke(result);

}
}
