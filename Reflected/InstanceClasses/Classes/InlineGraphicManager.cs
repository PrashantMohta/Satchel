using TMPro;

namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of InlineGraphicManager allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class InlineGraphicManagerR : InstanceClassWrapper<InlineGraphicManager>
{
    public InlineGraphicManagerR(InlineGraphicManager _orig) : base(_orig)
    {
    }

    public TMP_SpriteAsset m_spriteAsset
    {
        get => GetField<TMP_SpriteAsset>();
        set => SetField(value);
    }

    public InlineGraphic m_inlineGraphic
    {
        get => GetField<InlineGraphic>();
        set => SetField(value);
    }

    public CanvasRenderer m_inlineGraphicCanvasRenderer
    {
        get => GetField<CanvasRenderer>();
        set => SetField(value);
    }

    public UIVertex[] m_uiVertex
    {
        get => GetField<UIVertex[]>();
        set => SetField(value);
    }

    public RectTransform m_inlineGraphicRectTransform
    {
        get => GetField<RectTransform>();
        set => SetField(value);
    }

    public TMP_Text m_textComponent
    {
        get => GetField<TMP_Text>();
        set => SetField(value);
    }

    public bool m_isInitialized
    {
        get => GetField<bool>();
        set => SetField(value);
    }

    public TMP_SpriteAsset spriteAsset
    {
        get => orig.spriteAsset;
        set => orig.spriteAsset = value;
    }

    public InlineGraphic inlineGraphic
    {
        get => orig.inlineGraphic;
        set => orig.inlineGraphic = value;
    }

    public CanvasRenderer canvasRenderer => orig.canvasRenderer;

    public UIVertex[] uiVertex => orig.uiVertex;


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

    public void OnDestroy()
    {
        CallMethod();
    }

    public void LoadSpriteAsset(TMP_SpriteAsset spriteAsset)
    {
        CallMethod(new object[] { spriteAsset });
    }

    public void AddInlineGraphicsChild()
    {
        orig.AddInlineGraphicsChild();
    }

    public void AllocatedVertexBuffers(int size)
    {
        orig.AllocatedVertexBuffers(size);
    }

    public void UpdatePivot(Vector2 pivot)
    {
        orig.UpdatePivot(pivot);
    }

    public void ClearUIVertex()
    {
        orig.ClearUIVertex();
    }

    public void DrawSprite(UIVertex[] uiVertices, int spriteCount)
    {
        orig.DrawSprite(uiVertices, spriteCount);
    }

    public TMP_Sprite GetSprite(int index)
    {
        return orig.GetSprite(index);
    }

    public int GetSpriteIndexByHashCode(int hashCode)
    {
        return orig.GetSpriteIndexByHashCode(hashCode);
    }

    public int GetSpriteIndexByIndex(int index)
    {
        return orig.GetSpriteIndexByIndex(index);
    }

    public void SetUIVertex(UIVertex[] uiVertex)
    {
        orig.SetUIVertex(uiVertex);
    }
}