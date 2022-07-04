using UnityEngine.UI.Extensions;

namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of SoftMaskScript allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class SoftMaskScriptR : InstanceClassWrapper<SoftMaskScript>
{
    public SoftMaskScriptR(SoftMaskScript _orig) : base(_orig)
    {
    }

    public Material mat
    {
        get => GetField<Material>();
        set => SetField(value);
    }

    public Canvas cachedCanvas
    {
        get => GetField<Canvas>();
        set => SetField(value);
    }

    public Transform cachedCanvasTransform
    {
        get => GetField<Transform>();
        set => SetField(value);
    }

    public Vector3[] m_WorldCorners
    {
        get => GetField<Vector3[]>();
        set => SetField(value);
    }

    public Vector3[] m_CanvasCorners
    {
        get => GetField<Vector3[]>();
        set => SetField(value);
    }

    public RectTransform MaskArea
    {
        get => orig.MaskArea;
        set => orig.MaskArea = value;
    }

    public Texture AlphaMask
    {
        get => orig.AlphaMask;
        set => orig.AlphaMask = value;
    }

    public float CutOff
    {
        get => orig.CutOff;
        set => orig.CutOff = value;
    }

    public bool HardBlend
    {
        get => orig.HardBlend;
        set => orig.HardBlend = value;
    }

    public bool FlipAlphaMask
    {
        get => orig.FlipAlphaMask;
        set => orig.FlipAlphaMask = value;
    }

    public Vector2 maskOffset
    {
        get => GetField<Vector2>();
        set => SetField(value);
    }

    public Vector2 maskScale
    {
        get => GetField<Vector2>();
        set => SetField(value);
    }


    public void Start()
    {
        CallMethod();
    }

    public void Update()
    {
        CallMethod();
    }

    public void SetMask()
    {
        CallMethod();
    }

    public Rect GetCanvasRect()
    {
        return orig.GetCanvasRect();
    }
}