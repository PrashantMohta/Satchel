namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of TMP_SubMesh allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class TMP_SubMeshR:InstanceClassWrapper<TMPro.TMP_SubMesh>
{
public TMP_SubMeshR(TMPro.TMP_SubMesh _orig) : base(_orig) {}
public TMPro.TMP_FontAsset m_fontAsset
{
get => GetField<TMPro.TMP_FontAsset>();
set => SetField(value);
}

public TMPro.TMP_SpriteAsset m_spriteAsset
{
get => GetField<TMPro.TMP_SpriteAsset>();
set => SetField(value);
}

public UnityEngine.Material m_material
{
get => GetField<UnityEngine.Material>();
set => SetField(value);
}

public UnityEngine.Material m_sharedMaterial
{
get => GetField<UnityEngine.Material>();
set => SetField(value);
}

public UnityEngine.Material m_fallbackMaterial
{
get => GetField<UnityEngine.Material>();
set => SetField(value);
}

public UnityEngine.Material m_fallbackSourceMaterial
{
get => GetField<UnityEngine.Material>();
set => SetField(value);
}

public bool m_isDefaultMaterial
{
get => GetField<bool>();
set => SetField(value);
}

public float m_padding
{
get => GetField<float>();
set => SetField(value);
}

public UnityEngine.Renderer m_renderer
{
get => GetField<UnityEngine.Renderer>();
set => SetField(value);
}

public UnityEngine.MeshFilter m_meshFilter
{
get => GetField<UnityEngine.MeshFilter>();
set => SetField(value);
}

public UnityEngine.Mesh m_mesh
{
get => GetField<UnityEngine.Mesh>();
set => SetField(value);
}

public TMPro.TextMeshPro m_TextComponent
{
get => GetField<TMPro.TextMeshPro>();
set => SetField(value);
}

public bool m_isRegisteredForEvents
{
get => GetField<bool>();
set => SetField(value);
}

public TMPro.TMP_FontAsset fontAsset
{
get => orig.fontAsset;
set => orig.fontAsset = value;
}

public TMPro.TMP_SpriteAsset spriteAsset
{
get => orig.spriteAsset;
set => orig.spriteAsset = value;
}

public UnityEngine.Material material
{
get => orig.material;
set => orig.material = value;
}

public UnityEngine.Material sharedMaterial
{
get => orig.sharedMaterial;
set => orig.sharedMaterial = value;
}

public UnityEngine.Material fallbackMaterial
{
get => orig.fallbackMaterial;
set => orig.fallbackMaterial = value;
}

public UnityEngine.Material fallbackSourceMaterial
{
get => orig.fallbackSourceMaterial;
set => orig.fallbackSourceMaterial = value;
}

public bool isDefaultMaterial
{
get => orig.isDefaultMaterial;
set => orig.isDefaultMaterial = value;
}

public float padding
{
get => orig.padding;
set => orig.padding = value;
}

public UnityEngine.Renderer renderer
{
get => orig.renderer;
}

public UnityEngine.MeshFilter meshFilter
{
get => orig.meshFilter;
}

public UnityEngine.Mesh mesh
{
get => orig.mesh;
set => orig.mesh = value;
}



public void OnEnable () =>
CallMethod();

public void OnDisable () =>
CallMethod();

public void OnDestroy () =>
CallMethod();

public TMPro.TMP_SubMesh AddSubTextObject (TMPro.TextMeshPro textComponent, TMPro.MaterialReference materialReference) =>
TMPro.TMP_SubMesh.AddSubTextObject(textComponent, materialReference);

public void DestroySelf () =>
orig.DestroySelf();

public UnityEngine.Material GetMaterial (UnityEngine.Material mat) =>
CallMethod<UnityEngine.Material>(new object[] {mat});

public UnityEngine.Material CreateMaterialInstance (UnityEngine.Material source) =>
CallMethod<UnityEngine.Material>(new object[] {source});

public UnityEngine.Material GetSharedMaterial () =>
CallMethod<UnityEngine.Material>();

public void SetSharedMaterial (UnityEngine.Material mat) =>
CallMethod(new object[] {mat});

public float GetPaddingForMaterial () =>
orig.GetPaddingForMaterial();

public void UpdateMeshPadding (bool isExtraPadding, bool isUsingBold) =>
orig.UpdateMeshPadding(isExtraPadding, isUsingBold);

public void SetVerticesDirty () =>
orig.SetVerticesDirty();

public void SetMaterialDirty () =>
orig.SetMaterialDirty();

public void UpdateMaterial () =>
CallMethod();

}
}
