using UnityEngine.Audio;

namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of AtmosCue allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class AtmosCueR : InstanceClassWrapper<AtmosCue>
{
    public AtmosCueR(AtmosCue _orig) : base(_orig)
    {
    }

    public AudioMixerSnapshot snapshot
    {
        get => GetField<AudioMixerSnapshot>();
        set => SetField(value);
    }

    public bool[] isChannelEnabled
    {
        get => GetField<bool[]>();
        set => SetField(value);
    }

    public AudioMixerSnapshot Snapshot => orig.Snapshot;

    public string name
    {
        get => orig.name;
        set => orig.name = value;
    }

    public HideFlags hideFlags
    {
        get => orig.hideFlags;
        set => orig.hideFlags = value;
    }

    public bool IsChannelEnabled(AtmosChannels channel)
    {
        return orig.IsChannelEnabled(channel);
    }
}