namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of AtmosCue allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class AtmosCueR:InstanceClassWrapper<AtmosCue>
{
public AtmosCueR(AtmosCue _orig) : base(_orig) {}
public UnityEngine.Audio.AudioMixerSnapshot snapshot
{
get => GetField<UnityEngine.Audio.AudioMixerSnapshot>();
set => SetField(value);
}

public System.Boolean[] isChannelEnabled
{
get => GetField<System.Boolean[]>();
set => SetField(value);
}

public UnityEngine.Audio.AudioMixerSnapshot Snapshot
{
get => orig.Snapshot;
}

public string name
{
get => orig.name;
set => orig.name = value;
}

public UnityEngine.HideFlags hideFlags
{
get => orig.hideFlags;
set => orig.hideFlags = value;
}

public bool IsChannelEnabled (AtmosChannels channel) =>
orig.IsChannelEnabled(channel);

}
}
