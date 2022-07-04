namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of InlineGraphicManager allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class InlineGraphicManagerR:InstanceClassWrapper<TMPro.InlineGraphicManager>
{
public InlineGraphicManagerR(TMPro.InlineGraphicManager _orig) : base(_orig) {}
public TMPro.TMP_SpriteAsset m_spriteAsset
{
get => GetField<TMPro.TMP_SpriteAsset>();
set => SetField(value);
}

public TMPro.InlineGraphic m_inlineGraphic
{
get => GetField<TMPro.InlineGraphic>();
set => SetField(value);
}

public UnityEngine.CanvasRenderer m_inlineGraphicCanvasRenderer
{
get => GetField<UnityEngine.CanvasRenderer>();
set => SetField(value);
}

public UnityEngine.UIVertex[] m_uiVertex
{
get => GetField<UnityEngine.UIVertex[]>();
set => SetField(value);
}

public UnityEngine.RectTransform m_inlineGraphicRectTransform
{
get => GetField<UnityEngine.RectTransform>();
set => SetField(value);
}

public TMPro.TMP_Text m_textComponent
{
get => GetField<TMPro.TMP_Text>();
set => SetField(value);
}

public bool m_isInitialized
{
get => GetField<bool>();
set => SetField(value);
}

public TMPro.TMP_SpriteAsset spriteAsset
{
get => orig.spriteAsset;
set => orig.spriteAsset = value;
}

public TMPro.InlineGraphic inlineGraphic
{
get => orig.inlineGraphic;
set => orig.inlineGraphic = value;
}

public UnityEngine.CanvasRenderer canvasRenderer
{
get => orig.canvasRenderer;
}

public UnityEngine.UIVertex[] uiVertex
{
get => orig.uiVertex;
}



public void Awake () =>
CallMethod();

public void OnEnable () =>
CallMethod();

public void OnDisable () =>
CallMethod();

public void OnDestroy () =>
CallMethod();

public void LoadSpriteAsset (TMPro.TMP_SpriteAsset spriteAsset) =>
CallMethod(new object[] {spriteAsset});

public void AddInlineGraphicsChild () =>
orig.AddInlineGraphicsChild();

public void AllocatedVertexBuffers (int size) =>
orig.AllocatedVertexBuffers(size);

public void UpdatePivot (UnityEngine.Vector2 pivot) =>
orig.UpdatePivot(pivot);

public void ClearUIVertex () =>
orig.ClearUIVertex();

public void DrawSprite (UnityEngine.UIVertex[] uiVertices, int spriteCount) =>
orig.DrawSprite(uiVertices, spriteCount);

public TMPro.TMP_Sprite GetSprite (int index) =>
orig.GetSprite(index);

public int GetSpriteIndexByHashCode (int hashCode) =>
orig.GetSpriteIndexByHashCode(hashCode);

public int GetSpriteIndexByIndex (int index) =>
orig.GetSpriteIndexByIndex(index);

public void SetUIVertex (UnityEngine.UIVertex[] uiVertex) =>
orig.SetUIVertex(uiVertex);

}
}
