namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of HitInstanceHandler allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class HitInstanceHandlerR:InstanceClassWrapper<Modding.Delegates.HitInstanceHandler>
{
public HitInstanceHandlerR(Modding.Delegates.HitInstanceHandler _orig) : base(_orig) {}
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

public HitInstance Invoke (HutongGames.PlayMaker.Fsm owner, HitInstance hit) =>
orig.Invoke(owner, hit);

public HitInstance EndInvoke (System.IAsyncResult result) =>
orig.EndInvoke(result);

}
}
