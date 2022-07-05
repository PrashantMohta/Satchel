using TMPro;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of TMP_SubMeshUI allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class TMP_SubMeshUIR : InstanceClassWrapper<TMP_SubMeshUI>
{
    public TMP_SubMeshUIR(TMP_SubMeshUI _orig) : base(_orig)
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

    public CanvasRenderer m_canvasRenderer
    {
        get => GetField<CanvasRenderer>();
        set => SetField(value);
    }

    public Mesh m_mesh
    {
        get => GetField<Mesh>();
        set => SetField(value);
    }

    public TextMeshProUGUI m_TextComponent
    {
        get => GetField<TextMeshProUGUI>();
        set => SetField(value);
    }

    public bool m_isRegisteredForEvents
    {
        get => GetField<bool>();
        set => SetField(value);
    }

    public bool m_materialDirty
    {
        get => GetField<bool>();
        set => SetField(value);
    }

    public int m_materialReferenceIndex
    {
        get => GetField<int>();
        set => SetField(value);
    }

    public bool m_ShouldRecalculateStencil
    {
        get => GetField<bool>();
        set => SetField(value);
    }

    public Material m_MaskMaterial
    {
        get => GetField<Material>();
        set => SetField(value);
    }

    public bool m_IncludeForMasking
    {
        get => GetField<bool>();
        set => SetField(value);
    }

    public bool m_ShouldRecalculate
    {
        get => GetField<bool>();
        set => SetField(value);
    }

    public int m_StencilValue
    {
        get => GetField<int>();
        set => SetField(value);
    }

    public Material m_Material
    {
        get => GetField<Material>();
        set => SetField(value);
    }

    public bool m_SkipLayoutUpdate
    {
        get => GetField<bool>();
        set => SetField(value);
    }

    public bool m_SkipMaterialUpdate
    {
        get => GetField<bool>();
        set => SetField(value);
    }

    public UnityAction m_OnDirtyLayoutCallback
    {
        get => GetField<UnityAction>();
        set => SetField(value);
    }

    public UnityAction m_OnDirtyVertsCallback
    {
        get => GetField<UnityAction>();
        set => SetField(value);
    }

    public UnityAction m_OnDirtyMaterialCallback
    {
        get => GetField<UnityAction>();
        set => SetField(value);
    }

    public Mesh m_CachedMesh
    {
        get => GetField<Mesh>();
        set => SetField(value);
    }

    public Vector2[] m_CachedUvs
    {
        get => GetField<Vector2[]>();
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

    public Texture mainTexture => orig.mainTexture;

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

    public Material materialForRendering => orig.materialForRendering;

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

    public CanvasRenderer canvasRenderer => orig.canvasRenderer;

    public Mesh mesh
    {
        get => orig.mesh;
        set => orig.mesh = value;
    }

    public bool maskable
    {
        get => orig.maskable;
        set => orig.maskable = value;
    }

    public bool isMaskingGraphic
    {
        get => orig.isMaskingGraphic;
        set => orig.isMaskingGraphic = value;
    }

    public Color color
    {
        get => orig.color;
        set => orig.color = value;
    }

    public bool raycastTarget
    {
        get => orig.raycastTarget;
        set => orig.raycastTarget = value;
    }

    public Vector4 raycastPadding
    {
        get => orig.raycastPadding;
        set => orig.raycastPadding = value;
    }

    public bool useLegacyMeshGeneration
    {
        get => GetProperty<bool>();
        set => SetProperty(value);
    }

    public int depth => orig.depth;

    public RectTransform rectTransform => orig.rectTransform;

    public Canvas canvas => orig.canvas;

    public Material defaultMaterial => orig.defaultMaterial;


    public TMP_SubMeshUI AddSubTextObject(TextMeshProUGUI textComponent, MaterialReference materialReference)
    {
        return TMP_SubMeshUI.AddSubTextObject(textComponent, materialReference);
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

    public void OnTransformParentChanged()
    {
        CallMethod();
    }

    public Material GetModifiedMaterial(Material baseMaterial)
    {
        return orig.GetModifiedMaterial(baseMaterial);
    }

    public float GetPaddingForMaterial()
    {
        return orig.GetPaddingForMaterial();
    }

    public float GetPaddingForMaterial(Material mat)
    {
        return orig.GetPaddingForMaterial(mat);
    }

    public void UpdateMeshPadding(bool isExtraPadding, bool isUsingBold)
    {
        orig.UpdateMeshPadding(isExtraPadding, isUsingBold);
    }

    public void SetAllDirty()
    {
        orig.SetAllDirty();
    }

    public void SetVerticesDirty()
    {
        orig.SetVerticesDirty();
    }

    public void SetLayoutDirty()
    {
        orig.SetLayoutDirty();
    }

    public void SetMaterialDirty()
    {
        orig.SetMaterialDirty();
    }

    public void SetPivotDirty()
    {
        orig.SetPivotDirty();
    }

    public void UpdateGeometry()
    {
        CallMethod();
    }

    public void Rebuild(CanvasUpdate update)
    {
        orig.Rebuild(update);
    }

    public void RefreshMaterial()
    {
        orig.RefreshMaterial();
    }

    public void UpdateMaterial()
    {
        CallMethod();
    }

    public void RecalculateClipping()
    {
        orig.RecalculateClipping();
    }

    public void RecalculateMasking()
    {
        orig.RecalculateMasking();
    }

    public Material GetMaterial()
    {
        return CallMethod<Material>();
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
}