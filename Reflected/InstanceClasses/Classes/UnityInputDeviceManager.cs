using InControl;

namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of UnityInputDeviceManager allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class UnityInputDeviceManagerR : InstanceClassWrapper<UnityInputDeviceManager>
{
    public UnityInputDeviceManagerR(UnityInputDeviceManager _orig) : base(_orig)
    {
    }

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

    public string[] joystickNames
    {
        get => GetField<string[]>();
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

    public List<InputDevice> devices
    {
        get => GetField<List<InputDevice>>();
        set => SetField(value);
    }

    public bool JoystickInfoHasChanged => GetProperty<bool>();

    public void Update(ulong updateTick, float deltaTime)
    {
        orig.Update(updateTick, deltaTime);
    }

    public void QueryJoystickInfo()
    {
        CallMethod();
    }

    public void AttachDevices()
    {
        CallMethod();
    }

    public void DetachDevices()
    {
        CallMethod();
    }

    public void ReloadDevices()
    {
        orig.ReloadDevices();
    }

    public void AttachDevice(UnityInputDevice device)
    {
        CallMethod(new object[] { device });
    }

    public bool HasAttachedDeviceWithJoystickId(int unityJoystickId)
    {
        return CallMethod<bool>(new object[] { unityJoystickId });
    }

    public void DetectJoystickDevice(int unityJoystickId, string unityJoystickName)
    {
        CallMethod(new object[] { unityJoystickId, unityJoystickName });
    }

    public InputDeviceProfile DetectDevice(string unityJoystickName)
    {
        return CallMethod<InputDeviceProfile>(new object[] { unityJoystickName });
    }

    public void AddSystemDeviceProfile(InputDeviceProfile deviceProfile)
    {
        CallMethod(new object[] { deviceProfile });
    }

    public void AddSystemDeviceProfiles()
    {
        CallMethod();
    }
}