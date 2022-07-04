using UnityEngine.Audio;

namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of AudioManager allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class AudioManagerR : InstanceClassWrapper<AudioManager>
{
    public AudioManagerR(AudioManager _orig) : base(_orig)
    {
    }

    public AudioSource[] atmosSources
    {
        get => GetField<AudioSource[]>();
        set => SetField(value);
    }

    public AtmosCue currentAtmosCue
    {
        get => GetField<AtmosCue>();
        set => SetField(value);
    }

    public IEnumerator applyAtmosCueRoutine
    {
        get => GetField<IEnumerator>();
        set => SetField(value);
    }

    public AudioLoopMaster audioLoopMaster
    {
        get => GetField<AudioLoopMaster>();
        set => SetField(value);
    }

    public AudioSource[] musicSources
    {
        get => GetField<AudioSource[]>();
        set => SetField(value);
    }

    public MusicCue currentMusicCue
    {
        get => GetField<MusicCue>();
        set => SetField(value);
    }

    public IEnumerator applyMusicCueRoutine
    {
        get => GetField<IEnumerator>();
        set => SetField(value);
    }

    public IEnumerator applyMusicSnapshotRoutine
    {
        get => GetField<IEnumerator>();
        set => SetField(value);
    }

    public MusicCue CurrentMusicCue => orig.CurrentMusicCue;


    public void Start()
    {
        CallMethod();
    }

    public void ApplyAtmosCue(AtmosCue atmosCue, float transitionTime)
    {
        orig.ApplyAtmosCue(atmosCue, transitionTime);
    }

    public IEnumerator BeginApplyAtmosCue(AtmosCue atmosCue, float transitionTime)
    {
        return CallMethod<IEnumerator>(new object[] { atmosCue, transitionTime });
    }

    public void ApplyMusicCue(MusicCue musicCue, float delayTime, float transitionTime, bool applySnapshot)
    {
        orig.ApplyMusicCue(musicCue, delayTime, transitionTime, applySnapshot);
    }

    public IEnumerator BeginApplyMusicCue(MusicCue musicCue, float delayTime, float transitionTime, bool applySnapshot)
    {
        return CallMethod<IEnumerator>(new object[] { musicCue, delayTime, transitionTime, applySnapshot });
    }

    public void UpdateMusicSync(MusicChannels musicChannel, bool isSyncRequired)
    {
        CallMethod(new object[] { musicChannel, isSyncRequired });
    }

    public void ApplyMusicSnapshot(AudioMixerSnapshot snapshot, float delayTime, float transitionTime)
    {
        orig.ApplyMusicSnapshot(snapshot, delayTime, transitionTime);
    }

    public IEnumerator BeginApplyMusicSnapshot(AudioMixerSnapshot snapshot, float delayTime, float transitionTime)
    {
        return CallMethod<IEnumerator>(new object[] { snapshot, delayTime, transitionTime });
    }
}