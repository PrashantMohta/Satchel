namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of tk2dUILayoutContainerSizer allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class tk2dUILayoutContainerSizerR : InstanceClassWrapper<tk2dUILayoutContainerSizer>
{
    public tk2dUILayoutContainerSizerR(tk2dUILayoutContainerSizer _orig) : base(_orig)
    {
    }

    public bool horizontal
    {
        get => orig.horizontal;
        set => orig.horizontal = value;
    }

    public bool expand
    {
        get => orig.expand;
        set => orig.expand = value;
    }

    public Vector2 margin
    {
        get => orig.margin;
        set => orig.margin = value;
    }

    public float spacing
    {
        get => orig.spacing;
        set => orig.spacing = value;
    }

    public Vector2 innerSize
    {
        get => GetField<Vector2>();
        set => SetField(value);
    }

    public Vector3 bMin
    {
        get => orig.bMin;
        set => orig.bMin = value;
    }

    public Vector3 bMax
    {
        get => orig.bMax;
        set => orig.bMax = value;
    }

    public List<tk2dUILayoutItem> layoutItems
    {
        get => orig.layoutItems;
        set => orig.layoutItems = value;
    }

    public bool autoResizeCollider
    {
        get => orig.autoResizeCollider;
        set => orig.autoResizeCollider = value;
    }

    public int ItemCount => orig.ItemCount;


    public void DoChildLayout()
    {
        CallMethod();
    }
}