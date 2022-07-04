using tk2dRuntime.TileMap;

namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of ColorChunk allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class ColorChunkR : InstanceClassWrapper<ColorChunk>
{
    public ColorChunkR(ColorChunk _orig) : base(_orig)
    {
    }

    public Color32[] colors
    {
        get => orig.colors;
        set => orig.colors = value;
    }

    public bool Dirty
    {
        get => orig.Dirty;
        set => orig.Dirty = value;
    }

    public bool Empty => orig.Empty;
}