using System.IO;
using InControl;

namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of KeyBindingSource allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class KeyBindingSourceR : InstanceClassWrapper<KeyBindingSource>
{
    public KeyBindingSourceR(KeyBindingSource _orig) : base(_orig)
    {
    }

    public KeyCombo Control
    {
        get => orig.Control;
        set => SetProperty(value);
    }

    public string Name => orig.Name;

    public string DeviceName => orig.DeviceName;

    public InputDeviceClass DeviceClass => orig.DeviceClass;

    public InputDeviceStyle DeviceStyle => orig.DeviceStyle;

    public BindingSourceType BindingSourceType => orig.BindingSourceType;

    public PlayerAction BoundTo
    {
        get => GetProperty<PlayerAction>();
        set => SetProperty(value);
    }

    public bool IsValid => GetProperty<bool>();

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

    public void Load(BinaryReader reader, ushort dataFormatVersion)
    {
        orig.Load(reader, dataFormatVersion);
    }

    public void Save(BinaryWriter writer)
    {
        orig.Save(writer);
    }
}