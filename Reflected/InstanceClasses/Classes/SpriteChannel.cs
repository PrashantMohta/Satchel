namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of SpriteChannel allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class SpriteChannelR:InstanceClassWrapper<tk2dRuntime.TileMap.SpriteChannel>
{
public SpriteChannelR(tk2dRuntime.TileMap.SpriteChannel _orig) : base(_orig) {}
public tk2dRuntime.TileMap.SpriteChunk[] chunks
{
get => orig.chunks;
set => orig.chunks = value;
}

}
}
