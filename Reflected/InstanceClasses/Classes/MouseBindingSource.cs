using System.IO;
using InControl;

namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of MouseBindingSource allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class MouseBindingSourceR : InstanceClassWrapper<MouseBindingSource>
{
    public MouseBindingSourceR(MouseBindingSource _orig) : base(_orig)
    {
    }

    public float ScaleX
    {
        get => MouseBindingSource.ScaleX;
        set => MouseBindingSource.ScaleX = value;
    }

    public float ScaleY
    {
        get => MouseBindingSource.ScaleY;
        set => MouseBindingSource.ScaleY = value;
    }

    public float ScaleZ
    {
        get => MouseBindingSource.ScaleZ;
        set => MouseBindingSource.ScaleZ = value;
    }

    public float JitterThreshold
    {
        get => MouseBindingSource.JitterThreshold;
        set => MouseBindingSource.JitterThreshold = value;
    }

    public Mouse Control
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

    public bool ButtonIsPressed(Mouse control)
    {
        return CallMethodStatic<bool>(new object[] { control });
    }

    public bool NegativeScrollWheelIsActive(float threshold)
    {
        return CallMethodStatic<bool>(new object[] { threshold });
    }

    public bool PositiveScrollWheelIsActive(float threshold)
    {
        return CallMethodStatic<bool>(new object[] { threshold });
    }

    public float GetValue(Mouse mouseControl)
    {
        return CallMethodStatic<float>(new object[] { mouseControl });
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