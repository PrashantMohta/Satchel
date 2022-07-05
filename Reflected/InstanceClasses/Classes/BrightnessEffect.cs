namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of BrightnessEffect allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class BrightnessEffectR : InstanceClassWrapper<BrightnessEffect>
{
    public BrightnessEffectR(BrightnessEffect _orig) : base(_orig)
    {
    }

    public float _Brightness
    {
        get => orig._Brightness;
        set => orig._Brightness = value;
    }

    public float _Contrast
    {
        get => orig._Contrast;
        set => orig._Contrast = value;
    }

// public UnityEngine.Shader shader
// {
// get => orig.shader;
// set => orig.shader = value;
// }

    public Material material => GetProperty<Material>();


    public void OnRenderImage(RenderTexture source, RenderTexture destination)
    {
        CallMethod(new object[] { source, destination });
    }
}