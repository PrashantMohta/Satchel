namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of OuyaEverywhereDeviceManager allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class OuyaEverywhereDeviceManagerR:InstanceClassWrapper<InControl.OuyaEverywhereDeviceManager>
{
public OuyaEverywhereDeviceManagerR(InControl.OuyaEverywhereDeviceManager _orig) : base(_orig) {}
public System.Boolean[] deviceConnected
{
get => GetField<System.Boolean[]>();
set => SetField(value);
}

public System.Collections.Generic.List<InControl.InputDevice> devices
{
get => GetField<System.Collections.Generic.List<InControl.InputDevice>>();
set => SetField(value);
}

public void Update (System.UInt64 updateTick, float deltaTime) =>
orig.Update(updateTick, deltaTime);

public void Enable () =>
InControl.OuyaEverywhereDeviceManager.Enable();

}
}
