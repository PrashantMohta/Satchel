namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of VibrationPlayer allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class VibrationPlayerR : InstanceClassWrapper<VibrationPlayer>
{
    public VibrationPlayerR(VibrationPlayer _orig) : base(_orig)
    {
    }

    public VibrationData data
    {
        get => GetField<VibrationData>();
        set => SetField(value);
    }

    public VibrationTarget target
    {
        get => GetField<VibrationTarget>();
        set => SetField(value);
    }

    public bool playAutomatically
    {
        get => GetField<bool>();
        set => SetField(value);
    }

    public bool isLooping
    {
        get => GetField<bool>();
        set => SetField(value);
    }

    public string vibrationTag
    {
        get => GetField<string>();
        set => SetField(value);
    }

    public VibrationEmission emission
    {
        get => GetField<VibrationEmission>();
        set => SetField(value);
    }

    public VibrationData VibrationData
    {
        get => orig.VibrationData;
        set => orig.VibrationData = value;
    }

    public VibrationTarget Target
    {
        get => orig.Target;
        set => orig.Target = value;
    }

    public bool PlayAutomatically
    {
        get => orig.PlayAutomatically;
        set => orig.PlayAutomatically = value;
    }

    public bool IsLooping
    {
        get => orig.IsLooping;
        set => orig.IsLooping = value;
    }

    public string VibrationTag
    {
        get => orig.VibrationTag;
        set => orig.VibrationTag = value;
    }


    public void OnEnable()
    {
        CallMethod();
    }

    public void OnDisable()
    {
        CallMethod();
    }

    public void Play()
    {
        orig.Play();
    }

    public void Stop()
    {
        orig.Stop();
    }
}