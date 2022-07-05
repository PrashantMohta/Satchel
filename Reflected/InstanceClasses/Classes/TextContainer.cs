using TMPro;

namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of TextContainer allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class TextContainerR : InstanceClassWrapper<TextContainer>
{
    public TextContainerR(TextContainer _orig) : base(_orig)
    {
    }

    public bool m_hasChanged
    {
        get => GetField<bool>();
        set => SetField(value);
    }

    public Vector2 m_pivot
    {
        get => GetField<Vector2>();
        set => SetField(value);
    }

    public TextContainerAnchors m_anchorPosition
    {
        get => GetField<TextContainerAnchors>();
        set => SetField(value);
    }

    public Rect m_rect
    {
        get => GetField<Rect>();
        set => SetField(value);
    }

    public bool m_isDefaultWidth
    {
        get => GetField<bool>();
        set => SetField(value);
    }

    public bool m_isDefaultHeight
    {
        get => GetField<bool>();
        set => SetField(value);
    }

    public bool m_isAutoFitting
    {
        get => GetField<bool>();
        set => SetField(value);
    }

    public Vector3[] m_corners
    {
        get => GetField<Vector3[]>();
        set => SetField(value);
    }

    public Vector3[] m_worldCorners
    {
        get => GetField<Vector3[]>();
        set => SetField(value);
    }

    public Vector4 m_margins
    {
        get => GetField<Vector4>();
        set => SetField(value);
    }

    public RectTransform m_rectTransform
    {
        get => GetField<RectTransform>();
        set => SetField(value);
    }

    public Vector2 k_defaultSize
    {
        get => GetFieldStatic<Vector2>();
        set => SetField(value);
    }

    public TextMeshPro m_textMeshPro
    {
        get => GetField<TextMeshPro>();
        set => SetField(value);
    }

    public bool hasChanged
    {
        get => orig.hasChanged;
        set => orig.hasChanged = value;
    }

    public Vector2 pivot
    {
        get => orig.pivot;
        set => orig.pivot = value;
    }

    public TextContainerAnchors anchorPosition
    {
        get => orig.anchorPosition;
        set => orig.anchorPosition = value;
    }

    public Rect rect
    {
        get => orig.rect;
        set => orig.rect = value;
    }

    public Vector2 size
    {
        get => orig.size;
        set => orig.size = value;
    }

    public float width
    {
        get => orig.width;
        set => orig.width = value;
    }

    public float height
    {
        get => orig.height;
        set => orig.height = value;
    }

    public bool isDefaultWidth => orig.isDefaultWidth;

    public bool isDefaultHeight => orig.isDefaultHeight;

    public bool isAutoFitting
    {
        get => orig.isAutoFitting;
        set => orig.isAutoFitting = value;
    }

    public Vector3[] corners => orig.corners;

    public Vector3[] worldCorners => orig.worldCorners;

    public Vector4 margins
    {
        get => orig.margins;
        set => orig.margins = value;
    }

    public RectTransform rectTransform => orig.rectTransform;

    public TextMeshPro textMeshPro => orig.textMeshPro;


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

    public void OnContainerChanged()
    {
        CallMethod();
    }

    public void OnRectTransformDimensionsChange()
    {
        CallMethod();
    }

    public void SetRect(Vector2 size)
    {
        CallMethod(new object[] { size });
    }

    public void UpdateCorners()
    {
        CallMethod();
    }

    public Vector2 GetPivot(TextContainerAnchors anchor)
    {
        return CallMethod<Vector2>(new object[] { anchor });
    }

    public TextContainerAnchors GetAnchorPosition(Vector2 pivot)
    {
        return CallMethod<TextContainerAnchors>(new object[] { pivot });
    }
}