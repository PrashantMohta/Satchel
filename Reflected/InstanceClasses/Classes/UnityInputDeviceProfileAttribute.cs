namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of UnityInputDeviceProfileAttribute allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class UnityInputDeviceProfileAttributeR:InstanceClassWrapper<InControl.UnityInputDeviceProfileAttribute>
{
public UnityInputDeviceProfileAttributeR(InControl.UnityInputDeviceProfileAttribute _orig) : base(_orig) {}
public System.Object TypeId
{
get => orig.TypeId;
}

}
}
