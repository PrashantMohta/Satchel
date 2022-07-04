namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of AudioManager allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class AudioManagerR:InstanceClassWrapper<AudioManager>
{
public AudioManagerR(AudioManager _orig) : base(_orig) {}
public UnityEngine.AudioSource[] atmosSources
{
get => GetField<UnityEngine.AudioSource[]>();
set => SetField(value);
}

public AtmosCue currentAtmosCue
{
get => GetField<AtmosCue>();
set => SetField(value);
}

public System.Collections.IEnumerator applyAtmosCueRoutine
{
get => GetField<System.Collections.IEnumerator>();
set => SetField(value);
}

public AudioLoopMaster audioLoopMaster
{
get => GetField<AudioLoopMaster>();
set => SetField(value);
}

public UnityEngine.AudioSource[] musicSources
{
get => GetField<UnityEngine.AudioSource[]>();
set => SetField(value);
}

public MusicCue currentMusicCue
{
get => GetField<MusicCue>();
set => SetField(value);
}

public System.Collections.IEnumerator applyMusicCueRoutine
{
get => GetField<System.Collections.IEnumerator>();
set => SetField(value);
}

public System.Collections.IEnumerator applyMusicSnapshotRoutine
{
get => GetField<System.Collections.IEnumerator>();
set => SetField(value);
}

public MusicCue CurrentMusicCue
{
get => orig.CurrentMusicCue;
}



public void Start () =>
CallMethod();

public void ApplyAtmosCue (AtmosCue atmosCue, float transitionTime) =>
orig.ApplyAtmosCue(atmosCue, transitionTime);

public System.Collections.IEnumerator BeginApplyAtmosCue (AtmosCue atmosCue, float transitionTime) =>
CallMethod<System.Collections.IEnumerator>(new object[] {atmosCue, transitionTime});

public void ApplyMusicCue (MusicCue musicCue, float delayTime, float transitionTime, bool applySnapshot) =>
orig.ApplyMusicCue(musicCue, delayTime, transitionTime, applySnapshot);

public System.Collections.IEnumerator BeginApplyMusicCue (MusicCue musicCue, float delayTime, float transitionTime, bool applySnapshot) =>
CallMethod<System.Collections.IEnumerator>(new object[] {musicCue, delayTime, transitionTime, applySnapshot});

public void UpdateMusicSync (MusicChannels musicChannel, bool isSyncRequired) =>
CallMethod(new object[] {musicChannel, isSyncRequired});

public void ApplyMusicSnapshot (UnityEngine.Audio.AudioMixerSnapshot snapshot, float delayTime, float transitionTime) =>
orig.ApplyMusicSnapshot(snapshot, delayTime, transitionTime);

public System.Collections.IEnumerator BeginApplyMusicSnapshot (UnityEngine.Audio.AudioMixerSnapshot snapshot, float delayTime, float transitionTime) =>
CallMethod<System.Collections.IEnumerator>(new object[] {snapshot, delayTime, transitionTime});

}
}
