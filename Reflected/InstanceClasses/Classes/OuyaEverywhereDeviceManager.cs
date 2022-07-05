using InControl;

namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of OuyaEverywhereDeviceManager allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class OuyaEverywhereDeviceManagerR : InstanceClassWrapper<OuyaEverywhereDeviceManager>
{
    public OuyaEverywhereDeviceManagerR(OuyaEverywhereDeviceManager _orig) : base(_orig)
    {
    }

    public bool[] deviceConnected
    {
        get => GetField<bool[]>();
        set => SetField(value);
    }

    public List<InputDevice> devices
    {
        get => GetField<List<InputDevice>>();
        set => SetField(value);
    }

    public void Update(ulong updateTick, float deltaTime)
    {
        orig.Update(updateTick, deltaTime);
    }

    public void Enable()
    {
        OuyaEverywhereDeviceManager.Enable();
    }
}