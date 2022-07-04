using TMPro;

namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of TMP_SpriteAsset allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class TMP_SpriteAssetR : InstanceClassWrapper<TMP_SpriteAsset>
{
    public TMP_SpriteAssetR(TMP_SpriteAsset _orig) : base(_orig)
    {
    }

    public TMP_SpriteAsset m_defaultSpriteAsset
    {
        get => TMP_SpriteAsset.m_defaultSpriteAsset;
        set => TMP_SpriteAsset.m_defaultSpriteAsset = value;
    }

    public Texture spriteSheet
    {
        get => orig.spriteSheet;
        set => orig.spriteSheet = value;
    }

    public List<TMP_Sprite> spriteInfoList
    {
        get => orig.spriteInfoList;
        set => orig.spriteInfoList = value;
    }

    public List<Sprite> m_sprites
    {
        get => GetField<List<Sprite>>();
        set => SetField(value);
    }

    public int hashCode
    {
        get => orig.hashCode;
        set => orig.hashCode = value;
    }

    public Material material
    {
        get => orig.material;
        set => orig.material = value;
    }

    public int materialHashCode
    {
        get => orig.materialHashCode;
        set => orig.materialHashCode = value;
    }

    public TMP_SpriteAsset defaultSpriteAsset => TMP_SpriteAsset.defaultSpriteAsset;

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

    public void OnEnable()
    {
        CallMethod();
    }

    public Material GetDefaultSpriteMaterial()
    {
        return CallMethod<Material>();
    }

    public int GetSpriteIndex(int hashCode)
    {
        return orig.GetSpriteIndex(hashCode);
    }
}