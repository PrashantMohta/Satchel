namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of tk2dSpriteSheetSource allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class tk2dSpriteSheetSourceR : InstanceClassWrapper<tk2dSpriteSheetSource>
{
    public tk2dSpriteSheetSourceR(tk2dSpriteSheetSource _orig) : base(_orig)
    {
    }

    public Texture2D texture
    {
        get => orig.texture;
        set => orig.texture = value;
    }

    public int tilesX
    {
        get => orig.tilesX;
        set => orig.tilesX = value;
    }

    public int tilesY
    {
        get => orig.tilesY;
        set => orig.tilesY = value;
    }

    public int numTiles
    {
        get => orig.numTiles;
        set => orig.numTiles = value;
    }

    public Vector3 scale
    {
        get => orig.scale;
        set => orig.scale = value;
    }

    public bool additive
    {
        get => orig.additive;
        set => orig.additive = value;
    }

    public bool active
    {
        get => orig.active;
        set => orig.active = value;
    }

    public int tileWidth
    {
        get => orig.tileWidth;
        set => orig.tileWidth = value;
    }

    public int tileHeight
    {
        get => orig.tileHeight;
        set => orig.tileHeight = value;
    }

    public int tileMarginX
    {
        get => orig.tileMarginX;
        set => orig.tileMarginX = value;
    }

    public int tileMarginY
    {
        get => orig.tileMarginY;
        set => orig.tileMarginY = value;
    }

    public int tileSpacingX
    {
        get => orig.tileSpacingX;
        set => orig.tileSpacingX = value;
    }

    public int tileSpacingY
    {
        get => orig.tileSpacingY;
        set => orig.tileSpacingY = value;
    }

    public int version
    {
        get => orig.version;
        set => orig.version = value;
    }

    public int CURRENT_VERSION
    {
        get => tk2dSpriteSheetSource.CURRENT_VERSION;
        set => SetField(value);
    }

    public string Name => orig.Name;

    public void CopyFrom(tk2dSpriteSheetSource src)
    {
        orig.CopyFrom(src);
    }

    public bool CompareTo(tk2dSpriteSheetSource src)
    {
        return orig.CompareTo(src);
    }
}