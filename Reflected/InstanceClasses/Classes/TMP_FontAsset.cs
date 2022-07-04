using TMPro;

namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of TMP_FontAsset allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class TMP_FontAssetR : InstanceClassWrapper<TMP_FontAsset>
{
    public TMP_FontAssetR(TMP_FontAsset _orig) : base(_orig)
    {
    }

    public TMP_FontAsset s_defaultFontAsset
    {
        get => GetFieldStatic<TMP_FontAsset>();
        set => SetField(value);
    }

    public FaceInfo m_fontInfo
    {
        get => GetField<FaceInfo>();
        set => SetField(value);
    }

    public Texture2D atlas
    {
        get => orig.atlas;
        set => orig.atlas = value;
    }

    public List<TMP_Glyph> m_glyphInfoList
    {
        get => GetField<List<TMP_Glyph>>();
        set => SetField(value);
    }

    public Dictionary<int, TMP_Glyph> m_characterDictionary
    {
        get => GetField<Dictionary<int, TMP_Glyph>>();
        set => SetField(value);
    }

    public Dictionary<int, KerningPair> m_kerningDictionary
    {
        get => GetField<Dictionary<int, KerningPair>>();
        set => SetField(value);
    }

    public KerningTable m_kerningInfo
    {
        get => GetField<KerningTable>();
        set => SetField(value);
    }

    public KerningPair m_kerningPair
    {
        get => GetField<KerningPair>();
        set => SetField(value);
    }

    public List<TMP_FontAsset> fallbackFontAssets
    {
        get => orig.fallbackFontAssets;
        set => orig.fallbackFontAssets = value;
    }

    public FontCreationSetting fontCreationSettings
    {
        get => orig.fontCreationSettings;
        set => orig.fontCreationSettings = value;
    }

    public TMP_FontWeights[] fontWeights
    {
        get => orig.fontWeights;
        set => orig.fontWeights = value;
    }

    public int[] m_characterSet
    {
        get => GetField<int[]>();
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

    public byte italicStyle
    {
        get => orig.italicStyle;
        set => orig.italicStyle = value;
    }

    public byte tabSize
    {
        get => orig.tabSize;
        set => orig.tabSize = value;
    }

    public byte m_oldTabSize
    {
        get => GetField<byte>();
        set => SetField(value);
    }

    public int hashCode
    {
        get => orig.hashCode;
        set => orig.hashCode = value;
    }

    public Material material
    {
        get => orig.material;
        set => orig.material = value;
    }

    public int materialHashCode
    {
        get => orig.materialHashCode;
        set => orig.materialHashCode = value;
    }

    public TMP_FontAsset defaultFontAsset => TMP_FontAsset.defaultFontAsset;

    public FaceInfo fontInfo => orig.fontInfo;

    public Dictionary<int, TMP_Glyph> characterDictionary => orig.characterDictionary;

    public Dictionary<int, KerningPair> kerningDictionary => orig.kerningDictionary;

    public KerningTable kerningInfo => orig.kerningInfo;

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

    public void OnEnable()
    {
        CallMethod();
    }

    public void OnDisable()
    {
        CallMethod();
    }

    public void AddFaceInfo(FaceInfo faceInfo)
    {
        orig.AddFaceInfo(faceInfo);
    }

    public void AddGlyphInfo(TMP_Glyph[] glyphInfo)
    {
        orig.AddGlyphInfo(glyphInfo);
    }

    public void AddKerningInfo(KerningTable kerningTable)
    {
        orig.AddKerningInfo(kerningTable);
    }

    public void ReadFontDefinition()
    {
        orig.ReadFontDefinition();
    }

    public bool HasCharacter(int character)
    {
        return orig.HasCharacter(character);
    }

    public bool HasCharacter(char character)
    {
        return orig.HasCharacter(character);
    }

    public bool HasCharacter(char character, bool searchFallbacks)
    {
        return orig.HasCharacter(character, searchFallbacks);
    }

    public bool HasCharacters(string text, out List<char> missingCharacters)
    {
        return orig.HasCharacters(text, out missingCharacters);
    }

    public string GetCharacters(TMP_FontAsset fontAsset)
    {
        return TMP_FontAsset.GetCharacters(fontAsset);
    }

    public int[] GetCharactersArray(TMP_FontAsset fontAsset)
    {
        return TMP_FontAsset.GetCharactersArray(fontAsset);
    }
}