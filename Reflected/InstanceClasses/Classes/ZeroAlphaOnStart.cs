namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of ZeroAlphaOnStart allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class ZeroAlphaOnStartR:InstanceClassWrapper<ZeroAlphaOnStart>
{
public ZeroAlphaOnStartR(ZeroAlphaOnStart _orig) : base(_orig) {}


public void Start () =>
CallMethod();

}
}
