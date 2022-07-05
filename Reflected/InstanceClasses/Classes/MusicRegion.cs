using UnityEngine.Audio;

namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of MusicRegion allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class MusicRegionR : InstanceClassWrapper<MusicRegion>
{
    public MusicRegionR(MusicRegion _orig) : base(_orig)
    {
    }

    public bool dirtmouth
    {
        get => orig.dirtmouth;
        set => orig.dirtmouth = value;
    }

    public bool minesDelay
    {
        get => orig.minesDelay;
        set => orig.minesDelay = value;
    }

    public MusicCue enterMusicCue
    {
        get => orig.enterMusicCue;
        set => orig.enterMusicCue = value;
    }

    public AudioMixerSnapshot enterMusicSnapshot
    {
        get => orig.enterMusicSnapshot;
        set => orig.enterMusicSnapshot = value;
    }

    public string enterTrackEvent
    {
        get => orig.enterTrackEvent;
        set => orig.enterTrackEvent = value;
    }

    public float enterTransitionTime
    {
        get => orig.enterTransitionTime;
        set => orig.enterTransitionTime = value;
    }

    public MusicCue exitMusicCue
    {
        get => orig.exitMusicCue;
        set => orig.exitMusicCue = value;
    }

    public AudioMixerSnapshot exitMusicSnapshot
    {
        get => orig.exitMusicSnapshot;
        set => orig.exitMusicSnapshot = value;
    }

    public string exitTrackEvent
    {
        get => orig.exitTrackEvent;
        set => orig.exitTrackEvent = value;
    }

    public float exitTransitionTime
    {
        get => orig.exitTransitionTime;
        set => orig.exitTransitionTime = value;
    }

    public Coroutine fadeInRoutine
    {
        get => GetField<Coroutine>();
        set => SetField(value);
    }


    public void Reset()
    {
        CallMethod();
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        CallMethod(new object[] { collision });
    }

    public void OnTriggerExit2D(Collider2D collision)
    {
        CallMethod(new object[] { collision });
    }

    public IEnumerator FadeIn()
    {
        return CallMethod<IEnumerator>();
    }

    public void FadeOut()
    {
        CallMethod();
    }
}