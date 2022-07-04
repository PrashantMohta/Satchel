using TMPro;

namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of TMP_SubMesh allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class TMP_SubMeshR : InstanceClassWrapper<TMP_SubMesh>
{
    public TMP_SubMeshR(TMP_SubMesh _orig) : base(_orig)
    {
    }

    public TMP_FontAsset m_fontAsset
    {
        get => GetField<TMP_FontAsset>();
        set => SetField(value);
    }

    public TMP_SpriteAsset m_spriteAsset
    {
        get => GetField<TMP_SpriteAsset>();
        set => SetField(value);
    }

    public Material m_material
    {
        get => GetField<Material>();
        set => SetField(value);
    }

    public Material m_sharedMaterial
    {
        get => GetField<Material>();
        set => SetField(value);
    }

    public Material m_fallbackMaterial
    {
        get => GetField<Material>();
        set => SetField(value);
    }

    public Material m_fallbackSourceMaterial
    {
        get => GetField<Material>();
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

    public Renderer m_renderer
    {
        get => GetField<Renderer>();
        set => SetField(value);
    }

    public MeshFilter m_meshFilter
    {
        get => GetField<MeshFilter>();
        set => SetField(value);
    }

    public Mesh m_mesh
    {
        get => GetField<Mesh>();
        set => SetField(value);
    }

    public TextMeshPro m_TextComponent
    {
        get => GetField<TextMeshPro>();
        set => SetField(value);
    }

    public bool m_isRegisteredForEvents
    {
        get => GetField<bool>();
        set => SetField(value);
    }

    public TMP_FontAsset fontAsset
    {
        get => orig.fontAsset;
        set => orig.fontAsset = value;
    }

    public TMP_SpriteAsset spriteAsset
    {
        get => orig.spriteAsset;
        set => orig.spriteAsset = value;
    }

    public Material material
    {
        get => orig.material;
        set => orig.material = value;
    }

    public Material sharedMaterial
    {
        get => orig.sharedMaterial;
        set => orig.sharedMaterial = value;
    }

    public Material fallbackMaterial
    {
        get => orig.fallbackMaterial;
        set => orig.fallbackMaterial = value;
    }

    public Material fallbackSourceMaterial
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

    public Renderer renderer => orig.renderer;

    public MeshFilter meshFilter => orig.meshFilter;

    public Mesh mesh
    {
        get => orig.mesh;
        set => orig.mesh = value;
    }


    public void OnEnable()
    {
        CallMethod();
    }

    public void OnDisable()
    {
        CallMethod();
    }

    public void OnDestroy()
    {
        CallMethod();
    }

    public TMP_SubMesh AddSubTextObject(TextMeshPro textComponent, MaterialReference materialReference)
    {
        return TMP_SubMesh.AddSubTextObject(textComponent, materialReference);
    }

    public void DestroySelf()
    {
        orig.DestroySelf();
    }

    public Material GetMaterial(Material mat)
    {
        return CallMethod<Material>(new object[] { mat });
    }

    public Material CreateMaterialInstance(Material source)
    {
        return CallMethod<Material>(new object[] { source });
    }

    public Material GetSharedMaterial()
    {
        return CallMethod<Material>();
    }

    public void SetSharedMaterial(Material mat)
    {
        CallMethod(new object[] { mat });
    }

    public float GetPaddingForMaterial()
    {
        return orig.GetPaddingForMaterial();
    }

    public void UpdateMeshPadding(bool isExtraPadding, bool isUsingBold)
    {
        orig.UpdateMeshPadding(isExtraPadding, isUsingBold);
    }

    public void SetVerticesDirty()
    {
        orig.SetVerticesDirty();
    }

    public void SetMaterialDirty()
    {
        orig.SetMaterialDirty();
    }

    public void UpdateMaterial()
    {
        CallMethod();
    }
}