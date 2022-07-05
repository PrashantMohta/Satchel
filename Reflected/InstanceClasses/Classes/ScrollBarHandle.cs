using UnityEngine.UI;

namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of ScrollBarHandle allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class ScrollBarHandleR : InstanceClassWrapper<ScrollBarHandle>
{
    public ScrollBarHandleR(ScrollBarHandle _orig) : base(_orig)
    {
    }

    public Scrollbar scrollBar
    {
        get => orig.scrollBar;
        set => orig.scrollBar = value;
    }

    public RectTransform trans
    {
        get => GetField<RectTransform>();
        set => SetField(value);
    }


    public void Awake()
    {
        CallMethod();
    }

    public void Start()
    {
        CallMethod();
    }

    public void UpdatePosition(float value)
    {
        CallMethod(new object[] { value });
    }
}