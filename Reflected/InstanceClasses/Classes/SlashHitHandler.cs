namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of SlashHitHandler allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class SlashHitHandlerR:InstanceClassWrapper<Modding.Delegates.SlashHitHandler>
{
public SlashHitHandlerR(Modding.Delegates.SlashHitHandler _orig) : base(_orig) {}
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

public void Invoke (UnityEngine.Collider2D otherCollider, UnityEngine.GameObject slash) =>
orig.Invoke(otherCollider, slash);

public void EndInvoke (System.IAsyncResult result) =>
orig.EndInvoke(result);

}
}
