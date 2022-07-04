namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of NativeInputDeviceManager allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class NativeInputDeviceManagerR:InstanceClassWrapper<InControl.NativeInputDeviceManager>
{
public NativeInputDeviceManagerR(InControl.NativeInputDeviceManager _orig) : base(_orig) {}
public System.Func<InControl.InputDeviceInfo,System.Collections.ObjectModel.ReadOnlyCollection<InControl.NativeInputDevice>,InControl.NativeInputDevice> CustomFindDetachedDevice
{
get => InControl.NativeInputDeviceManager.CustomFindDetachedDevice;
set => InControl.NativeInputDeviceManager.CustomFindDetachedDevice = value;
}

public System.Collections.Generic.List<InControl.NativeInputDevice> attachedDevices
{
get => GetField<System.Collections.Generic.List<InControl.NativeInputDevice>>();
set => SetField(value);
}

public System.Collections.Generic.List<InControl.NativeInputDevice> detachedDevices
{
get => GetField<System.Collections.Generic.List<InControl.NativeInputDevice>>();
set => SetField(value);
}

public System.Collections.Generic.List<InControl.InputDeviceProfile> systemDeviceProfiles
{
get => GetField<System.Collections.Generic.List<InControl.InputDeviceProfile>>();
set => SetField(value);
}

public System.Collections.Generic.List<InControl.InputDeviceProfile> customDeviceProfiles
{
get => GetField<System.Collections.Generic.List<InControl.InputDeviceProfile>>();
set => SetField(value);
}

public System.UInt32[] deviceEvents
{
get => GetField<System.UInt32[]>();
set => SetField(value);
}

public System.Collections.Generic.List<InControl.InputDevice> devices
{
get => GetField<System.Collections.Generic.List<InControl.InputDevice>>();
set => SetField(value);
}

public void Destroy () =>
orig.Destroy();

public void Update (System.UInt64 updateTick, float deltaTime) =>
orig.Update(updateTick, deltaTime);

public void DetectDevice (System.UInt32 deviceHandle, InControl.InputDeviceInfo deviceInfo) =>
CallMethod(new object[] {deviceHandle, deviceInfo});

public void AttachDevice (InControl.NativeInputDevice device) =>
CallMethod(new object[] {device});

public void DetachDevice (InControl.NativeInputDevice device) =>
CallMethod(new object[] {device});

public InControl.NativeInputDevice FindAttachedDevice (System.UInt32 deviceHandle) =>
CallMethod<InControl.NativeInputDevice>(new object[] {deviceHandle});

public InControl.NativeInputDevice FindDetachedDevice (InControl.InputDeviceInfo deviceInfo) =>
CallMethod<InControl.NativeInputDevice>(new object[] {deviceInfo});

public InControl.NativeInputDevice SystemFindDetachedDevice (InControl.InputDeviceInfo deviceInfo, System.Collections.ObjectModel.ReadOnlyCollection<InControl.NativeInputDevice> detachedDevices) =>
CallMethodStatic<InControl.NativeInputDevice>(new object[] {deviceInfo, detachedDevices});

public void AddSystemDeviceProfile (InControl.InputDeviceProfile deviceProfile) =>
CallMethod(new object[] {deviceProfile});

public void AddSystemDeviceProfiles () =>
CallMethod();

public bool CheckPlatformSupport (System.Collections.Generic.ICollection<System.String> errors) =>
InControl.NativeInputDeviceManager.CheckPlatformSupport(errors);

public bool Enable () =>
CallMethodStatic<bool>();

}
}
