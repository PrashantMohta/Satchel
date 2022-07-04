namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of CinematicVideoReference allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class CinematicVideoReferenceR : InstanceClassWrapper<CinematicVideoReference>
{
    public CinematicVideoReferenceR(CinematicVideoReference _orig) : base(_orig)
    {
    }

    public string videoAssetPath
    {
        get => GetField<string>();
        set => SetField(value);
    }

    public string audioAssetPath
    {
        get => GetField<string>();
        set => SetField(value);
    }


    public string VideoFileName => orig.VideoFileName;

    public string VideoAssetPath => orig.VideoAssetPath;

    public string AudioAssetPath => orig.AudioAssetPath;

    public string name
    {
        get => orig.name;
        set => orig.name = value;
    }

    public HideFlags hideFlags
    {
        get => orig.hideFlags;
        set => orig.hideFlags = value;
    }
}