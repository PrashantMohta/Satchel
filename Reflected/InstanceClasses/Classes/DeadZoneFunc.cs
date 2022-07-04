namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of DeadZoneFunc allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class DeadZoneFuncR:InstanceClassWrapper<InControl.DeadZoneFunc>
{
public DeadZoneFuncR(InControl.DeadZoneFunc _orig) : base(_orig) {}
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

public UnityEngine.Vector2 Invoke (float x, float y, float lowerDeadZone, float upperDeadZone) =>
orig.Invoke(x, y, lowerDeadZone, upperDeadZone);

public UnityEngine.Vector2 EndInvoke (System.IAsyncResult result) =>
orig.EndInvoke(result);

}
}
