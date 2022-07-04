using System.Threading;
using InControl;
using InControl.Internal;
using XInputDotNetPure;

namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of XInputDeviceManager allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class XInputDeviceManagerR : InstanceClassWrapper<XInputDeviceManager>
{
    public XInputDeviceManagerR(XInputDeviceManager _orig) : base(_orig)
    {
    }

    public bool[] deviceConnected
    {
        get => GetField<bool[]>();
        set => SetField(value);
    }

    public int maxDevices
    {
        get => GetFieldStatic<int>();
        set => SetField(value);
    }

    public RingBuffer<GamePadState[]> gamePadState
    {
        get => GetField<RingBuffer<GamePadState[]>>();
        set => SetField(value);
    }

    public Thread thread
    {
        get => GetField<Thread>();
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

    public List<InputDevice> devices
    {
        get => GetField<List<InputDevice>>();
        set => SetField(value);
    }

    public void StartWorker()
    {
        CallMethod();
    }

    public void StopWorker()
    {
        CallMethod();
    }

    public void Worker()
    {
        CallMethod();
    }

    public GamePadState GetState(int deviceIndex)
    {
        return CallMethod<GamePadState>(new object[] { deviceIndex });
    }

    public void Update(ulong updateTick, float deltaTime)
    {
        orig.Update(updateTick, deltaTime);
    }

    public void Destroy()
    {
        orig.Destroy();
    }

    public bool CheckPlatformSupport(ICollection<string> errors)
    {
        return XInputDeviceManager.CheckPlatformSupport(errors);
    }

    public void Enable()
    {
        CallMethodStatic();
    }
}