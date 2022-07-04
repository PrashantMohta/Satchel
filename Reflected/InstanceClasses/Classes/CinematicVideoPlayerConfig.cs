namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of CinematicVideoPlayerConfig allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class CinematicVideoPlayerConfigR:InstanceClassWrapper<CinematicVideoPlayerConfig>
{
public CinematicVideoPlayerConfigR(CinematicVideoPlayerConfig _orig) : base(_orig) {}
public CinematicVideoReference videoReference
{
get => GetField<CinematicVideoReference>();
set => SetField(value);
}

public UnityEngine.MeshRenderer meshRenderer
{
get => GetField<UnityEngine.MeshRenderer>();
set => SetField(value);
}

public UnityEngine.AudioSource audioSource
{
get => GetField<UnityEngine.AudioSource>();
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

public CinematicVideoReference VideoReference
{
get => orig.VideoReference;
}

public UnityEngine.MeshRenderer MeshRenderer
{
get => orig.MeshRenderer;
}

public UnityEngine.AudioSource AudioSource
{
get => orig.AudioSource;
}

public CinematicVideoFaderStyles FaderStyle
{
get => orig.FaderStyle;
}

public float ImplicitVolume
{
get => orig.ImplicitVolume;
}

}
}
