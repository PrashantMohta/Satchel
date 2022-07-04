using UnityEngine.Audio;

namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of CinematicSequence allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class CinematicSequenceR : InstanceClassWrapper<CinematicSequence>
{
    public CinematicSequenceR(CinematicSequence _orig) : base(_orig)
    {
    }

    public AudioSource audioSource
    {
        get => GetField<AudioSource>();
        set => SetField(value);
    }

    public AudioMixerSnapshot atmosSnapshot
    {
        get => GetField<AudioMixerSnapshot>();
        set => SetField(value);
    }

    public float atmosSnapshotTransitionDuration
    {
        get => GetField<float>();
        set => SetField(value);
    }

    public CinematicVideoReference videoReference
    {
        get => GetField<CinematicVideoReference>();
        set => SetField(value);
    }

    public bool isLooping
    {
        get => GetField<bool>();
        set => SetField(value);
    }

    public MeshRenderer targetRenderer
    {
        get => GetField<MeshRenderer>();
        set => SetField(value);
    }

    public MeshRenderer blankerRenderer
    {
        get => GetField<MeshRenderer>();
        set => SetField(value);
    }

    public CinematicVideoPlayer videoPlayer
    {
        get => GetField<CinematicVideoPlayer>();
        set => SetField(value);
    }

    public bool didPlay
    {
        get => GetField<bool>();
        set => SetField(value);
    }

    public bool isSkipped
    {
        get => GetField<bool>();
        set => SetField(value);
    }

    public int framesSinceBegan
    {
        get => GetField<int>();
        set => SetField(value);
    }

    public float fadeByController
    {
        get => GetField<float>();
        set => SetField(value);
    }

    public CinematicVideoPlayer VideoPlayer => orig.VideoPlayer;

    public bool IsSkipped => orig.IsSkipped;

    public bool IsLooping
    {
        get => orig.IsLooping;
        set => orig.IsLooping = value;
    }

    public bool IsPlaying => orig.IsPlaying;

    public float FadeByController
    {
        get => orig.FadeByController;
        set => orig.FadeByController = value;
    }


    public void Awake()
    {
        CallMethod();
    }

    public void OnDestroy()
    {
        CallMethod();
    }

    public void Update()
    {
        CallMethod();
    }

    public void Begin()
    {
        orig.Begin();
    }

    public void UpdateBlanker(float alpha)
    {
        CallMethod(new object[] { alpha });
    }

    public void Skip()
    {
        orig.Skip();
    }
}