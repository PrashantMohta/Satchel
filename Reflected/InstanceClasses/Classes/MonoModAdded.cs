namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of MonoModAdded allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class MonoModAddedR:InstanceClassWrapper<MonoMod.MonoModAdded>
{
public MonoModAddedR(MonoMod.MonoModAdded _orig) : base(_orig) {}
public System.Object TypeId
{
get => orig.TypeId;
}

}
}
