using InControl;

namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of SwitchSimpleInputDeviceManager allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class SwitchSimpleInputDeviceManagerR : InstanceClassWrapper<SwitchSimpleInputDeviceManager>
{
    public SwitchSimpleInputDeviceManagerR(SwitchSimpleInputDeviceManager _orig) : base(_orig)
    {
    }

    public SwitchSimpleInputDevice device
    {
        get => GetField<SwitchSimpleInputDevice>();
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

    public SwitchSimpleInputDevice Device => orig.Device;

    public void Update(ulong updateTick, float deltaTime)
    {
        orig.Update(updateTick, deltaTime);
    }

    public bool CheckPlatformSupport(ICollection<string> errors)
    {
        return SwitchSimpleInputDeviceManager.CheckPlatformSupport(errors);
    }

    public bool Enable()
    {
        return CallMethodStatic<bool>();
    }
}