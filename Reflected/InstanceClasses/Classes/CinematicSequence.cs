namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of CinematicSequence allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class CinematicSequenceR:InstanceClassWrapper<CinematicSequence>
{
public CinematicSequenceR(CinematicSequence _orig) : base(_orig) {}
public UnityEngine.AudioSource audioSource
{
get => GetField<UnityEngine.AudioSource>();
set => SetField(value);
}

public UnityEngine.Audio.AudioMixerSnapshot atmosSnapshot
{
get => GetField<UnityEngine.Audio.AudioMixerSnapshot>();
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

public UnityEngine.MeshRenderer targetRenderer
{
get => GetField<UnityEngine.MeshRenderer>();
set => SetField(value);
}

public UnityEngine.MeshRenderer blankerRenderer
{
get => GetField<UnityEngine.MeshRenderer>();
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

public CinematicVideoPlayer VideoPlayer
{
get => orig.VideoPlayer;
}

public bool IsSkipped
{
get => orig.IsSkipped;
}

public bool IsLooping
{
get => orig.IsLooping;
set => orig.IsLooping = value;
}

public bool IsPlaying
{
get => orig.IsPlaying;
}

public float FadeByController
{
get => orig.FadeByController;
set => orig.FadeByController = value;
}



public void Awake () =>
CallMethod();

public void OnDestroy () =>
CallMethod();

public void Update () =>
CallMethod();

public void Begin () =>
orig.Begin();

public void UpdateBlanker (float alpha) =>
CallMethod(new object[] {alpha});

public void Skip () =>
orig.Skip();

}
}
