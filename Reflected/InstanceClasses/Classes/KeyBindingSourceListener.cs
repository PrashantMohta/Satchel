namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of KeyBindingSourceListener allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class KeyBindingSourceListenerR:InstanceClassWrapper<InControl.KeyBindingSourceListener>
{
public KeyBindingSourceListenerR(InControl.KeyBindingSourceListener _orig) : base(_orig) {}
public InControl.KeyCombo detectFound
{
get => GetField<InControl.KeyCombo>();
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

}
}
