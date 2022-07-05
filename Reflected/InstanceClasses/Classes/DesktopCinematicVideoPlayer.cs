namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of DesktopCinematicVideoPlayer allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class DesktopCinematicVideoPlayerR : InstanceClassWrapper<DesktopCinematicVideoPlayer>
{
    public DesktopCinematicVideoPlayerR(DesktopCinematicVideoPlayer _orig) : base(_orig)
    {
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

    public string GetAbsolutePath()
    {
        return CallMethod<string>();
    }
}