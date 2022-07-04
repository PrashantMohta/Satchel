using System.Reflection;
using InControl;

namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of DeadZoneFunc allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class DeadZoneFuncR : InstanceClassWrapper<DeadZoneFunc>
{
    public DeadZoneFuncR(DeadZoneFunc _orig) : base(_orig)
    {
    }

    public bool HasSingleTarget => GetProperty<bool>();

    public MethodInfo Method => orig.Method;

    public object Target => orig.Target;

    public Vector2 Invoke(float x, float y, float lowerDeadZone, float upperDeadZone)
    {
        return orig.Invoke(x, y, lowerDeadZone, upperDeadZone);
    }

    public Vector2 EndInvoke(IAsyncResult result)
    {
        return orig.EndInvoke(result);
    }
}