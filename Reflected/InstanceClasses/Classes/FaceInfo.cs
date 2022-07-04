using TMPro;

namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of FaceInfo allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class FaceInfoR : InstanceClassWrapper<FaceInfo>
{
    public FaceInfoR(FaceInfo _orig) : base(_orig)
    {
    }

    public string Name
    {
        get => orig.Name;
        set => orig.Name = value;
    }

    public float PointSize
    {
        get => orig.PointSize;
        set => orig.PointSize = value;
    }

    public float Scale
    {
        get => orig.Scale;
        set => orig.Scale = value;
    }

    public int CharacterCount
    {
        get => orig.CharacterCount;
        set => orig.CharacterCount = value;
    }

    public float LineHeight
    {
        get => orig.LineHeight;
        set => orig.LineHeight = value;
    }

    public float Baseline
    {
        get => orig.Baseline;
        set => orig.Baseline = value;
    }

    public float Ascender
    {
        get => orig.Ascender;
        set => orig.Ascender = value;
    }

    public float CapHeight
    {
        get => orig.CapHeight;
        set => orig.CapHeight = value;
    }

    public float Descender
    {
        get => orig.Descender;
        set => orig.Descender = value;
    }

    public float CenterLine
    {
        get => orig.CenterLine;
        set => orig.CenterLine = value;
    }

    public float SuperscriptOffset
    {
        get => orig.SuperscriptOffset;
        set => orig.SuperscriptOffset = value;
    }

    public float SubscriptOffset
    {
        get => orig.SubscriptOffset;
        set => orig.SubscriptOffset = value;
    }

    public float SubSize
    {
        get => orig.SubSize;
        set => orig.SubSize = value;
    }

    public float Underline
    {
        get => orig.Underline;
        set => orig.Underline = value;
    }

    public float UnderlineThickness
    {
        get => orig.UnderlineThickness;
        set => orig.UnderlineThickness = value;
    }

    public float TabWidth
    {
        get => orig.TabWidth;
        set => orig.TabWidth = value;
    }

    public float Padding
    {
        get => orig.Padding;
        set => orig.Padding = value;
    }

    public float AtlasWidth
    {
        get => orig.AtlasWidth;
        set => orig.AtlasWidth = value;
    }

    public float AtlasHeight
    {
        get => orig.AtlasHeight;
        set => orig.AtlasHeight = value;
    }
}