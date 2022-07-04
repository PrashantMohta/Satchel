using InControl;

namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of DeviceBindingSourceListener allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class DeviceBindingSourceListenerR : InstanceClassWrapper<DeviceBindingSourceListener>
{
    public DeviceBindingSourceListenerR(DeviceBindingSourceListener _orig) : base(_orig)
    {
    }

    public InputControlType detectFound
    {
        get => GetField<InputControlType>();
        set => SetField(value);
    }

    public int detectPhase
    {
        get => GetField<int>();
        set => SetField(value);
    }

    public void Reset()
    {
        orig.Reset();
    }

    public BindingSource Listen(BindingListenOptions listenOptions, InputDevice device)
    {
        return orig.Listen(listenOptions, device);
    }

    public bool IsPressed(InputControl control)
    {
        return CallMethod<bool>(new object[] { control });
    }

    public bool IsPressed(InputControlType control, InputDevice device)
    {
        return CallMethod<bool>(new object[] { control, device });
    }

    public InputControlType ListenForControl(BindingListenOptions listenOptions, InputDevice device)
    {
        return CallMethod<InputControlType>(new object[] { listenOptions, device });
    }
}