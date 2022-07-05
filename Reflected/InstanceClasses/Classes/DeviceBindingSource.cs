using System.IO;
using InControl;

namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of DeviceBindingSource allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class DeviceBindingSourceR : InstanceClassWrapper<DeviceBindingSource>
{
    public DeviceBindingSourceR(DeviceBindingSource _orig) : base(_orig)
    {
    }

    public InputControlType Control
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

    public float GetValue(InputDevice inputDevice)
    {
        return orig.GetValue(inputDevice);
    }

    public bool GetState(InputDevice inputDevice)
    {
        return orig.GetState(inputDevice);
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

    public void Save(BinaryWriter writer)
    {
        orig.Save(writer);
    }

    public void Load(BinaryReader reader, ushort dataFormatVersion)
    {
        orig.Load(reader, dataFormatVersion);
    }
}