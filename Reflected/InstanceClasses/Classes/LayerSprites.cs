using tk2dRuntime.TileMap;

namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of LayerSprites allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class LayerSpritesR : InstanceClassWrapper<LayerSprites>
{
    public LayerSpritesR(LayerSprites _orig) : base(_orig)
    {
    }

    public int[] spriteIds
    {
        get => orig.spriteIds;
        set => orig.spriteIds = value;
    }
}