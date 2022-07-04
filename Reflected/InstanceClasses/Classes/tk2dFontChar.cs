namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of tk2dFontChar allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class tk2dFontCharR : InstanceClassWrapper<tk2dFontChar>
{
    public tk2dFontCharR(tk2dFontChar _orig) : base(_orig)
    {
    }

    public Vector3 p0
    {
        get => orig.p0;
        set => orig.p0 = value;
    }

    public Vector3 p1
    {
        get => orig.p1;
        set => orig.p1 = value;
    }

    public Vector3 uv0
    {
        get => orig.uv0;
        set => orig.uv0 = value;
    }

    public Vector3 uv1
    {
        get => orig.uv1;
        set => orig.uv1 = value;
    }

    public bool flipped
    {
        get => orig.flipped;
        set => orig.flipped = value;
    }

    public Vector2[] gradientUv
    {
        get => orig.gradientUv;
        set => orig.gradientUv = value;
    }

    public float advance
    {
        get => orig.advance;
        set => orig.advance = value;
    }

    public int channel
    {
        get => orig.channel;
        set => orig.channel = value;
    }
}