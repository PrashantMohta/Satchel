namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of XB1CinematicVideoPlayer allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class XB1CinematicVideoPlayerR : InstanceClassWrapper<XB1CinematicVideoPlayer>
{
    public XB1CinematicVideoPlayerR(XB1CinematicVideoPlayer _orig) : base(_orig)
    {
    }

    public Texture originalMainTexture
    {
        get => GetField<Texture>();
        set => SetField(value);
    }

    public RenderTexture renderTexture
    {
        get => GetField<RenderTexture>();
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

    public bool IsLoading => orig.IsLoading;

    public bool IsLooping
    {
        get => orig.IsLooping;
        set => orig.IsLooping = value;
    }

    public bool IsPlaying => orig.IsPlaying;

    public CinematicVideoPlayerConfig Config => GetProperty<CinematicVideoPlayerConfig>();

    public float CurrentTime => orig.CurrentTime;

    public void Dispose()
    {
        orig.Dispose();
    }

    public void Play()
    {
        orig.Play();
    }

    public void Stop()
    {
        orig.Stop();
    }
}