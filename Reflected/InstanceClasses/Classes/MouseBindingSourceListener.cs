using InControl;

namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of MouseBindingSourceListener allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class MouseBindingSourceListenerR : InstanceClassWrapper<MouseBindingSourceListener>
{
    public MouseBindingSourceListenerR(MouseBindingSourceListener _orig) : base(_orig)
    {
    }

    public float ScrollWheelThreshold
    {
        get => MouseBindingSourceListener.ScrollWheelThreshold;
        set => MouseBindingSourceListener.ScrollWheelThreshold = value;
    }

    public Mouse detectFound
    {
        get => GetField<Mouse>();
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

    public bool IsPressed(Mouse control)
    {
        return CallMethod<bool>(new object[] { control });
    }

    public Mouse ListenForControl(BindingListenOptions listenOptions)
    {
        return CallMethod<Mouse>(new object[] { listenOptions });
    }
}