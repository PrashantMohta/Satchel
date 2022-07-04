namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of TextMeshProUGUI allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class TextMeshProUGUIR:InstanceClassWrapper<TMPro.TextMeshProUGUI>
{
public TextMeshProUGUIR(TMPro.TextMeshProUGUI _orig) : base(_orig) {}
public UnityEngine.Vector2 m_uvOffset
{
get => GetField<UnityEngine.Vector2>();
set => SetField(value);
}

public float m_uvLineOffset
{
get => GetField<float>();
set => SetField(value);
}

public bool m_hasFontAssetChanged
{
get => GetField<bool>();
set => SetField(value);
}

public TMPro.TMP_SubMeshUI[] m_subTextObjects
{
get => GetField<TMPro.TMP_SubMeshUI[]>();
set => SetField(value);
}

public float m_previousLossyScaleY
{
get => GetField<float>();
set => SetField(value);
}

public UnityEngine.Vector3[] m_RectTransformCorners
{
get => GetField<UnityEngine.Vector3[]>();
set => SetField(value);
}

public UnityEngine.CanvasRenderer m_canvasRenderer
{
get => GetField<UnityEngine.CanvasRenderer>();
set => SetField(value);
}

public UnityEngine.Canvas m_canvas
{
get => GetField<UnityEngine.Canvas>();
set => SetField(value);
}

public bool m_isFirstAllocation
{
get => GetField<bool>();
set => SetField(value);
}

public int m_max_characters
{
get => GetField<int>();
set => SetField(value);
}

public TMPro.WordWrapState m_SavedWordWrapState
{
get => GetField<TMPro.WordWrapState>();
set => SetField(value);
}

public TMPro.WordWrapState m_SavedLineState
{
get => GetField<TMPro.WordWrapState>();
set => SetField(value);
}

public bool m_isMaskingEnabled
{
get => GetField<bool>();
set => SetField(value);
}

public UnityEngine.Material m_baseMaterial
{
get => GetField<UnityEngine.Material>();
set => SetField(value);
}

public bool m_isScrollRegionSet
{
get => GetField<bool>();
set => SetField(value);
}

public int m_stencilID
{
get => GetField<int>();
set => SetField(value);
}

public UnityEngine.Vector4 m_maskOffset
{
get => GetField<UnityEngine.Vector4>();
set => SetField(value);
}

public UnityEngine.Matrix4x4 m_EnvMapMatrix
{
get => GetField<UnityEngine.Matrix4x4>();
set => SetField(value);
}

public bool m_isRegisteredForEvents
{
get => GetField<bool>();
set => SetField(value);
}

public int m_recursiveCount
{
get => GetField<int>();
set => SetField(value);
}

public int m_recursiveCountA
{
get => GetField<int>();
set => SetField(value);
}

public int loopCountA
{
get => GetField<int>();
set => SetField(value);
}

public bool m_isRebuildingLayout
{
get => GetField<bool>();
set => SetField(value);
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

public TMPro.TMP_FontAsset m_fontAsset
{
get => GetField<TMPro.TMP_FontAsset>();
set => SetField(value);
}

public TMPro.TMP_FontAsset m_currentFontAsset
{
get => GetField<TMPro.TMP_FontAsset>();
set => SetField(value);
}

public bool m_isSDFShader
{
get => GetField<bool>();
set => SetField(value);
}

public UnityEngine.Material m_sharedMaterial
{
get => GetField<UnityEngine.Material>();
set => SetField(value);
}

public UnityEngine.Material m_currentMaterial
{
get => GetField<UnityEngine.Material>();
set => SetField(value);
}

public TMPro.MaterialReference[] m_materialReferences
{
get => GetField<TMPro.MaterialReference[]>();
set => SetField(value);
}

public System.Collections.Generic.Dictionary<System.Int32,System.Int32> m_materialReferenceIndexLookup
{
get => GetField<System.Collections.Generic.Dictionary<System.Int32,System.Int32>>();
set => SetField(value);
}

public TMPro.TMP_XmlTagStack<TMPro.MaterialReference> m_materialReferenceStack
{
get => GetField<TMPro.TMP_XmlTagStack<TMPro.MaterialReference>>();
set => SetField(value);
}

public int m_currentMaterialIndex
{
get => GetField<int>();
set => SetField(value);
}

public UnityEngine.Material[] m_fontSharedMaterials
{
get => GetField<UnityEngine.Material[]>();
set => SetField(value);
}

public UnityEngine.Material m_fontMaterial
{
get => GetField<UnityEngine.Material>();
set => SetField(value);
}

public UnityEngine.Material[] m_fontMaterials
{
get => GetField<UnityEngine.Material[]>();
set => SetField(value);
}

public bool m_isMaterialDirty
{
get => GetField<bool>();
set => SetField(value);
}

public UnityEngine.Color32 m_fontColor32
{
get => GetField<UnityEngine.Color32>();
set => SetField(value);
}

public UnityEngine.Color m_fontColor
{
get => GetField<UnityEngine.Color>();
set => SetField(value);
}

public bool m_enableVertexGradient
{
get => GetField<bool>();
set => SetField(value);
}

public TMPro.VertexGradient m_fontColorGradient
{
get => GetField<TMPro.VertexGradient>();
set => SetField(value);
}

public TMPro.TMP_ColorGradient m_fontColorGradientPreset
{
get => GetField<TMPro.TMP_ColorGradient>();
set => SetField(value);
}

public TMPro.TMP_SpriteAsset m_spriteAsset
{
get => GetField<TMPro.TMP_SpriteAsset>();
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

public UnityEngine.Color32 m_spriteColor
{
get => GetField<UnityEngine.Color32>();
set => SetField(value);
}

public bool m_overrideHtmlColors
{
get => GetField<bool>();
set => SetField(value);
}

public UnityEngine.Color32 m_faceColor
{
get => GetField<UnityEngine.Color32>();
set => SetField(value);
}

public UnityEngine.Color32 m_outlineColor
{
get => GetField<UnityEngine.Color32>();
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

public TMPro.TMP_XmlTagStack<System.Single> m_sizeStack
{
get => GetField<TMPro.TMP_XmlTagStack<System.Single>>();
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

public TMPro.TMP_XmlTagStack<System.Int32> m_fontWeightStack
{
get => GetField<TMPro.TMP_XmlTagStack<System.Int32>>();
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

public TMPro.FontStyles m_fontStyle
{
get => GetField<TMPro.FontStyles>();
set => SetField(value);
}

public TMPro.FontStyles m_style
{
get => GetField<TMPro.FontStyles>();
set => SetField(value);
}

public bool m_isUsingBold
{
get => GetField<bool>();
set => SetField(value);
}

public TMPro.TextAlignmentOptions m_textAlignment
{
get => GetField<TMPro.TextAlignmentOptions>();
set => SetField(value);
}

public TMPro.TextAlignmentOptions m_lineJustification
{
get => GetField<TMPro.TextAlignmentOptions>();
set => SetField(value);
}

public UnityEngine.Vector3[] m_textContainerLocalCorners
{
get => GetField<UnityEngine.Vector3[]>();
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

public TMPro.TextOverflowModes m_overflowMode
{
get => GetField<TMPro.TextOverflowModes>();
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

public TMPro.TextureMappingOptions m_horizontalMapping
{
get => GetField<TMPro.TextureMappingOptions>();
set => SetField(value);
}

public TMPro.TextureMappingOptions m_verticalMapping
{
get => GetField<TMPro.TextureMappingOptions>();
set => SetField(value);
}

public TMPro.TextRenderFlags m_renderMode
{
get => GetField<TMPro.TextRenderFlags>();
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

public UnityEngine.Vector4 m_margin
{
get => GetField<UnityEngine.Vector4>();
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

public TMPro.TMP_TextInfo m_textInfo
{
get => GetField<TMPro.TMP_TextInfo>();
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

public UnityEngine.Transform m_transform
{
get => GetField<UnityEngine.Transform>();
set => SetField(value);
}

public UnityEngine.RectTransform m_rectTransform
{
get => GetField<UnityEngine.RectTransform>();
set => SetField(value);
}

public UnityEngine.Mesh m_mesh
{
get => GetField<UnityEngine.Mesh>();
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

public System.Char[] m_htmlTag
{
get => GetField<System.Char[]>();
set => SetField(value);
}

public TMPro.XML_TagAttribute[] m_xmlAttribute
{
get => GetField<TMPro.XML_TagAttribute[]>();
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

public TMPro.TMP_XmlTagStack<System.Single> m_indentStack
{
get => GetField<TMPro.TMP_XmlTagStack<System.Single>>();
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

public System.Int32[] m_char_buffer
{
get => GetField<System.Int32[]>();
set => SetField(value);
}

public System.Char[] m_input_CharArray
{
get => GetField<System.Char[]>();
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

public TMPro.Extents m_meshExtents
{
get => GetField<TMPro.Extents>();
set => SetField(value);
}

public UnityEngine.Color32 m_htmlColor
{
get => GetField<UnityEngine.Color32>();
set => SetField(value);
}

public TMPro.TMP_XmlTagStack<UnityEngine.Color32> m_colorStack
{
get => GetField<TMPro.TMP_XmlTagStack<UnityEngine.Color32>>();
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

public TMPro.TMP_XmlTagStack<System.Int32> m_styleStack
{
get => GetField<TMPro.TMP_XmlTagStack<System.Int32>>();
set => SetField(value);
}

public TMPro.TMP_XmlTagStack<System.Int32> m_actionStack
{
get => GetField<TMPro.TMP_XmlTagStack<System.Int32>>();
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

public TMPro.TMP_TextElementType m_textElementType
{
get => GetField<TMPro.TMP_TextElementType>();
set => SetField(value);
}

public TMPro.TMP_TextElement m_cached_TextElement
{
get => GetField<TMPro.TMP_TextElement>();
set => SetField(value);
}

public TMPro.TMP_Glyph m_cached_Underline_GlyphInfo
{
get => GetField<TMPro.TMP_Glyph>();
set => SetField(value);
}

public TMPro.TMP_Glyph m_cached_Ellipsis_GlyphInfo
{
get => GetField<TMPro.TMP_Glyph>();
set => SetField(value);
}

public TMPro.TMP_SpriteAsset m_defaultSpriteAsset
{
get => GetField<TMPro.TMP_SpriteAsset>();
set => SetField(value);
}

public TMPro.TMP_SpriteAsset m_currentSpriteAsset
{
get => GetField<TMPro.TMP_SpriteAsset>();
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

public TMPro.InlineGraphicManager m_inlineGraphics
{
get => GetField<TMPro.InlineGraphicManager>();
set => SetField(value);
}

public bool m_ignoreActiveState
{
get => GetField<bool>();
set => SetField(value);
}

public bool m_ShouldRecalculateStencil
{
get => GetField<bool>();
set => SetField(value);
}

public UnityEngine.Material m_MaskMaterial
{
get => GetField<UnityEngine.Material>();
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

public UnityEngine.Material m_Material
{
get => GetField<UnityEngine.Material>();
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

public UnityEngine.Events.UnityAction m_OnDirtyLayoutCallback
{
get => GetField<UnityEngine.Events.UnityAction>();
set => SetField(value);
}

public UnityEngine.Events.UnityAction m_OnDirtyVertsCallback
{
get => GetField<UnityEngine.Events.UnityAction>();
set => SetField(value);
}

public UnityEngine.Events.UnityAction m_OnDirtyMaterialCallback
{
get => GetField<UnityEngine.Events.UnityAction>();
set => SetField(value);
}

public UnityEngine.Mesh m_CachedMesh
{
get => GetField<UnityEngine.Mesh>();
set => SetField(value);
}

public UnityEngine.Vector2[] m_CachedUvs
{
get => GetField<UnityEngine.Vector2[]>();
set => SetField(value);
}

public UnityEngine.Material materialForRendering
{
get => orig.materialForRendering;
}

public UnityEngine.Mesh mesh
{
get => orig.mesh;
}

public UnityEngine.CanvasRenderer canvasRenderer
{
get => orig.canvasRenderer;
}

public TMPro.InlineGraphicManager inlineGraphicManager
{
get => orig.inlineGraphicManager;
}

public UnityEngine.Vector4 maskOffset
{
get => orig.maskOffset;
set => orig.maskOffset = value;
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

public TMPro.TMP_FontAsset font
{
get => orig.font;
set => orig.font = value;
}

public UnityEngine.Material fontSharedMaterial
{
get => orig.fontSharedMaterial;
set => orig.fontSharedMaterial = value;
}

public UnityEngine.Material[] fontSharedMaterials
{
get => orig.fontSharedMaterials;
set => orig.fontSharedMaterials = value;
}

public UnityEngine.Material fontMaterial
{
get => orig.fontMaterial;
set => orig.fontMaterial = value;
}

public UnityEngine.Material[] fontMaterials
{
get => orig.fontMaterials;
set => orig.fontMaterials = value;
}

public UnityEngine.Color color
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

public TMPro.VertexGradient colorGradient
{
get => orig.colorGradient;
set => orig.colorGradient = value;
}

public TMPro.TMP_ColorGradient colorGradientPreset
{
get => orig.colorGradientPreset;
set => orig.colorGradientPreset = value;
}

public TMPro.TMP_SpriteAsset spriteAsset
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

public UnityEngine.Color32 faceColor
{
get => orig.faceColor;
set => orig.faceColor = value;
}

public UnityEngine.Color32 outlineColor
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

public float fontScale
{
get => orig.fontScale;
}

public int fontWeight
{
get => orig.fontWeight;
set => orig.fontWeight = value;
}

public float pixelsPerUnit
{
get => orig.pixelsPerUnit;
}

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

public TMPro.FontStyles fontStyle
{
get => orig.fontStyle;
set => orig.fontStyle = value;
}

public bool isUsingBold
{
get => orig.isUsingBold;
}

public TMPro.TextAlignmentOptions alignment
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

public TMPro.TextOverflowModes OverflowMode
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

public TMPro.TextureMappingOptions horizontalMapping
{
get => orig.horizontalMapping;
set => orig.horizontalMapping = value;
}

public TMPro.TextureMappingOptions verticalMapping
{
get => orig.verticalMapping;
set => orig.verticalMapping = value;
}

public TMPro.TextRenderFlags renderMode
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

public UnityEngine.Vector4 margin
{
get => orig.margin;
set => orig.margin = value;
}

public TMPro.TMP_TextInfo textInfo
{
get => orig.textInfo;
}

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

public UnityEngine.Transform transform
{
get => orig.transform;
}

public UnityEngine.RectTransform rectTransform
{
get => orig.rectTransform;
}

public bool autoSizeTextContainer
{
get => orig.autoSizeTextContainer;
set => orig.autoSizeTextContainer = value;
}

public bool isVolumetricText
{
get => orig.isVolumetricText;
set => orig.isVolumetricText = value;
}

public UnityEngine.Bounds bounds
{
get => orig.bounds;
}

public UnityEngine.Bounds textBounds
{
get => orig.textBounds;
}

public float flexibleHeight
{
get => orig.flexibleHeight;
}

public float flexibleWidth
{
get => orig.flexibleWidth;
}

public float minHeight
{
get => orig.minHeight;
}

public float minWidth
{
get => orig.minWidth;
}

public float preferredWidth
{
get => orig.preferredWidth;
}

public float preferredHeight
{
get => orig.preferredHeight;
}

public float renderedWidth
{
get => orig.renderedWidth;
}

public float renderedHeight
{
get => orig.renderedHeight;
}

public int layoutPriority
{
get => orig.layoutPriority;
}

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

public UnityEngine.Vector4 raycastPadding
{
get => orig.raycastPadding;
set => orig.raycastPadding = value;
}

public bool useLegacyMeshGeneration
{
get => GetProperty<bool>();
set => SetProperty(value);
}

public int depth
{
get => orig.depth;
}

public UnityEngine.Canvas canvas
{
get => orig.canvas;
}

public UnityEngine.Material defaultMaterial
{
get => orig.defaultMaterial;
}

public UnityEngine.Material material
{
get => orig.material;
set => orig.material = value;
}

public UnityEngine.Texture mainTexture
{
get => orig.mainTexture;
}

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

public bool isActiveAndEnabled
{
get => orig.isActiveAndEnabled;
}

public UnityEngine.GameObject gameObject
{
get => orig.gameObject;
}

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

public UnityEngine.HideFlags hideFlags
{
get => orig.hideFlags;
set => orig.hideFlags = value;
}

public void Awake () =>
CallMethod();

public void OnEnable () =>
CallMethod();

public void OnDisable () =>
CallMethod();

public void OnDestroy () =>
CallMethod();

public void LoadFontAsset () =>
CallMethod();

public UnityEngine.Canvas GetCanvas () =>
CallMethod<UnityEngine.Canvas>();

public void UpdateEnvMapMatrix () =>
CallMethod();

public void EnableMasking () =>
CallMethod();

public void DisableMasking () =>
CallMethod();

public void UpdateMask () =>
CallMethod();

public UnityEngine.Material GetMaterial (UnityEngine.Material mat) =>
CallMethod<UnityEngine.Material>(new object[] {mat});

public UnityEngine.Material[] GetMaterials (UnityEngine.Material[] mats) =>
CallMethod<UnityEngine.Material[]>(new object[] {mats});

public void SetSharedMaterial (UnityEngine.Material mat) =>
CallMethod(new object[] {mat});

public UnityEngine.Material[] GetSharedMaterials () =>
CallMethod<UnityEngine.Material[]>();

public void SetSharedMaterials (UnityEngine.Material[] materials) =>
CallMethod(new object[] {materials});

public void SetOutlineThickness (float thickness) =>
CallMethod(new object[] {thickness});

public void SetFaceColor (UnityEngine.Color32 color) =>
CallMethod(new object[] {color});

public void SetOutlineColor (UnityEngine.Color32 color) =>
CallMethod(new object[] {color});

public void SetShaderDepth () =>
CallMethod();

public void SetCulling () =>
CallMethod();

public void SetPerspectiveCorrection () =>
CallMethod();

public float GetPaddingForMaterial (UnityEngine.Material mat) =>
CallMethod<float>(new object[] {mat});

public float GetPaddingForMaterial () =>
CallMethod<float>();

public void SetMeshArrays (int size) =>
CallMethod(new object[] {size});

public int SetArraySizes (System.Int32[] chars) =>
CallMethod<int>(new object[] {chars});

public void ComputeMarginSize () =>
CallMethod();

public void OnDidApplyAnimationProperties () =>
CallMethod();

public void OnCanvasHierarchyChanged () =>
CallMethod();

public void OnTransformParentChanged () =>
CallMethod();

public void OnRectTransformDimensionsChange () =>
CallMethod();

public void LateUpdate () =>
CallMethod();

public void OnPreRenderCanvas () =>
CallMethod();

public void GenerateTextMesh () =>
CallMethod();

public UnityEngine.Vector3[] GetTextContainerLocalCorners () =>
CallMethod<UnityEngine.Vector3[]>();

public void ClearMesh () =>
CallMethod();

public void SetActiveSubMeshes (bool state) =>
CallMethod(new object[] {state});

public UnityEngine.Bounds GetCompoundBounds () =>
CallMethod<UnityEngine.Bounds>();

public void UpdateSDFScale (float lossyScale) =>
CallMethod(new object[] {lossyScale});

public void AdjustLineOffset (int startIndex, int endIndex, float offset) =>
CallMethod(new object[] {startIndex, endIndex, offset});

public void CalculateLayoutInputHorizontal () =>
orig.CalculateLayoutInputHorizontal();

public void CalculateLayoutInputVertical () =>
orig.CalculateLayoutInputVertical();

public void SetVerticesDirty () =>
orig.SetVerticesDirty();

public void SetLayoutDirty () =>
orig.SetLayoutDirty();

public void SetMaterialDirty () =>
orig.SetMaterialDirty();

public void SetAllDirty () =>
orig.SetAllDirty();

public void Rebuild (UnityEngine.UI.CanvasUpdate update) =>
orig.Rebuild(update);

public void UpdateSubObjectPivot () =>
CallMethod();

public UnityEngine.Material GetModifiedMaterial (UnityEngine.Material baseMaterial) =>
orig.GetModifiedMaterial(baseMaterial);

public void UpdateMaterial () =>
CallMethod();

public void RecalculateClipping () =>
orig.RecalculateClipping();

public void RecalculateMasking () =>
orig.RecalculateMasking();

public void UpdateMeshPadding () =>
orig.UpdateMeshPadding();

public void InternalCrossFadeColor (UnityEngine.Color targetColor, float duration, bool ignoreTimeScale, bool useAlpha) =>
CallMethod(new object[] {targetColor, duration, ignoreTimeScale, useAlpha});

public void InternalCrossFadeAlpha (float alpha, float duration, bool ignoreTimeScale) =>
CallMethod(new object[] {alpha, duration, ignoreTimeScale});

public void ForceMeshUpdate () =>
orig.ForceMeshUpdate();

public void ForceMeshUpdate (bool ignoreInactive) =>
orig.ForceMeshUpdate(ignoreInactive);

public TMPro.TMP_TextInfo GetTextInfo (string text) =>
orig.GetTextInfo(text);

public void UpdateGeometry (UnityEngine.Mesh mesh, int index) =>
orig.UpdateGeometry(mesh, index);

public void UpdateVertexData (TMPro.TMP_VertexDataUpdateFlags flags) =>
orig.UpdateVertexData(flags);

public void UpdateVertexData () =>
orig.UpdateVertexData();

public void UpdateFontAsset () =>
orig.UpdateFontAsset();

}
}
