namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of InlineGraphic allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class InlineGraphicR:InstanceClassWrapper<TMPro.InlineGraphic>
{
public InlineGraphicR(TMPro.InlineGraphic _orig) : base(_orig) {}
public UnityEngine.Texture texture
{
get => orig.texture;
set => orig.texture = value;
}

public TMPro.InlineGraphicManager m_manager
{
get => GetField<TMPro.InlineGraphicManager>();
set => SetField(value);
}

public UnityEngine.RectTransform m_RectTransform
{
get => GetField<UnityEngine.RectTransform>();
set => SetField(value);
}

public UnityEngine.RectTransform m_ParentRectTransform
{
get => GetField<UnityEngine.RectTransform>();
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

public UnityEngine.Texture mainTexture
{
get => orig.mainTexture;
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

public UnityEngine.CanvasRenderer canvasRenderer
{
get => orig.canvasRenderer;
}

public UnityEngine.Material defaultMaterial
{
get => orig.defaultMaterial;
}

public UnityEngine.Material material
{
get => orig.material;
set => orig.material = value;
}

public UnityEngine.Material materialForRendering
{
get => orig.materialForRendering;
}



public void Awake () =>
CallMethod();

public void OnEnable () =>
CallMethod();

public void OnDisable () =>
CallMethod();

public void OnTransformParentChanged () =>
CallMethod();

public void OnRectTransformDimensionsChange () =>
CallMethod();

public void UpdateMaterial () =>
orig.UpdateMaterial();

public void UpdateGeometry () =>
CallMethod();

}
}
