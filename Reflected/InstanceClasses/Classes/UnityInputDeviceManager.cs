namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of UnityInputDeviceManager allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class UnityInputDeviceManagerR:InstanceClassWrapper<InControl.UnityInputDeviceManager>
{
public UnityInputDeviceManagerR(InControl.UnityInputDeviceManager _orig) : base(_orig) {}
public float deviceRefreshInterval
{
get => GetFieldStatic<float>();
set => SetField(value);
}

public float deviceRefreshTimer
{
get => GetField<float>();
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

public System.String[] joystickNames
{
get => GetField<System.String[]>();
set => SetField(value);
}

public int lastJoystickCount
{
get => GetField<int>();
set => SetField(value);
}

public int lastJoystickHash
{
get => GetField<int>();
set => SetField(value);
}

public int joystickCount
{
get => GetField<int>();
set => SetField(value);
}

public int joystickHash
{
get => GetField<int>();
set => SetField(value);
}

public System.Collections.Generic.List<InControl.InputDevice> devices
{
get => GetField<System.Collections.Generic.List<InControl.InputDevice>>();
set => SetField(value);
}

public bool JoystickInfoHasChanged
{
get => GetProperty<bool>();
}

public void Update (System.UInt64 updateTick, float deltaTime) =>
orig.Update(updateTick, deltaTime);

public void QueryJoystickInfo () =>
CallMethod();

public void AttachDevices () =>
CallMethod();

public void DetachDevices () =>
CallMethod();

public void ReloadDevices () =>
orig.ReloadDevices();

public void AttachDevice (InControl.UnityInputDevice device) =>
CallMethod(new object[] {device});

public bool HasAttachedDeviceWithJoystickId (int unityJoystickId) =>
CallMethod<bool>(new object[] {unityJoystickId});

public void DetectJoystickDevice (int unityJoystickId, string unityJoystickName) =>
CallMethod(new object[] {unityJoystickId, unityJoystickName});

public InControl.InputDeviceProfile DetectDevice (string unityJoystickName) =>
CallMethod<InControl.InputDeviceProfile>(new object[] {unityJoystickName});

public void AddSystemDeviceProfile (InControl.InputDeviceProfile deviceProfile) =>
CallMethod(new object[] {deviceProfile});

public void AddSystemDeviceProfiles () =>
CallMethod();

}
}
