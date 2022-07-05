namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of CinematicVideoPlayerConfig allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class CinematicVideoPlayerConfigR : InstanceClassWrapper<CinematicVideoPlayerConfig>
{
    public CinematicVideoPlayerConfigR(CinematicVideoPlayerConfig _orig) : base(_orig)
    {
    }

    public CinematicVideoReference videoReference
    {
        get => GetField<CinematicVideoReference>();
        set => SetField(value);
    }

    public MeshRenderer meshRenderer
    {
        get => GetField<MeshRenderer>();
        set => SetField(value);
    }

    public AudioSource audioSource
    {
        get => GetField<AudioSource>();
        set => SetField(value);
    }

    public CinematicVideoFaderStyles faderStyle
    {
        get => GetField<CinematicVideoFaderStyles>();
        set => SetField(value);
    }

    public float implicitVolume
    {
        get => GetField<float>();
        set => SetField(value);
    }

    public CinematicVideoReference VideoReference => orig.VideoReference;

    public MeshRenderer MeshRenderer => orig.MeshRenderer;

    public AudioSource AudioSource => orig.AudioSource;

    public CinematicVideoFaderStyles FaderStyle => orig.FaderStyle;

    public float ImplicitVolume => orig.ImplicitVolume;
}