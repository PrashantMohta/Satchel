using TeamCherry;

namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of MapAreas allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class MapAreasR : InstanceClassWrapper<MapAreas>
{
    public MapAreasR(MapAreas _orig) : base(_orig)
    {
    }

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