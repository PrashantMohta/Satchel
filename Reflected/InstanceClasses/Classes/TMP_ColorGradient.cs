using TMPro;

namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of TMP_ColorGradient allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class TMP_ColorGradientR : InstanceClassWrapper<TMP_ColorGradient>
{
    public TMP_ColorGradientR(TMP_ColorGradient _orig) : base(_orig)
    {
    }

    public Color topLeft
    {
        get => orig.topLeft;
        set => orig.topLeft = value;
    }

    public Color topRight
    {
        get => orig.topRight;
        set => orig.topRight = value;
    }

    public Color bottomLeft
    {
        get => orig.bottomLeft;
        set => orig.bottomLeft = value;
    }

    public Color bottomRight
    {
        get => orig.bottomRight;
        set => orig.bottomRight = value;
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