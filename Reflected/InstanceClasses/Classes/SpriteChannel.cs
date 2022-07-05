using tk2dRuntime.TileMap;

namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of SpriteChannel allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class SpriteChannelR : InstanceClassWrapper<SpriteChannel>
{
    public SpriteChannelR(SpriteChannel _orig) : base(_orig)
    {
    }

    public SpriteChunk[] chunks
    {
        get => orig.chunks;
        set => orig.chunks = value;
    }
}