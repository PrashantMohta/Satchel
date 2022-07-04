namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of tk2dTextMesh allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class tk2dTextMeshR:InstanceClassWrapper<tk2dTextMesh>
{
public tk2dTextMeshR(tk2dTextMesh _orig) : base(_orig) {}
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

public UnityEngine.Color _color
{
get => GetField<UnityEngine.Color>();
set => SetField(value);
}

public UnityEngine.Color _color2
{
get => GetField<UnityEngine.Color>();
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

public UnityEngine.TextAnchor _anchor
{
get => GetField<UnityEngine.TextAnchor>();
set => SetField(value);
}

public UnityEngine.Vector3 _scale
{
get => GetField<UnityEngine.Vector3>();
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

public UnityEngine.Vector3[] vertices
{
get => GetField<UnityEngine.Vector3[]>();
set => SetField(value);
}

public UnityEngine.Vector2[] uvs
{
get => GetField<UnityEngine.Vector2[]>();
set => SetField(value);
}

public UnityEngine.Vector2[] uv2
{
get => GetField<UnityEngine.Vector2[]>();
set => SetField(value);
}

public UnityEngine.Color32[] colors
{
get => GetField<UnityEngine.Color32[]>();
set => SetField(value);
}

public UnityEngine.Color32[] untintedColors
{
get => GetField<UnityEngine.Color32[]>();
set => SetField(value);
}

public UnityEngine.Mesh mesh
{
get => GetField<UnityEngine.Mesh>();
set => SetField(value);
}

public UnityEngine.MeshFilter meshFilter
{
get => GetField<UnityEngine.MeshFilter>();
set => SetField(value);
}

public UnityEngine.Renderer _cachedRenderer
{
get => GetField<UnityEngine.Renderer>();
set => SetField(value);
}

public string FormattedText
{
get => orig.FormattedText;
}

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

public UnityEngine.Color color
{
get => orig.color;
set => orig.color = value;
}

public UnityEngine.Color color2
{
get => orig.color2;
set => orig.color2 = value;
}

public bool useGradient
{
get => orig.useGradient;
set => orig.useGradient = value;
}

public UnityEngine.TextAnchor anchor
{
get => orig.anchor;
set => orig.anchor = value;
}

public UnityEngine.Vector3 scale
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

public UnityEngine.Renderer CachedRenderer
{
get => GetProperty<UnityEngine.Renderer>();
}

public bool useInlineStyling
{
get => GetProperty<bool>();
}



public void UpgradeData () =>
CallMethod();

public int GetInlineStyleCommandLength (int cmdSymbol) =>
CallMethodStatic<int>(new object[] {cmdSymbol});

public string FormatText (string unformattedString) =>
orig.FormatText(unformattedString);

public void FormatText () =>
CallMethod();

public void FormatText (string _targetString, string _source) =>
CallMethod(new object[] {_targetString, _source});

public void InitInstance () =>
CallMethod();

public void Awake () =>
CallMethod();

public void OnDestroy () =>
CallMethod();

public int NumDrawnCharacters () =>
orig.NumDrawnCharacters();

public int NumTotalCharacters () =>
orig.NumTotalCharacters();

public UnityEngine.Vector2 GetMeshDimensionsForString (string str) =>
orig.GetMeshDimensionsForString(str);

public UnityEngine.Bounds GetEstimatedMeshBoundsForString (string str) =>
orig.GetEstimatedMeshBoundsForString(str);

public void Init (bool force) =>
orig.Init(force);

public void Init () =>
orig.Init();

public void Commit () =>
orig.Commit();

public void DoNotUse__CommitInternal () =>
orig.DoNotUse__CommitInternal();

public void MakePixelPerfect () =>
orig.MakePixelPerfect();

public bool UsesSpriteCollection (tk2dSpriteCollectionData spriteCollection) =>
orig.UsesSpriteCollection(spriteCollection);

public void UpdateMaterial () =>
CallMethod();

public void ForceBuild () =>
orig.ForceBuild();

}
}
