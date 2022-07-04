namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of AudioSourcePitchRandomizer allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class AudioSourcePitchRandomizerR : InstanceClassWrapper<AudioSourcePitchRandomizer>
{
    public AudioSourcePitchRandomizerR(AudioSourcePitchRandomizer _orig) : base(_orig)
    {
    }

    public float pitchLower
    {
        get => orig.pitchLower;
        set => orig.pitchLower = value;
    }

    public float pitchUpper
    {
        get => orig.pitchUpper;
        set => orig.pitchUpper = value;
    }

    public AudioSource audioSource
    {
        get => GetField<AudioSource>();
        set => SetField(value);
    }


    public void Awake()
    {
        CallMethod();
    }
}