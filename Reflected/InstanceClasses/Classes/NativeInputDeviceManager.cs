using System.Collections.ObjectModel;
using InControl;

namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of NativeInputDeviceManager allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class NativeInputDeviceManagerR : InstanceClassWrapper<NativeInputDeviceManager>
{
    public NativeInputDeviceManagerR(NativeInputDeviceManager _orig) : base(_orig)
    {
    }

    public Func<InputDeviceInfo, ReadOnlyCollection<NativeInputDevice>, NativeInputDevice> CustomFindDetachedDevice
    {
        get => NativeInputDeviceManager.CustomFindDetachedDevice;
        set => NativeInputDeviceManager.CustomFindDetachedDevice = value;
    }

    public List<NativeInputDevice> attachedDevices
    {
        get => GetField<List<NativeInputDevice>>();
        set => SetField(value);
    }

    public List<NativeInputDevice> detachedDevices
    {
        get => GetField<List<NativeInputDevice>>();
        set => SetField(value);
    }

    public List<InputDeviceProfile> systemDeviceProfiles
    {
        get => GetField<List<InputDeviceProfile>>();
        set => SetField(value);
    }

    public List<InputDeviceProfile> customDeviceProfiles
    {
        get => GetField<List<InputDeviceProfile>>();
        set => SetField(value);
    }

    public uint[] deviceEvents
    {
        get => GetField<uint[]>();
        set => SetField(value);
    }

    public List<InputDevice> devices
    {
        get => GetField<List<InputDevice>>();
        set => SetField(value);
    }

    public void Destroy()
    {
        orig.Destroy();
    }

    public void Update(ulong updateTick, float deltaTime)
    {
        orig.Update(updateTick, deltaTime);
    }

    public void DetectDevice(uint deviceHandle, InputDeviceInfo deviceInfo)
    {
        CallMethod(new object[] { deviceHandle, deviceInfo });
    }

    public void AttachDevice(NativeInputDevice device)
    {
        CallMethod(new object[] { device });
    }

    public void DetachDevice(NativeInputDevice device)
    {
        CallMethod(new object[] { device });
    }

    public NativeInputDevice FindAttachedDevice(uint deviceHandle)
    {
        return CallMethod<NativeInputDevice>(new object[] { deviceHandle });
    }

    public NativeInputDevice FindDetachedDevice(InputDeviceInfo deviceInfo)
    {
        return CallMethod<NativeInputDevice>(new object[] { deviceInfo });
    }

    public NativeInputDevice SystemFindDetachedDevice(InputDeviceInfo deviceInfo,
        ReadOnlyCollection<NativeInputDevice> detachedDevices)
    {
        return CallMethodStatic<NativeInputDevice>(new object[] { deviceInfo, detachedDevices });
    }

    public void AddSystemDeviceProfile(InputDeviceProfile deviceProfile)
    {
        CallMethod(new object[] { deviceProfile });
    }

    public void AddSystemDeviceProfiles()
    {
        CallMethod();
    }

    public bool CheckPlatformSupport(ICollection<string> errors)
    {
        return NativeInputDeviceManager.CheckPlatformSupport(errors);
    }

    public bool Enable()
    {
        return CallMethodStatic<bool>();
    }
}