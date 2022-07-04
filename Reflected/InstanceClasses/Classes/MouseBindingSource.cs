namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of MouseBindingSource allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class MouseBindingSourceR:InstanceClassWrapper<InControl.MouseBindingSource>
{
public MouseBindingSourceR(InControl.MouseBindingSource _orig) : base(_orig) {}
public float ScaleX
{
get => InControl.MouseBindingSource.ScaleX;
set => InControl.MouseBindingSource.ScaleX = value;
}

public float ScaleY
{
get => InControl.MouseBindingSource.ScaleY;
set => InControl.MouseBindingSource.ScaleY = value;
}

public float ScaleZ
{
get => InControl.MouseBindingSource.ScaleZ;
set => InControl.MouseBindingSource.ScaleZ = value;
}

public float JitterThreshold
{
get => InControl.MouseBindingSource.JitterThreshold;
set => InControl.MouseBindingSource.JitterThreshold = value;
}

public InControl.Mouse Control
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

public InControl.PlayerAction BoundTo
{
get => GetProperty<InControl.PlayerAction>();
set => SetProperty(value);
}

public bool IsValid
{
get => GetProperty<bool>();
}

public bool ButtonIsPressed (InControl.Mouse control) =>
CallMethodStatic<bool>(new object[] {control});

public bool NegativeScrollWheelIsActive (float threshold) =>
CallMethodStatic<bool>(new object[] {threshold});

public bool PositiveScrollWheelIsActive (float threshold) =>
CallMethodStatic<bool>(new object[] {threshold});

public float GetValue (InControl.Mouse mouseControl) =>
CallMethodStatic<float>(new object[] {mouseControl});

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
