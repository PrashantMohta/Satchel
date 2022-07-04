namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of SwitchSimpleInputDeviceManager allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class SwitchSimpleInputDeviceManagerR:InstanceClassWrapper<InControl.SwitchSimpleInputDeviceManager>
{
public SwitchSimpleInputDeviceManagerR(InControl.SwitchSimpleInputDeviceManager _orig) : base(_orig) {}
public InControl.SwitchSimpleInputDevice device
{
get => GetField<InControl.SwitchSimpleInputDevice>();
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

public InControl.SwitchSimpleInputDevice Device
{
get => orig.Device;
}

public void Update (System.UInt64 updateTick, float deltaTime) =>
orig.Update(updateTick, deltaTime);

public bool CheckPlatformSupport (System.Collections.Generic.ICollection<System.String>errors) =>
InControl.SwitchSimpleInputDeviceManager.CheckPlatformSupport(errors);

public bool Enable () =>
CallMethodStatic<bool>();

}
}
