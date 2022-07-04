namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of MaterialReferenceManager allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class MaterialReferenceManagerR:InstanceClassWrapper<TMPro.MaterialReferenceManager>
{
public MaterialReferenceManagerR(TMPro.MaterialReferenceManager _orig) : base(_orig) {}
public TMPro.MaterialReferenceManager s_Instance
{
get => GetFieldStatic<TMPro.MaterialReferenceManager>();
set => SetField(value);
}

public System.Collections.Generic.Dictionary<System.Int32,UnityEngine.Material> m_FontMaterialReferenceLookup
{
get => GetField<System.Collections.Generic.Dictionary<System.Int32,UnityEngine.Material>>();
set => SetField(value);
}

public System.Collections.Generic.Dictionary<System.Int32,TMPro.TMP_FontAsset> m_FontAssetReferenceLookup
{
get => GetField<System.Collections.Generic.Dictionary<System.Int32,TMPro.TMP_FontAsset>>();
set => SetField(value);
}

public System.Collections.Generic.Dictionary<System.Int32,TMPro.TMP_SpriteAsset> m_SpriteAssetReferenceLookup
{
get => GetField<System.Collections.Generic.Dictionary<System.Int32,TMPro.TMP_SpriteAsset>>();
set => SetField(value);
}

public TMPro.MaterialReferenceManager instance
{
get => TMPro.MaterialReferenceManager.instance;
}

public void AddFontAsset (TMPro.TMP_FontAsset fontAsset) =>
TMPro.MaterialReferenceManager.AddFontAsset(fontAsset);

public void AddFontAssetInternal (TMPro.TMP_FontAsset fontAsset) =>
CallMethod(new object[] {fontAsset});

public void AddSpriteAsset (TMPro.TMP_SpriteAsset spriteAsset) =>
TMPro.MaterialReferenceManager.AddSpriteAsset(spriteAsset);

public void AddSpriteAssetInternal (TMPro.TMP_SpriteAsset spriteAsset) =>
CallMethod(new object[] {spriteAsset});

public void AddSpriteAsset (int hashCode, TMPro.TMP_SpriteAsset spriteAsset) =>
TMPro.MaterialReferenceManager.AddSpriteAsset(hashCode, spriteAsset);

public void AddSpriteAssetInternal (int hashCode, TMPro.TMP_SpriteAsset spriteAsset) =>
CallMethod(new object[] {hashCode, spriteAsset});

public void AddFontMaterial (int hashCode, UnityEngine.Material material) =>
TMPro.MaterialReferenceManager.AddFontMaterial(hashCode, material);

public void AddFontMaterialInternal (int hashCode, UnityEngine.Material material) =>
CallMethod(new object[] {hashCode, material});

public bool Contains (TMPro.TMP_FontAsset font) =>
orig.Contains(font);

public bool Contains (TMPro.TMP_SpriteAsset sprite) =>
orig.Contains(sprite);

public bool TryGetFontAsset (int hashCode, out TMPro.TMP_FontAsset fontAsset) =>
TMPro.MaterialReferenceManager.TryGetFontAsset(hashCode, out fontAsset);

public bool TryGetFontAssetInternal (int hashCode, TMPro.TMP_FontAsset fontAsset) =>
CallMethod<bool>(new object[] {hashCode, fontAsset});

public bool TryGetSpriteAsset (int hashCode, out TMPro.TMP_SpriteAsset spriteAsset) =>
TMPro.MaterialReferenceManager.TryGetSpriteAsset(hashCode, out spriteAsset);

public bool TryGetSpriteAssetInternal (int hashCode, TMPro.TMP_SpriteAsset spriteAsset) =>
CallMethod<bool>(new object[] {hashCode, spriteAsset});

public bool TryGetMaterial (int hashCode, out UnityEngine.Material material) =>
TMPro.MaterialReferenceManager.TryGetMaterial(hashCode, out material);

public bool TryGetMaterialInternal (int hashCode, UnityEngine.Material material) =>
CallMethod<bool>(new object[] {hashCode, material});

}
}
