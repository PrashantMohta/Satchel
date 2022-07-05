using InControl;

namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of KeyBindingSourceListener allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class KeyBindingSourceListenerR : InstanceClassWrapper<KeyBindingSourceListener>
{
    public KeyBindingSourceListenerR(KeyBindingSourceListener _orig) : base(_orig)
    {
    }

    public KeyCombo detectFound
    {
        get => GetField<KeyCombo>();
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
}