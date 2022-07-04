namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of TMP_Style allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class TMP_StyleR:InstanceClassWrapper<TMPro.TMP_Style>
{
public TMP_StyleR(TMPro.TMP_Style _orig) : base(_orig) {}
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

public System.Int32[] m_OpeningTagArray
{
get => GetField<System.Int32[]>();
set => SetField(value);
}

public System.Int32[] m_ClosingTagArray
{
get => GetField<System.Int32[]>();
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

public string styleOpeningDefinition
{
get => orig.styleOpeningDefinition;
}

public string styleClosingDefinition
{
get => orig.styleClosingDefinition;
}

public System.Int32[] styleOpeningTagArray
{
get => orig.styleOpeningTagArray;
}

public System.Int32[] styleClosingTagArray
{
get => orig.styleClosingTagArray;
}

public void RefreshStyle () =>
orig.RefreshStyle();

}
}
