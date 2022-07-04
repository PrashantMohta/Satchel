namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of tk2dSpriteCollectionData allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class tk2dSpriteCollectionDataR:InstanceClassWrapper<tk2dSpriteCollectionData>
{
public tk2dSpriteCollectionDataR(tk2dSpriteCollectionData _orig) : base(_orig) {}
public int CURRENT_VERSION
{
get => tk2dSpriteCollectionData.CURRENT_VERSION;
set => SetField(value);
}

public int version
{
get => orig.version;
set => orig.version = value;
}

public bool materialIdsValid
{
get => orig.materialIdsValid;
set => orig.materialIdsValid = value;
}

public bool needMaterialInstance
{
get => orig.needMaterialInstance;
set => orig.needMaterialInstance = value;
}

public tk2dSpriteDefinition[] spriteDefinitions
{
get => orig.spriteDefinitions;
set => orig.spriteDefinitions = value;
}

public System.Collections.Generic.Dictionary<System.String,System.Int32> spriteNameLookupDict
{
get => GetField<System.Collections.Generic.Dictionary<System.String,System.Int32>>();
set => SetField(value);
}

public bool premultipliedAlpha
{
get => orig.premultipliedAlpha;
set => orig.premultipliedAlpha = value;
}

public UnityEngine.Material material
{
get => orig.material;
set => orig.material = value;
}

public UnityEngine.Material[] materials
{
get => orig.materials;
set => orig.materials = value;
}

public UnityEngine.Material[] materialInsts
{
get => orig.materialInsts;
set => orig.materialInsts = value;
}

public UnityEngine.Texture2D[] textureInsts
{
get => orig.textureInsts;
set => orig.textureInsts = value;
}

public UnityEngine.Texture[] textures
{
get => orig.textures;
set => orig.textures = value;
}

public UnityEngine.TextAsset[] pngTextures
{
get => orig.pngTextures;
set => orig.pngTextures = value;
}

public System.Int32[] materialPngTextureId
{
get => orig.materialPngTextureId;
set => orig.materialPngTextureId = value;
}

public UnityEngine.FilterMode textureFilterMode
{
get => orig.textureFilterMode;
set => orig.textureFilterMode = value;
}

public bool textureMipMaps
{
get => orig.textureMipMaps;
set => orig.textureMipMaps = value;
}

public bool allowMultipleAtlases
{
get => orig.allowMultipleAtlases;
set => orig.allowMultipleAtlases = value;
}

public string spriteCollectionGUID
{
get => orig.spriteCollectionGUID;
set => orig.spriteCollectionGUID = value;
}

public string spriteCollectionName
{
get => orig.spriteCollectionName;
set => orig.spriteCollectionName = value;
}

public string assetName
{
get => orig.assetName;
set => orig.assetName = value;
}

public bool loadable
{
get => orig.loadable;
set => orig.loadable = value;
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

public int buildKey
{
get => orig.buildKey;
set => orig.buildKey = value;
}

public string dataGuid
{
get => orig.dataGuid;
set => orig.dataGuid = value;
}

public bool managedSpriteCollection
{
get => orig.managedSpriteCollection;
set => orig.managedSpriteCollection = value;
}

public bool hasPlatformData
{
get => orig.hasPlatformData;
set => orig.hasPlatformData = value;
}

public System.String[] spriteCollectionPlatforms
{
get => orig.spriteCollectionPlatforms;
set => orig.spriteCollectionPlatforms = value;
}

public System.String[] spriteCollectionPlatformGUIDs
{
get => orig.spriteCollectionPlatformGUIDs;
set => orig.spriteCollectionPlatformGUIDs = value;
}

public tk2dSpriteCollectionData platformSpecificData
{
get => GetField<tk2dSpriteCollectionData>();
set => SetField(value);
}

public string internalResourcePrefix
{
get => tk2dSpriteCollectionData.internalResourcePrefix;
set => SetField(value);
}

public bool Transient
{
get => orig.Transient;
set => orig.Transient = value;
}

public int Count
{
get => orig.Count;
}

public tk2dSpriteDefinition FirstValidDefinition
{
get => orig.FirstValidDefinition;
}

public int FirstValidDefinitionIndex
{
get => orig.FirstValidDefinitionIndex;
}

public tk2dSpriteCollectionData inst
{
get => orig.inst;
}



public int GetSpriteIdByName (string name) =>
orig.GetSpriteIdByName(name);

public int GetSpriteIdByName (string name, int defaultValue) =>
orig.GetSpriteIdByName(name, defaultValue);

public void ClearDictionary () =>
orig.ClearDictionary();

public tk2dSpriteDefinition GetSpriteDefinition (string name) =>
orig.GetSpriteDefinition(name);

public void InitDictionary () =>
orig.InitDictionary();

public bool IsValidSpriteId (int id) =>
orig.IsValidSpriteId(id);

public void InitMaterialIds () =>
orig.InitMaterialIds();

public void Init () =>
CallMethod();

public tk2dSpriteCollectionData CreateFromTexture (UnityEngine.Texture texture, tk2dSpriteCollectionSize size, System.String[] names, UnityEngine.Rect[] regions, UnityEngine.Vector2[] anchors) =>
tk2dSpriteCollectionData.CreateFromTexture(texture, size, names, regions, anchors);

public tk2dSpriteCollectionData CreateFromTexturePacker (tk2dSpriteCollectionSize size, string texturePackerData, UnityEngine.Texture texture) =>
tk2dSpriteCollectionData.CreateFromTexturePacker(size, texturePackerData, texture);

public void ResetPlatformData () =>
orig.ResetPlatformData();

public void DestroyTextureInsts () =>
CallMethod();

public void UnloadTextures () =>
orig.UnloadTextures();

public void DestroyMaterialInsts () =>
CallMethod();

public void OnDestroy () =>
CallMethod();

}
}
