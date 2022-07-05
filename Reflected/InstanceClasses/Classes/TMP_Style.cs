using TMPro;

namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of TMP_Style allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class TMP_StyleR : InstanceClassWrapper<TMP_Style>
{
    public TMP_StyleR(TMP_Style _orig) : base(_orig)
    {
    }

    public string m_Name
    {
        get => GetField<string>();
        set => SetField(value);
    }

    public int m_HashCode
    {
        get => GetField<int>();
        set => SetField(value);
    }

    public string m_OpeningDefinition
    {
        get => GetField<string>();
        set => SetField(value);
    }

    public string m_ClosingDefinition
    {
        get => GetField<string>();
        set => SetField(value);
    }

    public int[] m_OpeningTagArray
    {
        get => GetField<int[]>();
        set => SetField(value);
    }

    public int[] m_ClosingTagArray
    {
        get => GetField<int[]>();
        set => SetField(value);
    }

    public string name
    {
        get => orig.name;
        set => orig.name = value;
    }

    public int hashCode
    {
        get => orig.hashCode;
        set => orig.hashCode = value;
    }

    public string styleOpeningDefinition => orig.styleOpeningDefinition;

    public string styleClosingDefinition => orig.styleClosingDefinition;

    public int[] styleOpeningTagArray => orig.styleOpeningTagArray;

    public int[] styleClosingTagArray => orig.styleClosingTagArray;

    public void RefreshStyle()
    {
        orig.RefreshStyle();
    }
}