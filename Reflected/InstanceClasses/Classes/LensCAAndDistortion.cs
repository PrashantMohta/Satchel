namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of LensCAAndDistortion allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class LensCAAndDistortionR : InstanceClassWrapper<LensCAAndDistortion>
{
    public LensCAAndDistortionR(LensCAAndDistortion _orig) : base(_orig)
    {
    }

    public Shader LensShader
    {
        get => orig.LensShader;
        set => orig.LensShader = value;
    }

    public float RedCyan
    {
        get => orig.RedCyan;
        set => orig.RedCyan = value;
    }

    public float GreenMagenta
    {
        get => orig.GreenMagenta;
        set => orig.GreenMagenta = value;
    }

    public float BlueYellow
    {
        get => orig.BlueYellow;
        set => orig.BlueYellow = value;
    }

    public bool TrimExtents
    {
        get => orig.TrimExtents;
        set => orig.TrimExtents = value;
    }

    public Texture2D TrimTexture
    {
        get => orig.TrimTexture;
        set => orig.TrimTexture = value;
    }

    public float Zoom
    {
        get => orig.Zoom;
        set => orig.Zoom = value;
    }

    public float BarrelDistortion
    {
        get => orig.BarrelDistortion;
        set => orig.BarrelDistortion = value;
    }

    public Material curMaterial
    {
        get => GetField<Material>();
        set => SetField(value);
    }

    public Material material => GetProperty<Material>();


    public void Start()
    {
        CallMethod();
    }

    public void OnRenderImage(RenderTexture sourceTexture, RenderTexture destTexture)
    {
        CallMethod(new object[] { sourceTexture, destTexture });
    }

    public void Update()
    {
        CallMethod();
    }

    public void OnDisable()
    {
        CallMethod();
    }
}