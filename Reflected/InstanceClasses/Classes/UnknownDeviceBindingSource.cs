using System.IO;
using InControl;

namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of UnknownDeviceBindingSource allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class UnknownDeviceBindingSourceR : InstanceClassWrapper<UnknownDeviceBindingSource>
{
    public UnknownDeviceBindingSourceR(UnknownDeviceBindingSource _orig) : base(_orig)
    {
    }

    public UnknownDeviceControl Control
    {
        get => orig.Control;
        set => SetProperty(value);
    }

    public string Name => orig.Name;

    public string DeviceName => orig.DeviceName;

    public InputDeviceClass DeviceClass => orig.DeviceClass;

    public InputDeviceStyle DeviceStyle => orig.DeviceStyle;

    public BindingSourceType BindingSourceType => orig.BindingSourceType;

    public bool IsValid => GetProperty<bool>();

    public PlayerAction BoundTo
    {
        get => GetProperty<PlayerAction>();
        set => SetProperty(value);
    }

    public float GetValue(InputDevice device)
    {
        return orig.GetValue(device);
    }

    public bool GetState(InputDevice device)
    {
        return orig.GetState(device);
    }

    public bool Equals(BindingSource other)
    {
        return orig.Equals(other);
    }

    public bool Equals(object other)
    {
        return orig.Equals(other);
    }

    public int GetHashCode()
    {
        return orig.GetHashCode();
    }

    public void Load(BinaryReader reader, ushort dataFormatVersion)
    {
        orig.Load(reader, dataFormatVersion);
    }

    public void Save(BinaryWriter writer)
    {
        orig.Save(writer);
    }
}