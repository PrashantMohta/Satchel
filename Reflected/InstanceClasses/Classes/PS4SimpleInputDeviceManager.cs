using InControl;

namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of PS4SimpleInputDeviceManager allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class PS4SimpleInputDeviceManagerR : InstanceClassWrapper<PS4SimpleInputDeviceManager>
{
    public PS4SimpleInputDeviceManagerR(PS4SimpleInputDeviceManager _orig) : base(_orig)
    {
    }

    public PS4SimpleInputDevice device
    {
        get => GetField<PS4SimpleInputDevice>();
        set => SetField(value);
    }

    public bool isDeviceAttached
    {
        get => GetField<bool>();
        set => SetField(value);
    }

    public List<InputDevice> devices
    {
        get => GetField<List<InputDevice>>();
        set => SetField(value);
    }

    public PS4SimpleInputDevice Device => orig.Device;

    public void Update(ulong updateTick, float deltaTime)
    {
        orig.Update(updateTick, deltaTime);
    }

    public bool CheckPlatformSupport(ICollection<string> errors)
    {
        return PS4SimpleInputDeviceManager.CheckPlatformSupport(errors);
    }

    public bool Enable()
    {
        return CallMethodStatic<bool>();
    }
}