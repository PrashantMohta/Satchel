using MonoMod;

namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of MonoModOriginalName allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class MonoModOriginalNameR : InstanceClassWrapper<MonoModOriginalName>
{
    public MonoModOriginalNameR(MonoModOriginalName _orig) : base(_orig)
    {
    }

    public object TypeId => orig.TypeId;
}