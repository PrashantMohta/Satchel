namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of TMP_FontAsset allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class TMP_FontAssetR:InstanceClassWrapper<TMPro.TMP_FontAsset>
{
public TMP_FontAssetR(TMPro.TMP_FontAsset _orig) : base(_orig) {}
public TMPro.TMP_FontAsset s_defaultFontAsset
{
get => GetFieldStatic<TMPro.TMP_FontAsset>();
set => SetField(value);
}

public TMPro.FaceInfo m_fontInfo
{
get => GetField<TMPro.FaceInfo>();
set => SetField(value);
}

public UnityEngine.Texture2D atlas
{
get => orig.atlas;
set => orig.atlas = value;
}

public System.Collections.Generic.List<TMPro.TMP_Glyph> m_glyphInfoList
{
get => GetField<System.Collections.Generic.List<TMPro.TMP_Glyph>>();
set => SetField(value);
}

public System.Collections.Generic.Dictionary<System.Int32,TMPro.TMP_Glyph> m_characterDictionary
{
get => GetField<System.Collections.Generic.Dictionary<System.Int32,TMPro.TMP_Glyph>>();
set => SetField(value);
}

public System.Collections.Generic.Dictionary<System.Int32,TMPro.KerningPair> m_kerningDictionary
{
get => GetField<System.Collections.Generic.Dictionary<System.Int32,TMPro.KerningPair>>();
set => SetField(value);
}

public TMPro.KerningTable m_kerningInfo
{
get => GetField<TMPro.KerningTable>();
set => SetField(value);
}

public TMPro.KerningPair m_kerningPair
{
get => GetField<TMPro.KerningPair>();
set => SetField(value);
}

public System.Collections.Generic.List<TMPro.TMP_FontAsset> fallbackFontAssets
{
get => orig.fallbackFontAssets;
set => orig.fallbackFontAssets = value;
}

public TMPro.FontCreationSetting fontCreationSettings
{
get => orig.fontCreationSettings;
set => orig.fontCreationSettings = value;
}

public TMPro.TMP_FontWeights[] fontWeights
{
get => orig.fontWeights;
set => orig.fontWeights = value;
}

public System.Int32[] m_characterSet
{
get => GetField<System.Int32[]>();
set => SetField(value);
}

public float normalStyle
{
get => orig.normalStyle;
set => orig.normalStyle = value;
}

public float normalSpacingOffset
{
get => orig.normalSpacingOffset;
set => orig.normalSpacingOffset = value;
}

public float boldStyle
{
get => orig.boldStyle;
set => orig.boldStyle = value;
}

public float boldSpacing
{
get => orig.boldSpacing;
set => orig.boldSpacing = value;
}

public System.Byte italicStyle
{
get => orig.italicStyle;
set => orig.italicStyle = value;
}

public System.Byte tabSize
{
get => orig.tabSize;
set => orig.tabSize = value;
}

public System.Byte m_oldTabSize
{
get => GetField<System.Byte>();
set => SetField(value);
}

public int hashCode
{
get => orig.hashCode;
set => orig.hashCode = value;
}

public UnityEngine.Material material
{
get => orig.material;
set => orig.material = value;
}

public int materialHashCode
{
get => orig.materialHashCode;
set => orig.materialHashCode = value;
}

public TMPro.TMP_FontAsset defaultFontAsset
{
get => TMPro.TMP_FontAsset.defaultFontAsset;
}

public TMPro.FaceInfo fontInfo
{
get => orig.fontInfo;
}

public System.Collections.Generic.Dictionary<System.Int32,TMPro.TMP_Glyph> characterDictionary
{
get => orig.characterDictionary;
}

public System.Collections.Generic.Dictionary<System.Int32,TMPro.KerningPair> kerningDictionary
{
get => orig.kerningDictionary;
}

public TMPro.KerningTable kerningInfo
{
get => orig.kerningInfo;
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

public void OnEnable () =>
CallMethod();

public void OnDisable () =>
CallMethod();

public void AddFaceInfo (TMPro.FaceInfo faceInfo) =>
orig.AddFaceInfo(faceInfo);

public void AddGlyphInfo (TMPro.TMP_Glyph[] glyphInfo) =>
orig.AddGlyphInfo(glyphInfo);

public void AddKerningInfo (TMPro.KerningTable kerningTable) =>
orig.AddKerningInfo(kerningTable);

public void ReadFontDefinition () =>
orig.ReadFontDefinition();

public bool HasCharacter (int character) =>
orig.HasCharacter(character);

public bool HasCharacter (System.Char character) =>
orig.HasCharacter(character);

public bool HasCharacter (System.Char character, bool searchFallbacks) =>
orig.HasCharacter(character, searchFallbacks);

public bool HasCharacters (string text, out System.Collections.Generic.List<System.Char> missingCharacters) =>
orig.HasCharacters(text, out missingCharacters);

public string GetCharacters (TMPro.TMP_FontAsset fontAsset) =>
TMPro.TMP_FontAsset.GetCharacters(fontAsset);

public System.Int32[] GetCharactersArray (TMPro.TMP_FontAsset fontAsset) =>
TMPro.TMP_FontAsset.GetCharactersArray(fontAsset);

}
}
