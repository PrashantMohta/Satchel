namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of tk2dTextMeshData allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class tk2dTextMeshDataR : InstanceClassWrapper<tk2dTextMeshData>
{
    public tk2dTextMeshDataR(tk2dTextMeshData _orig) : base(_orig)
    {
    }

    public int version
    {
        get => orig.version;
        set => orig.version = value;
    }

    public tk2dFontData font
    {
        get => orig.font;
        set => orig.font = value;
    }

    public string text
    {
        get => orig.text;
        set => orig.text = value;
    }

    public Color color
    {
        get => orig.color;
        set => orig.color = value;
    }

    public Color color2
    {
        get => orig.color2;
        set => orig.color2 = value;
    }

    public bool useGradient
    {
        get => orig.useGradient;
        set => orig.useGradient = value;
    }

    public int textureGradient
    {
        get => orig.textureGradient;
        set => orig.textureGradient = value;
    }

    public TextAnchor anchor
    {
        get => orig.anchor;
        set => orig.anchor = value;
    }

    public int renderLayer
    {
        get => orig.renderLayer;
        set => orig.renderLayer = value;
    }

    public Vector3 scale
    {
        get => orig.scale;
        set => orig.scale = value;
    }

    public bool kerning
    {
        get => orig.kerning;
        set => orig.kerning = value;
    }

    public int maxChars
    {
        get => orig.maxChars;
        set => orig.maxChars = value;
    }

    public bool inlineStyling
    {
        get => orig.inlineStyling;
        set => orig.inlineStyling = value;
    }

    public bool formatting
    {
        get => orig.formatting;
        set => orig.formatting = value;
    }

    public int wordWrapWidth
    {
        get => orig.wordWrapWidth;
        set => orig.wordWrapWidth = value;
    }

    public float spacing
    {
        get => orig.spacing;
        set => orig.spacing = value;
    }

    public float lineSpacing
    {
        get => orig.lineSpacing;
        set => orig.lineSpacing = value;
    }
}