using MonoMod;

namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of MonoModOriginal allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class MonoModOriginalR : InstanceClassWrapper<MonoModOriginal>
{
    public MonoModOriginalR(MonoModOriginal _orig) : base(_orig)
    {
    }

    public object TypeId => orig.TypeId;
}