using UnityEngine.Audio;

namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of MuteAudioChannel allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class MuteAudioChannelR : InstanceClassWrapper<MuteAudioChannel>
{
    public MuteAudioChannelR(MuteAudioChannel _orig) : base(_orig)
    {
    }

    public AudioMixer mixer
    {
        get => orig.mixer;
        set => orig.mixer = value;
    }

    public string exposedProperty
    {
        get => orig.exposedProperty;
        set => orig.exposedProperty = value;
    }

    public float initialVolume
    {
        get => GetField<float>();
        set => SetField(value);
    }

    public float Volume
    {
        get => orig.Volume;
        set => orig.Volume = value;
    }


    public void OnEnable()
    {
        CallMethod();
    }

    public void OnDisable()
    {
        CallMethod();
    }

    public float LinearToDecibel(float linear)
    {
        return CallMethod<float>(new object[] { linear });
    }

    public float DecibelToLinear(float dB)
    {
        return CallMethod<float>(new object[] { dB });
    }
}