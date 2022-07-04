using TMPro;
using UnityEngine.Events;

namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of InlineGraphic allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class InlineGraphicR : InstanceClassWrapper<InlineGraphic>
{
    public InlineGraphicR(InlineGraphic _orig) : base(_orig)
    {
    }

    public Texture texture
    {
        get => orig.texture;
        set => orig.texture = value;
    }

    public InlineGraphicManager m_manager
    {
        get => GetField<InlineGraphicManager>();
        set => SetField(value);
    }

    public RectTransform m_RectTransform
    {
        get => GetField<RectTransform>();
        set => SetField(value);
    }

    public RectTransform m_ParentRectTransform
    {
        get => GetField<RectTransform>();
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

    public Texture mainTexture => orig.mainTexture;

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

    public CanvasRenderer canvasRenderer => orig.canvasRenderer;

    public Material defaultMaterial => orig.defaultMaterial;

    public Material material
    {
        get => orig.material;
        set => orig.material = value;
    }

    public Material materialForRendering => orig.materialForRendering;


    public void Awake()
    {
        CallMethod();
    }

    public void OnEnable()
    {
        CallMethod();
    }

    public void OnDisable()
    {
        CallMethod();
    }

    public void OnTransformParentChanged()
    {
        CallMethod();
    }

    public void OnRectTransformDimensionsChange()
    {
        CallMethod();
    }

    public void UpdateMaterial()
    {
        orig.UpdateMaterial();
    }

    public void UpdateGeometry()
    {
        CallMethod();
    }
}