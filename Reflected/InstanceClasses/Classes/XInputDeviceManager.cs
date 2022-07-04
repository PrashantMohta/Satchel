namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of XInputDeviceManager allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class XInputDeviceManagerR:InstanceClassWrapper<InControl.XInputDeviceManager>
{
public XInputDeviceManagerR(InControl.XInputDeviceManager _orig) : base(_orig) {}
public System.Boolean[] deviceConnected
{
get => GetField<System.Boolean[]>();
set => SetField(value);
}

public int maxDevices
{
get => GetFieldStatic<int>();
set => SetField(value);
}

public InControl.Internal.RingBuffer<XInputDotNetPure.GamePadState[]> gamePadState
{
get => GetField<InControl.Internal.RingBuffer<XInputDotNetPure.GamePadState[]>>();
set => SetField(value);
}

public System.Threading.Thread thread
{
get => GetField<System.Threading.Thread>();
set => SetField(value);
}

public int timeStep
{
get => GetField<int>();
set => SetField(value);
}

public int bufferSize
{
get => GetField<int>();
set => SetField(value);
}

public System.Collections.Generic.List<InControl.InputDevice> devices
{
get => GetField<System.Collections.Generic.List<InControl.InputDevice>>();
set => SetField(value);
}

public void StartWorker () =>
CallMethod();

public void StopWorker () =>
CallMethod();

public void Worker () =>
CallMethod();

public XInputDotNetPure.GamePadState GetState (int deviceIndex) =>
CallMethod<XInputDotNetPure.GamePadState>(new object[] {deviceIndex});

public void Update (System.UInt64 updateTick, float deltaTime) =>
orig.Update(updateTick, deltaTime);

public void Destroy () =>
orig.Destroy();

public bool CheckPlatformSupport (System.Collections.Generic.ICollection<System.String>errors) =>
InControl.XInputDeviceManager.CheckPlatformSupport(errors);

public void Enable () =>
CallMethodStatic();

}
}
