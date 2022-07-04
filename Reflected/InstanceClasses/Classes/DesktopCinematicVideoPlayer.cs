namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of DesktopCinematicVideoPlayer allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class DesktopCinematicVideoPlayerR:InstanceClassWrapper<DesktopCinematicVideoPlayer>
{
public DesktopCinematicVideoPlayerR(DesktopCinematicVideoPlayer _orig) : base(_orig) {}
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

public string GetAbsolutePath () =>
CallMethod<string>();

}
}
