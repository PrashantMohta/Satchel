namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of TMP_SubMeshUI allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class TMP_SubMeshUIR:InstanceClassWrapper<TMPro.TMP_SubMeshUI>
{
public TMP_SubMeshUIR(TMPro.TMP_SubMeshUI _orig) : base(_orig) {}
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

public UnityEngine.CanvasRenderer m_canvasRenderer
{
get => GetField<UnityEngine.CanvasRenderer>();
set => SetField(value);
}

public UnityEngine.Mesh m_mesh
{
get => GetField<UnityEngine.Mesh>();
set => SetField(value);
}

public TMPro.TextMeshProUGUI m_TextComponent
{
get => GetField<TMPro.TextMeshProUGUI>();
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

public UnityEngine.Material m_MaskMaterial
{
get => GetField<UnityEngine.Material>();
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

public UnityEngine.Material m_Material
{
get => GetField<UnityEngine.Material>();
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

public UnityEngine.Events.UnityAction m_OnDirtyLayoutCallback
{
get => GetField<UnityEngine.Events.UnityAction>();
set => SetField(value);
}

public UnityEngine.Events.UnityAction m_OnDirtyVertsCallback
{
get => GetField<UnityEngine.Events.UnityAction>();
set => SetField(value);
}

public UnityEngine.Events.UnityAction m_OnDirtyMaterialCallback
{
get => GetField<UnityEngine.Events.UnityAction>();
set => SetField(value);
}

public UnityEngine.Mesh m_CachedMesh
{
get => GetField<UnityEngine.Mesh>();
set => SetField(value);
}

public UnityEngine.Vector2[] m_CachedUvs
{
get => GetField<UnityEngine.Vector2[]>();
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

public UnityEngine.Texture mainTexture
{
get => orig.mainTexture;
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

public UnityEngine.Material materialForRendering
{
get => orig.materialForRendering;
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

public UnityEngine.CanvasRenderer canvasRenderer
{
get => orig.canvasRenderer;
}

public UnityEngine.Mesh mesh
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

public UnityEngine.Color color
{
get => orig.color;
set => orig.color = value;
}

public bool raycastTarget
{
get => orig.raycastTarget;
set => orig.raycastTarget = value;
}

public UnityEngine.Vector4 raycastPadding
{
get => orig.raycastPadding;
set => orig.raycastPadding = value;
}

public bool useLegacyMeshGeneration
{
get => GetProperty<bool>();
set => SetProperty(value);
}

public int depth
{
get => orig.depth;
}

public UnityEngine.RectTransform rectTransform
{
get => orig.rectTransform;
}

public UnityEngine.Canvas canvas
{
get => orig.canvas;
}

public UnityEngine.Material defaultMaterial
{
get => orig.defaultMaterial;
}



public TMPro.TMP_SubMeshUI AddSubTextObject (TMPro.TextMeshProUGUI textComponent, TMPro.MaterialReference materialReference) =>
TMPro.TMP_SubMeshUI.AddSubTextObject(textComponent, materialReference);

public void OnEnable () =>
CallMethod();

public void OnDisable () =>
CallMethod();

public void OnDestroy () =>
CallMethod();

public void OnTransformParentChanged () =>
CallMethod();

public UnityEngine.Material GetModifiedMaterial (UnityEngine.Material baseMaterial) =>
orig.GetModifiedMaterial(baseMaterial);

public float GetPaddingForMaterial () =>
orig.GetPaddingForMaterial();

public float GetPaddingForMaterial (UnityEngine.Material mat) =>
orig.GetPaddingForMaterial(mat);

public void UpdateMeshPadding (bool isExtraPadding, bool isUsingBold) =>
orig.UpdateMeshPadding(isExtraPadding, isUsingBold);

public void SetAllDirty () =>
orig.SetAllDirty();

public void SetVerticesDirty () =>
orig.SetVerticesDirty();

public void SetLayoutDirty () =>
orig.SetLayoutDirty();

public void SetMaterialDirty () =>
orig.SetMaterialDirty();

public void SetPivotDirty () =>
orig.SetPivotDirty();

public void UpdateGeometry () =>
CallMethod();

public void Rebuild (UnityEngine.UI.CanvasUpdate update) =>
orig.Rebuild(update);

public void RefreshMaterial () =>
orig.RefreshMaterial();

public void UpdateMaterial () =>
CallMethod();

public void RecalculateClipping () =>
orig.RecalculateClipping();

public void RecalculateMasking () =>
orig.RecalculateMasking();

public UnityEngine.Material GetMaterial () =>
CallMethod<UnityEngine.Material>();

public UnityEngine.Material GetMaterial (UnityEngine.Material mat) =>
CallMethod<UnityEngine.Material>(new object[] {mat});

public UnityEngine.Material CreateMaterialInstance (UnityEngine.Material source) =>
CallMethod<UnityEngine.Material>(new object[] {source});

public UnityEngine.Material GetSharedMaterial () =>
CallMethod<UnityEngine.Material>();

public void SetSharedMaterial (UnityEngine.Material mat) =>
CallMethod(new object[] {mat});


}
}
