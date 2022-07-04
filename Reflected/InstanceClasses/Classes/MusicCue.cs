namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of MusicCue allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class MusicCueR:InstanceClassWrapper<MusicCue>
{
public MusicCueR(MusicCue _orig) : base(_orig) {}
public string originalMusicEventName
{
get => GetField<string>();
set => SetField(value);
}

public int originalMusicTrackNumber
{
get => GetField<int>();
set => SetField(value);
}

public UnityEngine.Audio.AudioMixerSnapshot snapshot
{
get => GetField<UnityEngine.Audio.AudioMixerSnapshot>();
set => SetField(value);
}

public MusicCue.MusicChannelInfo[] channelInfos
{
get => GetField<MusicCue.MusicChannelInfo[]>();
set => SetField(value);
}

public MusicCue.Alternative[] alternatives
{
get => GetField<MusicCue.Alternative[]>();
set => SetField(value);
}

public string OriginalMusicEventName
{
get => orig.OriginalMusicEventName;
}

public int OriginalMusicTrackNumber
{
get => orig.OriginalMusicTrackNumber;
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

public MusicCue ResolveAlternatives (PlayerData playerData) =>
orig.ResolveAlternatives(playerData);

}
}
