using TMPro;

namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of TMP_Glyph allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class TMP_GlyphR : InstanceClassWrapper<TMP_Glyph>
{
    public TMP_GlyphR(TMP_Glyph _orig) : base(_orig)
    {
    }

    public int id
    {
        get => orig.id;
        set => orig.id = value;
    }

    public float x
    {
        get => orig.x;
        set => orig.x = value;
    }

    public float y
    {
        get => orig.y;
        set => orig.y = value;
    }

    public float width
    {
        get => orig.width;
        set => orig.width = value;
    }

    public float height
    {
        get => orig.height;
        set => orig.height = value;
    }

    public float xOffset
    {
        get => orig.xOffset;
        set => orig.xOffset = value;
    }

    public float yOffset
    {
        get => orig.yOffset;
        set => orig.yOffset = value;
    }

    public float xAdvance
    {
        get => orig.xAdvance;
        set => orig.xAdvance = value;
    }

    public float scale
    {
        get => orig.scale;
        set => orig.scale = value;
    }

    public TMP_Glyph Clone(TMP_Glyph source)
    {
        return TMP_Glyph.Clone(source);
    }
}