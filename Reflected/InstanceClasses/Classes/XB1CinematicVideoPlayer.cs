namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of XB1CinematicVideoPlayer allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class XB1CinematicVideoPlayerR:InstanceClassWrapper<XB1CinematicVideoPlayer>
{
public XB1CinematicVideoPlayerR(XB1CinematicVideoPlayer _orig) : base(_orig) {}

public UnityEngine.Texture originalMainTexture
{
get => GetField<UnityEngine.Texture>();
set => SetField(value);
}

public UnityEngine.RenderTexture renderTexture
{
get => GetField<UnityEngine.RenderTexture>();
set => SetField(value);
}

public string TexturePropertyName
{
get => GetFieldStatic<string>();
set => SetField(value);
}

public bool isPlayEnqueued
{
get => GetField<bool>();
set => SetField(value);
}

public float Volume
{
get => orig.Volume;
set => orig.Volume = value;
}

public bool IsLoading
{
get => orig.IsLoading;
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

public CinematicVideoPlayerConfig Config
{
get => GetProperty<CinematicVideoPlayerConfig>();
}

public float CurrentTime
{
get => orig.CurrentTime;
}

public void Dispose () =>
orig.Dispose();

public void Play () =>
orig.Play();

public void Stop () =>
orig.Stop();

}
}
