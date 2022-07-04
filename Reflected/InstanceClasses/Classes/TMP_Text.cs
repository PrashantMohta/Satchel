using System.Text;
using TMPro;
using UnityEngine.Events;
using Bounds = UnityEngine.Bounds;

namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of TMP_Text allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class TMP_TextR : InstanceClassWrapper<TMP_Text>
{
    public TMP_TextR(TMP_Text _orig) : base(_orig)
    {
    }

    public string m_text
    {
        get => GetField<string>();
        set => SetField(value);
    }

    public bool m_isRightToLeft
    {
        get => GetField<bool>();
        set => SetField(value);
    }

    public TMP_FontAsset m_fontAsset
    {
        get => GetField<TMP_FontAsset>();
        set => SetField(value);
    }

    public TMP_FontAsset m_currentFontAsset
    {
        get => GetField<TMP_FontAsset>();
        set => SetField(value);
    }

    public bool m_isSDFShader
    {
        get => GetField<bool>();
        set => SetField(value);
    }

    public Material m_sharedMaterial
    {
        get => GetField<Material>();
        set => SetField(value);
    }

    public Material m_currentMaterial
    {
        get => GetField<Material>();
        set => SetField(value);
    }

    public MaterialReference[] m_materialReferences
    {
        get => GetField<MaterialReference[]>();
        set => SetField(value);
    }

    public Dictionary<int, int> m_materialReferenceIndexLookup
    {
        get => GetField<Dictionary<int, int>>();
        set => SetField(value);
    }

    public TMP_XmlTagStack<MaterialReference> m_materialReferenceStack
    {
        get => GetField<TMP_XmlTagStack<MaterialReference>>();
        set => SetField(value);
    }

    public int m_currentMaterialIndex
    {
        get => GetField<int>();
        set => SetField(value);
    }

    public Material[] m_fontSharedMaterials
    {
        get => GetField<Material[]>();
        set => SetField(value);
    }

    public Material m_fontMaterial
    {
        get => GetField<Material>();
        set => SetField(value);
    }

    public Material[] m_fontMaterials
    {
        get => GetField<Material[]>();
        set => SetField(value);
    }

    public bool m_isMaterialDirty
    {
        get => GetField<bool>();
        set => SetField(value);
    }

    public Color32 m_fontColor32
    {
        get => GetField<Color32>();
        set => SetField(value);
    }

    public Color m_fontColor
    {
        get => GetField<Color>();
        set => SetField(value);
    }

    public Color32 s_colorWhite
    {
        get => GetFieldStatic<Color32>();
        set => SetField(value);
    }

    public bool m_enableVertexGradient
    {
        get => GetField<bool>();
        set => SetField(value);
    }

    public VertexGradient m_fontColorGradient
    {
        get => GetField<VertexGradient>();
        set => SetField(value);
    }

    public TMP_ColorGradient m_fontColorGradientPreset
    {
        get => GetField<TMP_ColorGradient>();
        set => SetField(value);
    }

    public TMP_SpriteAsset m_spriteAsset
    {
        get => GetField<TMP_SpriteAsset>();
        set => SetField(value);
    }

    public bool m_tintAllSprites
    {
        get => GetField<bool>();
        set => SetField(value);
    }

    public bool m_tintSprite
    {
        get => GetField<bool>();
        set => SetField(value);
    }

    public Color32 m_spriteColor
    {
        get => GetField<Color32>();
        set => SetField(value);
    }

    public bool m_overrideHtmlColors
    {
        get => GetField<bool>();
        set => SetField(value);
    }

    public Color32 m_faceColor
    {
        get => GetField<Color32>();
        set => SetField(value);
    }

    public Color32 m_outlineColor
    {
        get => GetField<Color32>();
        set => SetField(value);
    }

    public float m_outlineWidth
    {
        get => GetField<float>();
        set => SetField(value);
    }

    public float m_fontSize
    {
        get => GetField<float>();
        set => SetField(value);
    }

    public float m_currentFontSize
    {
        get => GetField<float>();
        set => SetField(value);
    }

    public float m_fontSizeBase
    {
        get => GetField<float>();
        set => SetField(value);
    }

    public TMP_XmlTagStack<float> m_sizeStack
    {
        get => GetField<TMP_XmlTagStack<float>>();
        set => SetField(value);
    }

    public int m_fontWeight
    {
        get => GetField<int>();
        set => SetField(value);
    }

    public int m_fontWeightInternal
    {
        get => GetField<int>();
        set => SetField(value);
    }

    public TMP_XmlTagStack<int> m_fontWeightStack
    {
        get => GetField<TMP_XmlTagStack<int>>();
        set => SetField(value);
    }

    public bool m_enableAutoSizing
    {
        get => GetField<bool>();
        set => SetField(value);
    }

    public float m_maxFontSize
    {
        get => GetField<float>();
        set => SetField(value);
    }

    public float m_minFontSize
    {
        get => GetField<float>();
        set => SetField(value);
    }

    public float m_fontSizeMin
    {
        get => GetField<float>();
        set => SetField(value);
    }

    public float m_fontSizeMax
    {
        get => GetField<float>();
        set => SetField(value);
    }

    public FontStyles m_fontStyle
    {
        get => GetField<FontStyles>();
        set => SetField(value);
    }

    public FontStyles m_style
    {
        get => GetField<FontStyles>();
        set => SetField(value);
    }

    public bool m_isUsingBold
    {
        get => GetField<bool>();
        set => SetField(value);
    }

    public TextAlignmentOptions m_textAlignment
    {
        get => GetField<TextAlignmentOptions>();
        set => SetField(value);
    }

    public TextAlignmentOptions m_lineJustification
    {
        get => GetField<TextAlignmentOptions>();
        set => SetField(value);
    }

    public Vector3[] m_textContainerLocalCorners
    {
        get => GetField<Vector3[]>();
        set => SetField(value);
    }

    public float m_characterSpacing
    {
        get => GetField<float>();
        set => SetField(value);
    }

    public float m_cSpacing
    {
        get => GetField<float>();
        set => SetField(value);
    }

    public float m_monoSpacing
    {
        get => GetField<float>();
        set => SetField(value);
    }

    public float m_lineSpacing
    {
        get => GetField<float>();
        set => SetField(value);
    }

    public float m_lineSpacingDelta
    {
        get => GetField<float>();
        set => SetField(value);
    }

    public float m_lineHeight
    {
        get => GetField<float>();
        set => SetField(value);
    }

    public float m_lineSpacingMax
    {
        get => GetField<float>();
        set => SetField(value);
    }

    public float m_paragraphSpacing
    {
        get => GetField<float>();
        set => SetField(value);
    }

    public float m_charWidthMaxAdj
    {
        get => GetField<float>();
        set => SetField(value);
    }

    public float m_charWidthAdjDelta
    {
        get => GetField<float>();
        set => SetField(value);
    }

    public bool m_enableWordWrapping
    {
        get => GetField<bool>();
        set => SetField(value);
    }

    public bool m_isCharacterWrappingEnabled
    {
        get => GetField<bool>();
        set => SetField(value);
    }

    public bool m_isNonBreakingSpace
    {
        get => GetField<bool>();
        set => SetField(value);
    }

    public bool m_isIgnoringAlignment
    {
        get => GetField<bool>();
        set => SetField(value);
    }

    public float m_wordWrappingRatios
    {
        get => GetField<float>();
        set => SetField(value);
    }

    public bool m_enableAdaptiveJustification
    {
        get => GetField<bool>();
        set => SetField(value);
    }

    public float m_adaptiveJustificationThreshold
    {
        get => GetField<float>();
        set => SetField(value);
    }

    public TextOverflowModes m_overflowMode
    {
        get => GetField<TextOverflowModes>();
        set => SetField(value);
    }

    public bool m_isTextTruncated
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

    public bool checkPaddingRequired
    {
        get => GetField<bool>();
        set => SetField(value);
    }

    public bool m_isRichText
    {
        get => GetField<bool>();
        set => SetField(value);
    }

    public bool m_parseCtrlCharacters
    {
        get => GetField<bool>();
        set => SetField(value);
    }

    public bool m_isOverlay
    {
        get => GetField<bool>();
        set => SetField(value);
    }

    public bool m_isOrthographic
    {
        get => GetField<bool>();
        set => SetField(value);
    }

    public bool m_isCullingEnabled
    {
        get => GetField<bool>();
        set => SetField(value);
    }

    public bool m_ignoreCulling
    {
        get => GetField<bool>();
        set => SetField(value);
    }

    public TextureMappingOptions m_horizontalMapping
    {
        get => GetField<TextureMappingOptions>();
        set => SetField(value);
    }

    public TextureMappingOptions m_verticalMapping
    {
        get => GetField<TextureMappingOptions>();
        set => SetField(value);
    }

    public TextRenderFlags m_renderMode
    {
        get => GetField<TextRenderFlags>();
        set => SetField(value);
    }

    public int m_maxVisibleCharacters
    {
        get => GetField<int>();
        set => SetField(value);
    }

    public int m_maxVisibleWords
    {
        get => GetField<int>();
        set => SetField(value);
    }

    public int m_maxVisibleLines
    {
        get => GetField<int>();
        set => SetField(value);
    }

    public bool m_useMaxVisibleDescender
    {
        get => GetField<bool>();
        set => SetField(value);
    }

    public int m_pageToDisplay
    {
        get => GetField<int>();
        set => SetField(value);
    }

    public bool m_isNewPage
    {
        get => GetField<bool>();
        set => SetField(value);
    }

    public Vector4 m_margin
    {
        get => GetField<Vector4>();
        set => SetField(value);
    }

    public float m_marginLeft
    {
        get => GetField<float>();
        set => SetField(value);
    }

    public float m_marginRight
    {
        get => GetField<float>();
        set => SetField(value);
    }

    public float m_marginWidth
    {
        get => GetField<float>();
        set => SetField(value);
    }

    public float m_marginHeight
    {
        get => GetField<float>();
        set => SetField(value);
    }

    public float m_width
    {
        get => GetField<float>();
        set => SetField(value);
    }

    public TMP_TextInfo m_textInfo
    {
        get => GetField<TMP_TextInfo>();
        set => SetField(value);
    }

    public bool m_havePropertiesChanged
    {
        get => GetField<bool>();
        set => SetField(value);
    }

    public bool m_isUsingLegacyAnimationComponent
    {
        get => GetField<bool>();
        set => SetField(value);
    }

    public Transform m_transform
    {
        get => GetField<Transform>();
        set => SetField(value);
    }

    public RectTransform m_rectTransform
    {
        get => GetField<RectTransform>();
        set => SetField(value);
    }

    public Mesh m_mesh
    {
        get => GetField<Mesh>();
        set => SetField(value);
    }

    public bool m_isVolumetricText
    {
        get => GetField<bool>();
        set => SetField(value);
    }

    public float m_flexibleHeight
    {
        get => GetField<float>();
        set => SetField(value);
    }

    public float m_flexibleWidth
    {
        get => GetField<float>();
        set => SetField(value);
    }

    public float m_minHeight
    {
        get => GetField<float>();
        set => SetField(value);
    }

    public float m_minWidth
    {
        get => GetField<float>();
        set => SetField(value);
    }

    public float m_preferredWidth
    {
        get => GetField<float>();
        set => SetField(value);
    }

    public float m_renderedWidth
    {
        get => GetField<float>();
        set => SetField(value);
    }

    public bool m_isPreferredWidthDirty
    {
        get => GetField<bool>();
        set => SetField(value);
    }

    public float m_preferredHeight
    {
        get => GetField<float>();
        set => SetField(value);
    }

    public float m_renderedHeight
    {
        get => GetField<float>();
        set => SetField(value);
    }

    public bool m_isPreferredHeightDirty
    {
        get => GetField<bool>();
        set => SetField(value);
    }

    public bool m_isCalculatingPreferredValues
    {
        get => GetField<bool>();
        set => SetField(value);
    }

    public int m_layoutPriority
    {
        get => GetField<int>();
        set => SetField(value);
    }

    public bool m_isCalculateSizeRequired
    {
        get => GetField<bool>();
        set => SetField(value);
    }

    public bool m_isLayoutDirty
    {
        get => GetField<bool>();
        set => SetField(value);
    }

    public bool m_verticesAlreadyDirty
    {
        get => GetField<bool>();
        set => SetField(value);
    }

    public bool m_layoutAlreadyDirty
    {
        get => GetField<bool>();
        set => SetField(value);
    }

    public bool m_isAwake
    {
        get => GetField<bool>();
        set => SetField(value);
    }

    public bool m_isInputParsingRequired
    {
        get => GetField<bool>();
        set => SetField(value);
    }

    public string old_text
    {
        get => GetField<string>();
        set => SetField(value);
    }

    public float old_arg0
    {
        get => GetField<float>();
        set => SetField(value);
    }

    public float old_arg1
    {
        get => GetField<float>();
        set => SetField(value);
    }

    public float old_arg2
    {
        get => GetField<float>();
        set => SetField(value);
    }

    public float m_fontScale
    {
        get => GetField<float>();
        set => SetField(value);
    }

    public float m_fontScaleMultiplier
    {
        get => GetField<float>();
        set => SetField(value);
    }

    public char[] m_htmlTag
    {
        get => GetField<char[]>();
        set => SetField(value);
    }

    public XML_TagAttribute[] m_xmlAttribute
    {
        get => GetField<XML_TagAttribute[]>();
        set => SetField(value);
    }

    public float tag_LineIndent
    {
        get => GetField<float>();
        set => SetField(value);
    }

    public float tag_Indent
    {
        get => GetField<float>();
        set => SetField(value);
    }

    public TMP_XmlTagStack<float> m_indentStack
    {
        get => GetField<TMP_XmlTagStack<float>>();
        set => SetField(value);
    }

    public bool tag_NoParsing
    {
        get => GetField<bool>();
        set => SetField(value);
    }

    public bool m_isParsingText
    {
        get => GetField<bool>();
        set => SetField(value);
    }

    public int[] m_char_buffer
    {
        get => GetField<int[]>();
        set => SetField(value);
    }

    public TMP_CharacterInfo[] m_internalCharacterInfo
    {
        get => GetField<TMP_CharacterInfo[]>();
        set => SetField(value);
    }

    public char[] m_input_CharArray
    {
        get => GetField<char[]>();
        set => SetField(value);
    }

    public int m_charArray_Length
    {
        get => GetField<int>();
        set => SetField(value);
    }

    public int m_totalCharacterCount
    {
        get => GetField<int>();
        set => SetField(value);
    }

    public int m_characterCount
    {
        get => GetField<int>();
        set => SetField(value);
    }

    public int m_firstCharacterOfLine
    {
        get => GetField<int>();
        set => SetField(value);
    }

    public int m_firstVisibleCharacterOfLine
    {
        get => GetField<int>();
        set => SetField(value);
    }

    public int m_lastCharacterOfLine
    {
        get => GetField<int>();
        set => SetField(value);
    }

    public int m_lastVisibleCharacterOfLine
    {
        get => GetField<int>();
        set => SetField(value);
    }

    public int m_lineNumber
    {
        get => GetField<int>();
        set => SetField(value);
    }

    public int m_lineVisibleCharacterCount
    {
        get => GetField<int>();
        set => SetField(value);
    }

    public int m_pageNumber
    {
        get => GetField<int>();
        set => SetField(value);
    }

    public float m_maxAscender
    {
        get => GetField<float>();
        set => SetField(value);
    }

    public float m_maxCapHeight
    {
        get => GetField<float>();
        set => SetField(value);
    }

    public float m_maxDescender
    {
        get => GetField<float>();
        set => SetField(value);
    }

    public float m_maxLineAscender
    {
        get => GetField<float>();
        set => SetField(value);
    }

    public float m_maxLineDescender
    {
        get => GetField<float>();
        set => SetField(value);
    }

    public float m_startOfLineAscender
    {
        get => GetField<float>();
        set => SetField(value);
    }

    public float m_lineOffset
    {
        get => GetField<float>();
        set => SetField(value);
    }

    public Extents m_meshExtents
    {
        get => GetField<Extents>();
        set => SetField(value);
    }

    public Color32 m_htmlColor
    {
        get => GetField<Color32>();
        set => SetField(value);
    }

    public TMP_XmlTagStack<Color32> m_colorStack
    {
        get => GetField<TMP_XmlTagStack<Color32>>();
        set => SetField(value);
    }

    public float m_tabSpacing
    {
        get => GetField<float>();
        set => SetField(value);
    }

    public float m_spacing
    {
        get => GetField<float>();
        set => SetField(value);
    }

    public TMP_XmlTagStack<int> m_styleStack
    {
        get => GetField<TMP_XmlTagStack<int>>();
        set => SetField(value);
    }

    public TMP_XmlTagStack<int> m_actionStack
    {
        get => GetField<TMP_XmlTagStack<int>>();
        set => SetField(value);
    }

    public float m_padding
    {
        get => GetField<float>();
        set => SetField(value);
    }

    public float m_baselineOffset
    {
        get => GetField<float>();
        set => SetField(value);
    }

    public float m_xAdvance
    {
        get => GetField<float>();
        set => SetField(value);
    }

    public TMP_TextElementType m_textElementType
    {
        get => GetField<TMP_TextElementType>();
        set => SetField(value);
    }

    public TMP_TextElement m_cached_TextElement
    {
        get => GetField<TMP_TextElement>();
        set => SetField(value);
    }

    public TMP_Glyph m_cached_Underline_GlyphInfo
    {
        get => GetField<TMP_Glyph>();
        set => SetField(value);
    }

    public TMP_Glyph m_cached_Ellipsis_GlyphInfo
    {
        get => GetField<TMP_Glyph>();
        set => SetField(value);
    }

    public TMP_SpriteAsset m_defaultSpriteAsset
    {
        get => GetField<TMP_SpriteAsset>();
        set => SetField(value);
    }

    public TMP_SpriteAsset m_currentSpriteAsset
    {
        get => GetField<TMP_SpriteAsset>();
        set => SetField(value);
    }

    public int m_spriteCount
    {
        get => GetField<int>();
        set => SetField(value);
    }

    public int m_spriteIndex
    {
        get => GetField<int>();
        set => SetField(value);
    }

    public InlineGraphicManager m_inlineGraphics
    {
        get => GetField<InlineGraphicManager>();
        set => SetField(value);
    }

    public bool m_ignoreActiveState
    {
        get => GetField<bool>();
        set => SetField(value);
    }

    public float[] k_Power
    {
        get => GetField<float[]>();
        set => SetField(value);
    }

    public Vector2 k_LargePositiveVector2
    {
        get => GetFieldStatic<Vector2>();
        set => SetField(value);
    }

    public Vector2 k_LargeNegativeVector2
    {
        get => GetFieldStatic<Vector2>();
        set => SetField(value);
    }

    public float k_LargePositiveFloat
    {
        get => GetFieldStatic<float>();
        set => SetField(value);
    }

    public float k_LargeNegativeFloat
    {
        get => GetFieldStatic<float>();
        set => SetField(value);
    }

    public int k_LargePositiveInt
    {
        get => GetFieldStatic<int>();
        set => SetField(value);
    }

    public int k_LargeNegativeInt
    {
        get => GetFieldStatic<int>();
        set => SetField(value);
    }

    public bool m_ShouldRecalculateStencil
    {
        get => GetField<bool>();
        set => SetField(value);
    }

    public Material m_MaskMaterial
    {
        get => GetField<Material>();
        set => SetField(value);
    }

    public bool m_IncludeForMasking
    {
        get => GetField<bool>();
        set => SetField(value);
    }

    public bool m_ShouldRecalculate
    {
        get => GetField<bool>();
        set => SetField(value);
    }

    public int m_StencilValue
    {
        get => GetField<int>();
        set => SetField(value);
    }

    public Material m_Material
    {
        get => GetField<Material>();
        set => SetField(value);
    }

    public bool m_SkipLayoutUpdate
    {
        get => GetField<bool>();
        set => SetField(value);
    }

    public bool m_SkipMaterialUpdate
    {
        get => GetField<bool>();
        set => SetField(value);
    }

    public UnityAction m_OnDirtyLayoutCallback
    {
        get => GetField<UnityAction>();
        set => SetField(value);
    }

    public UnityAction m_OnDirtyVertsCallback
    {
        get => GetField<UnityAction>();
        set => SetField(value);
    }

    public UnityAction m_OnDirtyMaterialCallback
    {
        get => GetField<UnityAction>();
        set => SetField(value);
    }

    public Mesh m_CachedMesh
    {
        get => GetField<Mesh>();
        set => SetField(value);
    }

    public Vector2[] m_CachedUvs
    {
        get => GetField<Vector2[]>();
        set => SetField(value);
    }

    public string text
    {
        get => orig.text;
        set => orig.text = value;
    }

    public bool isRightToLeftText
    {
        get => orig.isRightToLeftText;
        set => orig.isRightToLeftText = value;
    }

    public TMP_FontAsset font
    {
        get => orig.font;
        set => orig.font = value;
    }

    public Material fontSharedMaterial
    {
        get => orig.fontSharedMaterial;
        set => orig.fontSharedMaterial = value;
    }

    public Material[] fontSharedMaterials
    {
        get => orig.fontSharedMaterials;
        set => orig.fontSharedMaterials = value;
    }

    public Material fontMaterial
    {
        get => orig.fontMaterial;
        set => orig.fontMaterial = value;
    }

    public Material[] fontMaterials
    {
        get => orig.fontMaterials;
        set => orig.fontMaterials = value;
    }

    public Color color
    {
        get => orig.color;
        set => orig.color = value;
    }

    public float alpha
    {
        get => orig.alpha;
        set => orig.alpha = value;
    }

    public bool enableVertexGradient
    {
        get => orig.enableVertexGradient;
        set => orig.enableVertexGradient = value;
    }

    public VertexGradient colorGradient
    {
        get => orig.colorGradient;
        set => orig.colorGradient = value;
    }

    public TMP_ColorGradient colorGradientPreset
    {
        get => orig.colorGradientPreset;
        set => orig.colorGradientPreset = value;
    }

    public TMP_SpriteAsset spriteAsset
    {
        get => orig.spriteAsset;
        set => orig.spriteAsset = value;
    }

    public bool tintAllSprites
    {
        get => orig.tintAllSprites;
        set => orig.tintAllSprites = value;
    }

    public bool overrideColorTags
    {
        get => orig.overrideColorTags;
        set => orig.overrideColorTags = value;
    }

    public Color32 faceColor
    {
        get => orig.faceColor;
        set => orig.faceColor = value;
    }

    public Color32 outlineColor
    {
        get => orig.outlineColor;
        set => orig.outlineColor = value;
    }

    public float outlineWidth
    {
        get => orig.outlineWidth;
        set => orig.outlineWidth = value;
    }

    public float fontSize
    {
        get => orig.fontSize;
        set => orig.fontSize = value;
    }

    public float fontScale => orig.fontScale;

    public int fontWeight
    {
        get => orig.fontWeight;
        set => orig.fontWeight = value;
    }

    public float pixelsPerUnit => orig.pixelsPerUnit;

    public bool enableAutoSizing
    {
        get => orig.enableAutoSizing;
        set => orig.enableAutoSizing = value;
    }

    public float fontSizeMin
    {
        get => orig.fontSizeMin;
        set => orig.fontSizeMin = value;
    }

    public float fontSizeMax
    {
        get => orig.fontSizeMax;
        set => orig.fontSizeMax = value;
    }

    public FontStyles fontStyle
    {
        get => orig.fontStyle;
        set => orig.fontStyle = value;
    }

    public bool isUsingBold => orig.isUsingBold;

    public TextAlignmentOptions alignment
    {
        get => orig.alignment;
        set => orig.alignment = value;
    }

    public float characterSpacing
    {
        get => orig.characterSpacing;
        set => orig.characterSpacing = value;
    }

    public float lineSpacing
    {
        get => orig.lineSpacing;
        set => orig.lineSpacing = value;
    }

    public float paragraphSpacing
    {
        get => orig.paragraphSpacing;
        set => orig.paragraphSpacing = value;
    }

    public float characterWidthAdjustment
    {
        get => orig.characterWidthAdjustment;
        set => orig.characterWidthAdjustment = value;
    }

    public bool enableWordWrapping
    {
        get => orig.enableWordWrapping;
        set => orig.enableWordWrapping = value;
    }

    public float wordWrappingRatios
    {
        get => orig.wordWrappingRatios;
        set => orig.wordWrappingRatios = value;
    }

    public bool enableAdaptiveJustification
    {
        get => orig.enableAdaptiveJustification;
        set => orig.enableAdaptiveJustification = value;
    }

    public TextOverflowModes OverflowMode
    {
        get => orig.OverflowMode;
        set => orig.OverflowMode = value;
    }

    public bool enableKerning
    {
        get => orig.enableKerning;
        set => orig.enableKerning = value;
    }

    public bool extraPadding
    {
        get => orig.extraPadding;
        set => orig.extraPadding = value;
    }

    public bool richText
    {
        get => orig.richText;
        set => orig.richText = value;
    }

    public bool parseCtrlCharacters
    {
        get => orig.parseCtrlCharacters;
        set => orig.parseCtrlCharacters = value;
    }

    public bool isOverlay
    {
        get => orig.isOverlay;
        set => orig.isOverlay = value;
    }

    public bool isOrthographic
    {
        get => orig.isOrthographic;
        set => orig.isOrthographic = value;
    }

    public bool enableCulling
    {
        get => orig.enableCulling;
        set => orig.enableCulling = value;
    }

    public bool ignoreVisibility
    {
        get => orig.ignoreVisibility;
        set => orig.ignoreVisibility = value;
    }

    public TextureMappingOptions horizontalMapping
    {
        get => orig.horizontalMapping;
        set => orig.horizontalMapping = value;
    }

    public TextureMappingOptions verticalMapping
    {
        get => orig.verticalMapping;
        set => orig.verticalMapping = value;
    }

    public TextRenderFlags renderMode
    {
        get => orig.renderMode;
        set => orig.renderMode = value;
    }

    public int maxVisibleCharacters
    {
        get => orig.maxVisibleCharacters;
        set => orig.maxVisibleCharacters = value;
    }

    public int maxVisibleWords
    {
        get => orig.maxVisibleWords;
        set => orig.maxVisibleWords = value;
    }

    public int maxVisibleLines
    {
        get => orig.maxVisibleLines;
        set => orig.maxVisibleLines = value;
    }

    public bool useMaxVisibleDescender
    {
        get => orig.useMaxVisibleDescender;
        set => orig.useMaxVisibleDescender = value;
    }

    public int pageToDisplay
    {
        get => orig.pageToDisplay;
        set => orig.pageToDisplay = value;
    }

    public Vector4 margin
    {
        get => orig.margin;
        set => orig.margin = value;
    }

    public TMP_TextInfo textInfo => orig.textInfo;

    public bool havePropertiesChanged
    {
        get => orig.havePropertiesChanged;
        set => orig.havePropertiesChanged = value;
    }

    public bool isUsingLegacyAnimationComponent
    {
        get => orig.isUsingLegacyAnimationComponent;
        set => orig.isUsingLegacyAnimationComponent = value;
    }

    public Transform transform => orig.transform;

    public RectTransform rectTransform => orig.rectTransform;

    public bool autoSizeTextContainer
    {
        get => orig.autoSizeTextContainer;
        set => orig.autoSizeTextContainer = value;
    }

    public Mesh mesh => orig.mesh;

    public bool isVolumetricText
    {
        get => orig.isVolumetricText;
        set => orig.isVolumetricText = value;
    }

    public Bounds bounds => orig.bounds;

    public Bounds textBounds => orig.textBounds;

    public float flexibleHeight => orig.flexibleHeight;

    public float flexibleWidth => orig.flexibleWidth;

    public float minHeight => orig.minHeight;

    public float minWidth => orig.minWidth;

    public float preferredWidth => orig.preferredWidth;

    public float preferredHeight => orig.preferredHeight;

    public float renderedWidth => orig.renderedWidth;

    public float renderedHeight => orig.renderedHeight;

    public int layoutPriority => orig.layoutPriority;

    public bool maskable
    {
        get => orig.maskable;
        set => orig.maskable = value;
    }

    public bool isMaskingGraphic
    {
        get => orig.isMaskingGraphic;
        set => orig.isMaskingGraphic = value;
    }

    public bool raycastTarget
    {
        get => orig.raycastTarget;
        set => orig.raycastTarget = value;
    }

    public Vector4 raycastPadding
    {
        get => orig.raycastPadding;
        set => orig.raycastPadding = value;
    }

    public bool useLegacyMeshGeneration
    {
        get => GetProperty<bool>();
        set => SetProperty(value);
    }

    public int depth => orig.depth;

    public Canvas canvas => orig.canvas;

    public CanvasRenderer canvasRenderer => orig.canvasRenderer;

    public Material defaultMaterial => orig.defaultMaterial;

    public Material material
    {
        get => orig.material;
        set => orig.material = value;
    }

    public Material materialForRendering => orig.materialForRendering;

    public Texture mainTexture => orig.mainTexture;

    public bool useGUILayout
    {
        get => orig.useGUILayout;
        set => orig.useGUILayout = value;
    }

    public bool enabled
    {
        get => orig.enabled;
        set => orig.enabled = value;
    }

    public bool isActiveAndEnabled => orig.isActiveAndEnabled;

    public GameObject gameObject => orig.gameObject;

    public string tag
    {
        get => orig.tag;
        set => orig.tag = value;
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

    public void LoadFontAsset()
    {
        CallMethod();
    }

    public void SetSharedMaterial(Material mat)
    {
        CallMethod(new object[] { mat });
    }

    public Material GetMaterial(Material mat)
    {
        return CallMethod<Material>(new object[] { mat });
    }

    public void SetFontBaseMaterial(Material mat)
    {
        CallMethod(new object[] { mat });
    }

    public Material[] GetSharedMaterials()
    {
        return CallMethod<Material[]>();
    }

    public void SetSharedMaterials(Material[] materials)
    {
        CallMethod(new object[] { materials });
    }

    public Material[] GetMaterials(Material[] mats)
    {
        return CallMethod<Material[]>(new object[] { mats });
    }

    public Material CreateMaterialInstance(Material source)
    {
        return CallMethod<Material>(new object[] { source });
    }

    public void SetVertexColorGradient(TMP_ColorGradient gradient)
    {
        CallMethod(new object[] { gradient });
    }

    public void SetFaceColor(Color32 color)
    {
        CallMethod(new object[] { color });
    }

    public void SetOutlineColor(Color32 color)
    {
        CallMethod(new object[] { color });
    }

    public void SetOutlineThickness(float thickness)
    {
        CallMethod(new object[] { thickness });
    }

    public void SetShaderDepth()
    {
        CallMethod();
    }

    public void SetCulling()
    {
        CallMethod();
    }

    public float GetPaddingForMaterial()
    {
        return CallMethod<float>();
    }

    public float GetPaddingForMaterial(Material mat)
    {
        return CallMethod<float>(new object[] { mat });
    }

    public Vector3[] GetTextContainerLocalCorners()
    {
        return CallMethod<Vector3[]>();
    }

    public void ForceMeshUpdate()
    {
        orig.ForceMeshUpdate();
    }

    public void ForceMeshUpdate(bool ignoreActiveState)
    {
        orig.ForceMeshUpdate(ignoreActiveState);
    }

    public void SetTextInternal(string text)
    {
        CallMethod(new object[] { text });
    }

    public void UpdateGeometry(Mesh mesh, int index)
    {
        orig.UpdateGeometry(mesh, index);
    }

    public void UpdateVertexData(TMP_VertexDataUpdateFlags flags)
    {
        orig.UpdateVertexData(flags);
    }

    public void UpdateVertexData()
    {
        orig.UpdateVertexData();
    }

    public void SetVertices(Vector3[] vertices)
    {
        orig.SetVertices(vertices);
    }

    public void UpdateMeshPadding()
    {
        orig.UpdateMeshPadding();
    }

    public void CrossFadeColor(Color targetColor, float duration, bool ignoreTimeScale, bool useAlpha)
    {
        orig.CrossFadeColor(targetColor, duration, ignoreTimeScale, useAlpha);
    }

    public void CrossFadeAlpha(float alpha, float duration, bool ignoreTimeScale)
    {
        orig.CrossFadeAlpha(alpha, duration, ignoreTimeScale);
    }

    public void InternalCrossFadeColor(Color targetColor, float duration, bool ignoreTimeScale, bool useAlpha)
    {
        CallMethod(new object[] { targetColor, duration, ignoreTimeScale, useAlpha });
    }

    public void InternalCrossFadeAlpha(float alpha, float duration, bool ignoreTimeScale)
    {
        CallMethod(new object[] { alpha, duration, ignoreTimeScale });
    }

    public void ParseInputText()
    {
        CallMethod();
    }

    public void SetText(string text)
    {
        orig.SetText(text);
    }

    public void SetText(string text, float arg0)
    {
        orig.SetText(text, arg0);
    }

    public void SetText(string text, float arg0, float arg1)
    {
        orig.SetText(text, arg0, arg1);
    }

    public void SetText(string text, float arg0, float arg1, float arg2)
    {
        orig.SetText(text, arg0, arg1, arg2);
    }

    public void SetText(StringBuilder text)
    {
        orig.SetText(text);
    }

    public void SetCharArray(char[] charArray)
    {
        orig.SetCharArray(charArray);
    }

    public void SetTextArrayToCharArray(char[] charArray, int[] charBuffer)
    {
        CallMethod(new object[] { charArray, charBuffer });
    }

    public void StringToCharArray(string text, int[] chars)
    {
        CallMethod(new object[] { text, chars });
    }

    public void StringBuilderToIntArray(StringBuilder text, int[] chars)
    {
        CallMethod(new object[] { text, chars });
    }

    public void AddFloatToCharArray(float number, int index, int precision)
    {
        CallMethod(new object[] { number, index, precision });
    }

    public void AddIntToCharArray(int number, int index, int precision)
    {
        CallMethod(new object[] { number, index, precision });
    }

    public int SetArraySizes(int[] chars)
    {
        return CallMethod<int>(new object[] { chars });
    }

    public void GenerateTextMesh()
    {
        CallMethod();
    }

    public Vector2 GetPreferredValues()
    {
        return orig.GetPreferredValues();
    }

    public Vector2 GetPreferredValues(float width, float height)
    {
        return orig.GetPreferredValues(width, height);
    }

    public Vector2 GetPreferredValues(string text)
    {
        return orig.GetPreferredValues(text);
    }

    public Vector2 GetPreferredValues(string text, float width, float height)
    {
        return orig.GetPreferredValues(text, width, height);
    }

    public float GetPreferredWidth()
    {
        return CallMethod<float>();
    }

    public float GetPreferredWidth(Vector2 margin)
    {
        return CallMethod<float>(new object[] { margin });
    }

    public float GetPreferredHeight()
    {
        return CallMethod<float>();
    }

    public float GetPreferredHeight(Vector2 margin)
    {
        return CallMethod<float>(new object[] { margin });
    }

    public Vector2 GetRenderedValues()
    {
        return orig.GetRenderedValues();
    }

    public float GetRenderedWidth()
    {
        return CallMethod<float>();
    }

    public float GetRenderedHeight()
    {
        return CallMethod<float>();
    }

    public Vector2 CalculatePreferredValues(float defaultFontSize, Vector2 marginSize)
    {
        return CallMethod<Vector2>(new object[] { defaultFontSize, marginSize });
    }

    public Bounds GetCompoundBounds()
    {
        return CallMethod<Bounds>();
    }

    public Bounds GetTextBounds()
    {
        return CallMethod<Bounds>();
    }

    public void AdjustLineOffset(int startIndex, int endIndex, float offset)
    {
        CallMethod(new object[] { startIndex, endIndex, offset });
    }

    public void ResizeLineExtents(int size)
    {
        CallMethod(new object[] { size });
    }

    public TMP_TextInfo GetTextInfo(string text)
    {
        return orig.GetTextInfo(text);
    }

    public void ComputeMarginSize()
    {
        CallMethod();
    }

    public int GetArraySizes(int[] chars)
    {
        return CallMethod<int>(new object[] { chars });
    }

    public void SaveWordWrappingState(WordWrapState state, int index, int count)
    {
        CallMethod(new object[] { state, index, count });
    }

    public int RestoreWordWrappingState(WordWrapState state)
    {
        return CallMethod<int>(new object[] { state });
    }

    public void SaveGlyphVertexInfo(float padding, float style_padding, Color32 vertexColor)
    {
        CallMethod(new object[] { padding, style_padding, vertexColor });
    }

    public void SaveSpriteVertexInfo(Color32 vertexColor)
    {
        CallMethod(new object[] { vertexColor });
    }

    public void FillCharacterVertexBuffers(int i, int index_X4)
    {
        CallMethod(new object[] { i, index_X4 });
    }

    public void FillCharacterVertexBuffers(int i, int index_X4, bool isVolumetric)
    {
        CallMethod(new object[] { i, index_X4, isVolumetric });
    }

    public void FillSpriteVertexBuffers(int i, int index_X4)
    {
        CallMethod(new object[] { i, index_X4 });
    }

    public void DrawUnderlineMesh(Vector3 start, Vector3 end, int index, float startScale, float endScale,
        float maxScale, float sdfScale, Color32 underlineColor)
    {
        CallMethod(new object[] { start, end, index, startScale, endScale, maxScale, sdfScale, underlineColor });
    }

    public void GetSpecialCharacters(TMP_FontAsset fontAsset)
    {
        CallMethod(new object[] { fontAsset });
    }

    public TMP_FontAsset GetFontAssetForWeight(int fontWeight)
    {
        return CallMethod<TMP_FontAsset>(new object[] { fontWeight });
    }

    public void SetActiveSubMeshes(bool state)
    {
        CallMethod(new object[] { state });
    }

    public Vector2 PackUV(float x, float y, float scale)
    {
        return CallMethod<Vector2>(new object[] { x, y, scale });
    }

    public float PackUV(float x, float y)
    {
        return CallMethod<float>(new object[] { x, y });
    }

    public int HexToInt(char hex)
    {
        return CallMethod<int>(new object[] { hex });
    }

    public int GetUTF16(int i)
    {
        return CallMethod<int>(new object[] { i });
    }

    public int GetUTF32(int i)
    {
        return CallMethod<int>(new object[] { i });
    }

    public Color32 HexCharsToColor(char[] hexChars, int tagCount)
    {
        return CallMethod<Color32>(new object[] { hexChars, tagCount });
    }

    public Color32 HexCharsToColor(char[] hexChars, int startIndex, int length)
    {
        return CallMethod<Color32>(new object[] { hexChars, startIndex, length });
    }

    public float ConvertToFloat(char[] chars, int startIndex, int length, int decimalPointIndex)
    {
        return CallMethod<float>(new object[] { chars, startIndex, length, decimalPointIndex });
    }

    public bool ValidateHtmlTag(int[] chars, int startIndex, int endIndex)
    {
        return CallMethod<bool>(new object[] { chars, startIndex, endIndex });
    }
}