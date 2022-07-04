namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of FastNoise allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class FastNoiseR:InstanceClassWrapper<UnityStandardAssets.ImageEffects.FastNoise>
{
public FastNoiseR(UnityStandardAssets.ImageEffects.FastNoise _orig) : base(_orig) {}
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

public UnityEngine.Texture2D noiseTexture
{
get => orig.noiseTexture;
set => orig.noiseTexture = value;
}

public UnityEngine.FilterMode filterMode
{
get => orig.filterMode;
set => orig.filterMode = value;
}

public UnityEngine.Vector3 intensities
{
get => GetField<UnityEngine.Vector3>();
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

public UnityEngine.Shader noiseShader
{
get => orig.noiseShader;
set => orig.noiseShader = value;
}

public UnityEngine.Material noiseMaterial
{
get => GetField<UnityEngine.Material>();
set => SetField(value);
}

public float TILE_AMOUNT
{
get => GetFieldStatic<float>();
set => SetField(value);
}

public System.Byte frameCount
{
get => GetField<System.Byte>();
set => SetField(value);
}

public UnityEngine.RenderTexture softnessTexture
{
get => GetField<UnityEngine.RenderTexture>();
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



public void OnDisable () =>
CallMethod();

public void OnRenderImage (UnityEngine.RenderTexture source, UnityEngine.RenderTexture destination) =>
CallMethod(new object[] {source, destination});

public void DrawNoiseQuadGrid (UnityEngine.RenderTexture source, UnityEngine.RenderTexture dest, UnityEngine.Material fxMaterial, UnityEngine.Texture2D noise, int passNr, int frameMultiple) =>
CallMethodStatic(new object[] {source, dest, fxMaterial, noise, passNr, frameMultiple});

}
}
