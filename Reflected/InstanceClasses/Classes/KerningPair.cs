using TMPro;

namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of KerningPair allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class KerningPairR : InstanceClassWrapper<KerningPair>
{
    public KerningPairR(KerningPair _orig) : base(_orig)
    {
    }

    public int AscII_Left
    {
        get => orig.AscII_Left;
        set => orig.AscII_Left = value;
    }

    public int AscII_Right
    {
        get => orig.AscII_Right;
        set => orig.AscII_Right = value;
    }

    public float XadvanceOffset
    {
        get => orig.XadvanceOffset;
        set => orig.XadvanceOffset = value;
    }
}