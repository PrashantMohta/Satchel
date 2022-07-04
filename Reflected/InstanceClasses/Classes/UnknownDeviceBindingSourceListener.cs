using InControl;

namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of UnknownDeviceBindingSourceListener allowing
///     you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class UnknownDeviceBindingSourceListenerR : InstanceClassWrapper<UnknownDeviceBindingSourceListener>
{
    public UnknownDeviceBindingSourceListenerR(UnknownDeviceBindingSourceListener _orig) : base(_orig)
    {
    }

    public UnknownDeviceControl detectFound
    {
        get => GetField<UnknownDeviceControl>();
        set => SetField(value);
    }

    public void Reset()
    {
        orig.Reset();
    }

    public void TakeSnapshotOnUnknownDevices()
    {
        CallMethod();
    }

    public BindingSource Listen(BindingListenOptions listenOptions, InputDevice device)
    {
        return orig.Listen(listenOptions, device);
    }

    public bool IsPressed(UnknownDeviceControl control, InputDevice device)
    {
        return CallMethod<bool>(new object[] { control, device });
    }

    public UnknownDeviceControl ListenForControl(BindingListenOptions listenOptions, InputDevice device)
    {
        return CallMethod<UnknownDeviceControl>(new object[] { listenOptions, device });
    }
}