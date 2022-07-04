namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of TextContainer allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class TextContainerR:InstanceClassWrapper<TMPro.TextContainer>
{
public TextContainerR(TMPro.TextContainer _orig) : base(_orig) {}
public bool m_hasChanged
{
get => GetField<bool>();
set => SetField(value);
}

public UnityEngine.Vector2 m_pivot
{
get => GetField<UnityEngine.Vector2>();
set => SetField(value);
}

public TMPro.TextContainerAnchors m_anchorPosition
{
get => GetField<TMPro.TextContainerAnchors>();
set => SetField(value);
}

public UnityEngine.Rect m_rect
{
get => GetField<UnityEngine.Rect>();
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

public UnityEngine.Vector3[] m_corners
{
get => GetField<UnityEngine.Vector3[]>();
set => SetField(value);
}

public UnityEngine.Vector3[] m_worldCorners
{
get => GetField<UnityEngine.Vector3[]>();
set => SetField(value);
}

public UnityEngine.Vector4 m_margins
{
get => GetField<UnityEngine.Vector4>();
set => SetField(value);
}

public UnityEngine.RectTransform m_rectTransform
{
get => GetField<UnityEngine.RectTransform>();
set => SetField(value);
}

public UnityEngine.Vector2 k_defaultSize
{
get => GetFieldStatic<UnityEngine.Vector2>();
set => SetField(value);
}

public TMPro.TextMeshPro m_textMeshPro
{
get => GetField<TMPro.TextMeshPro>();
set => SetField(value);
}

public bool hasChanged
{
get => orig.hasChanged;
set => orig.hasChanged = value;
}

public UnityEngine.Vector2 pivot
{
get => orig.pivot;
set => orig.pivot = value;
}

public TMPro.TextContainerAnchors anchorPosition
{
get => orig.anchorPosition;
set => orig.anchorPosition = value;
}

public UnityEngine.Rect rect
{
get => orig.rect;
set => orig.rect = value;
}

public UnityEngine.Vector2 size
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

public bool isDefaultWidth
{
get => orig.isDefaultWidth;
}

public bool isDefaultHeight
{
get => orig.isDefaultHeight;
}

public bool isAutoFitting
{
get => orig.isAutoFitting;
set => orig.isAutoFitting = value;
}

public UnityEngine.Vector3[] corners
{
get => orig.corners;
}

public UnityEngine.Vector3[] worldCorners
{
get => orig.worldCorners;
}

public UnityEngine.Vector4 margins
{
get => orig.margins;
set => orig.margins = value;
}

public UnityEngine.RectTransform rectTransform
{
get => orig.rectTransform;
}

public TMPro.TextMeshPro textMeshPro
{
get => orig.textMeshPro;
}



public void Awake () =>
CallMethod();

public void OnEnable () =>
CallMethod();

public void OnDisable () =>
CallMethod();

public void OnContainerChanged () =>
CallMethod();

public void OnRectTransformDimensionsChange () =>
CallMethod();

public void SetRect (UnityEngine.Vector2 size) =>
CallMethod(new object[] {size});

public void UpdateCorners () =>
CallMethod();

public UnityEngine.Vector2 GetPivot (TMPro.TextContainerAnchors anchor) =>
CallMethod<UnityEngine.Vector2>(new object[] {anchor});

public TMPro.TextContainerAnchors GetAnchorPosition (UnityEngine.Vector2 pivot) =>
CallMethod<TMPro.TextContainerAnchors>(new object[] {pivot});

}
}
