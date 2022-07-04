namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of AfterTakeDamageHandler allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class AfterTakeDamageHandlerR:InstanceClassWrapper<Modding.Delegates.AfterTakeDamageHandler>
{
public AfterTakeDamageHandlerR(Modding.Delegates.AfterTakeDamageHandler _orig) : base(_orig) {}
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

public int Invoke (int hazardType, int damageAmount) =>
orig.Invoke(hazardType, damageAmount);

public int EndInvoke (System.IAsyncResult result) =>
orig.EndInvoke(result);

}
}
