using InControl;

namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of PlatformVibrationHelper allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class PlatformVibrationHelperR : InstanceClassWrapper<PlatformVibrationHelper>
{
    public PlatformVibrationHelperR(PlatformVibrationHelper _orig) : base(_orig)
    {
    }

    public GamepadVibrationMixer vibrationMixer
    {
        get => GetField<GamepadVibrationMixer>();
        set => SetField(value);
    }

    public InputDevice lastVibratingInputDevice
    {
        get => GetField<InputDevice>();
        set => SetField(value);
    }

    public bool lastVibrationWasEmpty
    {
        get => GetField<bool>();
        set => SetField(value);
    }

    public void Destroy()
    {
        orig.Destroy();
    }

    public void UpdateVibration()
    {
        orig.UpdateVibration();
    }

    public VibrationMixer GetMixer()
    {
        return orig.GetMixer();
    }
}