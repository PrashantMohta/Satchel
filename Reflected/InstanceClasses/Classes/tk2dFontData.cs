namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of tk2dFontData allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class tk2dFontDataR : InstanceClassWrapper<tk2dFontData>
{
    public tk2dFontDataR(tk2dFontData _orig) : base(_orig)
    {
    }

    public int CURRENT_VERSION
    {
        get => tk2dFontData.CURRENT_VERSION;
        set => SetField(value);
    }

    public int version
    {
        get => orig.version;
        set => orig.version = value;
    }

    public float lineHeight
    {
        get => orig.lineHeight;
        set => orig.lineHeight = value;
    }

    public tk2dFontChar[] chars
    {
        get => orig.chars;
        set => orig.chars = value;
    }

    public List<int> charDictKeys
    {
        get => GetField<List<int>>();
        set => SetField(value);
    }

    public List<tk2dFontChar> charDictValues
    {
        get => GetField<List<tk2dFontChar>>();
        set => SetField(value);
    }

    public string[] fontPlatforms
    {
        get => orig.fontPlatforms;
        set => orig.fontPlatforms = value;
    }

    public string[] fontPlatformGUIDs
    {
        get => orig.fontPlatformGUIDs;
        set => orig.fontPlatformGUIDs = value;
    }

    public tk2dFontData platformSpecificData
    {
        get => GetField<tk2dFontData>();
        set => SetField(value);
    }

    public bool hasPlatformData
    {
        get => orig.hasPlatformData;
        set => orig.hasPlatformData = value;
    }

    public bool managedFont
    {
        get => orig.managedFont;
        set => orig.managedFont = value;
    }

    public bool needMaterialInstance
    {
        get => orig.needMaterialInstance;
        set => orig.needMaterialInstance = value;
    }

    public bool isPacked
    {
        get => orig.isPacked;
        set => orig.isPacked = value;
    }

    public bool premultipliedAlpha
    {
        get => orig.premultipliedAlpha;
        set => orig.premultipliedAlpha = value;
    }

    public tk2dSpriteCollectionData spriteCollection
    {
        get => orig.spriteCollection;
        set => orig.spriteCollection = value;
    }

    public Dictionary<int, tk2dFontChar> charDict
    {
        get => orig.charDict;
        set => orig.charDict = value;
    }

    public bool useDictionary
    {
        get => orig.useDictionary;
        set => orig.useDictionary = value;
    }

    public tk2dFontKerning[] kerning
    {
        get => orig.kerning;
        set => orig.kerning = value;
    }

    public float largestWidth
    {
        get => orig.largestWidth;
        set => orig.largestWidth = value;
    }

    public Material material
    {
        get => orig.material;
        set => orig.material = value;
    }

    public Material materialInst
    {
        get => orig.materialInst;
        set => orig.materialInst = value;
    }

    public Texture2D gradientTexture
    {
        get => orig.gradientTexture;
        set => orig.gradientTexture = value;
    }

    public bool textureGradients
    {
        get => orig.textureGradients;
        set => orig.textureGradients = value;
    }

    public int gradientCount
    {
        get => orig.gradientCount;
        set => orig.gradientCount = value;
    }

    public Vector2 texelSize
    {
        get => orig.texelSize;
        set => orig.texelSize = value;
    }

    public float invOrthoSize
    {
        get => orig.invOrthoSize;
        set => orig.invOrthoSize = value;
    }

    public float halfTargetHeight
    {
        get => orig.halfTargetHeight;
        set => orig.halfTargetHeight = value;
    }

    public tk2dFontData inst => orig.inst;


    public void Init()
    {
        CallMethod();
    }

    public void ResetPlatformData()
    {
        orig.ResetPlatformData();
    }

    public void OnDestroy()
    {
        CallMethod();
    }

    public void InitDictionary()
    {
        orig.InitDictionary();
    }

    public void SetDictionary(Dictionary<int, tk2dFontChar> dict)
    {
        orig.SetDictionary(dict);
    }
}