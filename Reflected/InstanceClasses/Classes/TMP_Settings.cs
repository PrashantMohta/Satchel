namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of TMP_Settings allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class TMP_SettingsR:InstanceClassWrapper<TMPro.TMP_Settings>
{
public TMP_SettingsR(TMPro.TMP_Settings _orig) : base(_orig) {}
public TMPro.TMP_Settings s_Instance
{
get => GetFieldStatic<TMPro.TMP_Settings>();
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

public TMPro.TMP_FontAsset m_defaultFontAsset
{
get => GetField<TMPro.TMP_FontAsset>();
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

public System.Collections.Generic.List<TMPro.TMP_FontAsset> m_fallbackFontAssets
{
get => GetField<System.Collections.Generic.List<TMPro.TMP_FontAsset>>();
set => SetField(value);
}

public bool m_matchMaterialPreset
{
get => GetField<bool>();
set => SetField(value);
}

public TMPro.TMP_SpriteAsset m_defaultSpriteAsset
{
get => GetField<TMPro.TMP_SpriteAsset>();
set => SetField(value);
}

public string m_defaultSpriteAssetPath
{
get => GetField<string>();
set => SetField(value);
}

public TMPro.TMP_StyleSheet m_defaultStyleSheet
{
get => GetField<TMPro.TMP_StyleSheet>();
set => SetField(value);
}

public UnityEngine.TextAsset m_leadingCharacters
{
get => GetField<UnityEngine.TextAsset>();
set => SetField(value);
}

public UnityEngine.TextAsset m_followingCharacters
{
get => GetField<UnityEngine.TextAsset>();
set => SetField(value);
}

public bool enableWordWrapping
{
get => TMPro.TMP_Settings.enableWordWrapping;
}

public bool enableKerning
{
get => TMPro.TMP_Settings.enableKerning;
}

public bool enableExtraPadding
{
get => TMPro.TMP_Settings.enableExtraPadding;
}

public bool enableTintAllSprites
{
get => TMPro.TMP_Settings.enableTintAllSprites;
}

public bool enableParseEscapeCharacters
{
get => TMPro.TMP_Settings.enableParseEscapeCharacters;
}

public int missingGlyphCharacter
{
get => TMPro.TMP_Settings.missingGlyphCharacter;
}

public bool warningsDisabled
{
get => TMPro.TMP_Settings.warningsDisabled;
}

public TMPro.TMP_FontAsset defaultFontAsset
{
get => TMPro.TMP_Settings.defaultFontAsset;
}

public string defaultFontAssetPath
{
get => TMPro.TMP_Settings.defaultFontAssetPath;
}

public float defaultFontSize
{
get => TMPro.TMP_Settings.defaultFontSize;
}

public float defaultTextContainerWidth
{
get => TMPro.TMP_Settings.defaultTextContainerWidth;
}

public float defaultTextContainerHeight
{
get => TMPro.TMP_Settings.defaultTextContainerHeight;
}

public System.Collections.Generic.List<TMPro.TMP_FontAsset> fallbackFontAssets
{
get => TMPro.TMP_Settings.fallbackFontAssets;
}

public bool matchMaterialPreset
{
get => TMPro.TMP_Settings.matchMaterialPreset;
}

public TMPro.TMP_SpriteAsset defaultSpriteAsset
{
get => TMPro.TMP_Settings.defaultSpriteAsset;
}

public string defaultSpriteAssetPath
{
get => TMPro.TMP_Settings.defaultSpriteAssetPath;
}

public TMPro.TMP_StyleSheet defaultStyleSheet
{
get => TMPro.TMP_Settings.defaultStyleSheet;
}

public UnityEngine.TextAsset leadingCharacters
{
get => TMPro.TMP_Settings.leadingCharacters;
}

public UnityEngine.TextAsset followingCharacters
{
get => TMPro.TMP_Settings.followingCharacters;
}

public TMPro.TMP_Settings instance
{
get => TMPro.TMP_Settings.instance;
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

public TMPro.TMP_Settings LoadDefaultSettings () =>
TMPro.TMP_Settings.LoadDefaultSettings();

public TMPro.TMP_Settings GetSettings () =>
TMPro.TMP_Settings.GetSettings();

public TMPro.TMP_FontAsset GetFontAsset () =>
TMPro.TMP_Settings.GetFontAsset();

public TMPro.TMP_SpriteAsset GetSpriteAsset () =>
TMPro.TMP_Settings.GetSpriteAsset();

public TMPro.TMP_StyleSheet GetStyleSheet () =>
TMPro.TMP_Settings.GetStyleSheet();

public void LoadLinebreakingRules () =>
TMPro.TMP_Settings.LoadLinebreakingRules();

public System.Collections.Generic.Dictionary<System.Int32,System.Char> GetCharacters (UnityEngine.TextAsset file) =>
CallMethodStatic<System.Collections.Generic.Dictionary<System.Int32,System.Char>>(new object[] {file});

}
}
