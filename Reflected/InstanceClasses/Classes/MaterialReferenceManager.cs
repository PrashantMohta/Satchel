using TMPro;

namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of MaterialReferenceManager allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class MaterialReferenceManagerR : InstanceClassWrapper<MaterialReferenceManager>
{
    public MaterialReferenceManagerR(MaterialReferenceManager _orig) : base(_orig)
    {
    }

    public MaterialReferenceManager s_Instance
    {
        get => GetFieldStatic<MaterialReferenceManager>();
        set => SetField(value);
    }

    public Dictionary<int, Material> m_FontMaterialReferenceLookup
    {
        get => GetField<Dictionary<int, Material>>();
        set => SetField(value);
    }

    public Dictionary<int, TMP_FontAsset> m_FontAssetReferenceLookup
    {
        get => GetField<Dictionary<int, TMP_FontAsset>>();
        set => SetField(value);
    }

    public Dictionary<int, TMP_SpriteAsset> m_SpriteAssetReferenceLookup
    {
        get => GetField<Dictionary<int, TMP_SpriteAsset>>();
        set => SetField(value);
    }

    public MaterialReferenceManager instance => MaterialReferenceManager.instance;

    public void AddFontAsset(TMP_FontAsset fontAsset)
    {
        MaterialReferenceManager.AddFontAsset(fontAsset);
    }

    public void AddFontAssetInternal(TMP_FontAsset fontAsset)
    {
        CallMethod(new object[] { fontAsset });
    }

    public void AddSpriteAsset(TMP_SpriteAsset spriteAsset)
    {
        MaterialReferenceManager.AddSpriteAsset(spriteAsset);
    }

    public void AddSpriteAssetInternal(TMP_SpriteAsset spriteAsset)
    {
        CallMethod(new object[] { spriteAsset });
    }

    public void AddSpriteAsset(int hashCode, TMP_SpriteAsset spriteAsset)
    {
        MaterialReferenceManager.AddSpriteAsset(hashCode, spriteAsset);
    }

    public void AddSpriteAssetInternal(int hashCode, TMP_SpriteAsset spriteAsset)
    {
        CallMethod(new object[] { hashCode, spriteAsset });
    }

    public void AddFontMaterial(int hashCode, Material material)
    {
        MaterialReferenceManager.AddFontMaterial(hashCode, material);
    }

    public void AddFontMaterialInternal(int hashCode, Material material)
    {
        CallMethod(new object[] { hashCode, material });
    }

    public bool Contains(TMP_FontAsset font)
    {
        return orig.Contains(font);
    }

    public bool Contains(TMP_SpriteAsset sprite)
    {
        return orig.Contains(sprite);
    }

    public bool TryGetFontAsset(int hashCode, out TMP_FontAsset fontAsset)
    {
        return MaterialReferenceManager.TryGetFontAsset(hashCode, out fontAsset);
    }

    public bool TryGetFontAssetInternal(int hashCode, TMP_FontAsset fontAsset)
    {
        return CallMethod<bool>(new object[] { hashCode, fontAsset });
    }

    public bool TryGetSpriteAsset(int hashCode, out TMP_SpriteAsset spriteAsset)
    {
        return MaterialReferenceManager.TryGetSpriteAsset(hashCode, out spriteAsset);
    }

    public bool TryGetSpriteAssetInternal(int hashCode, TMP_SpriteAsset spriteAsset)
    {
        return CallMethod<bool>(new object[] { hashCode, spriteAsset });
    }

    public bool TryGetMaterial(int hashCode, out Material material)
    {
        return MaterialReferenceManager.TryGetMaterial(hashCode, out material);
    }

    public bool TryGetMaterialInternal(int hashCode, Material material)
    {
        return CallMethod<bool>(new object[] { hashCode, material });
    }
}