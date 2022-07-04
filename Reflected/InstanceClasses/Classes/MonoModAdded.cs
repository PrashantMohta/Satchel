using MonoMod;

namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of MonoModAdded allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class MonoModAddedR : InstanceClassWrapper<MonoModAdded>
{
    public MonoModAddedR(MonoModAdded _orig) : base(_orig)
    {
    }

    public object TypeId => orig.TypeId;
}