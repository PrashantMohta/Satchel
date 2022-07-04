namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of PS4SimpleInputDeviceManager allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class PS4SimpleInputDeviceManagerR:InstanceClassWrapper<InControl.PS4SimpleInputDeviceManager>
{
public PS4SimpleInputDeviceManagerR(InControl.PS4SimpleInputDeviceManager _orig) : base(_orig) {}
public InControl.PS4SimpleInputDevice device
{
get => GetField<InControl.PS4SimpleInputDevice>();
set => SetField(value);
}

public bool isDeviceAttached
{
get => GetField<bool>();
set => SetField(value);
}

public System.Collections.Generic.List<InControl.InputDevice> devices
{
get => GetField<System.Collections.Generic.List<InControl.InputDevice>>();
set => SetField(value);
}

public InControl.PS4SimpleInputDevice Device
{
get => orig.Device;
}

public void Update (System.UInt64 updateTick, float deltaTime) =>
orig.Update(updateTick, deltaTime);

public bool CheckPlatformSupport (System.Collections.Generic.ICollection<System.String>errors) =>
InControl.PS4SimpleInputDeviceManager.CheckPlatformSupport(errors);

public bool Enable () =>
CallMethodStatic<bool>();

}
}
