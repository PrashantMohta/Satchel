using UnityStandardAssets.ImageEffects;

namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of FastNoise allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class FastNoiseR : InstanceClassWrapper<FastNoise>
{
    public FastNoiseR(FastNoise _orig) : base(_orig)
    {
    }

    public bool monochrome
    {
        get => GetField<bool>();
        set => SetField(value);
    }

    public float intensityMultiplier
    {
        get => orig.intensityMultiplier;
        set => orig.intensityMultiplier = value;
    }

    public float generalIntensity
    {
        get => orig.generalIntensity;
        set => orig.generalIntensity = value;
    }

    public float blackIntensity
    {
        get => orig.blackIntensity;
        set => orig.blackIntensity = value;
    }

    public float whiteIntensity
    {
        get => orig.whiteIntensity;
        set => orig.whiteIntensity = value;
    }

    public float midGrey
    {
        get => orig.midGrey;
        set => orig.midGrey = value;
    }

    public Texture2D noiseTexture
    {
        get => orig.noiseTexture;
        set => orig.noiseTexture = value;
    }

    public FilterMode filterMode
    {
        get => orig.filterMode;
        set => orig.filterMode = value;
    }

    public Vector3 intensities
    {
        get => GetField<Vector3>();
        set => SetField(value);
    }

    public float softness
    {
        get => orig.softness;
        set => orig.softness = value;
    }

    public float monochromeTiling
    {
        get => orig.monochromeTiling;
        set => orig.monochromeTiling = value;
    }

    public Shader noiseShader
    {
        get => orig.noiseShader;
        set => orig.noiseShader = value;
    }

    public Material noiseMaterial
    {
        get => GetField<Material>();
        set => SetField(value);
    }

    public float TILE_AMOUNT
    {
        get => GetFieldStatic<float>();
        set => SetField(value);
    }

    public byte frameCount
    {
        get => GetField<byte>();
        set => SetField(value);
    }

    public RenderTexture softnessTexture
    {
        get => GetField<RenderTexture>();
        set => SetField(value);
    }

    public bool supportHDRTextures
    {
        get => GetField<bool>();
        set => SetField(value);
    }

    public bool supportDX11
    {
        get => GetField<bool>();
        set => SetField(value);
    }

    public bool isSupported
    {
        get => GetField<bool>();
        set => SetField(value);
    }


    public void OnDisable()
    {
        CallMethod();
    }

    public void OnRenderImage(RenderTexture source, RenderTexture destination)
    {
        CallMethod(new object[] { source, destination });
    }

    public void DrawNoiseQuadGrid(RenderTexture source, RenderTexture dest, Material fxMaterial, Texture2D noise,
        int passNr, int frameMultiple)
    {
        CallMethodStatic(new object[] { source, dest, fxMaterial, noise, passNr, frameMultiple });
    }
}