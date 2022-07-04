namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of tk2dSpriteCollection allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class tk2dSpriteCollectionR : InstanceClassWrapper<tk2dSpriteCollection>
{
    public tk2dSpriteCollectionR(tk2dSpriteCollection _orig) : base(_orig)
    {
    }

    public int CURRENT_VERSION
    {
        get => tk2dSpriteCollection.CURRENT_VERSION;
        set => SetField(value);
    }

    public tk2dSpriteCollectionDefinition[] textures
    {
        get => GetField<tk2dSpriteCollectionDefinition[]>();
        set => SetField(value);
    }

    public Texture2D[] textureRefs
    {
        get => GetField<Texture2D[]>();
        set => SetField(value);
    }

    public tk2dSpriteSheetSource[] spriteSheets
    {
        get => orig.spriteSheets;
        set => orig.spriteSheets = value;
    }

    public tk2dSpriteCollectionFont[] fonts
    {
        get => orig.fonts;
        set => orig.fonts = value;
    }

    public tk2dSpriteCollectionDefault defaults
    {
        get => orig.defaults;
        set => orig.defaults = value;
    }

    public List<tk2dSpriteCollectionPlatform> platforms
    {
        get => orig.platforms;
        set => orig.platforms = value;
    }

    public bool managedSpriteCollection
    {
        get => orig.managedSpriteCollection;
        set => orig.managedSpriteCollection = value;
    }

    public tk2dSpriteCollection linkParent
    {
        get => orig.linkParent;
        set => orig.linkParent = value;
    }

    public bool loadable
    {
        get => orig.loadable;
        set => orig.loadable = value;
    }

    public int maxTextureSize
    {
        get => orig.maxTextureSize;
        set => orig.maxTextureSize = value;
    }

    public bool forceTextureSize
    {
        get => orig.forceTextureSize;
        set => orig.forceTextureSize = value;
    }

    public int forcedTextureWidth
    {
        get => orig.forcedTextureWidth;
        set => orig.forcedTextureWidth = value;
    }

    public int forcedTextureHeight
    {
        get => orig.forcedTextureHeight;
        set => orig.forcedTextureHeight = value;
    }

    public int atlasWidth
    {
        get => orig.atlasWidth;
        set => orig.atlasWidth = value;
    }

    public int atlasHeight
    {
        get => orig.atlasHeight;
        set => orig.atlasHeight = value;
    }

    public bool forceSquareAtlas
    {
        get => orig.forceSquareAtlas;
        set => orig.forceSquareAtlas = value;
    }

    public float atlasWastage
    {
        get => orig.atlasWastage;
        set => orig.atlasWastage = value;
    }

    public bool allowMultipleAtlases
    {
        get => orig.allowMultipleAtlases;
        set => orig.allowMultipleAtlases = value;
    }

    public bool removeDuplicates
    {
        get => orig.removeDuplicates;
        set => orig.removeDuplicates = value;
    }

    public tk2dSpriteCollectionDefinition[] textureParams
    {
        get => orig.textureParams;
        set => orig.textureParams = value;
    }

    public tk2dSpriteCollectionData spriteCollection
    {
        get => orig.spriteCollection;
        set => orig.spriteCollection = value;
    }

    public bool premultipliedAlpha
    {
        get => orig.premultipliedAlpha;
        set => orig.premultipliedAlpha = value;
    }

    public Material[] altMaterials
    {
        get => orig.altMaterials;
        set => orig.altMaterials = value;
    }

    public Material[] atlasMaterials
    {
        get => orig.atlasMaterials;
        set => orig.atlasMaterials = value;
    }

    public Texture2D[] atlasTextures
    {
        get => orig.atlasTextures;
        set => orig.atlasTextures = value;
    }

    public TextAsset[] atlasTextureFiles
    {
        get => orig.atlasTextureFiles;
        set => orig.atlasTextureFiles = value;
    }

    public bool useTk2dCamera
    {
        get => GetField<bool>();
        set => SetField(value);
    }

    public int targetHeight
    {
        get => GetField<int>();
        set => SetField(value);
    }

    public float targetOrthoSize
    {
        get => GetField<float>();
        set => SetField(value);
    }

    public tk2dSpriteCollectionSize sizeDef
    {
        get => orig.sizeDef;
        set => orig.sizeDef = value;
    }

    public float globalScale
    {
        get => orig.globalScale;
        set => orig.globalScale = value;
    }

    public float globalTextureRescale
    {
        get => orig.globalTextureRescale;
        set => orig.globalTextureRescale = value;
    }

    public List<tk2dSpriteCollection.AttachPointTestSprite> attachPointTestSprites
    {
        get => orig.attachPointTestSprites;
        set => orig.attachPointTestSprites = value;
    }

    public bool pixelPerfectPointSampled
    {
        get => GetField<bool>();
        set => SetField(value);
    }

    public FilterMode filterMode
    {
        get => orig.filterMode;
        set => orig.filterMode = value;
    }

    public TextureWrapMode wrapMode
    {
        get => orig.wrapMode;
        set => orig.wrapMode = value;
    }

    public bool userDefinedTextureSettings
    {
        get => orig.userDefinedTextureSettings;
        set => orig.userDefinedTextureSettings = value;
    }

    public bool mipmapEnabled
    {
        get => orig.mipmapEnabled;
        set => orig.mipmapEnabled = value;
    }

    public int anisoLevel
    {
        get => orig.anisoLevel;
        set => orig.anisoLevel = value;
    }

    public float physicsDepth
    {
        get => orig.physicsDepth;
        set => orig.physicsDepth = value;
    }

    public bool disableTrimming
    {
        get => orig.disableTrimming;
        set => orig.disableTrimming = value;
    }

    public bool disableRotation
    {
        get => orig.disableRotation;
        set => orig.disableRotation = value;
    }

    public int padAmount
    {
        get => orig.padAmount;
        set => orig.padAmount = value;
    }

    public bool autoUpdate
    {
        get => orig.autoUpdate;
        set => orig.autoUpdate = value;
    }

    public float editorDisplayScale
    {
        get => orig.editorDisplayScale;
        set => orig.editorDisplayScale = value;
    }

    public int version
    {
        get => orig.version;
        set => orig.version = value;
    }

    public string assetName
    {
        get => orig.assetName;
        set => orig.assetName = value;
    }

    public List<tk2dLinkedSpriteCollection> linkedSpriteCollections
    {
        get => orig.linkedSpriteCollections;
        set => orig.linkedSpriteCollections = value;
    }

    public Texture2D[] DoNotUse__TextureRefs
    {
        get => orig.DoNotUse__TextureRefs;
        set => orig.DoNotUse__TextureRefs = value;
    }

    public bool HasPlatformData => orig.HasPlatformData;


    public void Upgrade()
    {
        orig.Upgrade();
    }
}