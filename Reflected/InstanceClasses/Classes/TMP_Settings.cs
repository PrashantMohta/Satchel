using TMPro;

namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of TMP_Settings allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class TMP_SettingsR : InstanceClassWrapper<TMP_Settings>
{
    public TMP_SettingsR(TMP_Settings _orig) : base(_orig)
    {
    }

    public TMP_Settings s_Instance
    {
        get => GetFieldStatic<TMP_Settings>();
        set => SetField(value);
    }

    public bool m_enableWordWrapping
    {
        get => GetField<bool>();
        set => SetField(value);
    }

    public bool m_enableKerning
    {
        get => GetField<bool>();
        set => SetField(value);
    }

    public bool m_enableExtraPadding
    {
        get => GetField<bool>();
        set => SetField(value);
    }

    public bool m_enableTintAllSprites
    {
        get => GetField<bool>();
        set => SetField(value);
    }

    public bool m_enableParseEscapeCharacters
    {
        get => GetField<bool>();
        set => SetField(value);
    }

    public int m_missingGlyphCharacter
    {
        get => GetField<int>();
        set => SetField(value);
    }

    public bool m_warningsDisabled
    {
        get => GetField<bool>();
        set => SetField(value);
    }

    public TMP_FontAsset m_defaultFontAsset
    {
        get => GetField<TMP_FontAsset>();
        set => SetField(value);
    }

    public string m_defaultFontAssetPath
    {
        get => GetField<string>();
        set => SetField(value);
    }

    public float m_defaultFontSize
    {
        get => GetField<float>();
        set => SetField(value);
    }

    public float m_defaultTextContainerWidth
    {
        get => GetField<float>();
        set => SetField(value);
    }

    public float m_defaultTextContainerHeight
    {
        get => GetField<float>();
        set => SetField(value);
    }

    public List<TMP_FontAsset> m_fallbackFontAssets
    {
        get => GetField<List<TMP_FontAsset>>();
        set => SetField(value);
    }

    public bool m_matchMaterialPreset
    {
        get => GetField<bool>();
        set => SetField(value);
    }

    public TMP_SpriteAsset m_defaultSpriteAsset
    {
        get => GetField<TMP_SpriteAsset>();
        set => SetField(value);
    }

    public string m_defaultSpriteAssetPath
    {
        get => GetField<string>();
        set => SetField(value);
    }

    public TMP_StyleSheet m_defaultStyleSheet
    {
        get => GetField<TMP_StyleSheet>();
        set => SetField(value);
    }

    public TextAsset m_leadingCharacters
    {
        get => GetField<TextAsset>();
        set => SetField(value);
    }

    public TextAsset m_followingCharacters
    {
        get => GetField<TextAsset>();
        set => SetField(value);
    }

    public bool enableWordWrapping => TMP_Settings.enableWordWrapping;

    public bool enableKerning => TMP_Settings.enableKerning;

    public bool enableExtraPadding => TMP_Settings.enableExtraPadding;

    public bool enableTintAllSprites => TMP_Settings.enableTintAllSprites;

    public bool enableParseEscapeCharacters => TMP_Settings.enableParseEscapeCharacters;

    public int missingGlyphCharacter => TMP_Settings.missingGlyphCharacter;

    public bool warningsDisabled => TMP_Settings.warningsDisabled;

    public TMP_FontAsset defaultFontAsset => TMP_Settings.defaultFontAsset;

    public string defaultFontAssetPath => TMP_Settings.defaultFontAssetPath;

    public float defaultFontSize => TMP_Settings.defaultFontSize;

    public float defaultTextContainerWidth => TMP_Settings.defaultTextContainerWidth;

    public float defaultTextContainerHeight => TMP_Settings.defaultTextContainerHeight;

    public List<TMP_FontAsset> fallbackFontAssets => TMP_Settings.fallbackFontAssets;

    public bool matchMaterialPreset => TMP_Settings.matchMaterialPreset;

    public TMP_SpriteAsset defaultSpriteAsset => TMP_Settings.defaultSpriteAsset;

    public string defaultSpriteAssetPath => TMP_Settings.defaultSpriteAssetPath;

    public TMP_StyleSheet defaultStyleSheet => TMP_Settings.defaultStyleSheet;

    public TextAsset leadingCharacters => TMP_Settings.leadingCharacters;

    public TextAsset followingCharacters => TMP_Settings.followingCharacters;

    public TMP_Settings instance => TMP_Settings.instance;

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

    public TMP_Settings LoadDefaultSettings()
    {
        return TMP_Settings.LoadDefaultSettings();
    }

    public TMP_Settings GetSettings()
    {
        return TMP_Settings.GetSettings();
    }

    public TMP_FontAsset GetFontAsset()
    {
        return TMP_Settings.GetFontAsset();
    }

    public TMP_SpriteAsset GetSpriteAsset()
    {
        return TMP_Settings.GetSpriteAsset();
    }

    public TMP_StyleSheet GetStyleSheet()
    {
        return TMP_Settings.GetStyleSheet();
    }

    public void LoadLinebreakingRules()
    {
        TMP_Settings.LoadLinebreakingRules();
    }

    public Dictionary<int, char> GetCharacters(TextAsset file)
    {
        return CallMethodStatic<Dictionary<int, char>>(new object[] { file });
    }
}