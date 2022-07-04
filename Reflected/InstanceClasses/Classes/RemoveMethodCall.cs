using Modding.Patches;

namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of RemoveMethodCall allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class RemoveMethodCallR : InstanceClassWrapper<RemoveMethodCall>
{
    public RemoveMethodCallR(RemoveMethodCall _orig) : base(_orig)
    {
    }

    public object TypeId => orig.TypeId;
}