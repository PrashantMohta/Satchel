namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of TMP_SpriteAsset allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class TMP_SpriteAssetR:InstanceClassWrapper<TMPro.TMP_SpriteAsset>
{
public TMP_SpriteAssetR(TMPro.TMP_SpriteAsset _orig) : base(_orig) {}
public TMPro.TMP_SpriteAsset m_defaultSpriteAsset
{
get => TMPro.TMP_SpriteAsset.m_defaultSpriteAsset;
set => TMPro.TMP_SpriteAsset.m_defaultSpriteAsset = value;
}

public UnityEngine.Texture spriteSheet
{
get => orig.spriteSheet;
set => orig.spriteSheet = value;
}

public System.Collections.Generic.List<TMPro.TMP_Sprite> spriteInfoList
{
get => orig.spriteInfoList;
set => orig.spriteInfoList = value;
}

public System.Collections.Generic.List<UnityEngine.Sprite> m_sprites
{
get => GetField<System.Collections.Generic.List<UnityEngine.Sprite>>();
set => SetField(value);
}

public int hashCode
{
get => orig.hashCode;
set => orig.hashCode = value;
}

public UnityEngine.Material material
{
get => orig.material;
set => orig.material = value;
}

public int materialHashCode
{
get => orig.materialHashCode;
set => orig.materialHashCode = value;
}

public TMPro.TMP_SpriteAsset defaultSpriteAsset
{
get => TMPro.TMP_SpriteAsset.defaultSpriteAsset;
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

public void OnEnable () =>
CallMethod();

public UnityEngine.Material GetDefaultSpriteMaterial () =>
CallMethod<UnityEngine.Material>();

public int GetSpriteIndex (int hashCode) =>
orig.GetSpriteIndex(hashCode);

}
}
