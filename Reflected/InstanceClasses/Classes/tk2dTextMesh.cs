using Bounds = UnityEngine.Bounds;

namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of tk2dTextMesh allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class tk2dTextMeshR : InstanceClassWrapper<tk2dTextMesh>
{
    public tk2dTextMeshR(tk2dTextMesh _orig) : base(_orig)
    {
    }

    public tk2dFontData _fontInst
    {
        get => GetField<tk2dFontData>();
        set => SetField(value);
    }

    public string _formattedText
    {
        get => GetField<string>();
        set => SetField(value);
    }

    public tk2dFontData _font
    {
        get => GetField<tk2dFontData>();
        set => SetField(value);
    }

    public string _text
    {
        get => GetField<string>();
        set => SetField(value);
    }

    public Color _color
    {
        get => GetField<Color>();
        set => SetField(value);
    }

    public Color _color2
    {
        get => GetField<Color>();
        set => SetField(value);
    }

    public bool _useGradient
    {
        get => GetField<bool>();
        set => SetField(value);
    }

    public int _textureGradient
    {
        get => GetField<int>();
        set => SetField(value);
    }

    public TextAnchor _anchor
    {
        get => GetField<TextAnchor>();
        set => SetField(value);
    }

    public Vector3 _scale
    {
        get => GetField<Vector3>();
        set => SetField(value);
    }

    public bool _kerning
    {
        get => GetField<bool>();
        set => SetField(value);
    }

    public int _maxChars
    {
        get => GetField<int>();
        set => SetField(value);
    }

    public bool _inlineStyling
    {
        get => GetField<bool>();
        set => SetField(value);
    }

    public bool _formatting
    {
        get => GetField<bool>();
        set => SetField(value);
    }

    public int _wordWrapWidth
    {
        get => GetField<int>();
        set => SetField(value);
    }

    public float spacing
    {
        get => GetField<float>();
        set => SetField(value);
    }

    public float lineSpacing
    {
        get => GetField<float>();
        set => SetField(value);
    }

    public tk2dTextMeshData data
    {
        get => GetField<tk2dTextMeshData>();
        set => SetField(value);
    }

    public Vector3[] vertices
    {
        get => GetField<Vector3[]>();
        set => SetField(value);
    }

    public Vector2[] uvs
    {
        get => GetField<Vector2[]>();
        set => SetField(value);
    }

    public Vector2[] uv2
    {
        get => GetField<Vector2[]>();
        set => SetField(value);
    }

    public Color32[] colors
    {
        get => GetField<Color32[]>();
        set => SetField(value);
    }

    public Color32[] untintedColors
    {
        get => GetField<Color32[]>();
        set => SetField(value);
    }

    public Mesh mesh
    {
        get => GetField<Mesh>();
        set => SetField(value);
    }

    public MeshFilter meshFilter
    {
        get => GetField<MeshFilter>();
        set => SetField(value);
    }

    public Renderer _cachedRenderer
    {
        get => GetField<Renderer>();
        set => SetField(value);
    }

    public string FormattedText => orig.FormattedText;

    public tk2dFontData font
    {
        get => orig.font;
        set => orig.font = value;
    }

    public bool formatting
    {
        get => orig.formatting;
        set => orig.formatting = value;
    }

    public int wordWrapWidth
    {
        get => orig.wordWrapWidth;
        set => orig.wordWrapWidth = value;
    }

    public string text
    {
        get => orig.text;
        set => orig.text = value;
    }

    public Color color
    {
        get => orig.color;
        set => orig.color = value;
    }

    public Color color2
    {
        get => orig.color2;
        set => orig.color2 = value;
    }

    public bool useGradient
    {
        get => orig.useGradient;
        set => orig.useGradient = value;
    }

    public TextAnchor anchor
    {
        get => orig.anchor;
        set => orig.anchor = value;
    }

    public Vector3 scale
    {
        get => orig.scale;
        set => orig.scale = value;
    }

    public bool kerning
    {
        get => orig.kerning;
        set => orig.kerning = value;
    }

    public int maxChars
    {
        get => orig.maxChars;
        set => orig.maxChars = value;
    }

    public int textureGradient
    {
        get => orig.textureGradient;
        set => orig.textureGradient = value;
    }

    public bool inlineStyling
    {
        get => orig.inlineStyling;
        set => orig.inlineStyling = value;
    }

    public float Spacing
    {
        get => orig.Spacing;
        set => orig.Spacing = value;
    }

    public float LineSpacing
    {
        get => orig.LineSpacing;
        set => orig.LineSpacing = value;
    }

    public int SortingOrder
    {
        get => orig.SortingOrder;
        set => orig.SortingOrder = value;
    }

    public Renderer CachedRenderer => GetProperty<Renderer>();

    public bool useInlineStyling => GetProperty<bool>();


    public void UpgradeData()
    {
        CallMethod();
    }

    public int GetInlineStyleCommandLength(int cmdSymbol)
    {
        return CallMethodStatic<int>(new object[] { cmdSymbol });
    }

    public string FormatText(string unformattedString)
    {
        return orig.FormatText(unformattedString);
    }

    public void FormatText()
    {
        CallMethod();
    }

    public void FormatText(string _targetString, string _source)
    {
        CallMethod(new object[] { _targetString, _source });
    }

    public void InitInstance()
    {
        CallMethod();
    }

    public void Awake()
    {
        CallMethod();
    }

    public void OnDestroy()
    {
        CallMethod();
    }

    public int NumDrawnCharacters()
    {
        return orig.NumDrawnCharacters();
    }

    public int NumTotalCharacters()
    {
        return orig.NumTotalCharacters();
    }

    public Vector2 GetMeshDimensionsForString(string str)
    {
        return orig.GetMeshDimensionsForString(str);
    }

    public Bounds GetEstimatedMeshBoundsForString(string str)
    {
        return orig.GetEstimatedMeshBoundsForString(str);
    }

    public void Init(bool force)
    {
        orig.Init(force);
    }

    public void Init()
    {
        orig.Init();
    }

    public void Commit()
    {
        orig.Commit();
    }

    public void DoNotUse__CommitInternal()
    {
        orig.DoNotUse__CommitInternal();
    }

    public void MakePixelPerfect()
    {
        orig.MakePixelPerfect();
    }

    public bool UsesSpriteCollection(tk2dSpriteCollectionData spriteCollection)
    {
        return orig.UsesSpriteCollection(spriteCollection);
    }

    public void UpdateMaterial()
    {
        CallMethod();
    }

    public void ForceBuild()
    {
        orig.ForceBuild();
    }
}