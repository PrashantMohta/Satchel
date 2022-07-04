namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of DestructibleProp allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class DestructiblePropR:InstanceClassWrapper<DestructibleProp>
{
public DestructiblePropR(DestructibleProp _orig) : base(_orig) {}


}
}
