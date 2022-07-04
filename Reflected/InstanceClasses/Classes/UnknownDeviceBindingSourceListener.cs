namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of UnknownDeviceBindingSourceListener allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class UnknownDeviceBindingSourceListenerR:InstanceClassWrapper<InControl.UnknownDeviceBindingSourceListener>
{
public UnknownDeviceBindingSourceListenerR(InControl.UnknownDeviceBindingSourceListener _orig) : base(_orig) {}
public InControl.UnknownDeviceControl detectFound
{
get => GetField<InControl.UnknownDeviceControl>();
set => SetField(value);
}

public void Reset () =>
orig.Reset();

public void TakeSnapshotOnUnknownDevices () =>
CallMethod();

public InControl.BindingSource Listen (InControl.BindingListenOptions listenOptions, InControl.InputDevice device) =>
orig.Listen(listenOptions, device);

public bool IsPressed (InControl.UnknownDeviceControl control, InControl.InputDevice device) =>
CallMethod<bool>(new object[] {control, device});

public InControl.UnknownDeviceControl ListenForControl (InControl.BindingListenOptions listenOptions, InControl.InputDevice device) =>
CallMethod<InControl.UnknownDeviceControl>(new object[] {listenOptions, device});

}
}
