namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of MouseBindingSourceListener allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class MouseBindingSourceListenerR:InstanceClassWrapper<InControl.MouseBindingSourceListener>
{
public MouseBindingSourceListenerR(InControl.MouseBindingSourceListener _orig) : base(_orig) {}
public float ScrollWheelThreshold
{
get => InControl.MouseBindingSourceListener.ScrollWheelThreshold;
set => InControl.MouseBindingSourceListener.ScrollWheelThreshold = value;
}

public InControl.Mouse detectFound
{
get => GetField<InControl.Mouse>();
set => SetField(value);
}

public int detectPhase
{
get => GetField<int>();
set => SetField(value);
}

public void Reset () =>
orig.Reset();

public InControl.BindingSource Listen (InControl.BindingListenOptions listenOptions, InControl.InputDevice device) =>
orig.Listen(listenOptions, device);

public bool IsPressed (InControl.Mouse control) =>
CallMethod<bool>(new object[] {control});

public InControl.Mouse ListenForControl (InControl.BindingListenOptions listenOptions) =>
CallMethod<InControl.Mouse>(new object[] {listenOptions});

}
}
