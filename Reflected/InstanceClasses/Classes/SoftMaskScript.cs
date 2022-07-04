namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of SoftMaskScript allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class SoftMaskScriptR:InstanceClassWrapper<UnityEngine.UI.Extensions.SoftMaskScript>
{
public SoftMaskScriptR(UnityEngine.UI.Extensions.SoftMaskScript _orig) : base(_orig) {}
public UnityEngine.Material mat
{
get => GetField<UnityEngine.Material>();
set => SetField(value);
}

public UnityEngine.Canvas cachedCanvas
{
get => GetField<UnityEngine.Canvas>();
set => SetField(value);
}

public UnityEngine.Transform cachedCanvasTransform
{
get => GetField<UnityEngine.Transform>();
set => SetField(value);
}

public UnityEngine.Vector3[] m_WorldCorners
{
get => GetField<UnityEngine.Vector3[]>();
set => SetField(value);
}

public UnityEngine.Vector3[] m_CanvasCorners
{
get => GetField<UnityEngine.Vector3[]>();
set => SetField(value);
}

public UnityEngine.RectTransform MaskArea
{
get => orig.MaskArea;
set => orig.MaskArea = value;
}

public UnityEngine.Texture AlphaMask
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

public UnityEngine.Vector2 maskOffset
{
get => GetField<UnityEngine.Vector2>();
set => SetField(value);
}

public UnityEngine.Vector2 maskScale
{
get => GetField<UnityEngine.Vector2>();
set => SetField(value);
}



public void Start () =>
CallMethod();

public void Update () =>
CallMethod();

public void SetMask () =>
CallMethod();

public UnityEngine.Rect GetCanvasRect () =>
orig.GetCanvasRect();

}
}
