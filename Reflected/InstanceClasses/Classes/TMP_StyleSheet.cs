namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of TMP_StyleSheet allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class TMP_StyleSheetR:InstanceClassWrapper<TMPro.TMP_StyleSheet>
{
public TMP_StyleSheetR(TMPro.TMP_StyleSheet _orig) : base(_orig) {}
public TMPro.TMP_StyleSheet s_Instance
{
get => GetFieldStatic<TMPro.TMP_StyleSheet>();
set => SetField(value);
}

public System.Collections.Generic.List<TMPro.TMP_Style> m_StyleList
{
get => GetField<System.Collections.Generic.List<TMPro.TMP_Style>>();
set => SetField(value);
}

public System.Collections.Generic.Dictionary<System.Int32,TMPro.TMP_Style> m_StyleDictionary
{
get => GetField<System.Collections.Generic.Dictionary<System.Int32,TMPro.TMP_Style>>();
set => SetField(value);
}

public TMPro.TMP_StyleSheet instance
{
get => TMPro.TMP_StyleSheet.instance;
}

public string name
{
get => orig.name;
set => orig.name = value;
}

public UnityEngine.HideFlags hideFlags
{
get => orig.hideFlags;
set => orig.hideFlags = value;
}

public TMPro.TMP_StyleSheet LoadDefaultStyleSheet () =>
TMPro.TMP_StyleSheet.LoadDefaultStyleSheet();

public TMPro.TMP_Style GetStyle (int hashCode) =>
TMPro.TMP_StyleSheet.GetStyle(hashCode);

public TMPro.TMP_Style GetStyleInternal (int hashCode) =>
CallMethod<TMPro.TMP_Style>(new object[] {hashCode});

public void UpdateStyleDictionaryKey (int old_key, int new_key) =>
orig.UpdateStyleDictionaryKey(old_key, new_key);

public void RefreshStyles () =>
TMPro.TMP_StyleSheet.RefreshStyles();

public void LoadStyleDictionaryInternal () =>
CallMethod();

}
}
