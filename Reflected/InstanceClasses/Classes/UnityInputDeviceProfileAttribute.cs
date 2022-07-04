using InControl;

namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of UnityInputDeviceProfileAttribute allowing you
///     to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class UnityInputDeviceProfileAttributeR : InstanceClassWrapper<UnityInputDeviceProfileAttribute>
{
    public UnityInputDeviceProfileAttributeR(UnityInputDeviceProfileAttribute _orig) : base(_orig)
    {
    }

    public object TypeId => orig.TypeId;
}