namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of PreserveAttribute allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class PreserveAttributeR:InstanceClassWrapper<InControl.PreserveAttribute>
{
public PreserveAttributeR(InControl.PreserveAttribute _orig) : base(_orig) {}
public System.Object TypeId
{
get => orig.TypeId;
}

}
}
