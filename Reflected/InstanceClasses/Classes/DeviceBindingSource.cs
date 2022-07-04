namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of DeviceBindingSource allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class DeviceBindingSourceR:InstanceClassWrapper<InControl.DeviceBindingSource>
{
public DeviceBindingSourceR(InControl.DeviceBindingSource _orig) : base(_orig) {}
public InControl.InputControlType Control
{
get => orig.Control;
set => SetProperty(value);
}

public string Name
{
get => orig.Name;
}

public string DeviceName
{
get => orig.DeviceName;
}

public InControl.InputDeviceClass DeviceClass
{
get => orig.DeviceClass;
}

public InControl.InputDeviceStyle DeviceStyle
{
get => orig.DeviceStyle;
}

public InControl.BindingSourceType BindingSourceType
{
get => orig.BindingSourceType;
}

public bool IsValid
{
get => GetProperty<bool>();
}

public InControl.PlayerAction BoundTo
{
get => GetProperty<InControl.PlayerAction>();
set => SetProperty(value);
}

public float GetValue (InControl.InputDevice inputDevice) =>
orig.GetValue(inputDevice);

public bool GetState (InControl.InputDevice inputDevice) =>
orig.GetState(inputDevice);

public bool Equals (InControl.BindingSource other) =>
orig.Equals(other);

public bool Equals (System.Object other) =>
orig.Equals(other);

public int GetHashCode () =>
orig.GetHashCode();

public void Save (System.IO.BinaryWriter writer) =>
orig.Save(writer);

public void Load (System.IO.BinaryReader reader, System.UInt16 dataFormatVersion) =>
orig.Load(reader, dataFormatVersion);

}
}
