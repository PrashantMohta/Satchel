namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of CharmUpdateHandler allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class CharmUpdateHandlerR:InstanceClassWrapper<Modding.Delegates.CharmUpdateHandler>
{
public CharmUpdateHandlerR(Modding.Delegates.CharmUpdateHandler _orig) : base(_orig) {}
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

public void Invoke (PlayerData data, HeroController controller) =>
orig.Invoke(data, controller);

public void EndInvoke (System.IAsyncResult result) =>
orig.EndInvoke(result);

}
}
