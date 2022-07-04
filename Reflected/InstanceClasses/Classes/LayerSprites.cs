namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of LayerSprites allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class LayerSpritesR:InstanceClassWrapper<tk2dRuntime.TileMap.LayerSprites>
{
public LayerSpritesR(tk2dRuntime.TileMap.LayerSprites _orig) : base(_orig) {}
public System.Int32[] spriteIds
{
get => orig.spriteIds;
set => orig.spriteIds = value;
}

}
}
