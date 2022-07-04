namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of UnknownDeviceBindingSource allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class UnknownDeviceBindingSourceR:InstanceClassWrapper<InControl.UnknownDeviceBindingSource>
{
public UnknownDeviceBindingSourceR(InControl.UnknownDeviceBindingSource _orig) : base(_orig) {}
public InControl.UnknownDeviceControl Control
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

public float GetValue (InControl.InputDevice device) =>
orig.GetValue(device);

public bool GetState (InControl.InputDevice device) =>
orig.GetState(device);

public bool Equals (InControl.BindingSource other) =>
orig.Equals(other);

public bool Equals (System.Object other) =>
orig.Equals(other);

public int GetHashCode () =>
orig.GetHashCode();

public void Load (System.IO.BinaryReader reader, System.UInt16 dataFormatVersion) =>
orig.Load(reader, dataFormatVersion);

public void Save (System.IO.BinaryWriter writer) =>
orig.Save(writer);

}
}
